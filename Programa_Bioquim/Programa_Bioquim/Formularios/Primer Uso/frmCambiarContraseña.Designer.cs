namespace Programa_Bioquim.Formularios.Primer_Uso
{
    partial class frmCambiarContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCambiarContraseña));
            this.txtNuevaContrasena = new System.Windows.Forms.TextBox();
            this.txtConfirmarContrasena = new System.Windows.Forms.TextBox();
            this.txtContrasenaActual = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCambiarContrasena = new System.Windows.Forms.Button();
            this.lblTu = new System.Windows.Forms.Label();
            this.lblNueva = new System.Windows.Forms.Label();
            this.lblConfirmar = new System.Windows.Forms.Label();
            this.gbCambiodeContraseña = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.gbCambiodeContraseña.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNuevaContrasena
            // 
            this.txtNuevaContrasena.Location = new System.Drawing.Point(202, 96);
            this.txtNuevaContrasena.Margin = new System.Windows.Forms.Padding(2);
            this.txtNuevaContrasena.Name = "txtNuevaContrasena";
            this.txtNuevaContrasena.PasswordChar = '*';
            this.txtNuevaContrasena.Size = new System.Drawing.Size(170, 26);
            this.txtNuevaContrasena.TabIndex = 0;
            // 
            // txtConfirmarContrasena
            // 
            this.txtConfirmarContrasena.Location = new System.Drawing.Point(202, 149);
            this.txtConfirmarContrasena.Margin = new System.Windows.Forms.Padding(2);
            this.txtConfirmarContrasena.Name = "txtConfirmarContrasena";
            this.txtConfirmarContrasena.PasswordChar = '*';
            this.txtConfirmarContrasena.Size = new System.Drawing.Size(170, 26);
            this.txtConfirmarContrasena.TabIndex = 1;
            // 
            // txtContrasenaActual
            // 
            this.txtContrasenaActual.Location = new System.Drawing.Point(202, 44);
            this.txtContrasenaActual.Margin = new System.Windows.Forms.Padding(2);
            this.txtContrasenaActual.Name = "txtContrasenaActual";
            this.txtContrasenaActual.PasswordChar = '*';
            this.txtContrasenaActual.Size = new System.Drawing.Size(170, 26);
            this.txtContrasenaActual.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(228, 214);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 37);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnCambiarContrasena
            // 
            this.btnCambiarContrasena.ForeColor = System.Drawing.Color.Black;
            this.btnCambiarContrasena.Location = new System.Drawing.Point(323, 214);
            this.btnCambiarContrasena.Margin = new System.Windows.Forms.Padding(2);
            this.btnCambiarContrasena.Name = "btnCambiarContrasena";
            this.btnCambiarContrasena.Size = new System.Drawing.Size(101, 37);
            this.btnCambiarContrasena.TabIndex = 4;
            this.btnCambiarContrasena.Text = "Confirmar";
            this.btnCambiarContrasena.UseVisualStyleBackColor = true;
            this.btnCambiarContrasena.Click += new System.EventHandler(this.btnCambiarContrasena_Click_1);
            // 
            // lblTu
            // 
            this.lblTu.AutoSize = true;
            this.lblTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTu.ForeColor = System.Drawing.Color.White;
            this.lblTu.Location = new System.Drawing.Point(50, 49);
            this.lblTu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTu.Name = "lblTu";
            this.lblTu.Size = new System.Drawing.Size(142, 17);
            this.lblTu.TabIndex = 5;
            this.lblTu.Text = "Tu contraseña actual";
            // 
            // lblNueva
            // 
            this.lblNueva.AutoSize = true;
            this.lblNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNueva.ForeColor = System.Drawing.Color.White;
            this.lblNueva.Location = new System.Drawing.Point(50, 101);
            this.lblNueva.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNueva.Name = "lblNueva";
            this.lblNueva.Size = new System.Drawing.Size(124, 17);
            this.lblNueva.TabIndex = 6;
            this.lblNueva.Text = "Nueva contraseña";
            // 
            // lblConfirmar
            // 
            this.lblConfirmar.AutoSize = true;
            this.lblConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmar.ForeColor = System.Drawing.Color.White;
            this.lblConfirmar.Location = new System.Drawing.Point(50, 149);
            this.lblConfirmar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConfirmar.Name = "lblConfirmar";
            this.lblConfirmar.Size = new System.Drawing.Size(144, 17);
            this.lblConfirmar.TabIndex = 7;
            this.lblConfirmar.Text = "Confirmar contraseña";
            // 
            // gbCambiodeContraseña
            // 
            this.gbCambiodeContraseña.BackColor = System.Drawing.Color.SlateGray;
            this.gbCambiodeContraseña.Controls.Add(this.btnCancelar);
            this.gbCambiodeContraseña.Controls.Add(this.lblTu);
            this.gbCambiodeContraseña.Controls.Add(this.lblNueva);
            this.gbCambiodeContraseña.Controls.Add(this.lblConfirmar);
            this.gbCambiodeContraseña.Controls.Add(this.btnCambiarContrasena);
            this.gbCambiodeContraseña.Controls.Add(this.txtConfirmarContrasena);
            this.gbCambiodeContraseña.Controls.Add(this.txtNuevaContrasena);
            this.gbCambiodeContraseña.Controls.Add(this.txtContrasenaActual);
            this.gbCambiodeContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCambiodeContraseña.ForeColor = System.Drawing.Color.White;
            this.gbCambiodeContraseña.Location = new System.Drawing.Point(85, 50);
            this.gbCambiodeContraseña.Margin = new System.Windows.Forms.Padding(2);
            this.gbCambiodeContraseña.Name = "gbCambiodeContraseña";
            this.gbCambiodeContraseña.Padding = new System.Windows.Forms.Padding(2);
            this.gbCambiodeContraseña.Size = new System.Drawing.Size(428, 255);
            this.gbCambiodeContraseña.TabIndex = 8;
            this.gbCambiodeContraseña.TabStop = false;
            this.gbCambiodeContraseña.Text = "Cambio de contraseña";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(196, -13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(437, 392);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-7, -13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(137, 380);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // frmCambiarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.gbCambiodeContraseña);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCambiarContraseña";
            this.Text = "frmCambiarContraseña";
            this.Load += new System.EventHandler(this.frmCambiarContraseña_Load);
            this.gbCambiodeContraseña.ResumeLayout(false);
            this.gbCambiodeContraseña.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNuevaContrasena;
        private System.Windows.Forms.TextBox txtConfirmarContrasena;
        private System.Windows.Forms.TextBox txtContrasenaActual;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCambiarContrasena;
        private System.Windows.Forms.Label lblTu;
        private System.Windows.Forms.Label lblNueva;
        private System.Windows.Forms.Label lblConfirmar;
        private System.Windows.Forms.GroupBox gbCambiodeContraseña;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}