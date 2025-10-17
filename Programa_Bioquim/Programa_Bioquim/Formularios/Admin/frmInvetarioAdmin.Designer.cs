namespace Programa_Bioquim.Formularios.Empleado
{
    partial class frmInvetarioAdmin
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
            this.btnAgregarProducto.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.White;
            this.btnAgregarProducto.Location = new System.Drawing.Point(344, 109);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(106, 55);
            this.btnAgregarProducto.TabIndex = 6;
            this.btnAgregarProducto.Text = "Agregar producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarRuta_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.BackColor = System.Drawing.Color.Blue;
            this.btnEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarProducto.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProducto.ForeColor = System.Drawing.Color.White;
            this.btnEliminarProducto.Location = new System.Drawing.Point(456, 109);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(111, 55);
            this.btnEliminarProducto.TabIndex = 5;
            this.btnEliminarProducto.Text = "Eliminar producto";
            this.btnEliminarProducto.UseVisualStyleBackColor = false;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // dgvInventario
            // 
            this.dgvInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Location = new System.Drawing.Point(78, 91);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.ReadOnly = true;
            this.dgvInventario.RowHeadersVisible = false;
            this.dgvInventario.RowHeadersWidth = 45;
            this.dgvInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventario.Size = new System.Drawing.Size(584, 267);
            this.dgvInventario.TabIndex = 7;
            this.dgvInventario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvInventario.DoubleClick += new System.EventHandler(this.dgvInventario_DoubleClick);
            // 
            // pnlinventario
            // 
            this.pnlinventario.BackColor = System.Drawing.Color.Blue;
            this.pnlinventario.Controls.Add(this.lblInventario);
            this.pnlinventario.Location = new System.Drawing.Point(308, 36);
            this.pnlinventario.Name = "pnlinventario";
            this.pnlinventario.Size = new System.Drawing.Size(146, 49);
            this.pnlinventario.TabIndex = 8;
            // 
            // lblInventario
            // 
            this.lblInventario.AutoSize = true;
            this.lblInventario.BackColor = System.Drawing.Color.Blue;
            this.lblInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblInventario.Location = new System.Drawing.Point(17, 13);
            this.lblInventario.Name = "lblInventario";
            this.lblInventario.Size = new System.Drawing.Size(107, 25);
            this.lblInventario.TabIndex = 0;
            this.lblInventario.Text = "Inventario";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.Location = new System.Drawing.Point(30, 48);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.ShortcutsEnabled = false;
            this.txtNombreProducto.Size = new System.Drawing.Size(169, 28);
            this.txtNombreProducto.TabIndex = 9;
            this.txtNombreProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreProducto_KeyPress);
            // 
            // txtCantidadProducto
            // 
            this.txtCantidadProducto.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadProducto.Location = new System.Drawing.Point(30, 109);
            this.txtCantidadProducto.Name = "txtCantidadProducto";
            this.txtCantidadProducto.ShortcutsEnabled = false;
            this.txtCantidadProducto.Size = new System.Drawing.Size(169, 28);
            this.txtCantidadProducto.TabIndex = 10;
            this.txtCantidadProducto.TextChanged += new System.EventHandler(this.txtCantidadProducto_TextChanged);
            this.txtCantidadProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // txtCostoProducto
            // 
            this.txtCostoProducto.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoProducto.Location = new System.Drawing.Point(235, 44);
            this.txtCostoProducto.Name = "txtCostoProducto";
            this.txtCostoProducto.ShortcutsEnabled = false;
            this.txtCostoProducto.Size = new System.Drawing.Size(186, 28);
            this.txtCostoProducto.TabIndex = 11;
            this.txtCostoProducto.TextChanged += new System.EventHandler(this.txtCostoProducto_TextChanged);
            this.txtCostoProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
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
            this.panel1.Font = new System.Drawing.Font("Open Sans Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(78, 364);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 167);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnActualizarProduc
            // 
            this.btnActualizarProduc.BackColor = System.Drawing.Color.Blue;
            this.btnActualizarProduc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizarProduc.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarProduc.ForeColor = System.Drawing.Color.White;
            this.btnActualizarProduc.Location = new System.Drawing.Point(456, 48);
            this.btnActualizarProduc.Name = "btnActualizarProduc";
            this.btnActualizarProduc.Size = new System.Drawing.Size(111, 55);
            this.btnActualizarProduc.TabIndex = 16;
            this.btnActualizarProduc.Text = "Actualizar Producto";
            this.btnActualizarProduc.UseVisualStyleBackColor = false;
            this.btnActualizarProduc.Click += new System.EventHandler(this.btnActualizarProduc_Click);
            // 
            // lblCantidadProducto
            // 
            this.lblCantidadProducto.AutoSize = true;
            this.lblCantidadProducto.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadProducto.Location = new System.Drawing.Point(26, 84);
            this.lblCantidadProducto.Name = "lblCantidadProducto";
            this.lblCantidadProducto.Size = new System.Drawing.Size(148, 20);
            this.lblCantidadProducto.TabIndex = 14;
            this.lblCantidadProducto.Text = "Cantidad producto:";
            this.lblCantidadProducto.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblCostoProducto
            // 
            this.lblCostoProducto.AutoSize = true;
            this.lblCostoProducto.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoProducto.Location = new System.Drawing.Point(231, 21);
            this.lblCostoProducto.Name = "lblCostoProducto";
            this.lblCostoProducto.Size = new System.Drawing.Size(123, 20);
            this.lblCostoProducto.TabIndex = 13;
            this.lblCostoProducto.Text = "Costo producto:";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.Location = new System.Drawing.Point(26, 21);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(141, 20);
            this.lblNombreProducto.TabIndex = 12;
            this.lblNombreProducto.Text = "Nombre producto:";
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Location = new System.Drawing.Point(506, 64);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.ShortcutsEnabled = false;
            this.txtBuscarProducto.Size = new System.Drawing.Size(156, 20);
            this.txtBuscarProducto.TabIndex = 13;
            this.txtBuscarProducto.TextChanged += new System.EventHandler(this.txtBuscarProducto_TextChanged);
            // 
            // lblBuscarProductp
            // 
            this.lblBuscarProductp.AutoSize = true;
            this.lblBuscarProductp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarProductp.Location = new System.Drawing.Point(505, 43);
            this.lblBuscarProductp.Name = "lblBuscarProductp";
            this.lblBuscarProductp.Size = new System.Drawing.Size(133, 17);
            this.lblBuscarProductp.TabIndex = 23;
            this.lblBuscarProductp.Text = "Buscar Producto:";
            // 
            // frmInvetarioAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 618);
            this.Controls.Add(this.lblBuscarProductp);
            this.Controls.Add(this.txtBuscarProducto);
            this.Controls.Add(this.pnlinventario);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.panel1);
            this.Name = "frmInvetarioAdmin";
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