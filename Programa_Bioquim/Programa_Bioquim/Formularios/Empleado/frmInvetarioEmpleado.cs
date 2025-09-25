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
    public partial class frmInvetarioEmpleado : Form
    {
        
        public frmInvetarioEmpleado()
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
            try
            {
                Producto Pro = new Producto();
                Pro.NombreProducto = txtNombreProducto.Text;
                Pro.CostoProducto = double.Parse(txtCostoProducto.Text);
                Pro.CantidadProducto = double.Parse(txtCantidadProducto.Text);
                Pro.insertarProducto();
                MostrarInvetario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "error de informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvInventario.CurrentRow != null)
                {
                    int idProducto = Convert.ToInt32(dgvInventario.CurrentRow.Cells[0].Value);
                    Producto productoEliminar = new Producto();
                    productoEliminar.IdProducto = idProducto;
                    productoEliminar.eliminarProducto();
                    MostrarInvetario();
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

        private void dgvInventario_DoubleClick(object sender, EventArgs e)
        {
            txtNombreProducto.Text = dgvInventario.CurrentRow.Cells[1].Value.ToString();
            txtCostoProducto.Text = dgvInventario.CurrentRow.Cells[2].Value.ToString();
            txtCantidadProducto.Text = dgvInventario.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnActualizarProduc_Click(object sender, EventArgs e)
        {
            Producto p = new Producto();
            p.IdProducto = Convert.ToInt32(dgvInventario.CurrentRow.Cells[0].Value);
            p.NombreProducto = txtNombreProducto.Text;
            p.CostoProducto = double.Parse(txtCostoProducto.Text);
            p.CantidadProducto = double.Parse(txtCantidadProducto.Text);
            p.actualizarProducto();
            MostrarInvetario();
        }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            dgvInventario.DataSource = null;
            dgvInventario.DataSource = Producto.buscarProductos(txtBuscarProducto.Text);
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

        private void txtNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtCantidadProducto_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCantidadProducto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
