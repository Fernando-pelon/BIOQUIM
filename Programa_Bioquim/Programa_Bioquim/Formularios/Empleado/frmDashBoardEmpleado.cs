using Programa_Bioquim.Formularios;
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
    }
}
