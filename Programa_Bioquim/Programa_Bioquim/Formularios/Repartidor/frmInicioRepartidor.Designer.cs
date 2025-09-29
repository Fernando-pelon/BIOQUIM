namespace Programa_Bioquim.Formularios
{
    partial class frmInicioRepartidor
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
            this.pnlInicioEmpleado = new System.Windows.Forms.Panel();
            this.dgvDatosRutas = new System.Windows.Forms.DataGridView();
            this.lblRutas = new System.Windows.Forms.Label();
            this.pbPerfil = new System.Windows.Forms.PictureBox();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.pnlInicioEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosRutas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInicioEmpleado
            // 
            this.pnlInicioEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInicioEmpleado.Controls.Add(this.dgvDatosRutas);
            this.pnlInicioEmpleado.Controls.Add(this.lblRutas);
            this.pnlInicioEmpleado.Location = new System.Drawing.Point(47, 233);
            this.pnlInicioEmpleado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlInicioEmpleado.Name = "pnlInicioEmpleado";
            this.pnlInicioEmpleado.Size = new System.Drawing.Size(873, 326);
            this.pnlInicioEmpleado.TabIndex = 9;
            this.pnlInicioEmpleado.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlInicioEmpleado_Paint);
            // 
            // dgvDatosRutas
            // 
            this.dgvDatosRutas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatosRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosRutas.Location = new System.Drawing.Point(7, 39);
            this.dgvDatosRutas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDatosRutas.Name = "dgvDatosRutas";
            this.dgvDatosRutas.ReadOnly = true;
            this.dgvDatosRutas.RowHeadersWidth = 45;
            this.dgvDatosRutas.Size = new System.Drawing.Size(856, 260);
            this.dgvDatosRutas.TabIndex = 1;
            this.dgvDatosRutas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosRutas_CellContentClick);
            // 
            // lblRutas
            // 
            this.lblRutas.AutoSize = true;
            this.lblRutas.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRutas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRutas.Location = new System.Drawing.Point(0, 0);
            this.lblRutas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRutas.Name = "lblRutas";
            this.lblRutas.Size = new System.Drawing.Size(254, 31);
            this.lblRutas.TabIndex = 0;
            this.lblRutas.Text = "Rutas en progreso";
            // 
            // pbPerfil
            // 
            this.pbPerfil.Image = global::Programa_Bioquim.Properties.Resources.Group;
            this.pbPerfil.Location = new System.Drawing.Point(47, 86);
            this.pbPerfil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbPerfil.Name = "pbPerfil";
            this.pbPerfil.Size = new System.Drawing.Size(113, 103);
            this.pbPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPerfil.TabIndex = 0;
            this.pbPerfil.TabStop = false;
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.Location = new System.Drawing.Point(191, 122);
            this.lblBienvenida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(491, 29);
            this.lblBienvenida.TabIndex = 1;
            this.lblBienvenida.Text = "¡Hola, Bienvenido al sistema de Bioquim!";
            // 
            // frmInicioAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 658);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.pbPerfil);
            this.Controls.Add(this.pnlInicioEmpleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmInicioAdmin";
            this.Text = "frmInicio";
            this.Load += new System.EventHandler(this.frmInicioEmpleado_Load_1);
            this.pnlInicioEmpleado.ResumeLayout(false);
            this.pnlInicioEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosRutas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlInicioEmpleado;
        private System.Windows.Forms.DataGridView dgvDatosRutas;
        private System.Windows.Forms.Label lblRutas;
        private System.Windows.Forms.PictureBox pbPerfil;
        private System.Windows.Forms.Label lblBienvenida;
    }
}