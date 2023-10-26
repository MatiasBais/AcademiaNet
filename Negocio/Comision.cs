using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Comision
    {
        public Entidades.Comision getComision(int id)
        {
            Datos.Comision com = new Datos.Comision();
            return com.getComision(id);
        }
    
        public List<Entidades.Comision> getComisiones(string desc, int plan)
        {
            Datos.Comision com = new Datos.Comision();
            return com.getComisiones(desc, plan);
        }

        public void addComision(Entidades.Comision comision)
        {
            if (comision.Descripcion == "")
                throw (new Exception("Falta descripción"));
            if (comision.Plan.ID == 0)
                throw (new Exception("Falta id del plan"));
            if (comision.AnioEspecialidad == 0)
                throw (new Exception("Falta año"));
            Datos.Comision com = new Datos.Comision();
            com.addComision(comision);
        }
        public void updateComision(Entidades.Comision comision)
        {
            if (comision.Descripcion == "")
                throw (new Exception("Falta descripción"));
            if (comision.Plan.ID == 0)
                throw (new Exception("Falta id del plan"));
            if (comision.AnioEspecialidad == 0)
                throw (new Exception("Falta año"));

            Datos.Comision com = new Datos.Comision();
            com.updateComision(comision);
        }

          
        public void deleteComision(Entidades.Comision comision)
        {
            Datos.Curso c = new Datos.Curso();
            List<Entidades.Curso> cursos = c.getCursos(DateTime.Now.Year, comision.ID);
            if (cursos.Count > 0)
                throw new Exception("No se puede eliminar la comisión porque tiene cursos actuales. Años anteriores seguirán apareciendo.");
            Datos.Comision com = new Datos.Comision();
            com.deleteComision(comision);
        }

    }
}




