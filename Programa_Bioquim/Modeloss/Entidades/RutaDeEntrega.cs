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
        
        private int idProducto;
        private double montoPago;
        private int idEmpresa;
        private int idTipoPago;
        private int idUbicacion;

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public double MontoPago { get => montoPago; set => montoPago = value; }
        public int IdEmpresa { get => idEmpresa; set => idEmpresa = value; }
        public int IdTipoPago { get => idTipoPago; set => idTipoPago = value; }
        public int IdUbicacion { get => idUbicacion; set => idUbicacion = value; }

        public static DataTable cargarRutas()
        {
            SqlConnection conexion = ConexionDB.conectar();
            string consultaQuery = "select *from Rutas3;";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable tablaVirtual = new DataTable();
            add.Fill(tablaVirtual);
            return tablaVirtual;
        }



        public bool insertarRuta()
        {
            try
            {
                SqlConnection conexion = ConexionDB.conectar();
                string consultaQueryInsert = "insert into RutaDeEntrega  (idProducto,montoPago,idEmpresa,idTipoPago, idUbicacion) values(@idProducto,@montoPago,@idEmpresa,@idTipoPago, @idUbicacion);";
                SqlCommand insertar = new SqlCommand(consultaQueryInsert, conexion);
                insertar.Parameters.AddWithValue("@idProducto", idProducto);
                insertar.Parameters.AddWithValue("@montoPago",montoPago );
                insertar.Parameters.AddWithValue("@idEmpresa",idEmpresa );
                insertar.Parameters.AddWithValue("@iTipoPago", idTipoPago);
                insertar.Parameters.AddWithValue("@idUbicacion", idUbicacion);
                insertar.ExecuteNonQuery();
                MessageBox.Show("excelente datos registrados", "Datos correctos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verifica si la consulta de insertar esta correcta" + ex, "Error al insertar datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


        }

        //public bool eliminarRuta(int id)
        //{
        //    try
        //    {
        //        SqlConnection conexion
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}
    }
}
