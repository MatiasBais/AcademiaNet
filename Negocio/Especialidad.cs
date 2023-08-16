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
    }
}
