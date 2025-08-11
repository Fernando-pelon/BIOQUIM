namespace Programa_Bioquim.Formularios.Empleado
{
    partial class frmInvetario
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
            this.lblCantidadProducto = new System.Windows.Forms.Label();
            this.lblCostoProducto = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.pnlinventario.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.Blue;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.White;
            this.btnAgregarProducto.Location = new System.Drawing.Point(332, 109);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(106, 44);
            this.btnAgregarProducto.TabIndex = 6;
            this.btnAgregarProducto.Text = "Agregar producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarRuta_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.BackColor = System.Drawing.Color.Blue;
            this.btnEliminarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProducto.ForeColor = System.Drawing.Color.White;
            this.btnEliminarProducto.Location = new System.Drawing.Point(456, 109);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(111, 44);
            this.btnEliminarProducto.TabIndex = 5;
            this.btnEliminarProducto.Text = "Eliminar producto";
            this.btnEliminarProducto.UseVisualStyleBackColor = false;
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
            this.lblInventario.Size = new System.Drawing.Size(116, 25);
            this.lblInventario.TabIndex = 0;
            this.lblInventario.Text = "Inventario";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(30, 46);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(169, 20);
            this.txtNombreProducto.TabIndex = 9;
            // 
            // txtCantidadProducto
            // 
            this.txtCantidadProducto.Location = new System.Drawing.Point(30, 109);
            this.txtCantidadProducto.Name = "txtCantidadProducto";
            this.txtCantidadProducto.Size = new System.Drawing.Size(169, 20);
            this.txtCantidadProducto.TabIndex = 10;
            // 
            // txtCostoProducto
            // 
            this.txtCostoProducto.Location = new System.Drawing.Point(252, 46);
            this.txtCostoProducto.Name = "txtCostoProducto";
            this.txtCostoProducto.Size = new System.Drawing.Size(186, 20);
            this.txtCostoProducto.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.lblCantidadProducto);
            this.panel1.Controls.Add(this.lblCostoProducto);
            this.panel1.Controls.Add(this.lblNombreProducto);
            this.panel1.Controls.Add(this.txtCantidadProducto);
            this.panel1.Controls.Add(this.txtCostoProducto);
            this.panel1.Controls.Add(this.btnAgregarProducto);
            this.panel1.Controls.Add(this.txtNombreProducto);
            this.panel1.Controls.Add(this.btnEliminarProducto);
            this.panel1.Location = new System.Drawing.Point(78, 364);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 167);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblCantidadProducto
            // 
            this.lblCantidadProducto.AutoSize = true;
            this.lblCantidadProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadProducto.Location = new System.Drawing.Point(26, 84);
            this.lblCantidadProducto.Name = "lblCantidadProducto";
            this.lblCantidadProducto.Size = new System.Drawing.Size(187, 24);
            this.lblCantidadProducto.TabIndex = 14;
            this.lblCantidadProducto.Text = "Cantidad producto:";
            this.lblCantidadProducto.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblCostoProducto
            // 
            this.lblCostoProducto.AutoSize = true;
            this.lblCostoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoProducto.Location = new System.Drawing.Point(248, 21);
            this.lblCostoProducto.Name = "lblCostoProducto";
            this.lblCostoProducto.Size = new System.Drawing.Size(158, 24);
            this.lblCostoProducto.TabIndex = 13;
            this.lblCostoProducto.Text = "Costo producto:";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.Location = new System.Drawing.Point(26, 21);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(180, 24);
            this.lblNombreProducto.TabIndex = 12;
            this.lblNombreProducto.Text = "Nombre producto:";
            // 
            // frmInvetario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 618);
            this.Controls.Add(this.pnlinventario);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.panel1);
            this.Name = "frmInvetario";
            this.Text = "frmInvetario";
            this.Load += new System.EventHandler(this.frmInvetario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.pnlinventario.ResumeLayout(false);
            this.pnlinventario.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
    }
}