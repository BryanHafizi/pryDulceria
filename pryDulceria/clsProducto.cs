using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace pryDulceria
{
    internal class clsProducto
    {
        private int Id_producto;
        private string Nombre;
        private float Precio;
        private int Stock;
        private string categoria;

        public int Id_producto1 { get => Id_producto; set => Id_producto = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public float Precio1 { get => Precio; set => Precio = value; }
        public int Stock1 { get => Stock; set => Stock = value; }
        public string Categoria { get => categoria; set => categoria = value; }

        private MySqlDataAdapter consulta;
        private MySqlCommand comando;
        private DataTable tabla;

        public bool AgregarNuevoProducto()
        {
            clsConexion conexionBD = new clsConexion();
            MySqlConnection conexion = null;


            string SqlN = "INSERT INTO tblproductos (Nombre, Precio, Stock, categoria) VALUES (@Nombre, @Precio, @Stock, @categoria)";

            try
            {
                conexion = conexionBD.AbrirConexion();
                comando = new MySqlCommand(SqlN, conexion);

                comando.Parameters.AddWithValue("@Nombre", Nombre1);
                comando.Parameters.AddWithValue("@Precio", Precio1);
                comando.Parameters.AddWithValue("@Stock", Stock1);
                comando.Parameters.AddWithValue("@categoria", string.IsNullOrEmpty(this.Categoria) ? (object)DBNull.Value : this.Categoria);

                int filasAfectadas = comando.ExecuteNonQuery();
                return filasAfectadas > 0;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar guardar el producto: " + ex.Message);
            }
            finally
            {
                if (conexion != null)
                {
                    conexionBD.CerrarConexion(conexion);
                }
            }
        }

    }
}
