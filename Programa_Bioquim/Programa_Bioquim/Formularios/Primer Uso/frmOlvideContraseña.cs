using Modelos.Conexiones;
using Programa_Bioquim.Utilidades;
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

namespace Programa_Bioquim.Formularios.Primer_Uso
{
    public partial class frmOlvideContraseña : Form
    {
        public frmOlvideContraseña()
        {
            InitializeComponent();
        }
        private string correoUsuario;
        public frmOlvideContraseña(string correo)
        {
            InitializeComponent();
            correoUsuario = correo;
        }
        private bool ActualizarContrasena(string correo, string nuevaContrasena)
        {
            try
            {
                using (var conexion = ConexionDB.conectar())
                {
                    if (conexion != null)
                    {
                        string query = "UPDATE Usuario SET contrasenaUsuario = @nuevaContrasena WHERE correoUsuario = @correo";
                        SqlCommand cmd = new SqlCommand(query, conexion);
                        cmd.Parameters.AddWithValue("@nuevaContrasena", BCrypt.Net.BCrypt.HashPassword(nuevaContrasena));
                        cmd.Parameters.AddWithValue("@correo", correo);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private void btnCambiarContrasena_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar campos
                if (string.IsNullOrWhiteSpace(txtCorreoActual.Text) ||
                    string.IsNullOrWhiteSpace(txtNuevaContrasena.Text) ||
                    string.IsNullOrWhiteSpace(txtConfirmarContrasena.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Advertencia",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtNuevaContrasena.Text != txtConfirmarContrasena.Text)
                {
                    MessageBox.Show("Las nuevas contraseñas no coinciden.", "Advertencia",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtNuevaContrasena.Text.Length < 6)
                {
                    MessageBox.Show("La nueva contraseña debe tener al menos 6 caracteres.", "Advertencia",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Actualizar contraseña
                if (ActualizarContrasena(correoUsuario, txtNuevaContrasena.Text))
                {
                    // Marcar que ya cambió la contraseña
                    EstadoContrasena.MarcarContrasenaCambiada(correoUsuario);

                    MessageBox.Show("Contraseña cambiada exitosamente.", "Éxito",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al cambiar la contraseña.", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Debe cambiar su contraseña para continuar.", "Advertencia",
             MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
    }

