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
            login.Dock = DockStyle.Fill;
            this.Controls.Add(login);

            this.Text = "Login";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new System.Drawing.Size(810, 760);
        }
    }
}
