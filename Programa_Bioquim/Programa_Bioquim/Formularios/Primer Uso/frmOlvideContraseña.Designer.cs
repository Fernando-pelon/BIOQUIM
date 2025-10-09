namespace Programa_Bioquim.Formularios.Primer_Uso
{
    partial class frmOlvideContraseña
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
            this.gbRecuperacionContraseña = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblNueva = new System.Windows.Forms.Label();
            this.lblConfirmar = new System.Windows.Forms.Label();
            this.btnCambiarContrasena = new System.Windows.Forms.Button();
            this.txtConfirmarContrasena = new System.Windows.Forms.TextBox();
            this.txtNuevaContrasena = new System.Windows.Forms.TextBox();
            this.txtCorreoActual = new System.Windows.Forms.TextBox();
            this.gbRecuperacionContraseña.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRecuperacionContraseña
            // 
            this.gbRecuperacionContraseña.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gbRecuperacionContraseña.Controls.Add(this.btnCancelar);
            this.gbRecuperacionContraseña.Controls.Add(this.lblCorreo);
            this.gbRecuperacionContraseña.Controls.Add(this.lblNueva);
            this.gbRecuperacionContraseña.Controls.Add(this.lblConfirmar);
            this.gbRecuperacionContraseña.Controls.Add(this.btnCambiarContrasena);
            this.gbRecuperacionContraseña.Controls.Add(this.txtConfirmarContrasena);
            this.gbRecuperacionContraseña.Controls.Add(this.txtNuevaContrasena);
            this.gbRecuperacionContraseña.Controls.Add(this.txtCorreoActual);
            this.gbRecuperacionContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRecuperacionContraseña.Location = new System.Drawing.Point(115, 68);
            this.gbRecuperacionContraseña.Name = "gbRecuperacionContraseña";
            this.gbRecuperacionContraseña.Size = new System.Drawing.Size(571, 314);
            this.gbRecuperacionContraseña.TabIndex = 9;
            this.gbRecuperacionContraseña.TabStop = false;
            this.gbRecuperacionContraseña.Text = "Olvide mi contraseña";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(335, 263);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 45);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(90, 60);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(154, 20);
            this.lblCorreo.TabIndex = 5;
            this.lblCorreo.Text = "Correo Electronico:";
            // 
            // lblNueva
            // 
            this.lblNueva.AutoSize = true;
            this.lblNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNueva.Location = new System.Drawing.Point(90, 121);
            this.lblNueva.Name = "lblNueva";
            this.lblNueva.Size = new System.Drawing.Size(149, 20);
            this.lblNueva.TabIndex = 6;
            this.lblNueva.Text = "Nueva contraseña:";
            // 
            // lblConfirmar
            // 
            this.lblConfirmar.AutoSize = true;
            this.lblConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmar.Location = new System.Drawing.Point(90, 186);
            this.lblConfirmar.Name = "lblConfirmar";
            this.lblConfirmar.Size = new System.Drawing.Size(176, 20);
            this.lblConfirmar.TabIndex = 7;
            this.lblConfirmar.Text = "Confirmar contraseña:";
            // 
            // btnCambiarContrasena
            // 
            this.btnCambiarContrasena.Location = new System.Drawing.Point(451, 263);
            this.btnCambiarContrasena.Name = "btnCambiarContrasena";
            this.btnCambiarContrasena.Size = new System.Drawing.Size(114, 45);
            this.btnCambiarContrasena.TabIndex = 4;
            this.btnCambiarContrasena.Text = "Confirmar";
            this.btnCambiarContrasena.UseVisualStyleBackColor = true;
            this.btnCambiarContrasena.Click += new System.EventHandler(this.btnCambiarContrasena_Click);
            // 
            // txtConfirmarContrasena
            // 
            this.txtConfirmarContrasena.Location = new System.Drawing.Point(269, 183);
            this.txtConfirmarContrasena.Name = "txtConfirmarContrasena";
            this.txtConfirmarContrasena.PasswordChar = '*';
            this.txtConfirmarContrasena.Size = new System.Drawing.Size(226, 30);
            this.txtConfirmarContrasena.TabIndex = 1;
            // 
            // txtNuevaContrasena
            // 
            this.txtNuevaContrasena.Location = new System.Drawing.Point(269, 118);
            this.txtNuevaContrasena.Name = "txtNuevaContrasena";
            this.txtNuevaContrasena.PasswordChar = '*';
            this.txtNuevaContrasena.Size = new System.Drawing.Size(226, 30);
            this.txtNuevaContrasena.TabIndex = 0;
            // 
            // txtCorreoActual
            // 
            this.txtCorreoActual.Location = new System.Drawing.Point(269, 54);
            this.txtCorreoActual.Name = "txtCorreoActual";
            this.txtCorreoActual.PasswordChar = '*';
            this.txtCorreoActual.Size = new System.Drawing.Size(226, 30);
            this.txtCorreoActual.TabIndex = 2;
            // 
            // frmOlvideContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbRecuperacionContraseña);
            this.Name = "frmOlvideContraseña";
            this.Text = "frmOlvideContraseña";
            this.gbRecuperacionContraseña.ResumeLayout(false);
            this.gbRecuperacionContraseña.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRecuperacionContraseña;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblNueva;
        private System.Windows.Forms.Label lblConfirmar;
        private System.Windows.Forms.Button btnCambiarContrasena;
        private System.Windows.Forms.TextBox txtConfirmarContrasena;
        private System.Windows.Forms.TextBox txtNuevaContrasena;
        private System.Windows.Forms.TextBox txtCorreoActual;
    }
}