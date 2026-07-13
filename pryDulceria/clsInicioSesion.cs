using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace pryDulceria
{
    internal class clsInicioSesion
    {
        private string usuario, password;

        public string Usuario { get => usuario; set => usuario = value; }
        public string Password { get => password; set => password = value; }
        //Atributos estaticos
        private static string rol;
        private static bool esAdministrador;
        private static bool esCajero;

        public void AsignarPermisos()
        {
            switch (rol)
            {
                case "Administrador":
                    esAdministrador = true;
                    esCajero = false;
                    break;
                case "Cajero":
                    esAdministrador = false;
                    esCajero = true;
                    break;
                default:
                    esAdministrador = false;
                    esCajero = false;
                    break;
            }
        }

        //Propiedades estaticas
        public static bool EsAdministrador { get => esAdministrador; }
        public static bool EsCajero { get => esCajero; }

        public bool ValidarAcceso()
        {
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT vchrol FROM tblusuarios " + "WHERE vchnombreUsuario = @usuario AND vchpassword = MD5(@password);";
                    using (var consulta = new MySqlCommand(sql, conexion))
                    {
                        consulta.Parameters.AddWithValue("@usuario", usuario);
                        consulta.Parameters.AddWithValue("@password", password);

                        using (var resultado = consulta.ExecuteReader())
                        {
                            if (resultado.Read())
                            {
                                rol = resultado.GetString("vchRol");
                                AsignarPermisos();
                                MessageBox.Show("Tu perfil es: " + rol, "sistema");
                                return true;
                            }
                            else
                            {
                                throw new Exception("Usuario o contraseña icorrectos");
                            }
                        }//Liberar MySqlDataReader
                    }//Liberar MySqlCommand
                }//Liberar MySqulConnection a través de la clase
            }
            catch (Exception ex)
            {
                //Si ocurre un error, lo relanzamos para que se capture en el formulario
                throw new Exception(ex.Message, ex);
            }
        }//fin del metodo
    }
}
