using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_Bioquim.Formularios.Admin
{
    public partial class frmGestionUsuarios : Form
    {
        public frmGestionUsuarios()
        {
            InitializeComponent();

            // Label styling (already present)
            lblGestionUsuarios.AutoSize = true;
            lblGestionUsuarios.TextAlign = ContentAlignment.MiddleCenter;
            lblGestionUsuarios.BackColor = Color.FromArgb(20, 141, 255);
            lblGestionUsuarios.ForeColor = Color.White;
            lblGestionUsuarios.Font = new Font("Segoe UI", 18, FontStyle.Bold);

            CenterLabel();
            SetRoundedRegion();

            // Button styling
            StyleButton(btnIngresarUsuario);
            StyleButton(button1); // Eliminar Usuario
            StyleButton(btnBuscarUsuario);

            this.Resize += (s, e) =>
            {
                CenterLabel();
                SetRoundedRegion();
                SetButtonsRounded();
                PositionButtons();
            };

            lblGestionUsuarios.TextChanged += (s, e) =>
            {
                CenterLabel();
                SetRoundedRegion();
            };

            SetButtonsRounded();
        }

        private void CenterLabel()
        {
            lblGestionUsuarios.Left = (this.ClientSize.Width - lblGestionUsuarios.Width) / 2;
            lblGestionUsuarios.Top = 30;
        }

        private void SetRoundedRegion()
        {
            int radius = 15;
            Rectangle rect = new Rectangle(0, 0, lblGestionUsuarios.Width, lblGestionUsuarios.Height);
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            lblGestionUsuarios.Region = new Region(path);
        }

        private void StyleButton(Button btn)
        {
            btn.BackColor = Color.FromArgb(20, 141, 255);
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void SetButtonsRounded()
        {
            int radius = 15;
            SetButtonRoundedRegion(btnIngresarUsuario, radius);
            SetButtonRoundedRegion(button1, radius);
            SetButtonRoundedRegion(btnBuscarUsuario, radius);
        }

        private void SetButtonRoundedRegion(Button btn, int radius)
        {
            Rectangle rect = new Rectangle(0, 0, btn.Width, btn.Height);
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            btn.Region = new Region(path);
        }

        private void PositionButtons()
        {
            int minButtonWidth = 120;
            int maxButtonWidth = 187;
            int buttonHeight = 61;
            int minSpacing = 10;

            // Calcula el ancho máximo posible para los botones y el espacio
            int availableWidth = this.ClientSize.Width - 40; // margen lateral mínimo
            int buttonWidth = Math.Min(maxButtonWidth, (availableWidth - 2 * minSpacing) / 3);
            buttonWidth = Math.Max(minButtonWidth, buttonWidth);

            int totalWidth = buttonWidth * 3;
            int spacing = Math.Max(minSpacing, (availableWidth - totalWidth) / 2);

            int startX = Math.Max(20, (this.ClientSize.Width - (buttonWidth * 3 + spacing * 2)) / 2);
            int y = this.ClientSize.Height - buttonHeight - 40;

            btnIngresarUsuario.Size = new Size(buttonWidth, buttonHeight);
            button1.Size = new Size(buttonWidth, buttonHeight);
            btnBuscarUsuario.Size = new Size(buttonWidth, buttonHeight);

            btnIngresarUsuario.Location = new Point(startX, y);
            button1.Location = new Point(startX + buttonWidth + spacing, y);
            btnBuscarUsuario.Location = new Point(startX + (buttonWidth + spacing) * 2, y);
        }
    }
}
