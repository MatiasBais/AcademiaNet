using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AlumnosInscripcion : Padre
    {
        public String Condicion { get; set; }
        public int Nota { get; set; }

        public Entidades.Usuario Alumno { get; set; }

        public Entidades.Curso Curso { get; set; }
    }
}
