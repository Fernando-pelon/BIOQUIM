using Programa_Bioquim; 
using System;
using Modelos.Entidades;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_Bioquim.Formularios
{
    public partial class frmInicioAdmin : Form
    {
        public frmInicioAdmin()
        {
            InitializeComponent();
        }

        private void pnlInicioEmpleado_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pnlBienvenida_Paint(object sender, PaintEventArgs e)
        {
        }

        private void MostrarRutas()
        {
            dgvDatosRutas.DataSource = null;
            dgvDatosRutas.DataSource = RutaDeEntrega.cargarRutas();

        }

        private void dgvDatosRutas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
      
        }


        private void frmInicioEmpleado_Load(object sender, EventArgs e)
        {
            MostrarRutas();
        }

        private void frmInicioEmpleado_Load_1(object sender, EventArgs e)
        {
            MostrarRutas();
        }
    }
}
