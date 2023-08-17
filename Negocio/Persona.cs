using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Persona
    {
        public List<Entidades.Persona> getAlumnos()
        {
            Datos.Persona datos = new Datos.Persona();
            return datos.getAlumnos();
        }

        public void addPersona(Entidades.Persona p)
        {
            if (p.Legajo == 0)
                throw new Exception("Falta Legajo");
            if (p.Nombre == "")
                throw new Exception("Falta Nombre");
            if (p.Apellido == "")
                throw new Exception("Falta Apellido");
            Datos.Persona datos = new Datos.Persona();
            datos.addPersona(p);

        }

        public void updatePersona(Entidades.Persona p)
        {
            Datos.Persona datos = new Datos.Persona();
            datos.updatePersona(p);
        }

        public void deletePersona(Entidades.Persona p)
        {
            Datos.Persona datos = new Datos.Persona();
            datos.deletePersona(p);
        }
    }
}
