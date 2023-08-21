using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Especialidad
    {
        public List<Entidades.Especialidad> getEspecialidades()
        {
            Datos.Especialidad esp = new Datos.Especialidad();
            return esp.getEspecialidades();
        }

        public List<Entidades.Especialidad> getEspecialidades(string desc)
        {
            Datos.Especialidad esp = new Datos.Especialidad();
            return esp.getEspecialidades(desc);
        }

        public void addEspecialidad(Entidades.Especialidad especialidad)
        {
            if (especialidad.Descripcion == "")
                throw (new Exception("Falta descripción"));
            Datos.Especialidad esp = new Datos.Especialidad();
            esp.addEspecialidad(especialidad);
        }
        public void updateEspecialidad(Entidades.Especialidad especialidad)
        {
            if (especialidad.Descripcion == "")
                throw (new Exception("Falta descripción"));
            Datos.Especialidad esp = new Datos.Especialidad();
            esp.updateEspecialidad(especialidad);
        }
        public void deleteEspecialidad(Entidades.Especialidad especialidad)
        {
            Datos.Especialidad esp = new Datos.Especialidad();
            esp.deleteEspecialidad(especialidad);
        }
    }
}
