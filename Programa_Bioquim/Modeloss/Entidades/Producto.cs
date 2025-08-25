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
            string consultaQuery = "Select *from inven;";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable tablaVirtual = new DataTable();
            add.Fill(tablaVirtual);
            return tablaVirtual;

        }

        public static DataTable listaProducto()
        {
            SqlConnection conexion = ConexionDB.conectar();
            string consultaQuery = "select nombreProducto,idProducto from Producto;";
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
                string consultaQueryInsert = "insert into Producto (nombreProducto,costoProducto,cantidadProducto) values(@nombreProducto,@costoProducto,@cantidadProducto);";
                SqlCommand insertar = new SqlCommand(consultaQueryInsert, conexion);
                insertar.Parameters.AddWithValue("@nombreProducto", nombreProducto);
                insertar.Parameters.AddWithValue("@costoProducto", costoProducto);
                insertar.Parameters.AddWithValue("@cantidadProducto", cantidadProducto);
                insertar.ExecuteNonQuery();
                MessageBox.Show("Datos registrados correctamente", "Datos correctos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar datos: " + ex.Message, "Error al insertar datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool eliminarProducto()
        {
            try
            {
                SqlConnection conexion = ConexionDB.conectar();
                string consultaQueryDelete = "delete from Producto where idProducto=@idProducto;";
                SqlCommand eliminar = new SqlCommand(consultaQueryDelete, conexion);
                eliminar.Parameters.AddWithValue("@idProducto", idProducto);
                eliminar.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar producto: " + ex.Message, "Error al eliminar producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }   
 }   