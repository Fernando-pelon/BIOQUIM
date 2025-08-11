using Modelos.Conexiones;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelos.Entidades
{
    public class RutaDeEntrega
    {
        private string ubicacionEmpresa;
        private int idProducto;
        private double montoPago;
        private int idEmpresa;

        public string UbicacionEmpresa { get => ubicacionEmpresa; set => ubicacionEmpresa = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public double MontoPago { get => montoPago; set => montoPago = value; }
        public int IdEmpresa { get => idEmpresa; set => idEmpresa = value; }

        public static DataTable cargarRutas()
        {
            SqlConnection conexion = ConexionDB.conectar();
            string consultaQuery = "select *from Rutas2;";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable tablaVirtual = new DataTable();
            add.Fill(tablaVirtual);
            return tablaVirtual;
        }

        public bool insertarProducto()
        {
            try
            {
                SqlConnection conexion = ConexionDB.conectar();
                string consultaQueryInsert = "insert into RutaDeEntrega  (ubicacionEmpresa, nombresProducto, montoPago, nombreEmpresa, ) values(@ubicacionEmpresa, @nombresProducto, @montoPago, @nombreEmpresa);";
                SqlCommand insertar = new SqlCommand(consultaQueryInsert, conexion);
                insertar.Parameters.AddWithValue("@ubicacionEmpresa", UbicacionEmpresa);
                insertar.Parameters.AddWithValue("@nombresProducto", IdProducto);
                insertar.Parameters.AddWithValue("@montoPago", MontoPago);
                insertar.Parameters.AddWithValue("@nombreEmpresa",IdEmpresa);
                
                insertar.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verifica si la consulta de insertar esta correcta" + ex, "Error al insertar datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


        }
    }
}
