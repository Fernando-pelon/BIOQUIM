using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos.Entidades;

namespace Programa_Bioquim.Formularios.Primer_Uso
{
    public partial class frmCrearNuevoUsuario : Form
    {
        public frmCrearNuevoUsuario()
        {
            InitializeComponent();
        }

        private void btnCrearPrimerUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar campos
                if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtApellido.Text) ||
                    string.IsNullOrWhiteSpace(txtCorreo.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Advertencia",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear el usuario administrador con contraseña automática
                string contrasenaAutomatica = Modeloss.Entidades.ModelPrimerUso.CrearPrimerUsuarioAdministrador(
                    txtNombre.Text.Trim(),
                    txtApellido.Text.Trim(),
                    txtCorreo.Text.Trim()
                );

                if (!string.IsNullOrEmpty(contrasenaAutomatica))
                {
                    MessageBox.Show($"Usuario administrador creado exitosamente.\n\n" +
                                  $"Su contraseña temporal es: {contrasenaAutomatica}\n\n" +
                                  $"DEBE cambiarla en su primer inicio de sesión.",
                                  "Usuario Creado",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);

                    // MARCAR PRIMER USO COMPLETADO
                    Modeloss.Entidades.EstadoAplicacion.MarcarPrimerUsoCompletado();

                    this.Hide();
                    frmContenedorLogin login = new frmContenedorLogin();
                    login.Show();
                }
                else
                {
                    MessageBox.Show("Error al crear el usuario.", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el texto actual más el nuevo carácter excede los 100 caracteres
            if (txtNombre.Text.Length >= 100 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada del carácter
            }
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el texto actual más el nuevo carácter excede los 100 caracteres
            if (txtApellido.Text.Length >= 100 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada del carácter
            }
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el texto actual más el nuevo carácter excede los 100 caracteres
            if (txtCorreo.Text.Length >= 100 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada del carácter
            }
        }
    }
}