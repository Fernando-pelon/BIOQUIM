using Modelos.Conexiones;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Modelos.Entidades
{
    public class Usuario
    {
        private int idUsuario;
        private string nombreUsuario;
        private string apellidoUsuario;
        private string correoUsuario;
        private string contrasenaUsuario;
        private int idTipoUsuario;
        private int idDepartamento;

        public int IdUsario { get => idUsuario; set => idUsuario = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string ApellidoUsuario { get => apellidoUsuario; set => apellidoUsuario = value; }
        public string CorreoUsuario { get => correoUsuario; set => correoUsuario = value; }
        public string ContrasenaUsuario { get => contrasenaUsuario; set => contrasenaUsuario = value; }
        public int IdTipoUsuario { get => idTipoUsuario; set => idTipoUsuario = value; }
        public int IdDepartamento { get => idDepartamento; set => idDepartamento = value; }

        public bool RegistrarUsuario()
        {
            try
            {
                SqlConnection conn = ConexionDB.conectar();
                string queryhas = "Insert into Usuario(nombreUsuario, apellidoUsuario, correoUsuario, contrasenaUsuario, idTipoUsuario, idDepartamento) values (@nombreUsuario, @apellidoUsuario, @correoUsuario, @contrasenaUsuario, @idTipoUsuario, @idDepartamento)";
                SqlCommand insertar = new SqlCommand(queryhas, conn);
                insertar.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                insertar.Parameters.AddWithValue("@apellidoUsuario", apellidoUsuario);
                insertar.Parameters.AddWithValue("@correoUsuario", correoUsuario);
                insertar.Parameters.AddWithValue("@contrasenaUsuario", contrasenaUsuario);
                insertar.Parameters.AddWithValue("@idTipoUsuario", idTipoUsuario);
                insertar.Parameters.AddWithValue("@idDepartamento", idDepartamento);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Este Usuario ya existe, utiliza otro correo");
                return false;
            }
        }

        public bool VerificarLogin(string correo, string clave)
        {
            {
                string hashEnBaseDeDatos = "";
                SqlConnection conn = ConexionDB.conectar();
                string query = "SELECT clave FROM Usuarios WHERE correoUsuario = @correoUsuario";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@correoUsuario", correo);
                MessageBox.Show("executeescalar" + cmd.ExecuteScalar());
                if (cmd.ExecuteScalar() == null)
                {
                    return false;
                }
                else
                {
                    hashEnBaseDeDatos = cmd.ExecuteScalar().ToString();
                    return BCrypt.Net.BCrypt.Verify(clave, hashEnBaseDeDatos);
                }
            }
        }

        public static DataTable cargarTipoUsuario()
        {
            SqlConnection conn = ConexionDB.conectar();
            string querycargar = "select idTipoUsuario, nombreTipoUsuario from TipoUsuario;";
            SqlDataAdapter dt = new SqlDataAdapter(querycargar, conn);
            DataTable tabla = new DataTable();
            dt.Fill(tabla);
            return tabla;
        }
        public static DataTable CargarDepartamento()
        {
            SqlConnection conn = ConexionDB.conectar();
            string querycargar = "select idDepartamento, nombreDepartamento from Departamento;";
            SqlDataAdapter dt = new SqlDataAdapter(querycargar, conn);
            DataTable tabla = new DataTable();
            dt.Fill(tabla);
            return tabla;
        }
        public static DataTable cargarUsuarios()

        {
            try
            {

                SqlConnection conexion = ConexionDB.conectar();

                string cadena = "select *from UsuariosDGV";

                SqlDataAdapter add = new SqlDataAdapter(cadena, conexion);

                DataTable tablaCargar = new DataTable();

                add.Fill(tablaCargar);

                return tablaCargar;

            }

            catch (Exception ex)

            {

                MessageBox.Show("Error al cargar los datos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;

            }

        }
        public static DataTable buscarUsuarios(string termino)
        {
            SqlConnection conexion = ConexionDB.conectar();
            string comando =
                $"SELECT Usuario.idUsuario, Usuario.nombreUsuario, Departamento.nombreDepartamento " +
                $"FROM Usuario " +
                $"INNER JOIN Departamento ON Usuario.idDepartamento = Departamento.idDepartamento " +
                $"WHERE Usuario.nombreUsuario LIKE '%{termino}%';";

            SqlDataAdapter ad = new SqlDataAdapter(comando, conexion);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }
        public bool eliminarUsuarios(int id)

        {
            try
            {

                SqlConnection conectar = ConexionDB.conectar();

                string consultaDelete = "DELETE FROM Usuario WHERE idUsuario = @id";

                SqlCommand delete = new SqlCommand(consultaDelete, conectar);

                delete.Parameters.AddWithValue("@id", id);

                delete.ExecuteNonQuery();

                return true;

            }

            catch (Exception ex)

            {

                MessageBox.Show("Error al eliminar el registro", "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;

            }

        }
        public bool insertarUsuarios()
        {
            try
            {
                using (SqlConnection conexion = ConexionDB.conectar()) // ya viene abierta
                {
                    string consultaQueryInsert = @"
                INSERT INTO Usuario
                (nombreUsuario, apellidoUsuario, correoUsuario, contrasenaUsuario, idTipoUsuario, idDepartamento)
                VALUES
                (@nombreUsuario, @apellidoUsuario, @correoUsuario, @contrasenaUsuario, @idTipoUsuario, @idDepartamento)";

                    using (SqlCommand insertar = new SqlCommand(consultaQueryInsert, conexion))
                    {
                        insertar.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                        insertar.Parameters.AddWithValue("@apellidoUsuario", apellidoUsuario);
                        insertar.Parameters.AddWithValue("@correoUsuario", correoUsuario);
                        insertar.Parameters.AddWithValue("@contrasenaUsuario", contrasenaUsuario);
                        insertar.Parameters.AddWithValue("@idTipoUsuario", idTipoUsuario);
                        insertar.Parameters.AddWithValue("@idDepartamento", idDepartamento);

                        int filas = insertar.ExecuteNonQuery();
                        return filas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verifica si la consulta es correcta: " + ex.Message, "Error al insertar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}
