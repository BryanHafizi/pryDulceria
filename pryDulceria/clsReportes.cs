using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.Drawing.Imaging;

namespace pryDulceria
{
    internal class clsReportes
    {
        //propiedaades para reportes
        private DateTime fechacorte;
        private DateTime fechafin;
        private string tiporeporte;
        

        private MySqlDataAdapter consulta;
        private MySqlCommand comando;
        private DataTable tabla;

        public DateTime Fechacorte { get => fechacorte; set => fechacorte = value; }
        public DateTime Fechafin { get => fechafin; set => fechafin = value; }
        public string Tiporeporte { get => tiporeporte; set => tiporeporte = value; }
        

        public DataTable buscarReporte()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "";
                    switch (tiporeporte)
                    { 
                        case "Ventas del dia":
                            sql = "SELECT Ticket, Concepto, Fecha, Producto, Cantidad, Precio, Total FROM ( SELECT v.Id_venta AS Ticket, 'VENTA DEL DÍA' AS Concepto, v.fecha AS Fecha, '----------------' AS Producto, '----------------' AS Cantidad,'----------------' AS Precio, v.Total AS Total, 1 AS Orden FROM tblventa v WHERE v.fecha = @fecha UNION ALL SELECT v.Id_venta, '   Detalle' AS Concepto, v.fecha, prod.nombre, dv.Cantidad, dv.Precio_Unitario, (dv.Cantidad * dv.Precio_Unitario), 2 AS Orden FROM tblventa v INNER JOIN tbldet_venta dv ON v.Id_venta = dv.Id_venta INNER JOIN tblproductos prod ON dv.Id_producto = prod.Id_producto WHERE v.fecha = @fecha ) AS ReporteCompleto ORDER BY Ticket ASC, Orden ASC;";
                            break;

                      
                        case "Ventas por rango (Personalizada)":
                            sql = "SELECT v.fecha AS 'Fecha',COUNT(v.Id_venta) AS 'Tickets Emitidos',SUM(v.Total) AS 'Ingreso Total del Día' FROM tblventa v WHERE v.fecha BETWEEN @fecha AND @fechaFin GROUP BY v.fecha ORDER BY v.fecha ASC;";
                            break;

                        case "Ranking de productos ":
                            sql = "SELECT p.Nombre AS Producto,SUM(dv.Cantidad) AS Total_Unidades_Vendidas FROM tblproductos p INNER JOIN tbldet_venta dv ON p.Id_producto = dv.Id_producto INNER JOIN  tblventa v ON dv.Id_venta = v.Id_venta WHERE v.fecha BETWEEN @fecha AND @fechaFin GROUP BY p.Id_producto, p.Nombre ORDER BY Total_Unidades_Vendidas DESC;";
                            break;
                      

                        case "Compras Realizadas":
                            sql = "SELECT c.Id_compra AS Numero_Compra, c.fecha AS Fecha, CONCAT_WS(' ', p.Nombre, p.Ap, p.Am) AS Proveedor, u.vchnombreUsuario AS Usuario, c.Total AS Total_Invertido FROM tblcompra c LEFT JOIN tblusuarios u ON c.intidUsuario = u.intidUsuario LEFT JOIN tblproveedor p ON c.Id_proveedor = p.Id_proveedor WHERE c.fecha = @fecha ORDER BY c.fecha ASC;";
                            break;
                        case "Compras por rango":
                            sql = "SELECT c.Id_compra AS Numero_Compra,c.fecha AS Fecha, CONCAT_WS(' ', p.Nombre, p.Ap, p.Am) AS Proveedor, u.vchnombreUsuario AS Usuario, c.Total AS Total_Invertido FROM tblcompra c LEFT JOIN tblusuarios u ON c.intidUsuario = u.intidUsuario LEFT JOIN tblproveedor p ON c.Id_proveedor = p.Id_proveedor WHERE c.fecha BETWEEN @fecha AND @fechaFin ORDER BY c.fecha ASC;";
                            break;

                            throw new Exception("Seleccione un tipo de reporte válido.");
                    }
                    // Ejecutar la consulta y llenar el DataTable
                    using (comando = new MySqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@fecha", fechacorte.ToString("yyyy-MM-dd"));
                        comando.Parameters.AddWithValue("@fechaFin", Fechafin.ToString("yyyy-MM-dd"));

                        using (consulta = new MySqlDataAdapter(comando))
                        {
                            consulta.Fill(tabla);
                        }
                    }
                }
            }
            catch (Exception ex) 
            {
                throw new Exception("Error: " + ex.Message); 
            }
            return tabla;

        }
        public void exportarPDF(DataTable tabla,string Tiporeporte,string nombreArchivoSugerido)
        {
            if (tabla == null || tabla.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para convertir a PDF", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SaveFileDialog guardarArchivo = new SaveFileDialog();
            guardarArchivo.FileName = nombreArchivoSugerido;
            guardarArchivo.Filter = "Archivos PDF (*.pdf)|*.pdf";
            if(guardarArchivo.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Document.Create(container =>
                    {
                        container.Page(page =>
                        {
                            page.Size(PageSizes.A4);
                            page.Margin(2, Unit.Centimetre);
                            page.PageColor(Colors.White);
                            page.DefaultTextStyle(x => x.FontSize(12));

                            page.Header().Row(row =>
                                {
                                    row.RelativeItem().AlignLeft().AlignMiddle().Column(col =>
                                    {
                                        col.Item().Text("DULCERIA MARLYN")
                                        .FontSize(18)
                                        .Bold()
                                        .FontColor("#10407a");

                                        col.Item().PaddingTop(5).LineHorizontal(1).LineColor(Colors.Grey.Lighten2);
                                    });
                                    if (Properties.Resources.dulceria != null)
                                    {
                                        byte[] byteslogo;
                                        using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
                                        {
                                            Properties.Resources.dulceria.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                                            byteslogo = ms.ToArray();
                                        }
                                        row.ConstantItem(90).AlignRight().AlignMiddle().Image(byteslogo);
                                    }
                                });

                            page.Content().PaddingTop(20).Column(column =>
                            {
                                column.Item().PaddingBottom(15).Text(Tiporeporte)
                                .FontSize(12).Bold().FontColor(Colors.Black);
                                column.Item().Table(table =>
                                {

                                    int totalColumnas = tabla.Columns.Count;

                                    table.ColumnsDefinition(columns =>
                                    {
                                        for (int i = 0; i < totalColumnas; i++)
                                        {
                                            if (i > 0 && i < totalColumnas - 1)
                                                columns.RelativeColumn(2f);
                                            else
                                                columns.RelativeColumn(1.2f);
                                        }
                                    });
                                    foreach (DataColumn columnaobj in tabla.Columns)
                                    {
                                        table.Cell().Background("#4272CB").Padding(8).AlignLeft().AlignMiddle()
                                        .Text(columnaobj.ColumnName).FontSize(10).Bold().FontColor(Colors.White);
                                    }

                                    bool alternarFila = true;
                                    foreach (DataRow fila in tabla.Rows)
                                    {
                                        string colorFondo = alternarFila ? "#E8E8E8" : "#FFFFFF";
                                        for (int i = 0; i < totalColumnas; i++)
                                        {
                                            var celda = table.Cell().Background(colorFondo)
                                                             .BorderBottom(1).BorderColor(Colors.Grey.Lighten3)
                                                             .Padding(7).AlignMiddle();
                                            if (i == 0 || i == (totalColumnas - 1))
                                                celda.AlignCenter();
                                            else
                                                celda.AlignLeft();
                                            celda.Text(fila[i].ToString()).FontSize(9).FontColor(Colors.Black);
                                        }
                                        alternarFila = !alternarFila;
                                    }
                                });
                            });
                            page.Footer().AlignCenter().Text(x =>
                                {
                                    x.Span("Página ").FontSize(9).FontColor(Colors.Grey.Darken1);
                                    x.CurrentPageNumber().FontSize(9).Bold();
                                    x.Span(" de ").FontSize(9).FontColor(Colors.Grey.Darken1);
                                    x.TotalPages().FontSize(9).Bold();
                                });
                        });
                    }).GeneratePdf(guardarArchivo.FileName);
                    MessageBox.Show("Reporte guardado con exito","Exito",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar el PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
