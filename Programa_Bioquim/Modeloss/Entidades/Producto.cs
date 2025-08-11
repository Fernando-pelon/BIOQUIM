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
    public class Producto
    {
        private int idProducto;
        private string nombreProducto;
        private double costoProducto;
        private double cantidadProducto;

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public double CostoProducto { get => costoProducto; set => costoProducto = value; }
        public double CantidadProducto { get => cantidadProducto; set => cantidadProducto = value; }

        public static DataTable cargarInventario()
        {
            SqlConnection conexion = ConexionDB.conectar();
            string consultaQuery = "select nombreProducto,costoProducto,cantidadProducto from Producto;";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable tablaVirtual = new DataTable();
            add.Fill(tablaVirtual);
            return tablaVirtual;

        }

        //public bool insertarProducto()
        //{
        //    try
        //    {
        //        SqlConnection conexion = ConexionDB.conectar();
        //        string consultaQueryInsert = "insert into  (CategoriaId, Nombre, Precio, ImagenURL, FechaCreacion) values(@CategoriaId, @Nombre, @Precio, @ImagenURL, @FechaCreacion);";
        //        SqlCommand insertar = new SqlCommand(consultaQueryInsert, conexion);
        //        insertar.Parameters.AddWithValue("@",;
        //        insertar.Parameters.AddWithValue("@",;
        //        insertar.Parameters.AddWithValue("@",;
        //        insertar.Parameters.AddWithValue("@",;
        //        insertar.Parameters.AddWithValue("@",;
        //        insertar.ExecuteNonQuery();
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Verifica si la consulta de insertar esta correcta" + ex, "Error al insertar datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return false;
        //    }
        //}
    }   
 }   