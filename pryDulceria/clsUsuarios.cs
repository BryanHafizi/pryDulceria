using System;
using System.Data;
using MySqlConnector;

namespace pryDulceria
{
    internal class clsUsuarios
    {
        // Propiedades adaptadas a tblusuarios
        private int idUsuario;
        private string nombreUsuario;
        private string password;
        private string rol;

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Password { get => password; set => password = value; }
        public string Rol { get => rol; set => rol = value; }

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
                    string sql = "SELECT intIdUsuario AS Clave, vchnombreUsuario AS Usuario, vchPassword AS Contrasena, vchRol AS Rol FROM tblusuarios;";
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
                    string sql = "SELECT intIdUsuario AS Clave, vchnombreUsuario AS Usuario, vchPassword AS Contrasena, vchRol AS Rol FROM tblusuarios WHERE vchnombreUsuario LIKE @nombre;";
                    using (var consultar = new MySqlCommand(sql, conexion))
                    {
                        consultar.Parameters.AddWithValue("@nombre", "%" + NombreUsuario + "%");
                        using (var consulta = new MySqlDataAdapter(consultar)) { consulta.Fill(tabla); }
                    }
                }
            }
            catch (Exception ex) { throw new Exception("Error: " + ex.Message); }
            return tabla;
        }

        public string GuardarActualizarRegistros(int tipoOperacion)
        {
            string msg = "";
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    if (tipoOperacion == 0) // Nuevo Registro
                    {
                        string sqlN = "INSERT INTO tblusuarios(vchnombreUsuario, vchPassword, vchRol) VALUES(@nombre, MD5(@pass), @rol);";
                        using (comando = new MySqlCommand(sqlN, conexion))
                        {
                            comando.Parameters.AddWithValue("@nombre", NombreUsuario);
                            comando.Parameters.AddWithValue("@pass", Password);
                            comando.Parameters.AddWithValue("@rol", Rol);
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
                    else // Actualizar Registro
                    {
                        string sqlA = "UPDATE tblusuarios SET vchnombreUsuario = @nombre, vchPassword = MD5(@pass), vchRol = @rol WHERE intIdUsuario = @id;";
                        using (comando = new MySqlCommand(sqlA, conexion))
                        {
                            comando.Parameters.AddWithValue("@id", IdUsuario);
                            comando.Parameters.AddWithValue("@nombre", NombreUsuario);
                            comando.Parameters.AddWithValue("@pass", Password);
                            comando.Parameters.AddWithValue("@rol", Rol);
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
                    string sql = "DELETE FROM tblusuarios WHERE intIdUsuario = @id;";
                    using (comando = new MySqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@id", IdUsuario);
                        msg = comando.ExecuteNonQuery() > 0 ? "Usuario eliminado correctamente" : "Error al eliminar";
                    }
                }
            }
            catch (Exception ex) { throw new Exception("Error: " + ex.Message); }
            return msg;
        }
    }
}