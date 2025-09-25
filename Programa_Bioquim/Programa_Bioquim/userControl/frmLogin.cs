using BCrypt.Net;
using Modelos.Conexiones;
using Modelos.Entidades;
using Programa_Bioquim.Formularios.Admin;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
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
                MessageBox.Show("Por favor, complete todos los campos.", "Aviso",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasenia.Text.Trim();
            try
            {
                frmCarga carga = new frmCarga();
                carga.Show();
                Application.DoEvents();

                // Verificar el login
                Usuario usuarioLogueado = Usuario.VerificarLoginCompleto(usuario, contrasena);
                carga.Close();

                if (usuarioLogueado != null)
                {
                    // Iniciar sesión
                    SesionUsuario.IniciarSesion(usuarioLogueado);

                    // Redirigir según el tipo de usuario
                    RedirigirSegunTipoUsuario();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos", "Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar iniciar sesión: " + ex.Message,
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RedirigirSegunTipoUsuario()
        {
            // Ocultar el formulario de login
            Form formPadre = this.ParentForm;
            if (formPadre != null)
            {
                formPadre.Hide();
            }

            // Redirigir según el tipo de usuario
            switch (SesionUsuario.IdTipoUsuario)
            {
                case 1: // Administrador
                    frmDashBoardAdmin adminForm = new frmDashBoardAdmin();
                    adminForm.Show();
                    break;

                case 2: // Empleado
                    frmDashBoardEmpleado empleadoForm = new frmDashBoardEmpleado();
                    empleadoForm.Show();
                    break;

                case 3: // Repartidor
                    frmDashBoardRepartidor repartidorForm = new frmDashBoardRepartidor();
                    repartidorForm.Show();
                    break;

                default:
                    MessageBox.Show("Tipo de usuario no reconocido.", "Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Mostrar nuevamente el login si hay error
                    if (formPadre != null) formPadre.Show();
                    return;
            }
        }
    }

}