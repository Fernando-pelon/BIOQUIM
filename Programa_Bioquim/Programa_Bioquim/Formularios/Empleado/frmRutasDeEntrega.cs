using System;
using Modelos.Entidades;
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
    public partial class frmRutasDeEntrega : Form
    {
        public frmRutasDeEntrega()
        {
            InitializeComponent();
        }
        private void MostrarRutas()
        {
            dgvRutas.DataSource = null;
            dgvRutas.DataSource = RutaDeEntrega.cargarRutas();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmRutasDeEntrega_Load(object sender, EventArgs e)
        {
            MostrarRutas();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblNombreProducto_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarRuta_Click(object sender, EventArgs e)
        {
            try
            {
                RutaDeEntrega rut = new RutaDeEntrega();
                rut.IdProducto = txtProducto.Text;
                rut.MontoPago = double.Parse(txtCostoProducto.Text);
                rut.UbicacionEmpresa = txtUbicacionEmpresa.Text;
                rut.IdEmpresa = Convert.ToInt32(cbEmpresa.SelectedValue);
                rut.insertarProducto();
                insertarProducto();
                MessageBox.Show("excelente datos registrados", "Datos correctos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "error de informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
