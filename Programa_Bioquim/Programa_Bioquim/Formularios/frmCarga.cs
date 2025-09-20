using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Programa_Bioquim
{
    public partial class frmCarga : Form
    {
        public frmCarga()
        {
            InitializeComponent();
        }

        private void frmCarga_Load(object sender, EventArgs e)
        {
            pbIntermediario.Value = 0;
            pbIntermediario.Minimum = 0;
            pbIntermediario.Maximum = 100;
            pbIntermediario.Style = ProgressBarStyle.Continuous;

            timerCarga.Interval = 30;
            timerCarga.Tick += new EventHandler(timerCarga_Tick);
            timerCarga.Start();
        }

        private void timerCarga_Tick(object sender, EventArgs e)
        {
            if (pbIntermediario.Value < pbIntermediario.Maximum)
            {
                pbIntermediario.Value += 2;
            }
            else
            {
                timerCarga.Stop();
                this.Hide();
                frmDashBoardEmpleado dashboard = new frmDashBoardEmpleado();
                dashboard.Show();
            }
        }
    }
}
