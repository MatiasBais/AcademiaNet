using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Curso
    {
        public List<Entidades.Curso> getCursos()
        {
            Datos.Curso cur = new Datos.Curso();
            return cur.getCursos();

        }

        public List<Entidades.Curso> getCursos(string desc)
        {
            Datos.Curso cur = new Datos.Curso();
            return cur.getCursos(desc);

        }

        public void addCurso(Entidades.Curso curso)
        {
            if (curso.Descripcion == "")
                throw (new Exception("Falta descripción"));
            if (curso.AnioCalendario == 0)
                throw (new Exception("Falta año del curso"));
            if (curso.Cupo == 0)
                throw (new Exception("Falta cupo"));
            if (curso.Comision.ID == 0)
                throw (new Exception("Falta id de la comision"));
            if (curso.Materia.ID == 0)
                throw (new Exception("Falta id de la materia"));
            Datos.Curso cur = new Datos.Curso();
            cur.addCurso(curso);
        }

        public void updateCurso(Entidades.Curso curso)
        {
            if (curso.Descripcion == "")
                throw (new Exception("Falta descripción"));
            if (curso.AnioCalendario == 0)
                throw (new Exception("Falta año del curso"));
            if (curso.Cupo == 0)
                throw (new Exception("Falta cupo"));
            if (curso.Comision.ID == 0)
                throw (new Exception("Falta id de la comision"));
            if (curso.Materia.ID == 0)
                throw (new Exception("Falta id de la materia"));

            Datos.Curso cur = new Datos.Curso();
            cur.updateCurso(curso);
        }

        public void deleteCurso(Entidades.Curso curso)
        {
            Datos.Curso com = new Datos.Curso();
            com.deleteCurso(curso);
        }
    }
}
