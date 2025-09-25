using Programa_Bioquim.Formularios;
using Programa_Bioquim.Formularios.Admin;
using Programa_Bioquim.Formularios.Empleado;
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
    public partial class frmDashBoardAdmin : Form
    {
        public frmDashBoardAdmin()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void frmDashBoard_Load(object sender, EventArgs e)
        {
            abrirForm(new frmInicioAdmin());
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
            abrirForm(new frmRutasDeEntregaAdmin());
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
    }
}
