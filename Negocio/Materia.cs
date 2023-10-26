using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Materia
    {
        public List<Entidades.Materia> getMaterias(int ID)
        {
            Datos.Materia mat = new Datos.Materia();
            return mat.getMaterias(ID);
        }

        public void addMateria(Entidades.Materia materia)
        {
            Datos.Materia mat = new Datos.Materia();
            mat.addMateria(materia);
        }

        public void deleteMateria(int ID)
        {
            Datos.Curso c = new Datos.Curso();
            List<Entidades.Curso> cursos = c.getCursos(ID);
            if (cursos.Count > 0)
                throw new Exception("No se puede eliminar la materia porque tiene cursos asociados.");
            Datos.Materia mat = new Datos.Materia();
            Entidades.Materia materia = mat.getMateria(ID);
            mat.deleteMateria(materia);
        }

        public void updateMateria(Entidades.Materia materia)
        {
            Datos.Materia mat = new Datos.Materia();
            mat.updateMateria(materia);
        }
    }
}
