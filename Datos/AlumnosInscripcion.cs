using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class AlumnosInscripcion : Base
    {
        public void addAlumnosInscripcion(Entidades.AlumnosInscripcion inscripcion)
        {
            conn.Open();
            string query = String.Format("insert into alumnosinscripciones (idalumno, idcurso) " +
                "values ('{0}', '{1}')",
                inscripcion.Alumno.ID,
                inscripcion.Curso.ID);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void updateAlumnosInscripcion(Entidades.AlumnosInscripcion inscripcion)
        {
            conn.Open();
            string query = String.Format("update alumnosinscripciones " +
                "SET condicion = '{0}', " +
                "nota = '{1}' " +
                "where ID = '{2}'",
                inscripcion.Condicion,
                inscripcion.Nota,
                inscripcion.ID);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void deleteAlumnosInscripcion(Entidades.AlumnosInscripcion inscripcion)
        {
            conn.Open();
            string query = String.Format("update alumnosinscripciones set State = 'E' where ID = '{0}'",
                inscripcion.ID);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public List<Entidades.AlumnosInscripcion> getInscripciones(Entidades.Curso curso)
        {
            List<Entidades.AlumnosInscripcion> lista = new List<Entidades.AlumnosInscripcion>();
            conn.Open();
            string query = String.Format("select alumnosinscripciones.id as 'id', idalumno, nombre, apellido, legajo, condicion, nota " +
                "from alumnosinscripciones " +
                "join usuarios on alumnosinscripciones.idAlumno = usuarios.id " +
                "join personas on personas.id = usuarios.idPersona " +
                "where idcurso ='{0}' and alumnosinscripciones.state is null",
                curso.ID);
            SqlCommand cmd = new SqlCommand(query, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Entidades.AlumnosInscripcion inscripcion = new Entidades.AlumnosInscripcion();
                    inscripcion.ID = (int)reader["ID"];
                    inscripcion.Condicion = reader["condicion"].ToString();
                    inscripcion.Nota = (int)(reader["nota"]);

                    inscripcion.Alumno = new Entidades.Usuario();
                    inscripcion.Alumno.Legajo = (int)reader["legajo"];
                    inscripcion.Alumno.ID = (int)reader["idalumno"];

                    inscripcion.Alumno.Persona = new Entidades.Persona();
                    inscripcion.Alumno.Persona.Nombre = reader["nombre"].ToString();
                    inscripcion.Alumno.Persona.Apellido = reader["apellido"].ToString();

                    lista.Add(inscripcion);
                }
            }
            conn.Close();
            return lista;
        }

        public List<Entidades.AlumnosInscripcion> getInscripciones(Entidades.Usuario alumno)
        {
            List<Entidades.AlumnosInscripcion> lista = new List<Entidades.AlumnosInscripcion>();
            conn.Open();
            string query = String.Format("select alumnosinscripciones.id as 'id', condicion, nota, idcurso, añocalendario, cursos.descripcion, añoespecialidad, comisiones.descripcion, materias.descripcion " +
                "from alumnosinscripciones " +
                "join cursos on idcurso = cursos.id " +
                "join comisiones on idcomision = comisiones.id " +
                "join materias on idmateria = materias.id " +
                "where idalumno ='{0}' and alumnosinscripciones.state is null",
                alumno.ID);
            SqlCommand cmd = new SqlCommand(query, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Entidades.AlumnosInscripcion inscripcion = new Entidades.AlumnosInscripcion();
                    inscripcion.ID = (int)reader["ID"];
                    inscripcion.Condicion = reader["condicion"].ToString();
                    inscripcion.Nota = (int)(reader["nota"]);

                    inscripcion.Curso = new Entidades.Curso();
                    inscripcion.Curso.ID = (int)reader["idcurso"];
                    inscripcion.Curso.AnioCalendario = (int)reader["añocalendario"];
                    inscripcion.Curso.Descripcion = reader["cursos.descripcion"].ToString();

                    inscripcion.Curso.Comision = new Entidades.Comision();
                    inscripcion.Curso.Comision.AnioEspecialidad = (int)reader["añoespecialidad"];
                    inscripcion.Curso.Comision.Descripcion = reader["comisiones.descripcion"].ToString();

                    inscripcion.Curso.Materia = new Entidades.Materia();
                    inscripcion.Curso.Materia.Descripcion = reader["materias.descripcion"].ToString();


                    lista.Add(inscripcion);
                }
            }
            conn.Close();
            return lista;
        }

        

    }
}
