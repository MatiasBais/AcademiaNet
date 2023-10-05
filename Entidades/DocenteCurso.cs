using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DocenteCurso : Padre
    {
        public Usuario Docente {  get; set; }
        public Curso Curso { get; set; }

        public String Cargo { get; set; }

    }
}
