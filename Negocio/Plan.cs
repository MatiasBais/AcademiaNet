using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Plan
    {

        public List<Entidades.Plan> getPlanes()
        {
            Datos.Plan plan = new Datos.Plan();
            return plan.getPlanes();
        }

        public List<Entidades.Plan> getPlanes(int idEspecialidad)
        {
            Datos.Plan plan = new Datos.Plan();
            return plan.getPlanes(idEspecialidad);
        }
    }
}
