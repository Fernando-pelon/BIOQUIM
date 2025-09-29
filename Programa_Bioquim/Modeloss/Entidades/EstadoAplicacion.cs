using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modeloss.Entidades
{
    public static class EstadoAplicacion
    {
        private static readonly string archivoEstado = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "BioquimApp", "estado.aplicacion");
        public static bool EsPrimerUso()
            {
            string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "BioquimApp", "estado.aplicacion");

            bool existe = File.Exists(ruta);
            return !existe;
        }

        public static void MarcarPrimerUsoCompletado()
        {
            try
            {
                string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "BioquimApp", "estado.aplicacion");

                // Crear el directorio si no existe
                string directorio = Path.GetDirectoryName(ruta);
                if (!Directory.Exists(directorio))
                {
                    Directory.CreateDirectory(directorio);
                }

                File.WriteAllText(ruta, "APLICACION_CONFIGURADA");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar estado: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
