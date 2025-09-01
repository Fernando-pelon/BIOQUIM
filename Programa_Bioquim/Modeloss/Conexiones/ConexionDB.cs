using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Modelos.Conexiones
{
    public class ConexionDB
    {
        private static string servidor = "LAB03-DS-EQ18\\SQLEXPRESS";
        private static string dataBase = "BIOQUIM_PTC";

        public static SqlConnection conectar()
        {
            string cadena = $"Data source={servidor};Initial Catalog={dataBase};Integrated Security=true;";
            SqlConnection conexion = new SqlConnection(cadena);
            conexion.Open();
            return conexion;
        }
    }
}
