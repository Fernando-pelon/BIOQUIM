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
    public partial class frmRutasDeEntregaEmpleado : Form
    {
        public frmRutasDeEntregaEmpleado()
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
                rut.IdTipoPago = rbEfectivo.Checked ? 1 : 2;
                rut.IdTipoPago = rbTarjetaCredito.Checked ? 2 : 1;
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
            cbProducto.Text = dgvRutas.CurrentRow.Cells[1].Value.ToString();
            txtCostoProducto.Text = dgvRutas.CurrentRow.Cells[2].Value.ToString();
            rbEfectivo.Checked = dgvRutas.CurrentRow.Cells[3].Value.ToString() == "Efectivo";
            rbTarjetaCredito.Checked = dgvRutas.CurrentRow.Cells[3].Value.ToString() == "Tarjeta de Credito";
            cbEmpresa.Text = dgvRutas.CurrentRow.Cells[4].Value.ToString();
            cbUbicacionEmpresa.Text = dgvRutas.CurrentRow.Cells[5].Value.ToString();

        }

        private void btnEliminarRuta_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRutas.CurrentRow != null)
                {
                    int idRutaEntrega = Convert.ToInt32(dgvRutas.CurrentRow.Cells[0].Value);
                    RutaDeEntrega rutaEliminar = new RutaDeEntrega();
                    rutaEliminar.eliminarRuta(idRutaEntrega);
                    MostrarRutas();
                    MessageBox.Show("Producto eliminado correctamente.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Seleccione un producto para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizarRutas_Click(object sender, EventArgs e)
        {

            RutaDeEntrega ruta = new RutaDeEntrega();
            ruta.IdProducto = Convert.ToInt32(cbProducto.SelectedValue);
            ruta.MontoPago = double.Parse(txtCostoProducto.Text);
            ruta.IdUbicacion = Convert.ToInt32(cbUbicacionEmpresa.SelectedValue);
            ruta.IdEmpresa = Convert.ToInt32(cbEmpresa.SelectedValue);
            ruta.IdTipoPago = rbEfectivo.Checked ? 1 : 2;
            ruta.IdTipoPago = rbTarjetaCredito.Checked ? 2 : 1;
            int idRutaEntrega = Convert.ToInt32(dgvRutas.CurrentRow.Cells[0].Value);
            ruta.actualizarRuta(idRutaEntrega);
            MostrarRutas();

        }

        private void txtBuscarRutas_TextChanged(object sender, EventArgs e)
        {
            dgvRutas.DataSource = null;
            dgvRutas.DataSource = RutaDeEntrega.buscarRutaDeEntrega(txtBuscarRutas.Text);
        }

        private void txtCostoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
