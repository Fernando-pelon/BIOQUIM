using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_Bioquim.Formularios.Admin
{
    public partial class frmAyuda : Form
    {
        public frmAyuda()
        {
            InitializeComponent();
        }

        private void frmAyuda_Load(object sender, EventArgs e)
        {
            // Ruta relativa - funcionará en cualquier PC
            string rutaPDF = Path.Combine(Application.StartupPath, "Bioquim_Manual_de_Usuario.pdf");

            if (File.Exists(rutaPDF))
            {
                wbAyuda.Navigate(rutaPDF);
            }
            else
            {
                MessageBox.Show($"No se encontró el PDF.\nBusca en: {rutaPDF}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
