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
            string consultaQuery = "select *from Rutas;";
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
                insertar.Parameters.AddWithValue("@montoPago", montoPago);
                insertar.Parameters.AddWithValue("@idEmpresa", idEmpresa);
                insertar.Parameters.AddWithValue("@idTipoPago", idTipoPago);
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

        public bool eliminarRuta(int id)
        {
            try
            {
                SqlConnection conexion = ConexionDB.conectar();
                string consultaQueryDelete = "delete from RutaDeEntrega where idRutaEntrega=@id;";
                SqlCommand eliminar = new SqlCommand(consultaQueryDelete, conexion);
                eliminar.Parameters.AddWithValue("@id", id);
                eliminar.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool actualizarRuta(int id)
        {
            try
            {
                SqlConnection conexion = ConexionDB.conectar();
                string consultaQueryUpdate = "update RutaDeEntrega set idProducto=@idProducto,montoPago=@montoPago,idEmpresa=@idEmpresa,idTipoPago=@idTipoPago, idUbicacion=@idUbicacion where idRutaEntrega=@id;";
                SqlCommand actualizar = new SqlCommand(consultaQueryUpdate, conexion);
                actualizar.Parameters.AddWithValue("@idProducto", idProducto);
                actualizar.Parameters.AddWithValue("@montoPago", montoPago);
                actualizar.Parameters.AddWithValue("@idEmpresa", idEmpresa);
                actualizar.Parameters.AddWithValue("@idTipoPago", idTipoPago);
                actualizar.Parameters.AddWithValue("@idUbicacion", idUbicacion);
                actualizar.Parameters.AddWithValue("@id", id);
                actualizar.ExecuteNonQuery();
                MessageBox.Show("Datos actualizados correctamente", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar datos: " + ex.Message, "Error al actualizar datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static DataTable buscarRutaDeEntrega(string termino)
        {
            using (SqlConnection conexion = ConexionDB.conectar())
            {
                string consulta = @"
            SELECT 
                RutaDetalleEntrega.idEntrega, 
                Producto.nombreProducto, 
                Express.nombreExpress, 
                TipoApp.nombreTipoApp, 
                Ubicaciones.ubicacion
            FROM RutaDetalleEntrega
            INNER JOIN Producto ON RutaDetalleEntrega.idProducto = Producto.idProducto
            INNER JOIN Express ON RutaDetalleEntrega.idExpress = Express.idExpress
            INNER JOIN TipoApp ON RutaDetalleEntrega.idTipoApp = TipoApp.idTipoApp
            INNER JOIN Ubicaciones ON RutaDetalleEntrega.idUbicacion = Ubicaciones.idUbicacion
            WHERE Producto.nombreProducto LIKE @termino;";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@termino", "%" + termino + "%");

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        DataTable resultado = new DataTable();
                        adaptador.Fill(resultado);
                        return resultado;
                    }
                }
            }


        }
    }
}
