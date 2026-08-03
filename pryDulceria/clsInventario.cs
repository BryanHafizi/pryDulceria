using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace pryDulceria
{
    internal class clsInventario
    {
        //Propiedades de los productos
        private string nombreProd;
        private float precioProd, precioVentaProd, margenGanancia;
        private int idProducto, idCategoria, stockProd;

        private MySqlDataAdapter consulta;
        private MySqlCommand comando;
        private DataTable tabla;

        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string NombreProd { get => nombreProd; set => nombreProd = value; }
        public float PrecioProd { get => precioProd; set => precioProd = value; }
        public float PrecioVentaProd { get => precioVentaProd; set => precioVentaProd = value; }
        public float MargenGanancia { get => margenGanancia; set => margenGanancia = value; }
        public int StockProd { get => stockProd; set => stockProd = value; }

        //Metodo para cargar los datos el DataGrid (dgvInventario)
        public DataTable CargarDataGrid()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT p.Id_producto AS Id, p.Nombre AS Nombre, p.Costo AS Costo, p.Precio AS 'Precio de venta', p.Stock AS Stock, c.categoria AS Categoria FROM tblproductos p INNER JOIN tblcategorias c ON p.id_categoria = c.id_categoria;";
                    using (var consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
            return tabla;
        }

        //Metodo para filtrar por busqueda
        public DataTable ConsultarCoincidencias()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT p.Id_producto AS Id, p.Nombre AS Nombre, p.Costo AS Costo, p.Precio AS 'Precio de venta', p.Stock AS Stock, c.categoria AS Categoria FROM tblproductos p INNER JOIN tblcategorias c ON p.id_categoria = c.id_categoria WHERE p.Nombre LIKE @nombre;";
                    using (var consultar = new MySqlCommand(sql, conexion))
                    {
                        consultar.Parameters.AddWithValue("@nombre", "%" + nombreProd + "%");
                        using (var consulta = new MySqlDataAdapter(consultar)) { consulta.Fill(tabla); }
                    }
                }
            }
            catch (Exception ex) { throw new Exception("Error: " + ex.Message); }
            return tabla;
        }
        //Metodo para actualizar y eliminar registros
        public string GuardarActualizarRegistros(int tipoOperacion)
        {
            string msg = "";
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    if (tipoOperacion == 0) // Nuevo registro
                    {
                        string sqlN = "INSERT INTO tblproductos (Nombre, Costo, Precio, Stock, id_categoria) VALUES (@nombre, @costo, @precio, @stock, @id_categoria);";

                        using (var comando = new MySqlCommand(sqlN, conexion))
                        {
                            comando.Parameters.AddWithValue("@nombre", NombreProd);
                            comando.Parameters.AddWithValue("@costo", PrecioProd);
                            comando.Parameters.AddWithValue("@precio", PrecioVentaProd);
                            comando.Parameters.AddWithValue("@stock", StockProd);
                            comando.Parameters.AddWithValue("@id_categoria", IdCategoria);

                            int filasAfectadas = comando.ExecuteNonQuery();
                            if (filasAfectadas > 0)
                            {
                                msg = "Producto guardado correctamente.";
                            }
                            else
                            {
                                msg = "Error: El producto no se pudo guardar.";
                            }
                        }
                    }
                    else //Actualizar un registro
                    {
                        string sqlA = "UPDATE tblproductos SET Nombre = @nombre, Costo = @costo, Precio = @precio, Stock = @stock, id_categoria = @id_categoria WHERE Id_producto = @id;";

                        using (var comando = new MySqlCommand(sqlA, conexion))
                        {
                            comando.Parameters.AddWithValue("@id", IdProducto);
                            comando.Parameters.AddWithValue("@nombre", NombreProd);
                            comando.Parameters.AddWithValue("@costo", PrecioProd);
                            comando.Parameters.AddWithValue("@precio", PrecioVentaProd);
                            comando.Parameters.AddWithValue("@stock", StockProd);
                            comando.Parameters.AddWithValue("@id_categoria", IdCategoria);

                            int filasAfectadas = comando.ExecuteNonQuery();
                            if (filasAfectadas > 0)
                            {
                                msg = "Producto actualizado correctamente.";
                            }
                            else
                            {
                                msg = "Error: El producto no se pudo actualizar.";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error de base de datos: " + ex.Message);
            }
            return msg;
        }
        //Metodo para eliminar un registro
        public string Eliminar()
        {
            string msg = "";
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "DELETE FROM tblproductos WHERE Id_producto = @id;";
                    using (comando = new MySqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@id", IdProducto);
                        msg = comando.ExecuteNonQuery() > 0 ? "Producto eliminado correctamente" : "Error al eliminar";

                    }
                }
            }
            catch (Exception ex) { throw new Exception("Error: " + ex.Message); }
            return msg;
        }
        //Metodo para calcular el precio sugerido
        public float CalcularPrecioSugerido(float costo, float margen)
        {
            return costo + (costo * (margen / 100f));
        }
    }
}