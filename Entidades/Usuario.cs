using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario : Padre
    {

        public string NombreUsuario { get; set; }

        public string Clave { get; set; }

        public string Habilitado { get; set; }

        public Entidades.Plan Plan { get; set; }

        public int Legajo { get; set; }

        public Entidades.TipoUsuario tipo { get; set; }


    }
}
