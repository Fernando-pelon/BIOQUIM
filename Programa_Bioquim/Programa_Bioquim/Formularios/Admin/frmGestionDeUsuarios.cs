using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void dgvGestionUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            Usuario user = new Usuario();
            user.IdUsario = Convert.ToInt32(dgvGestionUsuarios.CurrentRow.Cells[0].Value);
            user.NombreUsuario = dgvGestionUsuarios.CurrentRow.Cells[1].Value.ToString();
            user.ApellidoUsuario = dgvGestionUsuarios.CurrentRow.Cells[2].Value.ToString();
            user.CorreoUsuario = dgvGestionUsuarios.CurrentRow.Cells[3].Value.ToString();
            user.IdDepartamento = Convert.ToInt32(dgvGestionUsuarios.CurrentRow.Cells[5].Value);
            user.IdTipoUsuario = Convert.ToInt32(dgvGestionUsuarios.CurrentRow.Cells[6].Value);

            //user.actualizarUsuarios();
            cargarUsuarios();



        }

        private void frmGestionDeUsuarios_Load(object sender, EventArgs e)
        {
            cargarUsuarios();
        }

        private void lblCorreoCrear_Click(object sender, EventArgs e)
        {

        }

        private void dgvGestionUsuarios_DoubleClick(object sender, EventArgs e)
        {
            txtNombreUser.Text = dgvGestionUsuarios.CurrentRow.Cells[1].Value.ToString();
            txtApellidoUser.Text = dgvGestionUsuarios.CurrentRow.Cells[2].Value.ToString();
            txtContraseñaUser.Text = dgvGestionUsuarios.CurrentRow.Cells[6].Value.ToString();
            txtCorreoUser.Text = dgvGestionUsuarios.CurrentRow.Cells[3].Value.ToString();
            cbTIpoUsuarioUser.Text = dgvGestionUsuarios.CurrentRow.Cells[4].Value.ToString();
            cbDepartamentoUser.Text = dgvGestionUsuarios.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
