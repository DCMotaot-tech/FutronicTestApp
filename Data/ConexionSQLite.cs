using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace FutronicTestApp.Data
{
    public class ConexionSQLite
    {
        public static string BaseDatosPath => Path.Combine("Data", "futronic_test.db");
        public static string CadenaConexion => $"Data Source={BaseDatosPath};Version=3;";

        public static SQLiteConnection ObtenerConexion() 
        {
            if (!File.Exists(BaseDatosPath)) 
            {
                CrearBaseDeDatos();
            }

            return new SQLiteConnection(CadenaConexion);
        }

        private static void CrearBaseDeDatos() 
        {
            Directory.CreateDirectory("Data");

            SQLiteConnection.CreateFile(BaseDatosPath);

            using (var conexion = new SQLiteConnection(CadenaConexion)) 
            {
                conexion.Open();
                string sql = @"
                    CREATE TABLE IF NOT EXISTS Usuarios (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Nombre TEXT NOT NULL,
                        TemplateHuella BLOB NOT NULL
                    );
                ";

                using (var cmd = new SQLiteCommand(sql, conexion)) 
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
