using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
            Datos.Comision c = new Datos.Comision();
            Datos.Materia m = new Datos.Materia();
            List<Entidades.Comision> comisiones = c.getComisiones("", plan.ID);
            List<Entidades.Materia> materias = m.getMaterias(plan.ID);
            if (comisiones.Count > 0 && materias.Count > 0)
                throw new Exception("No se puede eliminar el plan ya que posee comisiones y/o materias.");
            Datos.Plan p = new Datos.Plan();
            p.deletePlan(plan);
        }

        public Entidades.Plan getPlan(int idPlan)
        {
            Datos.Plan plan = new Datos.Plan();
            return plan.getPlan(idPlan);
        }
    }
}
