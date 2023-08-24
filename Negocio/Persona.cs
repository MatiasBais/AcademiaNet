using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Persona
    {
        public List<Entidades.Persona> getPersonas(string nombre)
        {
            Datos.Persona datos = new Datos.Persona();
            return datos.getPersonas(nombre);
        }
        public void addPersona(Entidades.Persona p)
        {
            if (p.Nombre == "")
                throw new Exception("Falta Nombre");
            if (p.Apellido == "")
                throw new Exception("Falta Apellido");
            Datos.Persona datos = new Datos.Persona();
            datos.addPersona(p);

        }

        public void updatePersona(Entidades.Persona p)
        {
            if (p.Nombre == "")
                throw new Exception("Falta Nombre");
            if (p.Apellido == "")
                throw new Exception("Falta Apellido");
            Datos.Persona datos = new Datos.Persona();
            datos.updatePersona(p);
        }

        public void deletePersona(int id)
        {
            Datos.Persona datos = new Datos.Persona();
            datos.deletePersona(id);
        }
    }
}
