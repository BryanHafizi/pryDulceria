using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace pryDulceria
{
    internal class clsProveedores
    {
        // Propiedades adaptadas a tblusuarios
        private int idProveedor;
        private string nombre;
        private string ap;
        private string am;
        private string tel;
        private string tel_secundario;


      

        private MySqlDataAdapter consulta;
        private MySqlCommand comando;
        private DataTable tabla;

        public int IdProveedor { get => idProveedor; set => idProveedor = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Ap { get => ap; set => ap = value; }
        public string Am { get => am; set => am = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Tel_secundario { get => tel_secundario; set => tel_secundario = value; }

        public DataTable CargarDataGrid()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT Id_proveedor AS Id,Nombre AS nom,Ap AS a_p,AM AS a_m,Tel AS telf,Tel_secundario AS tel_sec FROM proveedor;";
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
                    string sql = "SELECT Id_proveedor AS Id,Nombre AS nom,Ap AS a_p,AM AS a_m,Tel AS telf,Tel_secundario AS tel_sec FROM proveedor;";
                    using (var consultar = new MySqlCommand(sql, conexion))
                    {
                        consultar.Parameters.AddWithValue("@nombre", "%" + Nombre + "%");
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
                        string sqlN = "INSERT INTO proveedor(Nombre, Ap, Am,Tel,Tel_secundario) VALUES(@nombre,@ap,@am,@tel,@tel_secundario);";
                        using (comando = new MySqlCommand(sqlN, conexion))
                        {
                            comando.Parameters.AddWithValue("@nombre", Nombre);
                            comando.Parameters.AddWithValue("@ap", Ap);
                            comando.Parameters.AddWithValue("@am", Am);
                            comando.Parameters.AddWithValue("@tel", Tel);
                            comando.Parameters.AddWithValue("@tel_secundario", Tel_secundario);
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
                        string sqlA = "UPDATE tblusuarios SET nombre = @nombre,@ap = AP,  WHERE intIdUsuario = @id;";
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
