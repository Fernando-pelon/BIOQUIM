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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Programa_Bioquim.Formularios.Admin
{
    public partial class frmGestionDeUsuarios : Form
    {
        public frmGestionDeUsuarios()
        {
            InitializeComponent();
        }

        private void btnEliminarUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvGestionUsuarios.CurrentRow != null)
                {
                    int idUsuario = Convert.ToInt32(dgvGestionUsuarios.CurrentRow.Cells[0].Value);
                    Usuario UsuarioEliminar = new Usuario();
                    UsuarioEliminar.IdUsario = idUsuario;
                    UsuarioEliminar.eliminarUsuarios(idUsuario);
                    cargarUsuarios();
                    MessageBox.Show("Usuario eliminado correctamente.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Seleccione un Usuario para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cargarUsuarios()
        {
            dgvGestionUsuarios.DataSource = null;
            dgvGestionUsuarios.DataSource = Usuario.cargarUsuarios();
        }

        private void btnAgregarUser_Click(object sender, EventArgs e)
        {
            frmContenedorRegistrarUsuario flotante = new frmContenedorRegistrarUsuario();

            flotante.StartPosition = FormStartPosition.CenterParent;

            flotante.ShowDialog(this);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgvGestionUsuarios.DataSource = null;
            dgvGestionUsuarios.DataSource = Usuario.buscarUsuarios(txtBuscarUser.Text);
        }

        private void btnActualizarUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombreUser.Tag == null)
                {
                    MessageBox.Show("Seleccione un usuario dando doble clic en la tabla.", "Aviso",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Usuario user = new Usuario();
                user.IdUsario = Convert.ToInt32(txtNombreUser.Tag);
                user.NombreUsuario = txtNombreUser.Text;
                user.ApellidoUsuario = txtApellidoUser.Text;
                user.CorreoUsuario = txtCorreoUser.Text;
                user.ContrasenaUsuario = txtContraseñaUser.Text;
                user.IdDepartamento = Convert.ToInt32(cbDepartamentoUser.SelectedValue);
                user.IdTipoUsuario = Convert.ToInt32(cbTIpoUsuarioUser.SelectedValue);

                if (user.actualizarUsuarios(user.IdUsario))
                {
                    cargarUsuarios();
                    MessageBox.Show("Usuario actualizado correctamente.", "Éxito",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar campos
                    txtNombreUser.Clear();
                    txtApellidoUser.Clear();
                    txtCorreoUser.Clear();
                    txtContraseñaUser.Clear();
                    cbDepartamentoUser.SelectedIndex = -1;
                    cbTIpoUsuarioUser.SelectedIndex = -1;
                    txtNombreUser.Tag = null;
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el usuario.", "Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar usuario: " + ex.Message, "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmGestionDeUsuarios_Load(object sender, EventArgs e)
        {
            cargarUsuarios();
            CargarComboTipoUsuario();
            CargarComboDepartamento();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            btnRefrescar.Enabled = false;
            Cursor = Cursors.WaitCursor;

            try
            {
                cargarUsuarios();
                MessageBox.Show("Datos actualizados correctamente.", "Actualización",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnRefrescar.Enabled = true;
                Cursor = Cursors.Default;
            }
        }
        private void dgvGestionUsuarios_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvGestionUsuarios.Rows[e.RowIndex];

                txtNombreUser.Tag = fila.Cells[0].Value;

                txtNombreUser.Text = fila.Cells[1].Value.ToString();
                txtApellidoUser.Text = fila.Cells[2].Value.ToString();
                txtCorreoUser.Text = fila.Cells[3].Value.ToString();
                txtContraseñaUser.Text = fila.Cells[4].Value.ToString();
                cbDepartamentoUser.Text = fila.Cells[5].Value.ToString();
                cbTIpoUsuarioUser.Text = fila.Cells[6].Value.ToString();
            }
        }
        private void CargarComboTipoUsuario()
        {
      
            string query = "SELECT idTipoUsuario, nombreTipoUsuario FROM TipoUsuario";

            using (SqlConnection con = ConexionDB.conectar())
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbTIpoUsuarioUser.DataSource = dt;
                cbTIpoUsuarioUser.DisplayMember = "nombreTipoUsuario";
                cbTIpoUsuarioUser.ValueMember = "idTipoUsuario";
            }
        }
        private void CargarComboDepartamento()
        {
            string query = "SELECT idDepartamento, nombreDepartamento FROM Departamento";

            using (SqlConnection con = ConexionDB.conectar())
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbDepartamentoUser.DataSource = dt;
                cbDepartamentoUser.DisplayMember = "nombreDepartamento"; 
                cbDepartamentoUser.ValueMember = "idDepartamento";      
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el texto actual más el nuevo carácter excede los 100 caracteres
            if (txtNombreUser.Text.Length >= 100 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada del carácter
            }
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el texto actual más el nuevo carácter excede los 100 caracteres
            if (txtApellidoUser.Text.Length >= 100 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada del carácter
            }
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el texto actual más el nuevo carácter excede los 100 caracteres
            if (txtContraseñaUser.Text.Length >= 100 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada del carácter
            }
        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el texto actual más el nuevo carácter excede los 100 caracteres
            if (txtCorreoUser.Text.Length >= 100 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada del carácter
            }
        }
        



    }

}
