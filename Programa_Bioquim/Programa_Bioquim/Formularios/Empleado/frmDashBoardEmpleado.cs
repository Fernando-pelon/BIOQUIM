using Modelos.Entidades;
using Programa_Bioquim.Formularios;
using Programa_Bioquim.Formularios.Admin;
using Programa_Bioquim.Formularios.Empleado;
using Programa_Bioquim.userControl;
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

namespace Programa_Bioquim
{
    public partial class frmDashBoardEmpleado : Form
    {
        public frmDashBoardEmpleado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void frmDashBoard_Load(object sender, EventArgs e)
        {
            abrirForm(new frmInicioEmpleado());
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblInicio_Click(object sender, EventArgs e)
        {
            abrirForm(new frmInicioEmpleado());
        }
        #region " Metodos para abrir formularios"
        private Form activarForm = null;

        private void abrirForm(Form formularioPintar)
        {
            if (activarForm != null)
            {
                activarForm.Close();
            }
            activarForm = formularioPintar;
            formularioPintar.TopLevel = false;
            formularioPintar.FormBorderStyle = FormBorderStyle.None;
            formularioPintar.Dock = DockStyle.Fill;

            pnlCentral.Controls.Add(formularioPintar);
            formularioPintar.BringToFront();
            formularioPintar.Show();

        }
        #endregion

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblRutas_Click(object sender, EventArgs e)
        {
            abrirForm(new frmRutasDeEntregaEmpleado());
        }

        private void lblInventario_Click(object sender, EventArgs e)
        {
            abrirForm(new frmInvetarioEmpleado());
        }

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GestionUsuario_Click(object sender, EventArgs e)
        {
            abrirForm(new frmGestionDeUsuarios());
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void btnCerrarSesionEmpleado_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Deseas cerrar sesión?", "Confirmar",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                CerrarSesionYLimpiarCampos();
            }
        }

        private void CerrarSesionYLimpiarCampos()
        {
            SesionUsuario.CerrarSesion();

            foreach (Form form in Application.OpenForms)
            {
                if (form is frmContenedorLogin contenedor)
                {
                    // Limpiar los campos del UserControl de login
                    LimpiarCamposLogin(contenedor);

                    // Mostrar el contenedor
                    form.Show();
                    form.BringToFront();

                    // Cerrar este dashboard
                    this.Close();
                    return;
                }
            }

            frmContenedorLogin nuevoContenedor = new frmContenedorLogin();
            nuevoContenedor.Show();
            this.Close();
        }

        private void LimpiarCamposLogin(frmContenedorLogin contenedor)
        {
            foreach (Control control in contenedor.Controls)
            {
                if (control is frmLogin loginControl)
                {
                    LimpiarTextBox(loginControl, "txtUsuario");
                    LimpiarTextBox(loginControl, "txtContrasenia");
                    break;
                }
            }
        }

        private void LimpiarTextBox(Control parent, string nombreControl)
        {
            foreach (Control control in parent.Controls)
            {
                if (control.Name == nombreControl && control is TextBox textBox)
                {
                    textBox.Text = "";
                    break;
                }

                if (control.HasChildren)
                {
                    LimpiarTextBox(control, nombreControl);
                }
            }
        }

        private void lblAyuda_Click(object sender, EventArgs e)
        {
            abrirForm(new frmAyuda());
        }
    }
}
