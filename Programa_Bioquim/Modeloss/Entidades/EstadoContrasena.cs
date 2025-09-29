using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Programa_Bioquim.Utilidades
{
    public static class EstadoContrasena
    {
        private static readonly string archivoContrasena = Path.Combine(Application.StartupPath, "contrasena.cambio");

        public static bool NecesitaCambioContrasena(string correoUsuario)
        {
            try
            {
                bool archivoExiste = File.Exists(archivoContrasena);

                // Si el archivo no existe, entonces necesita cambio
                if (!archivoExiste)
                {
                    return true;
                }

                // Si el archivo existe, leemos y vemos si el usuario ya está en la lista
                string[] lineas = File.ReadAllLines(archivoContrasena);
                bool yaCambio = lineas.Any(linea => linea.Trim() == correoUsuario);

                // Si ya cambió, no necesita cambio (retorna false), sino true
                return !yaCambio;
            }
            catch (Exception)
            {
                return true;
            }
        }

        public static void MarcarContrasenaCambiada(string correoUsuario)
        {
            try
            {
                List<string> lineas = new List<string>();

                if (File.Exists(archivoContrasena))
                {
                    lineas = File.ReadAllLines(archivoContrasena).ToList();
                }

                if (!lineas.Contains(correoUsuario))
                {
                    lineas.Add(correoUsuario);
                    File.WriteAllLines(archivoContrasena, lineas);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar estado de contraseña: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}