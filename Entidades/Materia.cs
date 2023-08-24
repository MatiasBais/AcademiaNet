using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Materia: Padre
    {
        public int ID { get; set; }
        public string Descripcion { get; set; }

        public int HSSemanales { get; set; }

        public int HSTotales { get; set; }

        public Plan Plan { get; set; }
    }
}
