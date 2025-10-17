namespace Programa_Bioquim.Formularios.Empleado
{
    partial class frmInvetarioEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.pnlinventario = new System.Windows.Forms.Panel();
            this.lblInventario = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtCantidadProducto = new System.Windows.Forms.TextBox();
            this.txtCostoProducto = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnActualizarProduc = new System.Windows.Forms.Button();
            this.lblCantidadProducto = new System.Windows.Forms.Label();
            this.lblCostoProducto = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.lblBuscarProductp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.pnlinventario.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.Blue;
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.White;
            this.btnAgregarProducto.Location = new System.Drawing.Point(443, 134);
            this.btnAgregarProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(141, 54);
            this.btnAgregarProducto.TabIndex = 6;
            this.btnAgregarProducto.Text = "Agregar producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarRuta_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.BackColor = System.Drawing.Color.Blue;
            this.btnEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarProducto.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProducto.ForeColor = System.Drawing.Color.White;
            this.btnEliminarProducto.Location = new System.Drawing.Point(608, 134);
            this.btnEliminarProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(148, 54);
            this.btnEliminarProducto.TabIndex = 5;
            this.btnEliminarProducto.Text = "Eliminar producto";
            this.btnEliminarProducto.UseVisualStyleBackColor = false;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // dgvInventario
            // 
            this.dgvInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Location = new System.Drawing.Point(104, 112);
            this.dgvInventario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.ReadOnly = true;
            this.dgvInventario.RowHeadersVisible = false;
            this.dgvInventario.RowHeadersWidth = 45;
            this.dgvInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventario.Size = new System.Drawing.Size(779, 329);
            this.dgvInventario.TabIndex = 7;
            this.dgvInventario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvInventario.DoubleClick += new System.EventHandler(this.dgvInventario_DoubleClick);
            // 
            // pnlinventario
            // 
            this.pnlinventario.BackColor = System.Drawing.Color.Blue;
            this.pnlinventario.Controls.Add(this.lblInventario);
            this.pnlinventario.Location = new System.Drawing.Point(411, 44);
            this.pnlinventario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlinventario.Name = "pnlinventario";
            this.pnlinventario.Size = new System.Drawing.Size(195, 60);
            this.pnlinventario.TabIndex = 8;
            // 
            // lblInventario
            // 
            this.lblInventario.AutoSize = true;
            this.lblInventario.BackColor = System.Drawing.Color.Blue;
            this.lblInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblInventario.Location = new System.Drawing.Point(23, 16);
            this.lblInventario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInventario.Name = "lblInventario";
            this.lblInventario.Size = new System.Drawing.Size(107, 25);
            this.lblInventario.TabIndex = 0;
            this.lblInventario.Text = "Inventario";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.Location = new System.Drawing.Point(40, 59);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.ShortcutsEnabled = false;
            this.txtNombreProducto.Size = new System.Drawing.Size(224, 29);
            this.txtNombreProducto.TabIndex = 9;
            this.txtNombreProducto.TextChanged += new System.EventHandler(this.txtNombreProducto_TextChanged);
            this.txtNombreProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txtCantidadProducto
            // 
            this.txtCantidadProducto.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadProducto.Location = new System.Drawing.Point(40, 134);
            this.txtCantidadProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantidadProducto.Name = "txtCantidadProducto";
            this.txtCantidadProducto.ShortcutsEnabled = false;
            this.txtCantidadProducto.Size = new System.Drawing.Size(224, 29);
            this.txtCantidadProducto.TabIndex = 10;
            this.txtCantidadProducto.TextChanged += new System.EventHandler(this.txtCantidadProducto_TextChanged);
            this.txtCantidadProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // txtCostoProducto
            // 
            this.txtCostoProducto.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoProducto.Location = new System.Drawing.Point(336, 57);
            this.txtCostoProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCostoProducto.MaxLength = 50;
            this.txtCostoProducto.Name = "txtCostoProducto";
            this.txtCostoProducto.ShortcutsEnabled = false;
            this.txtCostoProducto.Size = new System.Drawing.Size(247, 29);
            this.txtCostoProducto.TabIndex = 11;
            this.txtCostoProducto.TextChanged += new System.EventHandler(this.txtCostoProducto_TextChanged);
            this.txtCostoProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.btnActualizarProduc);
            this.panel1.Controls.Add(this.lblCantidadProducto);
            this.panel1.Controls.Add(this.lblCostoProducto);
            this.panel1.Controls.Add(this.lblNombreProducto);
            this.panel1.Controls.Add(this.txtCantidadProducto);
            this.panel1.Controls.Add(this.txtCostoProducto);
            this.panel1.Controls.Add(this.btnAgregarProducto);
            this.panel1.Controls.Add(this.txtNombreProducto);
            this.panel1.Controls.Add(this.btnEliminarProducto);
            this.panel1.Location = new System.Drawing.Point(104, 448);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 206);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnActualizarProduc
            // 
            this.btnActualizarProduc.BackColor = System.Drawing.Color.Blue;
            this.btnActualizarProduc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizarProduc.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarProduc.ForeColor = System.Drawing.Color.White;
            this.btnActualizarProduc.Location = new System.Drawing.Point(608, 73);
            this.btnActualizarProduc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnActualizarProduc.Name = "btnActualizarProduc";
            this.btnActualizarProduc.Size = new System.Drawing.Size(148, 54);
            this.btnActualizarProduc.TabIndex = 16;
            this.btnActualizarProduc.Text = "Actualizar Producto";
            this.btnActualizarProduc.UseVisualStyleBackColor = false;
            this.btnActualizarProduc.Click += new System.EventHandler(this.btnActualizarProduc_Click);
            // 
            // lblCantidadProducto
            // 
            this.lblCantidadProducto.AutoSize = true;
            this.lblCantidadProducto.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadProducto.Location = new System.Drawing.Point(35, 103);
            this.lblCantidadProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadProducto.Name = "lblCantidadProducto";
            this.lblCantidadProducto.Size = new System.Drawing.Size(157, 22);
            this.lblCantidadProducto.TabIndex = 14;
            this.lblCantidadProducto.Text = "Cantidad producto:";
            this.lblCantidadProducto.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblCostoProducto
            // 
            this.lblCostoProducto.AutoSize = true;
            this.lblCostoProducto.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoProducto.Location = new System.Drawing.Point(331, 26);
            this.lblCostoProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCostoProducto.Name = "lblCostoProducto";
            this.lblCostoProducto.Size = new System.Drawing.Size(133, 22);
            this.lblCostoProducto.TabIndex = 13;
            this.lblCostoProducto.Text = "Costo producto:";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.Location = new System.Drawing.Point(35, 26);
            this.lblNombreProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(153, 22);
            this.lblNombreProducto.TabIndex = 12;
            this.lblNombreProducto.Text = "Nombre producto:";
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Location = new System.Drawing.Point(675, 79);
            this.txtBuscarProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.ShortcutsEnabled = false;
            this.txtBuscarProducto.Size = new System.Drawing.Size(207, 22);
            this.txtBuscarProducto.TabIndex = 13;
            this.txtBuscarProducto.TextChanged += new System.EventHandler(this.txtBuscarProducto_TextChanged);
            // 
            // lblBuscarProductp
            // 
            this.lblBuscarProductp.AutoSize = true;
            this.lblBuscarProductp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarProductp.Location = new System.Drawing.Point(673, 53);
            this.lblBuscarProductp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscarProductp.Name = "lblBuscarProductp";
            this.lblBuscarProductp.Size = new System.Drawing.Size(133, 17);
            this.lblBuscarProductp.TabIndex = 23;
            this.lblBuscarProductp.Text = "Buscar Producto:";
            // 
            // frmInvetarioEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 761);
            this.Controls.Add(this.lblBuscarProductp);
            this.Controls.Add(this.txtBuscarProducto);
            this.Controls.Add(this.pnlinventario);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmInvetarioEmpleado";
            this.Text = "frmInvetario";
            this.Load += new System.EventHandler(this.frmInvetario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.pnlinventario.ResumeLayout(false);
            this.pnlinventario.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.Panel pnlinventario;
        private System.Windows.Forms.Label lblInventario;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtCantidadProducto;
        private System.Windows.Forms.TextBox txtCostoProducto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCantidadProducto;
        private System.Windows.Forms.Label lblCostoProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Button btnActualizarProduc;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.Label lblBuscarProductp;
    }
}