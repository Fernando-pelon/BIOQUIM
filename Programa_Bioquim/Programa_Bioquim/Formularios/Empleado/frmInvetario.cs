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

namespace Programa_Bioquim.Formularios.Empleado
{
    public partial class frmInvetario : Form
    {
        
        public frmInvetario()
        {
            InitializeComponent();
        }

        private void MostrarInvetario()
        {
            dgvInventario.DataSource = null;
            dgvInventario.DataSource = Producto.cargarInventario();
        }

        private void frmInvetario_Load(object sender, EventArgs e)
        {
            MostrarInvetario();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnAgregarRuta_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
