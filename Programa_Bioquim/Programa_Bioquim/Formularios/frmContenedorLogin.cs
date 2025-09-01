using Programa_Bioquim.userControl;
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
    public partial class frmContenedorLogin : Form
    {
        public frmContenedorLogin()
        {
            InitializeComponent();

            var login = new userControl.frmLogin();
            login.Dock = DockStyle.Fill;
            this.Controls.Add(login);

            this.Text = "Login";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new System.Drawing.Size(565, 550);
        }
    }
}
