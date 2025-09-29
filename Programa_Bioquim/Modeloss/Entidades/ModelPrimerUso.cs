using Modelos.Conexiones;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;
using System.Windows.Forms;

namespace Modeloss.Entidades
{
    public class ModelPrimerUso
    {
        public static bool CheckEmpleados()
        {
            string query = "SELECT COUNT(*) FROM Usuario";
            try
            {
                using (SqlConnection conexion = ConexionDB.conectar())
                {
                    if (conexion != null)
                    {
                        SqlCommand cmd = new SqlCommand(query, conexion);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static string CrearPrimerUsuarioAdministrador(string nombre, string apellido, string correo)
        {
            try
            {
                string contrasenaAutomatica = GenerarContrasenaAutomatica(nombre);

                using (SqlConnection conexion = ConexionDB.conectar())
                {
                    if (conexion != null)
                    {
                        string query = @"INSERT INTO Usuario 
                                (nombreUsuario, apellidoUsuario, correoUsuario, contrasenaUsuario, idTipoUsuario, idDepartamento) 
                                VALUES 
                                (@nombre, @apellido, @correo, @contrasena, 1, 1)"; // 1 = Admin, 1 = Departamento por defecto

                        SqlCommand cmd = new SqlCommand(query, conexion);
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@apellido", apellido);
                        cmd.Parameters.AddWithValue("@correo", correo);
                        cmd.Parameters.AddWithValue("@contrasena", BCrypt.Net.BCrypt.HashPassword(contrasenaAutomatica));

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            return contrasenaAutomatica; // Retornar la contraseña generada
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear usuario: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        private static string GenerarContrasenaAutomatica(string nombreUsuario)
        {
            string nombreCorto = new string(nombreUsuario.Where(char.IsLetter).Take(4).ToArray());
            if (string.IsNullOrEmpty(nombreCorto))
            {
                nombreCorto = "user"; // Si no hay letras, usar "user"
            }
            return nombreCorto.ToLower() + "123";
        }
    }
}
