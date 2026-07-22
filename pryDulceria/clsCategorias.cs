using MySqlConnector;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace pryDulceria
{
    internal class clsCategoria
    {
        private int id_categoria;
        private string categoria;

        public int Id_categoria { get => id_categoria; set => id_categoria = value; }
        public string Categoria { get => categoria; set => categoria = value; }

        private MySqlDataAdapter consulta;
        private MySqlCommand comando;
        private DataTable tabla;

        public DataTable CargarDataGrid()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT id_categoria AS Id, categoria AS Categoria FROM categorias";
                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }
                }
            }
            catch (Exception ex) { throw new Exception("Error: " + ex.Message); }
            return tabla;
        }
        public bool AgregarCategoria()
        {
            clsConexion conexionBD = new clsConexion();
            MySqlConnection conexion = null;

            string SqlN = "INSERT INTO tblcategorias (id_categoria, categoria) VALUES (@id_categoria, @categoria)";

            try
            {
                conexion = conexionBD.AbrirConexion();
                comando = new MySqlCommand(SqlN, conexion);

                comando.Parameters.AddWithValue("@id_categoria", Id_categoria);
                comando.Parameters.AddWithValue("@categoria", Categoria);
               
                int filasAfectadas = comando.ExecuteNonQuery();
                return filasAfectadas > 0;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar guardar la categoria: " + ex.Message);
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
