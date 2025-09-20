using Modelos.Conexiones;
using Programa_Bioquim.Formularios.Admin;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using BCrypt.Net;

namespace Programa_Bioquim.userControl
{
    public partial class frmLogin : UserControl
    {
        public event EventHandler LoginExitoso;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtContrasenia.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasenia.Text.Trim();

            try
            {
                frmCarga carga = new frmCarga();
                carga.Show();
                Application.DoEvents();

                using (SqlConnection conn = ConexionDB.conectar())
                {
                    string query = "SELECT ContrasenaUsuario FROM Usuario WHERE NombreUsuario=@user";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@user", usuario);

                    object result = cmd.ExecuteScalar();
                    carga.Close();

                    if (result == null)
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string hashEnDB = result.ToString();

                    // Validar la contraseña ingresada contra el hash almacenado
                    if (BCrypt.Net.BCrypt.Verify(contrasena, hashEnDB))
                    {
                        LoginExitoso?.Invoke(this, EventArgs.Empty);
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar iniciar sesión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}