using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Plan
    {
        public Entidades.Plan getPlan(int idPlan)
        {
            Datos.Plan plan = new Datos.Plan();
            return plan.getPlan(idPlan);
        }

        public List<Entidades.Plan> getPlanes(int idEspecialidad)
        {
            Datos.Plan p = new Datos.Plan();
            return p.getPlanes(idEspecialidad);
        }
        public List<Entidades.Plan> getPlanes(string desc)
        {
            Datos.Plan p = new Datos.Plan();
            return p.getPlanes(desc);
        }

        public void addPlan(Entidades.Plan plan)
        {
            if (plan.Descripcion == "")
                throw (new Exception("Falta descripción"));
            Datos.Plan p = new Datos.Plan();
            p.addPlan(plan);
        }
        public void updatePlan(Entidades.Plan plan)
        {
            if (plan.Descripcion == "")
                throw (new Exception("Falta descripción"));
            Datos.Plan p = new Datos.Plan();
            p.updatePlan(plan);
        }
        public void deletePlan(Entidades.Plan plan)
        {
            Datos.Plan p = new Datos.Plan();
            p.deletePlan(plan);
        }

        public void addPlan(Entidades.Plan p)
        {
            if (p.Descripcion == "")
                throw new Exception("Falta Descripcion");
            if (p.Especialidad == null)
                throw new Exception("Falta Especialidad");
            Datos.Plan datos = new Datos.Plan();
            datos.addPlan(p);

        }

        public void updatePlan(Entidades.Plan plan)
        {
            Datos.Plan p = new Datos.Plan();
            p.updatePlan(plan);
        }

        public void deletePlan(int idPlan)
        {
            Datos.Plan p = new Datos.Plan();
            p.deletePlan(p.getPlan(idPlan));
        }
    }
}
