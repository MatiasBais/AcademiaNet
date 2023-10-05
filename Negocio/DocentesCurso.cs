using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class DocentesCurso
    {
        public List<Entidades.DocenteCurso> getDocentes(Entidades.Curso curso)
        {
            Datos.DocenteCurso datos = new Datos.DocenteCurso();
            return datos.getDocentes(curso);
        }

        public List<Entidades.Usuario> getDocentesNo(Entidades.Curso curso)
        {
            Datos.DocenteCurso datos = new Datos.DocenteCurso();
            return datos.getDocentesNo(curso);
        }
    }
}
