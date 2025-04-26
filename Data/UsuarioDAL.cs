using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using FutronicTestApp.Modelo;

namespace FutronicTestApp.Data
{
    public static class UsuarioDAL
    {
        public static void InsertarUsuario(string nombre, byte[] templateHuella) 
        {
            using (var conexion = ConexionSQLite.ObtenerConexion()) 
            {
                conexion.Open();

                string sql = "INSERT INTO Usuarios (Nombre, TemplateHuella) VALUES (@nombre, @huella)";
                using (var cmd = new SQLiteCommand(sql, conexion)) 
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@huella", templateHuella);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Usuario> ObtenerTodos() 
        {
            var lista = new List<Usuario>();

            using (var conexion = ConexionSQLite.ObtenerConexion()) 
            {
                conexion.Open();

                string sql = "SELECT Id, Nombre, TemplateHuella FROM Usuarios";
                using (var cmd = new SQLiteCommand(sql, conexion))
                using (var reader = cmd.ExecuteReader()) 
                {
                    while (reader.Read()) 
                    {
                        lista.Add(new Usuario
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Nombre = reader["Nombre"].ToString(),
                            TemplateHuella = (byte[])reader["TemplateHuella"]
                        });
                    }
                }
            }
            return lista;
        }
    }
}
