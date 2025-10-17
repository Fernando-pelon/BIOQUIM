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

        private async void frmCarga_Load(object sender, EventArgs e)
        {
        
            pbIntermediario.Minimum = 0;
            pbIntermediario.Maximum = 100;
            pbIntermediario.Value = pbIntermediario.Minimum;
            pbIntermediario.Style = ProgressBarStyle.Continuous;

            const int step = 2;
            const int delayMs = 30;

            for (int v = pbIntermediario.Minimum; v <= pbIntermediario.Maximum; v += step)
            {
                pbIntermediario.Value = Math.Min(v, pbIntermediario.Maximum);
                await Task.Delay(delayMs);
            }

            await Task.Delay(150);
            this.Hide();
        }

       
        private void timerCarga_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
