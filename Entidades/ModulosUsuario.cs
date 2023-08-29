using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ModulosUsuario : Padre
    {
        public Entidades.Modulo modulo { get; set; }

        public Boolean Consulta { get; set; }
        public Boolean Alta { get; set; }
        public Boolean Modificacion { get; set; }
        public Boolean Baja { get; set; }
    }
}
