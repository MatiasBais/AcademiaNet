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


        public void deleteUsuario(Entidades.Usuario usuario)
        {
            Datos.Usuario datos = new Datos.Usuario();
            usuario = datos.getUsuario(usuario.ID);
            if (usuario.tipo.Descripcion == "Profesor")
            {
                Datos.Curso datos2 = new Datos.Curso();
                List<Entidades.Curso> cursos = new List<Entidades.Curso>();
                cursos= datos2.getCursos(usuario, DateTime.Now.Year);
                if(cursos.Count > 0)
                    throw new Exception("Debe desvincular al profesor de sus cursos actuales para poder eliminar el usuairo. En los cursos de años anteriores seguirá apareciendo");
            }
            if(usuario.tipo.Descripcion == "Alumno")
            {
                Datos.AlumnosInscripcion datos2 = new Datos.AlumnosInscripcion();
                List<Entidades.AlumnosInscripcion> inscripciones = new List<Entidades.AlumnosInscripcion>();
                inscripciones = datos2.getInscripciones(usuario);
                if (inscripciones.Count > 0)
                    throw new Exception("El alumno no se puede eliminar ya que está anotado en uno o varios cursos. En los cursos de años anteriores seguirá apareciendo");
            }
            datos.deleteUsuario(usuario);
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

        public int validarUsuario(string nombreUsuario, string clave)
        {
            Datos.Usuario datos = new Datos.Usuario();
            return (datos.validarUsuario(nombreUsuario, clave));
        }

        public string getTipoUsuario(int idUsuario)
        {
            Datos.Usuario datos = new Datos.Usuario();

            return (datos.getTipoUsuario(idUsuario));
        }

        public Entidades.Usuario getUsuario(int idUsuario)
        {
            Datos.Usuario datos = new Datos.Usuario();
            return datos.getUsuario(idUsuario);
        }
    }
}
