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
            this.lblTipoPago = new System.Windows.Forms.Label();
            this.rbTarjetaCredito = new System.Windows.Forms.RadioButton();
            this.rbEfectivo = new System.Windows.Forms.RadioButton();
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.cbUbicacionEmpresa = new System.Windows.Forms.ComboBox();
            this.cbEmpresa = new System.Windows.Forms.ComboBox();
            this.lblEmpresaNombre = new System.Windows.Forms.Label();
            this.lblCantidadProducto = new System.Windows.Forms.Label();
            this.lblMontoPagar = new System.Windows.Forms.Label();
            this.lblUbicacionEmpresa = new System.Windows.Forms.Label();
            this.txtCostoProducto = new System.Windows.Forms.TextBox();
            this.txtBuscarRutas = new System.Windows.Forms.TextBox();
            this.lblBuscarRuta = new System.Windows.Forms.Label();
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
            this.dgvRutas.Location = new System.Drawing.Point(12, 88);
            this.dgvRutas.Name = "dgvRutas";
            this.dgvRutas.ReadOnly = true;
            this.dgvRutas.RowHeadersVisible = false;
            this.dgvRutas.RowHeadersWidth = 45;
            this.dgvRutas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRutas.Size = new System.Drawing.Size(703, 274);
            this.dgvRutas.TabIndex = 1;
            this.dgvRutas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvRutas.DoubleClick += new System.EventHandler(this.dgvRutas_DoubleClick);
            // 
            // btnEliminarRuta
            // 
            this.btnEliminarRuta.BackColor = System.Drawing.Color.Blue;
            this.btnEliminarRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarRuta.ForeColor = System.Drawing.Color.White;
            this.btnEliminarRuta.Location = new System.Drawing.Point(578, 88);
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
            this.btnAgregarRuta.Location = new System.Drawing.Point(578, 129);
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
            this.panel1.Controls.Add(this.lblTipoPago);
            this.panel1.Controls.Add(this.rbTarjetaCredito);
            this.panel1.Controls.Add(this.rbEfectivo);
            this.panel1.Controls.Add(this.cbProducto);
            this.panel1.Controls.Add(this.cbUbicacionEmpresa);
            this.panel1.Controls.Add(this.cbEmpresa);
            this.panel1.Controls.Add(this.lblEmpresaNombre);
            this.panel1.Controls.Add(this.lblCantidadProducto);
            this.panel1.Controls.Add(this.btnAgregarRuta);
            this.panel1.Controls.Add(this.lblMontoPagar);
            this.panel1.Controls.Add(this.btnEliminarRuta);
            this.panel1.Controls.Add(this.lblUbicacionEmpresa);
            this.panel1.Controls.Add(this.txtCostoProducto);
            this.panel1.Location = new System.Drawing.Point(12, 368);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 167);
            this.panel1.TabIndex = 13;
            // 
            // lblTipoPago
            // 
            this.lblTipoPago.AutoSize = true;
            this.lblTipoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPago.Location = new System.Drawing.Point(410, 21);
            this.lblTipoPago.Name = "lblTipoPago";
            this.lblTipoPago.Size = new System.Drawing.Size(113, 18);
            this.lblTipoPago.TabIndex = 21;
            this.lblTipoPago.Text = "Tipo de Pago:";
            // 
            // rbTarjetaCredito
            // 
            this.rbTarjetaCredito.AutoSize = true;
            this.rbTarjetaCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTarjetaCredito.Location = new System.Drawing.Point(413, 88);
            this.rbTarjetaCredito.Name = "rbTarjetaCredito";
            this.rbTarjetaCredito.Size = new System.Drawing.Size(143, 22);
            this.rbTarjetaCredito.TabIndex = 20;
            this.rbTarjetaCredito.TabStop = true;
            this.rbTarjetaCredito.Text = "Tarjeta de Credito";
            this.rbTarjetaCredito.UseVisualStyleBackColor = true;
            // 
            // rbEfectivo
            // 
            this.rbEfectivo.AutoSize = true;
            this.rbEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEfectivo.Location = new System.Drawing.Point(413, 50);
            this.rbEfectivo.Name = "rbEfectivo";
            this.rbEfectivo.Size = new System.Drawing.Size(79, 22);
            this.rbEfectivo.TabIndex = 19;
            this.rbEfectivo.TabStop = true;
            this.rbEfectivo.Text = "Efectivo";
            this.rbEfectivo.UseVisualStyleBackColor = true;
            // 
            // cbProducto
            // 
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Location = new System.Drawing.Point(17, 111);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(169, 21);
            this.cbProducto.TabIndex = 18;
            // 
            // cbUbicacionEmpresa
            // 
            this.cbUbicacionEmpresa.FormattingEnabled = true;
            this.cbUbicacionEmpresa.Location = new System.Drawing.Point(17, 46);
            this.cbUbicacionEmpresa.Name = "cbUbicacionEmpresa";
            this.cbUbicacionEmpresa.Size = new System.Drawing.Size(169, 21);
            this.cbUbicacionEmpresa.TabIndex = 17;
            this.cbUbicacionEmpresa.SelectedIndexChanged += new System.EventHandler(this.cbUbicacionEmpresa_SelectedIndexChanged);
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
            // txtCostoProducto
            // 
            this.txtCostoProducto.Location = new System.Drawing.Point(216, 46);
            this.txtCostoProducto.Name = "txtCostoProducto";
            this.txtCostoProducto.Size = new System.Drawing.Size(186, 20);
            this.txtCostoProducto.TabIndex = 11;
            // 
            // txtBuscarRutas
            // 
            this.txtBuscarRutas.Location = new System.Drawing.Point(530, 57);
            this.txtBuscarRutas.Multiline = true;
            this.txtBuscarRutas.Name = "txtBuscarRutas";
            this.txtBuscarRutas.Size = new System.Drawing.Size(185, 25);
            this.txtBuscarRutas.TabIndex = 14;
            // 
            // lblBuscarRuta
            // 
            this.lblBuscarRuta.AutoSize = true;
            this.lblBuscarRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarRuta.Location = new System.Drawing.Point(527, 36);
            this.lblBuscarRuta.Name = "lblBuscarRuta";
            this.lblBuscarRuta.Size = new System.Drawing.Size(106, 18);
            this.lblBuscarRuta.TabIndex = 22;
            this.lblBuscarRuta.Text = "Buscar Ruta:";
            // 
            // frmRutasDeEntrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 610);
            this.Controls.Add(this.lblBuscarRuta);
            this.Controls.Add(this.txtBuscarRutas);
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
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox txtCostoProducto;
        private System.Windows.Forms.Label lblEmpresaNombre;
        private System.Windows.Forms.ComboBox cbEmpresa;
        private System.Windows.Forms.ComboBox cbProducto;
        private System.Windows.Forms.ComboBox cbUbicacionEmpresa;
        private System.Windows.Forms.RadioButton rbTarjetaCredito;
        private System.Windows.Forms.RadioButton rbEfectivo;
        private System.Windows.Forms.Label lblTipoPago;
        private System.Windows.Forms.TextBox txtBuscarRutas;
        private System.Windows.Forms.Label lblBuscarRuta;
    }
}