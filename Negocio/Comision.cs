using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Comision
    {
        public List<Entidades.Comision> getComisiones()
        {
            Datos.Comision com = new Datos.Comision();
            return com.getComisiones();
        }
    
        public List<Entidades.Comision> getComisiones(string desc)
        {
            Datos.Comision com = new Datos.Comision();
            return com.getComisiones(desc);
        }

        public void addComision(Entidades.Comision comision)
        {
            if (comision.Descripcion == "")
                throw (new Exception("Falta descripción"));
            if (comision.IDPlan == 0)
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
            if (comision.IDPlan == 0)
                throw (new Exception("Falta id del plan"));
            if (comision.AnioEspecialidad == 0)
                throw (new Exception("Falta año"));

            Datos.Comision com = new Datos.Comision();
            com.updateComision(comision);
        }

          
        public void deleteComision(Entidades.Comision comision)
        {
            Datos.Comision com = new Datos.Comision();
            com.deleteComision(comision);
        }

    }
}




