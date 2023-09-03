using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Usuario
    {
        public List<Entidades.Usuario> getUsuarios(Entidades.Persona persona)
        {
            Datos.Usuario datos = new Datos.Usuario();
            return datos.getUsuarios(persona);
        }

        public void addUsuario(Entidades.Usuario usuario, Entidades.Persona persona)
        {
            if (usuario.NombreUsuario == "")
                throw new Exception("Falta Nombre de Usuario");
            if (usuario.Clave == "")
                throw new Exception("Falta Clave");
            if (usuario.Legajo == 0)
                throw new Exception("Falta Legajo");
            Datos.Usuario datos = new Datos.Usuario();
            datos.addUsuario(usuario, persona);
        }


        public void deleteUsuario(int id)
        {
            Datos.Usuario datos = new Datos.Usuario();
            datos.deleteUsuario(id);
        }

        public void updateUsuario(Entidades.Usuario usuario)
        {
            if (usuario.NombreUsuario == "")
                throw new Exception("Falta Nombre de Usuario");
            if (usuario.Clave == "")
                throw new Exception("Falta Clave");
            if (usuario.Legajo == 0)
                throw new Exception("Falta Legajo");
            Datos.Usuario datos = new Datos.Usuario();
            datos.updateUsuario(usuario);

        }

        public Boolean validarUsuario(string nombreUsuario, string clave)
        {
            Datos.Usuario datos = new Datos.Usuario();
            return (datos.validarUsuario(nombreUsuario, clave));
        }

        public string getTipoUsuario(string nombreUsuario, string clave)
        {
            Datos.Usuario datos = new Datos.Usuario();

            return (datos.getTipoUsuario(nombreUsuario, clave));
        }
    }
}
