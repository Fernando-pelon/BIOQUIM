using Modelos.Entidades;
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

namespace Programa_Bioquim.Formularios.Primer_Uso
{
    public partial class frmBienvenida : Form
    {
        public frmBienvenida()
        {
            InitializeComponent();
        }

        private void frmBienvenida_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            // Verificar si existen usuarios 
            bool respuesta = Modeloss.Entidades.ModelPrimerUso.CheckEmpleados(); // ← CON DOBLE 's'

            if (respuesta)
            {
                // Si existen usuarios, muestra login
                frmContenedorLogin login = new frmContenedorLogin();
                login.Show();
                this.Hide();
            }
            else
            {
                // Si no existen usuarios, muestra frmPrimerUsuario
                frmCrearNuevoUsuario primerUsuario = new frmCrearNuevoUsuario();
                primerUsuario.Show();
                this.Hide();
            }
        }
    }
}