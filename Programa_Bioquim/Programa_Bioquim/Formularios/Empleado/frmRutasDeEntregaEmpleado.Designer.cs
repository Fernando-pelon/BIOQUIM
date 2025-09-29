namespace Programa_Bioquim.Formularios.Empleado
{
    partial class frmRutasDeEntregaEmpleado
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
            this.btnActualizarRutas = new System.Windows.Forms.Button();
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
            this.pnlRutas.Location = new System.Drawing.Point(393, 27);
            this.pnlRutas.Margin = new System.Windows.Forms.Padding(4);
            this.pnlRutas.Name = "pnlRutas";
            this.pnlRutas.Size = new System.Drawing.Size(195, 60);
            this.pnlRutas.TabIndex = 0;
            // 
            // lblRutas
            // 
            this.lblRutas.AutoSize = true;
            this.lblRutas.BackColor = System.Drawing.Color.Blue;
            this.lblRutas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRutas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRutas.Location = new System.Drawing.Point(49, 17);
            this.lblRutas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRutas.Name = "lblRutas";
            this.lblRutas.Size = new System.Drawing.Size(79, 29);
            this.lblRutas.TabIndex = 0;
            this.lblRutas.Text = "Rutas";
            this.lblRutas.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvRutas
            // 
            this.dgvRutas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRutas.Location = new System.Drawing.Point(16, 108);
            this.dgvRutas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRutas.Name = "dgvRutas";
            this.dgvRutas.ReadOnly = true;
            this.dgvRutas.RowHeadersVisible = false;
            this.dgvRutas.RowHeadersWidth = 45;
            this.dgvRutas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRutas.Size = new System.Drawing.Size(1038, 337);
            this.dgvRutas.TabIndex = 1;
            this.dgvRutas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvRutas.DoubleClick += new System.EventHandler(this.dgvRutas_DoubleClick);
            // 
            // btnEliminarRuta
            // 
            this.btnEliminarRuta.BackColor = System.Drawing.Color.Blue;
            this.btnEliminarRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarRuta.ForeColor = System.Drawing.Color.White;
            this.btnEliminarRuta.Location = new System.Drawing.Point(879, 87);
            this.btnEliminarRuta.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarRuta.Name = "btnEliminarRuta";
            this.btnEliminarRuta.Size = new System.Drawing.Size(155, 43);
            this.btnEliminarRuta.TabIndex = 3;
            this.btnEliminarRuta.Text = "Eliminar Ruta";
            this.btnEliminarRuta.UseVisualStyleBackColor = false;
            this.btnEliminarRuta.Click += new System.EventHandler(this.btnEliminarRuta_Click);
            // 
            // btnAgregarRuta
            // 
            this.btnAgregarRuta.BackColor = System.Drawing.Color.Blue;
            this.btnAgregarRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarRuta.ForeColor = System.Drawing.Color.White;
            this.btnAgregarRuta.Location = new System.Drawing.Point(879, 135);
            this.btnAgregarRuta.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarRuta.Name = "btnAgregarRuta";
            this.btnAgregarRuta.Size = new System.Drawing.Size(152, 43);
            this.btnAgregarRuta.TabIndex = 4;
            this.btnAgregarRuta.Text = "Agregar Ruta";
            this.btnAgregarRuta.UseVisualStyleBackColor = false;
            this.btnAgregarRuta.Click += new System.EventHandler(this.btnAgregarRuta_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.btnActualizarRutas);
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
            this.panel1.Location = new System.Drawing.Point(16, 453);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1038, 206);
            this.panel1.TabIndex = 13;
            // 
            // btnActualizarRutas
            // 
            this.btnActualizarRutas.BackColor = System.Drawing.Color.Blue;
            this.btnActualizarRutas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarRutas.ForeColor = System.Drawing.Color.White;
            this.btnActualizarRutas.Location = new System.Drawing.Point(879, 21);
            this.btnActualizarRutas.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizarRutas.Name = "btnActualizarRutas";
            this.btnActualizarRutas.Size = new System.Drawing.Size(155, 58);
            this.btnActualizarRutas.TabIndex = 23;
            this.btnActualizarRutas.Text = "Actualizar Ruta";
            this.btnActualizarRutas.UseVisualStyleBackColor = false;
            this.btnActualizarRutas.Click += new System.EventHandler(this.btnActualizarRutas_Click);
            // 
            // lblTipoPago
            // 
            this.lblTipoPago.AutoSize = true;
            this.lblTipoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPago.Location = new System.Drawing.Point(630, 40);
            this.lblTipoPago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoPago.Name = "lblTipoPago";
            this.lblTipoPago.Size = new System.Drawing.Size(125, 20);
            this.lblTipoPago.TabIndex = 21;
            this.lblTipoPago.Text = "Tipo de Pago:";
            // 
            // rbTarjetaCredito
            // 
            this.rbTarjetaCredito.AutoSize = true;
            this.rbTarjetaCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTarjetaCredito.Location = new System.Drawing.Point(634, 122);
            this.rbTarjetaCredito.Margin = new System.Windows.Forms.Padding(4);
            this.rbTarjetaCredito.Name = "rbTarjetaCredito";
            this.rbTarjetaCredito.Size = new System.Drawing.Size(164, 24);
            this.rbTarjetaCredito.TabIndex = 20;
            this.rbTarjetaCredito.TabStop = true;
            this.rbTarjetaCredito.Text = "Tarjeta de Credito";
            this.rbTarjetaCredito.UseVisualStyleBackColor = true;
            // 
            // rbEfectivo
            // 
            this.rbEfectivo.AutoSize = true;
            this.rbEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEfectivo.Location = new System.Drawing.Point(634, 76);
            this.rbEfectivo.Margin = new System.Windows.Forms.Padding(4);
            this.rbEfectivo.Name = "rbEfectivo";
            this.rbEfectivo.Size = new System.Drawing.Size(90, 24);
            this.rbEfectivo.TabIndex = 19;
            this.rbEfectivo.TabStop = true;
            this.rbEfectivo.Text = "Efectivo";
            this.rbEfectivo.UseVisualStyleBackColor = true;
            // 
            // cbProducto
            // 
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Location = new System.Drawing.Point(23, 137);
            this.cbProducto.Margin = new System.Windows.Forms.Padding(4);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(224, 24);
            this.cbProducto.TabIndex = 18;
            // 
            // cbUbicacionEmpresa
            // 
            this.cbUbicacionEmpresa.FormattingEnabled = true;
            this.cbUbicacionEmpresa.Location = new System.Drawing.Point(23, 57);
            this.cbUbicacionEmpresa.Margin = new System.Windows.Forms.Padding(4);
            this.cbUbicacionEmpresa.Name = "cbUbicacionEmpresa";
            this.cbUbicacionEmpresa.Size = new System.Drawing.Size(224, 24);
            this.cbUbicacionEmpresa.TabIndex = 17;
            this.cbUbicacionEmpresa.SelectedIndexChanged += new System.EventHandler(this.cbUbicacionEmpresa_SelectedIndexChanged);
            // 
            // cbEmpresa
            // 
            this.cbEmpresa.FormattingEnabled = true;
            this.cbEmpresa.Location = new System.Drawing.Point(288, 137);
            this.cbEmpresa.Margin = new System.Windows.Forms.Padding(4);
            this.cbEmpresa.Name = "cbEmpresa";
            this.cbEmpresa.Size = new System.Drawing.Size(247, 24);
            this.cbEmpresa.TabIndex = 16;
            // 
            // lblEmpresaNombre
            // 
            this.lblEmpresaNombre.AutoSize = true;
            this.lblEmpresaNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresaNombre.Location = new System.Drawing.Point(284, 103);
            this.lblEmpresaNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpresaNombre.Name = "lblEmpresaNombre";
            this.lblEmpresaNombre.Size = new System.Drawing.Size(95, 20);
            this.lblEmpresaNombre.TabIndex = 15;
            this.lblEmpresaNombre.Text = "Empresa :";
            // 
            // lblCantidadProducto
            // 
            this.lblCantidadProducto.AutoSize = true;
            this.lblCantidadProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadProducto.Location = new System.Drawing.Point(17, 103);
            this.lblCantidadProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadProducto.Name = "lblCantidadProducto";
            this.lblCantidadProducto.Size = new System.Drawing.Size(88, 20);
            this.lblCantidadProducto.TabIndex = 14;
            this.lblCantidadProducto.Text = "producto:";
            // 
            // lblMontoPagar
            // 
            this.lblMontoPagar.AutoSize = true;
            this.lblMontoPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoPagar.Location = new System.Drawing.Point(284, 26);
            this.lblMontoPagar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontoPagar.Name = "lblMontoPagar";
            this.lblMontoPagar.Size = new System.Drawing.Size(135, 20);
            this.lblMontoPagar.TabIndex = 13;
            this.lblMontoPagar.Text = "Monto a pagar:";
            // 
            // lblUbicacionEmpresa
            // 
            this.lblUbicacionEmpresa.AutoSize = true;
            this.lblUbicacionEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUbicacionEmpresa.Location = new System.Drawing.Point(19, 26);
            this.lblUbicacionEmpresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUbicacionEmpresa.Name = "lblUbicacionEmpresa";
            this.lblUbicacionEmpresa.Size = new System.Drawing.Size(175, 20);
            this.lblUbicacionEmpresa.TabIndex = 12;
            this.lblUbicacionEmpresa.Text = "ubicacion Empresa:";
            this.lblUbicacionEmpresa.Click += new System.EventHandler(this.lblNombreProducto_Click);
            // 
            // txtCostoProducto
            // 
            this.txtCostoProducto.Location = new System.Drawing.Point(288, 57);
            this.txtCostoProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtCostoProducto.Name = "txtCostoProducto";
            this.txtCostoProducto.ShortcutsEnabled = false;
            this.txtCostoProducto.Size = new System.Drawing.Size(247, 22);
            this.txtCostoProducto.TabIndex = 11;
            this.txtCostoProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCostoProducto_KeyPress);
            // 
            // txtBuscarRutas
            // 
            this.txtBuscarRutas.Location = new System.Drawing.Point(707, 70);
            this.txtBuscarRutas.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarRutas.Multiline = true;
            this.txtBuscarRutas.Name = "txtBuscarRutas";
            this.txtBuscarRutas.ShortcutsEnabled = false;
            this.txtBuscarRutas.Size = new System.Drawing.Size(245, 30);
            this.txtBuscarRutas.TabIndex = 14;
            this.txtBuscarRutas.TextChanged += new System.EventHandler(this.txtBuscarRutas_TextChanged);
            // 
            // lblBuscarRuta
            // 
            this.lblBuscarRuta.AutoSize = true;
            this.lblBuscarRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarRuta.Location = new System.Drawing.Point(703, 44);
            this.lblBuscarRuta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscarRuta.Name = "lblBuscarRuta";
            this.lblBuscarRuta.Size = new System.Drawing.Size(120, 20);
            this.lblBuscarRuta.TabIndex = 22;
            this.lblBuscarRuta.Text = "Buscar Ruta:";
            // 
            // frmRutasDeEntregaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 751);
            this.Controls.Add(this.lblBuscarRuta);
            this.Controls.Add(this.txtBuscarRutas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvRutas);
            this.Controls.Add(this.pnlRutas);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRutasDeEntregaAdmin";
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
        private System.Windows.Forms.Button btnActualizarRutas;
    }
}