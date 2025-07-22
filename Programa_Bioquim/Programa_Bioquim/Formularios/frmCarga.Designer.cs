namespace Programa_Bioquim
{
    partial class frmCarga
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
            this.components = new System.ComponentModel.Container();
            this.pbIntermediario = new System.Windows.Forms.ProgressBar();
            this.pbGotitas = new System.Windows.Forms.PictureBox();
            this.timerCarga = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbGotitas)).BeginInit();
            this.SuspendLayout();
            // 
            // pbIntermediario
            // 
            this.pbIntermediario.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pbIntermediario.Location = new System.Drawing.Point(84, 306);
            this.pbIntermediario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbIntermediario.Name = "pbIntermediario";
            this.pbIntermediario.Size = new System.Drawing.Size(484, 24);
            this.pbIntermediario.TabIndex = 0;
            this.pbIntermediario.Click += new System.EventHandler(this.pbIntermediario_Click);
            // 
            // pbGotitas
            // 
            this.pbGotitas.Image = global::Programa_Bioquim.Properties.Resources.LogoSimple;
            this.pbGotitas.Location = new System.Drawing.Point(277, 125);
            this.pbGotitas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbGotitas.Name = "pbGotitas";
            this.pbGotitas.Size = new System.Drawing.Size(123, 88);
            this.pbGotitas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGotitas.TabIndex = 1;
            this.pbGotitas.TabStop = false;
            // 
            // timerCarga
            // 
            this.timerCarga.Tick += new System.EventHandler(this.timerCarga_Tick);
            // 
            // frmCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(681, 406);
            this.Controls.Add(this.pbGotitas);
            this.Controls.Add(this.pbIntermediario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmCarga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla de carga";
            this.Load += new System.EventHandler(this.frmCarga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbGotitas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbIntermediario;
        private System.Windows.Forms.PictureBox pbGotitas;
        private System.Windows.Forms.Timer timerCarga;
    }
}