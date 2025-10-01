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
            this.Load += frmRegistrarUsuario_Load;
        }

        private void cargarTipoUsuario()
        {
            cbTIpoUsuario.DataSource = null;
            cbTIpoUsuario.DataSource = Usuario.cargarTipoUsuario();
            cbTIpoUsuario.DisplayMember = "nombreTipoUsuario";
            cbTIpoUsuario.ValueMember = "idTipoUsuario";
        }
        private void cargarDepartamento()
        {
            cbDepartamento.DataSource = null;
            cbDepartamento.DataSource = Usuario.CargarDepartamento();
            cbDepartamento.DisplayMember = "nombreDepartamento";
            cbDepartamento.ValueMember = "idDepartamento";
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
            if (user.insertarUsuarios())
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
            cargarTipoUsuario();
            cargarDepartamento();
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
