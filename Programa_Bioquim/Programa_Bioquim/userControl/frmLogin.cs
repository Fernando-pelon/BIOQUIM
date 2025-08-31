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
                string usuario = txtUsuario.Text;
                string contrasenia = txtContrasenia.Text;

                Usuario usuario1 = new Usuario();
                if (usuario1.VerificarLogin(usuario, contrasenia))
                {
                    MessageBox.Show("Login exitoso");
                    frmDashBoardEmpleado dashBoardEmpleado = new frmDashBoardEmpleado();
                    dashBoardEmpleado.Show();
                    Form mainForm = this.FindForm();
                    if (mainForm != null)
                    {
                        mainForm.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }
        }
    }
}
