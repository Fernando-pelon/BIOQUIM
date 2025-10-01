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
            this.txtNuevaContrasena = new System.Windows.Forms.TextBox();
            this.txtConfirmarContrasena = new System.Windows.Forms.TextBox();
            this.txtContrasenaActual = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCambiarContrasena = new System.Windows.Forms.Button();
            this.lblTu = new System.Windows.Forms.Label();
            this.lblNueva = new System.Windows.Forms.Label();
            this.lblConfirmar = new System.Windows.Forms.Label();
            this.gbCambiodeContraseña = new System.Windows.Forms.GroupBox();
            this.gbCambiodeContraseña.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNuevaContrasena
            // 
            this.txtNuevaContrasena.Location = new System.Drawing.Point(269, 118);
            this.txtNuevaContrasena.Name = "txtNuevaContrasena";
            this.txtNuevaContrasena.PasswordChar = '*';
            this.txtNuevaContrasena.Size = new System.Drawing.Size(226, 30);
            this.txtNuevaContrasena.TabIndex = 0;
            // 
            // txtConfirmarContrasena
            // 
            this.txtConfirmarContrasena.Location = new System.Drawing.Point(269, 183);
            this.txtConfirmarContrasena.Name = "txtConfirmarContrasena";
            this.txtConfirmarContrasena.PasswordChar = '*';
            this.txtConfirmarContrasena.Size = new System.Drawing.Size(226, 30);
            this.txtConfirmarContrasena.TabIndex = 1;
            // 
            // txtContrasenaActual
            // 
            this.txtContrasenaActual.Location = new System.Drawing.Point(269, 54);
            this.txtContrasenaActual.Name = "txtContrasenaActual";
            this.txtContrasenaActual.PasswordChar = '*';
            this.txtContrasenaActual.Size = new System.Drawing.Size(226, 30);
            this.txtContrasenaActual.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(335, 263);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 45);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnCambiarContrasena
            // 
            this.btnCambiarContrasena.Location = new System.Drawing.Point(451, 263);
            this.btnCambiarContrasena.Name = "btnCambiarContrasena";
            this.btnCambiarContrasena.Size = new System.Drawing.Size(114, 45);
            this.btnCambiarContrasena.TabIndex = 4;
            this.btnCambiarContrasena.Text = "Confirmar";
            this.btnCambiarContrasena.UseVisualStyleBackColor = true;
            this.btnCambiarContrasena.Click += new System.EventHandler(this.btnCambiarContrasena_Click_1);
            // 
            // lblTu
            // 
            this.lblTu.AutoSize = true;
            this.lblTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTu.Location = new System.Drawing.Point(90, 60);
            this.lblTu.Name = "lblTu";
            this.lblTu.Size = new System.Drawing.Size(166, 20);
            this.lblTu.TabIndex = 5;
            this.lblTu.Text = "Tu contraseña actual";
            // 
            // lblNueva
            // 
            this.lblNueva.AutoSize = true;
            this.lblNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNueva.Location = new System.Drawing.Point(90, 121);
            this.lblNueva.Name = "lblNueva";
            this.lblNueva.Size = new System.Drawing.Size(144, 20);
            this.lblNueva.TabIndex = 6;
            this.lblNueva.Text = "Nueva contraseña";
            // 
            // lblConfirmar
            // 
            this.lblConfirmar.AutoSize = true;
            this.lblConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmar.Location = new System.Drawing.Point(90, 186);
            this.lblConfirmar.Name = "lblConfirmar";
            this.lblConfirmar.Size = new System.Drawing.Size(171, 20);
            this.lblConfirmar.TabIndex = 7;
            this.lblConfirmar.Text = "Confirmar contraseña";
            // 
            // gbCambiodeContraseña
            // 
            this.gbCambiodeContraseña.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gbCambiodeContraseña.Controls.Add(this.btnCancelar);
            this.gbCambiodeContraseña.Controls.Add(this.lblTu);
            this.gbCambiodeContraseña.Controls.Add(this.lblNueva);
            this.gbCambiodeContraseña.Controls.Add(this.lblConfirmar);
            this.gbCambiodeContraseña.Controls.Add(this.btnCambiarContrasena);
            this.gbCambiodeContraseña.Controls.Add(this.txtConfirmarContrasena);
            this.gbCambiodeContraseña.Controls.Add(this.txtNuevaContrasena);
            this.gbCambiodeContraseña.Controls.Add(this.txtContrasenaActual);
            this.gbCambiodeContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCambiodeContraseña.Location = new System.Drawing.Point(113, 62);
            this.gbCambiodeContraseña.Name = "gbCambiodeContraseña";
            this.gbCambiodeContraseña.Size = new System.Drawing.Size(571, 314);
            this.gbCambiodeContraseña.TabIndex = 8;
            this.gbCambiodeContraseña.TabStop = false;
            this.gbCambiodeContraseña.Text = "Cambio de contraseña";
            // 
            // frmCambiarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbCambiodeContraseña);
            this.Name = "frmCambiarContraseña";
            this.Text = "frmCambiarContraseña";
            this.gbCambiodeContraseña.ResumeLayout(false);
            this.gbCambiodeContraseña.PerformLayout();
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
    }
}