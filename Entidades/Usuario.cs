using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario : Padre
    {
        public Persona Persona { get; set; }

        public string NombreUsuario { get; set; }

        public string Clave { get; set; }

        public Boolean Habilitado { get; set; }


    }
}
