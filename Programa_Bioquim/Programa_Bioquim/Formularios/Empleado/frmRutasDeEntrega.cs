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
using Modeloss.Entidades;

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
            cargarEmpresas();
            cargarProductos();
            cargarUbicaciones();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblNombreProducto_Click(object sender, EventArgs e)
        {

        }

        private void cargarProductos()
        {
            cbProducto.DataSource = null;
            cbProducto.DataSource = Producto.listaProducto();
            cbProducto.DisplayMember = "nombreProducto";
            cbProducto.ValueMember = "idProducto";
            cbProducto.SelectedIndex = -1;
        }

        private void cargarEmpresas()
        {
            cbEmpresa.DataSource = null;
            cbEmpresa.DataSource = Empresa.listaEmpresa();
            cbEmpresa.DisplayMember = "NombreEmpresa";
            cbEmpresa.ValueMember = "idEmpresa";
            cbEmpresa.SelectedIndex = -1;
        }

        private void cargarUbicaciones()
        {
            cbUbicacionEmpresa.DataSource = null;
            cbUbicacionEmpresa.DataSource = Empresa.listarRutas();
            cbUbicacionEmpresa.DisplayMember = "ubicacionEmpresa";
            cbUbicacionEmpresa.ValueMember = "idUbicacion";
            cbUbicacionEmpresa.SelectedIndex = -1;
        }

        private void btnAgregarRuta_Click(object sender, EventArgs e)
        {
            try
            {
                RutaDeEntrega rut = new RutaDeEntrega();
                rut.IdProducto = Convert.ToInt32(cbProducto.SelectedValue);
                rut.MontoPago = double.Parse(txtCostoProducto.Text);
                rut.IdUbicacion = Convert.ToInt32(cbUbicacionEmpresa.SelectedValue);
                rut.IdEmpresa = Convert.ToInt32(cbEmpresa.SelectedValue);
                rut.insertarRuta();
                MostrarRutas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "error de informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbUbicacionEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvRutas_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
