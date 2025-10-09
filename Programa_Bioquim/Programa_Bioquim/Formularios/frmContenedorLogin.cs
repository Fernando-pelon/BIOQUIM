using System;
using System.Windows.Forms;
using Programa_Bioquim.userControl;

namespace Programa_Bioquim.Formularios
{
    public partial class frmContenedorLogin : Form
    {
        public frmContenedorLogin()
        {
            InitializeComponent();

            // Cargar el UserControl de login
            frmLogin loginControl = new frmLogin();
            loginControl.Dock = DockStyle.Fill;
            loginControl.LoginExitoso += LoginControl_LoginExitoso;
            this.Controls.Add(loginControl);
            this.Text = "Login";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new System.Drawing.Size(565, 550);

        }

        private void LoginControl_LoginExitoso(object sender, EventArgs e)
        {
            // Ocultar este formulario y mostrar el dashboard
            this.Hide();
            frmDashBoardEmpleado dashboard = new frmDashBoardEmpleado();
            dashboard.FormClosed += (s, args) => this.Close(); // Cierra el login cuando el dashboard se cierra
            dashboard.Show();
        }

        private void frmLogin2_Load(object sender, EventArgs e)
        {

        }
    }
}