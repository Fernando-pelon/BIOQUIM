using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_Bioquim.Formularios
{
    public partial class frmContenedorRegistrarUsuario : Form
    {
        public frmContenedorRegistrarUsuario()
        {
            InitializeComponent();

            var login = new userControl.frmRegistrarUsuario();
            login.Size = new System.Drawing.Size(810, 760); // Tamaño fijo
            login.Anchor = AnchorStyles.None; // No se estira

            // Centrar el UserControl en la ventana
            login.Location = new Point(
                (this.ClientSize.Width - login.Width) / 2,
                (this.ClientSize.Height - login.Height) / 2
            );

            this.Controls.Add(login);

            this.Text = "Login";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new System.Drawing.Size(810, 760); // Ventana más grande para centrar
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (Controls.Count > 0)
            {
                var login = Controls[0];
                login.Location = new Point(
                    (this.ClientSize.Width - login.Width) / 2,
                    (this.ClientSize.Height - login.Height) / 2
                );
            }
        }
    }
}
