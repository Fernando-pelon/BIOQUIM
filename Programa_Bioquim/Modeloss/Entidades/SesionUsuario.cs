using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Entidades
{
    public static class SesionUsuario

    {
        private static int idUsuario;
        private static string nombreUsuario1;
        private static string nombreCompleto;
        private static int idTipoUsuario1;
        private static int idDepartamento1;
        private static bool estaLogueado;

        public static int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public static string NombreUsuario { get => nombreUsuario1; set => nombreUsuario1 = value; }
        public static string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        public static int IdTipoUsuario { get => idTipoUsuario1; set => idTipoUsuario1 = value; }
        public static int IdDepartamento { get => idDepartamento1; set => idDepartamento1 = value; }
        public static bool EstaLogueado { get => estaLogueado; set => estaLogueado = value; }

        public static void IniciarSesion(Usuario usuario)
        {
            IdUsuario = usuario.IdUsuario;
            NombreUsuario = usuario.NombreUsuario;
            NombreCompleto = $"{usuario.NombreUsuario} {usuario.ApellidoUsuario}";
            IdTipoUsuario = usuario.IdTipoUsuario;
            IdDepartamento = usuario.IdDepartamento;
            EstaLogueado = true;
        }

        public static void CerrarSesion()
        {
            IdUsuario = 0;
            NombreUsuario = string.Empty;
            NombreCompleto = string.Empty;
            IdTipoUsuario = 0;
            IdDepartamento = 0;
            EstaLogueado = false;
        }

        public static bool EsAdministrador()
        {
            return EstaLogueado && IdTipoUsuario == 1;
        }

        public static bool EsEmpleado()
        {
            return EstaLogueado && IdTipoUsuario == 2;
        }

        public static bool EsRepartidor()
        {
            return EstaLogueado && IdTipoUsuario == 3;
        }
    }
}