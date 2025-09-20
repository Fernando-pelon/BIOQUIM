namespace Programa_Bioquim.Formularios.Admin
{
    partial class frmGestionDeUsuarios
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
            this.dgvGestionUsuarios = new System.Windows.Forms.DataGridView();
            this.pnlinventario = new System.Windows.Forms.Panel();
            this.lblInventario = new System.Windows.Forms.Label();
            this.btnAgregarUser = new System.Windows.Forms.Button();
            this.btnEliminarUser = new System.Windows.Forms.Button();
            this.btnActualizarUser = new System.Windows.Forms.Button();
            this.txtBuscarUser = new System.Windows.Forms.TextBox();
            this.lblBuscarUser = new System.Windows.Forms.Label();
            this.PnlDatosUsuarios = new System.Windows.Forms.Panel();
            this.cbDepartamentoUser = new System.Windows.Forms.ComboBox();
            this.txtNombreUser = new System.Windows.Forms.TextBox();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtApellidoUser = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtCorreoUser = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.cbTIpoUsuarioUser = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContraseñaUser = new System.Windows.Forms.TextBox();
            this.lblCorreoCrear = new System.Windows.Forms.Label();
            this.btnRefrescar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestionUsuarios)).BeginInit();
            this.pnlinventario.SuspendLayout();
            this.PnlDatosUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGestionUsuarios
            // 
            this.dgvGestionUsuarios.AllowUserToAddRows = false;
            this.dgvGestionUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGestionUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGestionUsuarios.Location = new System.Drawing.Point(159, 103);
            this.dgvGestionUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvGestionUsuarios.Name = "dgvGestionUsuarios";
            this.dgvGestionUsuarios.ReadOnly = true;
            this.dgvGestionUsuarios.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvGestionUsuarios.RowHeadersWidth = 51;
            this.dgvGestionUsuarios.RowTemplate.Height = 24;
            this.dgvGestionUsuarios.Size = new System.Drawing.Size(804, 327);
            this.dgvGestionUsuarios.TabIndex = 3;
            this.dgvGestionUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGestionUsuarios_CellDoubleClick_1);
            // 
            // pnlinventario
            // 
            this.pnlinventario.BackColor = System.Drawing.Color.Blue;
            this.pnlinventario.Controls.Add(this.lblInventario);
            this.pnlinventario.Location = new System.Drawing.Point(383, 37);
            this.pnlinventario.Margin = new System.Windows.Forms.Padding(4);
            this.pnlinventario.Name = "pnlinventario";
            this.pnlinventario.Size = new System.Drawing.Size(345, 60);
            this.pnlinventario.TabIndex = 9;
            // 
            // lblInventario
            // 
            this.lblInventario.AutoSize = true;
            this.lblInventario.BackColor = System.Drawing.Color.Blue;
            this.lblInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblInventario.Location = new System.Drawing.Point(25, 16);
            this.lblInventario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInventario.Name = "lblInventario";
            this.lblInventario.Size = new System.Drawing.Size(246, 29);
            this.lblInventario.TabIndex = 0;
            this.lblInventario.Text = "Gestion de usuarios";
            // 
            // btnAgregarUser
            // 
            this.btnAgregarUser.BackColor = System.Drawing.Color.Blue;
            this.btnAgregarUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarUser.ForeColor = System.Drawing.Color.White;
            this.btnAgregarUser.Location = new System.Drawing.Point(16, 377);
            this.btnAgregarUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarUser.Name = "btnAgregarUser";
            this.btnAgregarUser.Size = new System.Drawing.Size(136, 53);
            this.btnAgregarUser.TabIndex = 10;
            this.btnAgregarUser.Text = "Agregar";
            this.btnAgregarUser.UseVisualStyleBackColor = false;
            this.btnAgregarUser.Click += new System.EventHandler(this.btnAgregarUser_Click);
            // 
            // btnEliminarUser
            // 
            this.btnEliminarUser.BackColor = System.Drawing.Color.Blue;
            this.btnEliminarUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUser.ForeColor = System.Drawing.Color.White;
            this.btnEliminarUser.Location = new System.Drawing.Point(16, 316);
            this.btnEliminarUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarUser.Name = "btnEliminarUser";
            this.btnEliminarUser.Size = new System.Drawing.Size(136, 53);
            this.btnEliminarUser.TabIndex = 11;
            this.btnEliminarUser.Text = "Eliminar";
            this.btnEliminarUser.UseVisualStyleBackColor = false;
            this.btnEliminarUser.Click += new System.EventHandler(this.btnEliminarUser_Click);
            // 
            // btnActualizarUser
            // 
            this.btnActualizarUser.BackColor = System.Drawing.Color.Blue;
            this.btnActualizarUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarUser.ForeColor = System.Drawing.Color.White;
            this.btnActualizarUser.Location = new System.Drawing.Point(16, 256);
            this.btnActualizarUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizarUser.Name = "btnActualizarUser";
            this.btnActualizarUser.Size = new System.Drawing.Size(136, 53);
            this.btnActualizarUser.TabIndex = 12;
            this.btnActualizarUser.Text = "Actualizar";
            this.btnActualizarUser.UseVisualStyleBackColor = false;
            this.btnActualizarUser.Click += new System.EventHandler(this.btnActualizarUser_Click);
            // 
            // txtBuscarUser
            // 
            this.txtBuscarUser.Location = new System.Drawing.Point(736, 60);
            this.txtBuscarUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarUser.Multiline = true;
            this.txtBuscarUser.Name = "txtBuscarUser";
            this.txtBuscarUser.Size = new System.Drawing.Size(203, 35);
            this.txtBuscarUser.TabIndex = 13;
            this.txtBuscarUser.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblBuscarUser
            // 
            this.lblBuscarUser.AutoSize = true;
            this.lblBuscarUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarUser.Location = new System.Drawing.Point(732, 34);
            this.lblBuscarUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscarUser.Name = "lblBuscarUser";
            this.lblBuscarUser.Size = new System.Drawing.Size(131, 20);
            this.lblBuscarUser.TabIndex = 14;
            this.lblBuscarUser.Text = "Buscar Usuario:";
            // 
            // PnlDatosUsuarios
            // 
            this.PnlDatosUsuarios.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PnlDatosUsuarios.Controls.Add(this.cbDepartamentoUser);
            this.PnlDatosUsuarios.Controls.Add(this.txtNombreUser);
            this.PnlDatosUsuarios.Controls.Add(this.lblDepartamento);
            this.PnlDatosUsuarios.Controls.Add(this.lblNombre);
            this.PnlDatosUsuarios.Controls.Add(this.txtApellidoUser);
            this.PnlDatosUsuarios.Controls.Add(this.lblApellido);
            this.PnlDatosUsuarios.Controls.Add(this.txtCorreoUser);
            this.PnlDatosUsuarios.Controls.Add(this.lblCorreo);
            this.PnlDatosUsuarios.Controls.Add(this.cbTIpoUsuarioUser);
            this.PnlDatosUsuarios.Controls.Add(this.label1);
            this.PnlDatosUsuarios.Controls.Add(this.txtContraseñaUser);
            this.PnlDatosUsuarios.Controls.Add(this.lblCorreoCrear);
            this.PnlDatosUsuarios.Location = new System.Drawing.Point(159, 437);
            this.PnlDatosUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.PnlDatosUsuarios.Name = "PnlDatosUsuarios";
            this.PnlDatosUsuarios.Size = new System.Drawing.Size(804, 177);
            this.PnlDatosUsuarios.TabIndex = 15;
            // 
            // cbDepartamentoUser
            // 
            this.cbDepartamentoUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDepartamentoUser.FormattingEnabled = true;
            this.cbDepartamentoUser.Location = new System.Drawing.Point(387, 148);
            this.cbDepartamentoUser.Margin = new System.Windows.Forms.Padding(4);
            this.cbDepartamentoUser.Name = "cbDepartamentoUser";
            this.cbDepartamentoUser.Size = new System.Drawing.Size(329, 24);
            this.cbDepartamentoUser.TabIndex = 24;
            // 
            // txtNombreUser
            // 
            this.txtNombreUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreUser.Location = new System.Drawing.Point(24, 33);
            this.txtNombreUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreUser.Name = "txtNombreUser";
            this.txtNombreUser.Size = new System.Drawing.Size(332, 22);
            this.txtNombreUser.TabIndex = 15;
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(388, 128);
            this.lblDepartamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(96, 16);
            this.lblDepartamento.TabIndex = 23;
            this.lblDepartamento.Text = "Departamento:";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 14);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 13;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtApellidoUser
            // 
            this.txtApellidoUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApellidoUser.Location = new System.Drawing.Point(24, 90);
            this.txtApellidoUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidoUser.Name = "txtApellidoUser";
            this.txtApellidoUser.Size = new System.Drawing.Size(332, 22);
            this.txtApellidoUser.TabIndex = 22;
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(20, 62);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(60, 16);
            this.lblApellido.TabIndex = 21;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtCorreoUser
            // 
            this.txtCorreoUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCorreoUser.Location = new System.Drawing.Point(24, 149);
            this.txtCorreoUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreoUser.Multiline = true;
            this.txtCorreoUser.Name = "txtCorreoUser";
            this.txtCorreoUser.Size = new System.Drawing.Size(332, 20);
            this.txtCorreoUser.TabIndex = 16;
            this.txtCorreoUser.UseSystemPasswordChar = true;
            // 
            // lblCorreo
            // 
            this.lblCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(21, 129);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(51, 16);
            this.lblCorreo.TabIndex = 14;
            this.lblCorreo.Text = "Correo:";
            // 
            // cbTIpoUsuarioUser
            // 
            this.cbTIpoUsuarioUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTIpoUsuarioUser.FormattingEnabled = true;
            this.cbTIpoUsuarioUser.Location = new System.Drawing.Point(387, 89);
            this.cbTIpoUsuarioUser.Margin = new System.Windows.Forms.Padding(4);
            this.cbTIpoUsuarioUser.Name = "cbTIpoUsuarioUser";
            this.cbTIpoUsuarioUser.Size = new System.Drawing.Size(329, 24);
            this.cbTIpoUsuarioUser.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tipo Usuario:";
            // 
            // txtContraseñaUser
            // 
            this.txtContraseñaUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContraseñaUser.Location = new System.Drawing.Point(387, 30);
            this.txtContraseñaUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtContraseñaUser.Name = "txtContraseñaUser";
            this.txtContraseñaUser.Size = new System.Drawing.Size(332, 22);
            this.txtContraseñaUser.TabIndex = 18;
            this.txtContraseñaUser.UseSystemPasswordChar = true;
            // 
            // lblCorreoCrear
            // 
            this.lblCorreoCrear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCorreoCrear.AutoSize = true;
            this.lblCorreoCrear.Location = new System.Drawing.Point(383, 10);
            this.lblCorreoCrear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreoCrear.Name = "lblCorreoCrear";
            this.lblCorreoCrear.Size = new System.Drawing.Size(79, 16);
            this.lblCorreoCrear.TabIndex = 17;
            this.lblCorreoCrear.Text = "Contraseña:";
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefrescar.ForeColor = System.Drawing.Color.Transparent;
            this.btnRefrescar.Image = global::Programa_Bioquim.Properties.Resources.actualizar_flecha;
            this.btnRefrescar.Location = new System.Drawing.Point(29, 103);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(109, 78);
            this.btnRefrescar.TabIndex = 16;
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // frmGestionDeUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1208, 629);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.PnlDatosUsuarios);
            this.Controls.Add(this.lblBuscarUser);
            this.Controls.Add(this.txtBuscarUser);
            this.Controls.Add(this.btnActualizarUser);
            this.Controls.Add(this.btnEliminarUser);
            this.Controls.Add(this.btnAgregarUser);
            this.Controls.Add(this.pnlinventario);
            this.Controls.Add(this.dgvGestionUsuarios);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGestionDeUsuarios";
            this.Text = "frmGestionDeUsuarios";
            this.Load += new System.EventHandler(this.frmGestionDeUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestionUsuarios)).EndInit();
            this.pnlinventario.ResumeLayout(false);
            this.pnlinventario.PerformLayout();
            this.PnlDatosUsuarios.ResumeLayout(false);
            this.PnlDatosUsuarios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGestionUsuarios;
        private System.Windows.Forms.Panel pnlinventario;
        private System.Windows.Forms.Label lblInventario;
        private System.Windows.Forms.Button btnAgregarUser;
        private System.Windows.Forms.Button btnEliminarUser;
        private System.Windows.Forms.Button btnActualizarUser;
        private System.Windows.Forms.TextBox txtBuscarUser;
        private System.Windows.Forms.Label lblBuscarUser;
        private System.Windows.Forms.Panel PnlDatosUsuarios;
        private System.Windows.Forms.TextBox txtNombreUser;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtApellidoUser;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtCorreoUser;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtContraseñaUser;
        private System.Windows.Forms.Label lblCorreoCrear;
        private System.Windows.Forms.ComboBox cbDepartamentoUser;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.ComboBox cbTIpoUsuarioUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefrescar;
    }
}