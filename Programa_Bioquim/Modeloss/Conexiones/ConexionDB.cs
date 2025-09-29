using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelos.Conexiones
{
    public class ConexionDB
    {
        // TUS DATOS DE CONEXIÓN DIRECTA
        private static string servidor = "SQL8020.site4now.net";
        private static string dataBase = "db_abec8a_bioquimptc";
        private static string usuario = "db_abec8a_bioquimptc_admin";
        private static string contrasena = "BioquimPTC2025@";

        public static SqlConnection conectar()
        {
            // Cadena de conexión directa
            string cadena = $"Server={servidor};Database={dataBase};User Id={usuario};Password={contrasena};";

            SqlConnection conexion = new SqlConnection(cadena);

            try
            {
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar con la base de datos:\n{ex.Message}",
                              "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        // Método para probar la conexión
        public static bool ProbarConexion()
        {
            try
            {
                using (SqlConnection conexion = conectar())
                {
                    if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                    {
                        MessageBox.Show("Conexión exitosa ✅", "Éxito",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("No se pudo establecer la conexión", "Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error de conexión:\n{ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}