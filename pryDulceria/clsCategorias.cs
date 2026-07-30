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
            

        }
        public string Actualizar()
        {
            

        }
        public string Eliminar()
        {
            

        }
    }
}
