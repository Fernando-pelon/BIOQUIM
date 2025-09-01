using Modelos.Conexiones;
using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_Bioquim.userControl
{
    public partial class frmLogin : UserControl
    {
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
            if (!(string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtContrasenia.Text)))
            {
                string usuario = txtUsuario.Text.Trim();
                string contrasena = txtContrasenia.Text.Trim();

                if (usuario == "" || contrasena == "")
                {
                    MessageBox.Show("Debe ingresar usuario y contraseña", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    frmCarga carga = new frmCarga();
                    carga.Show();
                    Application.DoEvents();

                    using (SqlConnection conn = ConexionDB.conectar())
                    {
                        string query = "SELECT COUNT(*) FROM Usuario WHERE NombreUsuario=@user AND Contrasena=@pass";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@user", usuario);
                        cmd.Parameters.AddWithValue("@pass", contrasena);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        carga.Close();

                        if (count > 0)
                        {
                            this.Hide();
                            frmDashBoardEmpleado dashboard = new frmDashBoardEmpleado();
                            dashboard.Show();
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
                    // No mostrar dashboard ni cerrar el login
                }
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }
        }
    }
}
