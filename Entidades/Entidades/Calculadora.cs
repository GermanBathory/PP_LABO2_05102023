using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        private string nombreAlumno;
        private List<string> operaciones = new List<string>();
        private Numeracion primerOperando;
        private Numeracion resultado;
        private Numeracion segundoOperando;
        private ESistema sistema;
    }
}
