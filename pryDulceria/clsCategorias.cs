using MySqlConnector;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
                    string sql = "SELECT id_categoria AS Id, categoria AS Categoria FROM tblcategorias";
                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }
                }
            }
            catch (Exception ex) { throw new Exception("Error: " + ex.Message); }
            return tabla;
        }
        public DataTable ConsultarCoincidencias()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT id_categoria AS Id, categoria AS Categoria FROM tblcategorias WHERE categoria LIKE @nombre;";
                    using (var consultar = new MySqlCommand(sql, conexion))
                    {
                        consultar.Parameters.AddWithValue("@nombre", "%" + Categoria + "%");
                        using (var consulta = new MySqlDataAdapter(consultar)) { consulta.Fill(tabla); }
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
        public string Actualizar()
        {
            string msg = "";

            clsConexion conexionBD = new clsConexion();
            using (var conexion = conexionBD.AbrirConexion())
                try
                {
                    string sqlA = "UPDATE tblcategorias SET categoria = @nombre WHERE id_categoria = @id;";
                    using (comando = new MySqlCommand(sqlA, conexion))
                    {
                        comando.Parameters.AddWithValue("@id", Id_categoria);
                        comando.Parameters.AddWithValue("@nombre", Categoria);
                        int filasAfectadas = comando.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            msg = "Registro guardado correctamente";
                        }
                        else
                        {
                            msg = "Error, Datos no guardados";
                        }
                    }
                }
                catch (Exception ex) { throw new Exception("Error: " + ex.Message); }
                return msg;
        }
        public string Eliminar()
        {
            string msg = "";
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "DELETE FROM tblcategorias WHERE id_categoria = @id;";
                    using (comando = new MySqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@id", Id_categoria);
                        msg = comando.ExecuteNonQuery() > 0 ? "Categoria eliminado correctamente" : "Error al eliminar";
                    }
                }
            }
            catch (Exception ex) { throw new Exception("Error: " + ex.Message); }
            return msg;
        }
    }
}
