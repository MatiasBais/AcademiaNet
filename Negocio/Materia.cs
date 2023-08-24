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
