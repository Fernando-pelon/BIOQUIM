using Modelos.Conexiones;
using Modelos.Entidades;
using Programa_Bioquim.Formularios.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_Bioquim.userControl
{
    public partial class frmLogin : UserControl
    {
        public frmLogin()
        {
            InitializeComponent();
        }



        private void btnSalida_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtContrasenia.Text)))
            {
                string usuario = txtUsuario.Text.Trim();
                string contrasena = txtContrasenia.Text.Trim();

                if (usuario == "" || contrasena == "")
                {
                    MessageBox.Show("Debe ingresar usuario y contraseña", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    frmCarga carga = new frmCarga();
                    carga.Show();
                    Application.DoEvents();

                    using (SqlConnection conn = ConexionDB.conectar())
                    {
                        string query = "SELECT ContrasenaUsuario FROM Usuario WHERE NombreUsuario=@user";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@user", usuario);

                        object result = cmd.ExecuteScalar();
                        carga.Close();

                        if (result == null)
                        {
                            // Usuario no existe
                            MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string passwordEnDB = result.ToString(); // contraseña en texto plano
                            if (contrasena == passwordEnDB)
                            {
                                // Contraseña correcta
                                this.Hide();
                                frmDashBoardEmpleado dashboard = new frmDashBoardEmpleado();
                                dashboard.Show();
                            }
                            else
                            {
                                // Contraseña incorrecta
                                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al intentar iniciar sesión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }
        }

        //public void logear(string usuario, string contraseña)
        //{
        //    SqlConnection conn = null;
        //    try
        //    {
        //        conn = ConexionDB.conectar();
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand("SELECT Nombre, Tipo_usuario FROM usuarios WHERE Usuario = @usuario AND Password = @pass", conn);
        //        cmd.Parameters.AddWithValue("usuario", usuario);
        //        cmd.Parameters.AddWithValue("pass", contraseña);
        //        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        sda.Fill(dt);

        //        if (dt.Rows.Count == 1)
        //        {
        //            this.Hide();
        //            if (dt.Rows[0][1].ToString() == "Admin")
        //            {
        //                new frmGestionUsuarios().Show();
        //            }
        //            else if (dt.Rows[0][1].ToString() == "Usuario")
        //            {
        //                new frmDashBoardEmpleado().Show();
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Usuario y/o Contraseña Incorrecta");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
                
        //            conn.Close();
        //    }
        //}

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
