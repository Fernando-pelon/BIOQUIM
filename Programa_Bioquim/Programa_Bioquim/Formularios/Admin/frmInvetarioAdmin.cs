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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Programa_Bioquim.Formularios.Empleado
{
    public partial class frmInvetarioAdmin : Form
    {
        
        public frmInvetarioAdmin()
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
            txtCantidadProducto.MaxLength = 35;
            txtNombreProducto.MaxLength = 8;
            txtCostoProducto.MaxLength = 8;
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


        private void txtNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }



        private void txtCantidadProducto_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el texto actual más el nuevo carácter excede los 100 caracteres
            if (txtBuscarProducto.Text.Length >= 100 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada del carácter
            }
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el texto actual más el nuevo carácter excede los 100 caracteres
            if (txtNombreProducto.Text.Length >= 100 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada del carácter
            }
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos y teclas de control (como Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea cualquier carácter que no sea número
                return;
            }

            // Limitar a 100 caracteres
            if (txtCantidadProducto.Text.Length >= 100 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquea si ya hay 100 caracteres
            }
        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos y teclas de control (como Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea cualquier carácter que no sea número
                return;
            }

            // Limitar a 100 caracteres
            if (txtCostoProducto.Text.Length >= 100 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquea si ya hay 100 caracteres
            }
        }

        private void txtCostoProducto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
