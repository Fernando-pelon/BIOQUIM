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

namespace Programa_Bioquim.userControl
{
    public partial class frmRegistrarUsuario : UserControl
    {
        public frmRegistrarUsuario()
        {
            InitializeComponent();
        }

        private void cargarRoles()
        {
            cbDepartamento.DataSource= null;
            cbDepartamento.DataSource=Usuario.cargarRoles();
            cbDepartamento.DisplayMember = "Nombre";
            cbDepartamento.ValueMember = "id";
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.NombreUsuario = txtNombre.Text;
            user.ApellidoUsuario = txtApellido.Text;
            user.CorreoUsuario = txtCorreo.Text;
            user.ContrasenaUsuario = BCrypt.Net.BCrypt.HashPassword(txtContraseña.Text);
            user.IdTipoUsuario = Convert.ToInt32(cbTIpoUsuario.SelectedValue);
            user.IdDepartamento = Convert.ToInt32(cbDepartamento.SelectedValue);
            if (user.RegistrarUsuario())
            {
                MessageBox.Show("Usuario registrado con exito");
            }
            else
            {
                MessageBox.Show("Error al registrar usuario");
            }
        }

        private void frmRegistrarUsuario_Load(object sender, EventArgs e)
        {
            cargarRoles();
        }
    }
}
