using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            if(!IsValidEmail(p.Email))
                throw new Exception("Email invalido");
            Datos.Persona datos = new Datos.Persona();
            datos.addPersona(p);

        }
        static bool IsValidEmail(string email)
        {
            string pattern = @"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }
        public void updatePersona(Entidades.Persona p)
        {
            if (p.Nombre == "")
                throw new Exception("Falta Nombre");
            if (p.Apellido == "")
                throw new Exception("Falta Apellido");
            if (!IsValidEmail(p.Email))
                throw new Exception("Email invalido");
            Datos.Persona datos = new Datos.Persona();
            datos.updatePersona(p);
        }

        public void deletePersona(int id)
        {
            Datos.Usuario u = new Datos.Usuario();
            Entidades.Persona persona = new Entidades.Persona();
            persona.ID=id;
            List<Entidades.Usuario> usuarios = u.getUsuarios(persona);
            if (usuarios.Count > 0)
                throw new Exception("No se puede eliminar la persona porque tiene usuarios.");
            Datos.Persona datos = new Datos.Persona();
            datos.deletePersona(id);
        }
    }
}
