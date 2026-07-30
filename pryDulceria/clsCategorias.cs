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
        public string AgregarCategoria()
        {
            clsConexion conexionBD = new clsConexion();
            string msg = "";
            try
            {
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string SqlN = "INSERT INTO tblcategorias (categoria) VALUES (@categoria);";

                    using (MySqlCommand comando = new MySqlCommand(SqlN, conexion))
                    {
                        comando.Parameters.AddWithValue("@categoria", Categoria);

                        msg = comando.ExecuteNonQuery() > 0 ? "Categoría agregada correctamente" : "Error al agregar la categoría";
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar guardar la categoria: " + ex.Message);
            }
            return msg;

        }
        public string Actualizar()
        {
            string msg = "";
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sqlA = "UPDATE tblcategorias SET categoria = @nombre WHERE id_categoria = @id;";

                    using (MySqlCommand comando = new MySqlCommand(sqlA, conexion))
                    {
                        comando.Parameters.AddWithValue("@nombre", Categoria);
                        comando.Parameters.AddWithValue("@id", Id_categoria);

                        int filasAfectadas = comando.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            msg = "Categoría actualizada correctamente";
                        }
                        else
                        {
                            msg = "Error, no se pudo actualizar la categoría";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
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
                    // La instrucción SQL ya corregida
                    string sql = "DELETE FROM tblcategorias WHERE id_categoria = @id;";
                    using (MySqlCommand comando = new MySqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@id", Id_categoria);
                        msg = comando.ExecuteNonQuery() > 0 ? "Categoría eliminada correctamente" : "Error al eliminar";
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No puedes eliminar esta categoría porque ya tiene productos en ella.");
            }
            return msg;

        }
    }
}
