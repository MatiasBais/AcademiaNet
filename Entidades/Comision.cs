using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Comision : Padre
    {

        public int? AnioEspecialidad { get; set; }

        public string Descripcion { get; set; }

        public Plan Plan { get; set; }

    }
}
