using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class DocentesCurso
    {
        public List<Entidades.DocenteCurso> getDocentes(Entidades.Curso curso, string filtro)
        {
            Datos.DocenteCurso datos = new Datos.DocenteCurso();
            return datos.getDocentes(curso, filtro);
        }

        public List<Entidades.Usuario> getDocentesNo(Entidades.Curso curso, string filtro)
        {
            Datos.DocenteCurso datos = new Datos.DocenteCurso();
            return datos.getDocentesNo(curso, filtro);
        }

        public void addDocenteCurso(Entidades.DocenteCurso docenteCurso)
        {
            Datos.DocenteCurso datos = new Datos.DocenteCurso();
            datos.addDocenteCurso(docenteCurso);
        }

        public void removeDocenteCurso(Entidades.DocenteCurso docenteCurso)
        {
            Datos.DocenteCurso datos = new Datos.DocenteCurso();
            datos.removeDocenteCurso(docenteCurso);
        }

        public void updateDocenteCurso(Entidades.DocenteCurso docenteCurso)
        {
            Datos.DocenteCurso datos = new Datos.DocenteCurso();
            datos.updateDocenteCurso(docenteCurso);
        }
    }
}
