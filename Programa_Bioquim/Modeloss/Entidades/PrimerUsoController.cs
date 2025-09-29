using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modeloss.Entidades
{
    public class PrimerUsoController
    {
        public bool VerificarUsuarios()
        {
            return ModelPrimerUso.CheckEmpleados();
        }
    }
}
