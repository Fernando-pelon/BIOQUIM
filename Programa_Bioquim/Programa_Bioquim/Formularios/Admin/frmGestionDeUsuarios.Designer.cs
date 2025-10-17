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
            this.dgvGestionUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGestionUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGestionUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGestionUsuarios.Location = new System.Drawing.Point(119, 84);
            this.dgvGestionUsuarios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvGestionUsuarios.Name = "dgvGestionUsuarios";
            this.dgvGestionUsuarios.ReadOnly = true;
            this.dgvGestionUsuarios.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvGestionUsuarios.RowHeadersWidth = 51;
            this.dgvGestionUsuarios.RowTemplate.Height = 24;
            this.dgvGestionUsuarios.Size = new System.Drawing.Size(603, 324);
            this.dgvGestionUsuarios.TabIndex = 3;
            this.dgvGestionUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGestionUsuarios_CellDoubleClick_1);
            // 
            // pnlinventario
            // 
            this.pnlinventario.BackColor = System.Drawing.Color.Blue;
            this.pnlinventario.Controls.Add(this.lblInventario);
            this.pnlinventario.Location = new System.Drawing.Point(297, 37);
            this.pnlinventario.Name = "pnlinventario";
            this.pnlinventario.Size = new System.Drawing.Size(191, 41);
            this.pnlinventario.TabIndex = 9;
            // 
            // lblInventario
            // 
            this.lblInventario.AutoSize = true;
            this.lblInventario.BackColor = System.Drawing.Color.Blue;
            this.lblInventario.Font = new System.Drawing.Font("Open Sans Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblInventario.Location = new System.Drawing.Point(15, 7);
            this.lblInventario.Name = "lblInventario";
            this.lblInventario.Size = new System.Drawing.Size(210, 28);
            this.lblInventario.TabIndex = 0;
            this.lblInventario.Text = "Gestion de usuarios";
            // 
            // btnAgregarUser
            // 
            this.btnAgregarUser.BackColor = System.Drawing.Color.Blue;
            this.btnAgregarUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarUser.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarUser.ForeColor = System.Drawing.Color.White;
            this.btnAgregarUser.Location = new System.Drawing.Point(12, 306);
            this.btnAgregarUser.Name = "btnAgregarUser";
            this.btnAgregarUser.Size = new System.Drawing.Size(102, 43);
            this.btnAgregarUser.TabIndex = 10;
            this.btnAgregarUser.Text = "Agregar";
            this.btnAgregarUser.UseVisualStyleBackColor = false;
            this.btnAgregarUser.Click += new System.EventHandler(this.btnAgregarUser_Click);
            // 
            // btnEliminarUser
            // 
            this.btnEliminarUser.BackColor = System.Drawing.Color.Blue;
            this.btnEliminarUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarUser.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUser.ForeColor = System.Drawing.Color.White;
            this.btnEliminarUser.Location = new System.Drawing.Point(12, 257);
            this.btnEliminarUser.Name = "btnEliminarUser";
            this.btnEliminarUser.Size = new System.Drawing.Size(102, 43);
            this.btnEliminarUser.TabIndex = 11;
            this.btnEliminarUser.Text = "Eliminar";
            this.btnEliminarUser.UseVisualStyleBackColor = false;
            this.btnEliminarUser.Click += new System.EventHandler(this.btnEliminarUser_Click);
            // 
            // btnActualizarUser
            // 
            this.btnActualizarUser.BackColor = System.Drawing.Color.Blue;
            this.btnActualizarUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizarUser.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarUser.ForeColor = System.Drawing.Color.White;
            this.btnActualizarUser.Location = new System.Drawing.Point(12, 208);
            this.btnActualizarUser.Name = "btnActualizarUser";
            this.btnActualizarUser.Size = new System.Drawing.Size(102, 43);
            this.btnActualizarUser.TabIndex = 12;
            this.btnActualizarUser.Text = "Actualizar";
            this.btnActualizarUser.UseVisualStyleBackColor = false;
            this.btnActualizarUser.Click += new System.EventHandler(this.btnActualizarUser_Click);
            // 
            // txtBuscarUser
            // 
            this.txtBuscarUser.Location = new System.Drawing.Point(552, 49);
            this.txtBuscarUser.Multiline = true;
            this.txtBuscarUser.Name = "txtBuscarUser";
            this.txtBuscarUser.Size = new System.Drawing.Size(153, 29);
            this.txtBuscarUser.TabIndex = 13;
            this.txtBuscarUser.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblBuscarUser
            // 
            this.lblBuscarUser.AutoSize = true;
            this.lblBuscarUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarUser.Location = new System.Drawing.Point(549, 28);
            this.lblBuscarUser.Name = "lblBuscarUser";
            this.lblBuscarUser.Size = new System.Drawing.Size(109, 17);
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
            this.PnlDatosUsuarios.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlDatosUsuarios.Location = new System.Drawing.Point(119, 355);
            this.PnlDatosUsuarios.Name = "PnlDatosUsuarios";
            this.PnlDatosUsuarios.Size = new System.Drawing.Size(603, 172);
            this.PnlDatosUsuarios.TabIndex = 15;
            // 
            // cbDepartamentoUser
            // 
            this.cbDepartamentoUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDepartamentoUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartamentoUser.FormattingEnabled = true;
            this.cbDepartamentoUser.Location = new System.Drawing.Point(290, 120);
            this.cbDepartamentoUser.Name = "cbDepartamentoUser";
            this.cbDepartamentoUser.Size = new System.Drawing.Size(248, 26);
            this.cbDepartamentoUser.TabIndex = 24;
            // 
            // txtNombreUser
            // 
            this.txtNombreUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreUser.Location = new System.Drawing.Point(18, 27);
            this.txtNombreUser.Name = "txtNombreUser";
            this.txtNombreUser.Size = new System.Drawing.Size(250, 25);
            this.txtNombreUser.TabIndex = 15;
            this.txtNombreUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(291, 104);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(104, 18);
            this.lblDepartamento.TabIndex = 23;
            this.lblDepartamento.Text = "Departamento:";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(15, 11);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(63, 18);
            this.lblNombre.TabIndex = 13;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtApellidoUser
            // 
            this.txtApellidoUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApellidoUser.Location = new System.Drawing.Point(18, 73);
            this.txtApellidoUser.Name = "txtApellidoUser";
            this.txtApellidoUser.Size = new System.Drawing.Size(250, 25);
            this.txtApellidoUser.TabIndex = 22;
            this.txtApellidoUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(15, 50);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(64, 18);
            this.lblApellido.TabIndex = 21;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtCorreoUser
            // 
            this.txtCorreoUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCorreoUser.Location = new System.Drawing.Point(18, 121);
            this.txtCorreoUser.Name = "txtCorreoUser";
            this.txtCorreoUser.Size = new System.Drawing.Size(250, 25);
            this.txtCorreoUser.TabIndex = 16;
            this.txtCorreoUser.UseSystemPasswordChar = true;
            this.txtCorreoUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // lblCorreo
            // 
            this.lblCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(16, 105);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(55, 18);
            this.lblCorreo.TabIndex = 14;
            this.lblCorreo.Text = "Correo:";
            // 
            // cbTIpoUsuarioUser
            // 
            this.cbTIpoUsuarioUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTIpoUsuarioUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTIpoUsuarioUser.FormattingEnabled = true;
            this.cbTIpoUsuarioUser.Location = new System.Drawing.Point(290, 72);
            this.cbTIpoUsuarioUser.Name = "cbTIpoUsuarioUser";
            this.cbTIpoUsuarioUser.Size = new System.Drawing.Size(248, 26);
            this.cbTIpoUsuarioUser.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tipo Usuario:";
            // 
            // txtContraseñaUser
            // 
            this.txtContraseñaUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContraseñaUser.Location = new System.Drawing.Point(290, 24);
            this.txtContraseñaUser.Name = "txtContraseñaUser";
            this.txtContraseñaUser.Size = new System.Drawing.Size(250, 25);
            this.txtContraseñaUser.TabIndex = 18;
            this.txtContraseñaUser.UseSystemPasswordChar = true;
            this.txtContraseñaUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // lblCorreoCrear
            // 
            this.lblCorreoCrear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCorreoCrear.AutoSize = true;
            this.lblCorreoCrear.Location = new System.Drawing.Point(287, 8);
            this.lblCorreoCrear.Name = "lblCorreoCrear";
            this.lblCorreoCrear.Size = new System.Drawing.Size(84, 18);
            this.lblCorreoCrear.TabIndex = 17;
            this.lblCorreoCrear.Text = "Contraseña:";
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefrescar.ForeColor = System.Drawing.Color.Transparent;
            this.btnRefrescar.Image = global::Programa_Bioquim.Properties.Resources.actualizar_flecha;
            this.btnRefrescar.Location = new System.Drawing.Point(22, 84);
            this.btnRefrescar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(82, 68);
            this.btnRefrescar.TabIndex = 16;
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // frmGestionDeUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(906, 569);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.PnlDatosUsuarios);
            this.Controls.Add(this.lblBuscarUser);
            this.Controls.Add(this.txtBuscarUser);
            this.Controls.Add(this.btnActualizarUser);
            this.Controls.Add(this.btnEliminarUser);
            this.Controls.Add(this.btnAgregarUser);
            this.Controls.Add(this.pnlinventario);
            this.Controls.Add(this.dgvGestionUsuarios);
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