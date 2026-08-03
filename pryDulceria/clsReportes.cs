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
                            sql = "SELECT v.Id_venta AS Numero_Ticket, t.vchnombreUsuario AS Usuario, v.Total AS Total_Cobrado FROM tblventa v  INNER JOIN tblusuarios t ON v.intidUsuario = t.intidUsuario WHERE v.fecha = @fecha;";
                            break;

                        case "Producto más vendido":
                            sql = "SELECT p.Nombre AS Producto, SUM(d.Cantidad) AS Total_Vendidos FROM tbldet_venta d INNER JOIN tblventa v ON d.Id_venta = v.Id_venta INNER JOIN tblproductos p ON d.Id_producto = p.Id_producto WHERE v.fecha = @fecha GROUP BY p.Nombre ORDER BY Total_Vendidos DESC;";
                            break;
                        case "Ventas semanales/mensuales":
                        
                            sql = "SELECT v.Id_venta AS Numero_Ticket, v.fecha AS Fecha, u.vchnombreUsuario AS Usuario, v.Total AS Total_Cobrado FROM tblventa v INNER JOIN tblusuarios u ON v.intidUsuario = u.intidUsuario WHERE v.fecha BETWEEN @fecha AND @fechaFin ORDER BY v.fecha ASC;"; 
                            break;

                        case "Compras Realizadas":
                            sql = "SELECT c.Id_compra AS Numero_Compra, c.fecha AS Fecha, CONCAT_WS(' ', p.Nombre, p.Ap, p.Am) AS Proveedor, u.vchnombreUsuario AS Usuario, c.Total AS Total_Invertido FROM tblcompra c LEFT JOIN tblusuarios u ON c.intidUsuario = u.intidUsuario LEFT JOIN tblproveedor p ON c.Id_proveedor = p.Id_proveedor WHERE c.fecha = @fecha ORDER BY c.fecha ASC;";
                            break;
                        default:
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
