namespace Programa_Bioquim.Formularios.Empleado
{
    partial class frmRutasDeEntrega
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
            this.pnlRutas = new System.Windows.Forms.Panel();
            this.lblRutas = new System.Windows.Forms.Label();
            this.dgvRutas = new System.Windows.Forms.DataGridView();
            this.btnEliminarRuta = new System.Windows.Forms.Button();
            this.btnAgregarRuta = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbEmpresa = new System.Windows.Forms.ComboBox();
            this.lblEmpresaNombre = new System.Windows.Forms.Label();
            this.lblCantidadProducto = new System.Windows.Forms.Label();
            this.lblMontoPagar = new System.Windows.Forms.Label();
            this.lblUbicacionEmpresa = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtCostoProducto = new System.Windows.Forms.TextBox();
            this.txtUbicacionEmpresa = new System.Windows.Forms.TextBox();
            this.pnlRutas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRutas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRutas
            // 
            this.pnlRutas.BackColor = System.Drawing.Color.Blue;
            this.pnlRutas.Controls.Add(this.lblRutas);
            this.pnlRutas.Location = new System.Drawing.Point(295, 22);
            this.pnlRutas.Name = "pnlRutas";
            this.pnlRutas.Size = new System.Drawing.Size(146, 49);
            this.pnlRutas.TabIndex = 0;
            // 
            // lblRutas
            // 
            this.lblRutas.AutoSize = true;
            this.lblRutas.BackColor = System.Drawing.Color.Blue;
            this.lblRutas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRutas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRutas.Location = new System.Drawing.Point(37, 14);
            this.lblRutas.Name = "lblRutas";
            this.lblRutas.Size = new System.Drawing.Size(73, 25);
            this.lblRutas.TabIndex = 0;
            this.lblRutas.Text = "Rutas";
            this.lblRutas.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvRutas
            // 
            this.dgvRutas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRutas.Location = new System.Drawing.Point(65, 88);
            this.dgvRutas.Name = "dgvRutas";
            this.dgvRutas.ReadOnly = true;
            this.dgvRutas.RowHeadersVisible = false;
            this.dgvRutas.RowHeadersWidth = 45;
            this.dgvRutas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRutas.Size = new System.Drawing.Size(609, 274);
            this.dgvRutas.TabIndex = 1;
            this.dgvRutas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnEliminarRuta
            // 
            this.btnEliminarRuta.BackColor = System.Drawing.Color.Blue;
            this.btnEliminarRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarRuta.ForeColor = System.Drawing.Color.White;
            this.btnEliminarRuta.Location = new System.Drawing.Point(457, 96);
            this.btnEliminarRuta.Name = "btnEliminarRuta";
            this.btnEliminarRuta.Size = new System.Drawing.Size(116, 35);
            this.btnEliminarRuta.TabIndex = 3;
            this.btnEliminarRuta.Text = "Eliminar Ruta";
            this.btnEliminarRuta.UseVisualStyleBackColor = false;
            // 
            // btnAgregarRuta
            // 
            this.btnAgregarRuta.BackColor = System.Drawing.Color.Blue;
            this.btnAgregarRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarRuta.ForeColor = System.Drawing.Color.White;
            this.btnAgregarRuta.Location = new System.Drawing.Point(457, 46);
            this.btnAgregarRuta.Name = "btnAgregarRuta";
            this.btnAgregarRuta.Size = new System.Drawing.Size(114, 35);
            this.btnAgregarRuta.TabIndex = 4;
            this.btnAgregarRuta.Text = "Agregar Ruta";
            this.btnAgregarRuta.UseVisualStyleBackColor = false;
            this.btnAgregarRuta.Click += new System.EventHandler(this.btnAgregarRuta_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.cbEmpresa);
            this.panel1.Controls.Add(this.lblEmpresaNombre);
            this.panel1.Controls.Add(this.lblCantidadProducto);
            this.panel1.Controls.Add(this.btnAgregarRuta);
            this.panel1.Controls.Add(this.lblMontoPagar);
            this.panel1.Controls.Add(this.btnEliminarRuta);
            this.panel1.Controls.Add(this.lblUbicacionEmpresa);
            this.panel1.Controls.Add(this.txtProducto);
            this.panel1.Controls.Add(this.txtCostoProducto);
            this.panel1.Controls.Add(this.txtUbicacionEmpresa);
            this.panel1.Location = new System.Drawing.Point(65, 368);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 167);
            this.panel1.TabIndex = 13;
            // 
            // cbEmpresa
            // 
            this.cbEmpresa.FormattingEnabled = true;
            this.cbEmpresa.Location = new System.Drawing.Point(216, 111);
            this.cbEmpresa.Name = "cbEmpresa";
            this.cbEmpresa.Size = new System.Drawing.Size(186, 21);
            this.cbEmpresa.TabIndex = 16;
            // 
            // lblEmpresaNombre
            // 
            this.lblEmpresaNombre.AutoSize = true;
            this.lblEmpresaNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresaNombre.Location = new System.Drawing.Point(213, 84);
            this.lblEmpresaNombre.Name = "lblEmpresaNombre";
            this.lblEmpresaNombre.Size = new System.Drawing.Size(85, 18);
            this.lblEmpresaNombre.TabIndex = 15;
            this.lblEmpresaNombre.Text = "Empresa :";
            // 
            // lblCantidadProducto
            // 
            this.lblCantidadProducto.AutoSize = true;
            this.lblCantidadProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadProducto.Location = new System.Drawing.Point(13, 84);
            this.lblCantidadProducto.Name = "lblCantidadProducto";
            this.lblCantidadProducto.Size = new System.Drawing.Size(80, 18);
            this.lblCantidadProducto.TabIndex = 14;
            this.lblCantidadProducto.Text = "producto:";
            // 
            // lblMontoPagar
            // 
            this.lblMontoPagar.AutoSize = true;
            this.lblMontoPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoPagar.Location = new System.Drawing.Point(213, 21);
            this.lblMontoPagar.Name = "lblMontoPagar";
            this.lblMontoPagar.Size = new System.Drawing.Size(122, 18);
            this.lblMontoPagar.TabIndex = 13;
            this.lblMontoPagar.Text = "Monto a pagar:";
            // 
            // lblUbicacionEmpresa
            // 
            this.lblUbicacionEmpresa.AutoSize = true;
            this.lblUbicacionEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUbicacionEmpresa.Location = new System.Drawing.Point(14, 21);
            this.lblUbicacionEmpresa.Name = "lblUbicacionEmpresa";
            this.lblUbicacionEmpresa.Size = new System.Drawing.Size(157, 18);
            this.lblUbicacionEmpresa.TabIndex = 12;
            this.lblUbicacionEmpresa.Text = "ubicacion Empresa:";
            this.lblUbicacionEmpresa.Click += new System.EventHandler(this.lblNombreProducto_Click);
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(17, 111);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(169, 20);
            this.txtProducto.TabIndex = 10;
            // 
            // txtCostoProducto
            // 
            this.txtCostoProducto.Location = new System.Drawing.Point(216, 46);
            this.txtCostoProducto.Name = "txtCostoProducto";
            this.txtCostoProducto.Size = new System.Drawing.Size(186, 20);
            this.txtCostoProducto.TabIndex = 11;
            // 
            // txtUbicacionEmpresa
            // 
            this.txtUbicacionEmpresa.Location = new System.Drawing.Point(17, 46);
            this.txtUbicacionEmpresa.Name = "txtUbicacionEmpresa";
            this.txtUbicacionEmpresa.Size = new System.Drawing.Size(169, 20);
            this.txtUbicacionEmpresa.TabIndex = 9;
            // 
            // frmRutasDeEntrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 610);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvRutas);
            this.Controls.Add(this.pnlRutas);
            this.Name = "frmRutasDeEntrega";
            this.Text = "RutasDeEntrega";
            this.Load += new System.EventHandler(this.frmRutasDeEntrega_Load);
            this.pnlRutas.ResumeLayout(false);
            this.pnlRutas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRutas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRutas;
        private System.Windows.Forms.Label lblRutas;
        private System.Windows.Forms.DataGridView dgvRutas;
        private System.Windows.Forms.Button btnEliminarRuta;
        private System.Windows.Forms.Button btnAgregarRuta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCantidadProducto;
        private System.Windows.Forms.Label lblMontoPagar;
        private System.Windows.Forms.Label lblUbicacionEmpresa;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtCostoProducto;
        private System.Windows.Forms.Label lblEmpresaNombre;
        private System.Windows.Forms.ComboBox cbEmpresa;
        private System.Windows.Forms.TextBox txtUbicacionEmpresa;
    }
}