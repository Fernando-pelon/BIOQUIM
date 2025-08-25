using Modelos.Conexiones;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modeloss.Entidades
{
    public class Empresa
    {
        private int idEmpresa;
        private string NombreEmpresa;
        private string correoEmpresa;
        private string ubicacionEmpresa;

        public int IdEmpresa { get => idEmpresa; set => idEmpresa = value; }
        public string NombreEmpresa1 { get => NombreEmpresa; set => NombreEmpresa = value; }
        public string CorreoEmpresa { get => correoEmpresa; set => correoEmpresa = value; }
        public string UbicacionEmpresa { get => ubicacionEmpresa; set => ubicacionEmpresa = value; }

        public static DataTable listaEmpresa()
        {
            SqlConnection conexion = ConexionDB.conectar();
            string consultaQuery = "select idEmpresa, NombreEmpresa from Empresas;";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable tablaVirtual = new DataTable();
            add.Fill(tablaVirtual);
            return tablaVirtual;

        }

        public static DataTable listarRutas()
        {
            SqlConnection conexion = ConexionDB.conectar();
            string consultaQuery = "select idUbicacion, ubicacionEmpresa from Ubicaciones;";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable tablaVirtual = new DataTable();
            add.Fill(tablaVirtual);
            return tablaVirtual;
        }
    }
}
