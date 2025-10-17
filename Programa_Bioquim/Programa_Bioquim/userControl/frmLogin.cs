using BCrypt.Net;
using Modelos.Conexiones;
using Modelos.Entidades;
using Programa_Bioquim.Formularios;
using Programa_Bioquim.Formularios.Admin;
using Programa_Bioquim.Formularios.Primer_Uso;
using Programa_Bioquim.Utilidades;
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
                    // Verificar si necesita cambiar contraseña
                    bool necesitaCambio = EstadoContrasena.NecesitaCambioContrasena(usuarioLogueado.CorreoUsuario);

                    if (necesitaCambio)
                    {
                        // Mostrar formulario de cambio de contraseña
                        frmCambiarContraseña cambiarContrasena = new frmCambiarContraseña(usuarioLogueado.CorreoUsuario);
                        var formPadre = this.ParentForm;
                        if (formPadre != null) formPadre.Hide();

                        if (cambiarContrasena.ShowDialog() == DialogResult.OK)
                        {
                            // Contraseña cambiada, continuar normal
                            SesionUsuario.IniciarSesion(usuarioLogueado);
                            if (formPadre != null) formPadre.Hide();
                            RedirigirSegunTipoUsuario();
                        }
                        else
                        {
                            // No cambió la contraseña, volver al login
                            if (formPadre != null) formPadre.Show();
                            return;
                        }
                    }
                    else
                    {
                        // No necesita cambiar contraseña, login normal
                        SesionUsuario.IniciarSesion(usuarioLogueado);
                        RedirigirSegunTipoUsuario();
                    }
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

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsuario.KeyDown += TxtUsuario_KeyDown;
            txtContrasenia.KeyDown += TxtContrasenia_KeyDown;
        }

        private void TxtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(txtUsuario.Text))
            {
                e.SuppressKeyPress = true;
                txtContrasenia.Focus();
            }
        }

        private void TxtContrasenia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(txtContrasenia.Text))
            {
                e.SuppressKeyPress = true;
                btnLogIn.PerformClick();
            }
        }

        private void lblOlvideContraseña_Click(object sender, EventArgs e)
        {
            frmOlvideContraseña formOlvide = new frmOlvideContraseña();
            formOlvide.Show();
            this.Hide();
        }
    }
}