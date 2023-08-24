using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Persona
    {
        public List<Entidades.Persona> getAlumnos(string nombre)
        {
            Datos.Persona datos = new Datos.Persona();
            return datos.getAlumnos(nombre);
        }

        public List<Entidades.Persona> getProfesores(string nombre)
        {
            Datos.Persona datos = new Datos.Persona();
            return datos.getProfesores(nombre);
        }
        public void addProfesor(Entidades.Persona p)
        {
            if (p.Legajo == 0)
                throw new Exception("Falta Legajo");
            if (p.Nombre == "")
                throw new Exception("Falta Nombre");
            if (p.Apellido == "")
                throw new Exception("Falta Apellido");
            Datos.Persona datos = new Datos.Persona();
            datos.addProfesor(p);

        }
        public void addAlumno(Entidades.Persona p)
        {
            if (p.Legajo == 0)
                throw new Exception("Falta Legajo");
            if (p.Nombre == "")
                throw new Exception("Falta Nombre");
            if (p.Apellido == "")
                throw new Exception("Falta Apellido");
            Datos.Persona datos = new Datos.Persona();
            datos.addAlumno(p);

        }

        public void updateAlumno(Entidades.Persona p)
        {
            if (p.Legajo == 0)
                throw new Exception("Falta Legajo");
            if (p.Nombre == "")
                throw new Exception("Falta Nombre");
            if (p.Apellido == "")
                throw new Exception("Falta Apellido");
            Datos.Persona datos = new Datos.Persona();
            datos.updateAlumno(p);
        }

        public void updateProfesor(Entidades.Persona p)
        {
            if (p.Legajo == 0)
                throw new Exception("Falta Legajo");
            if (p.Nombre == "")
                throw new Exception("Falta Nombre");
            if (p.Apellido == "")
                throw new Exception("Falta Apellido");
            Datos.Persona datos = new Datos.Persona();
            datos.updateProfesor(p);
        }

        public void deleteAlumno(Entidades.Persona p)
        {
            Datos.Persona datos = new Datos.Persona();
            datos.deleteAlumno(p);
        }
        public void deleteProfesor(Entidades.Persona p)
        {
            Datos.Persona datos = new Datos.Persona();
            datos.deleteProfesor(p);
        }
    }
}
