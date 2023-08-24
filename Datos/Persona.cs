using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace Datos
{
    public class Persona:Base
    {
       
        public List<Entidades.Persona> getAlumnos(string nombre)
        {
            List<Entidades.Persona> list = new List<Entidades.Persona>();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SET DATEFORMAT 'YMD';select nombre, apellido, email, legajo, fechaNacimiento, personas.id as 'ID' , direccion, telefono, especialidades.id as 'IDEspecialidad', planes.id as 'IDPlan', planes.descripcion as 'plan', especialidades.descripcion as 'descripcion' from personas join planes on IDPLAN = planes.id join Especialidades on IDESpecialidad = especialidades.ID where tipoPersona ='Alumno' and (nombre like'" + nombre + "%' or apellido like'"+nombre+"%' or legajo like'"+nombre+"%')", conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read()) { 
                    Entidades.Persona persona = new Entidades.Persona();
                    persona.Nombre = reader["Nombre"].ToString();
                    persona.Apellido = reader["Apellido"].ToString();
                    persona.Email = reader["email"].ToString();
                    persona.Legajo = (int)reader["legajo"];
                    persona.FechaNacimiento = (DateTime)reader["FechaNacimiento"];
                    persona.ID = (int)reader["ID"];
                    persona.Direccion = reader["Direccion"].ToString();
                    persona.Telefono = reader["telefono"].ToString();

                    Entidades.Especialidad especialidad = new Entidades.Especialidad();
                    especialidad.ID = (int)reader["IDEspecialidad"];
                    especialidad.Descripcion = reader["Descripcion"].ToString();

                    Entidades.Plan plan = new Entidades.Plan();
                    plan.ID = (int)reader["IDPlan"];
                    plan.Descripcion = reader["plan"].ToString();
                    plan.Especialidad = especialidad;

                    persona.Plan = plan;
                    
                    list.Add(persona);
                }
            }
            conn.Close();

            return list;
        }

        public List<Entidades.Persona> getProfesores(string nombre)
        {
            List<Entidades.Persona> list = new List<Entidades.Persona>();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SET DATEFORMAT 'YMD';select nombre, apellido, email, legajo, fechaNacimiento, personas.id as 'ID' , direccion, telefono from personas where tipoPersona ='Profesor' and (nombre like'" + nombre + "%' or apellido like'"+nombre+"%' or legajo like'"+nombre+"%')", conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Entidades.Persona persona = new Entidades.Persona();
                    persona.Nombre = reader["Nombre"].ToString();
                    persona.Apellido = reader["Apellido"].ToString();
                    persona.Email = reader["email"].ToString();
                    persona.Legajo = (int)reader["legajo"];
                    persona.FechaNacimiento = (DateTime)reader["FechaNacimiento"];
                    persona.ID = (int)reader["ID"];
                    persona.Direccion = reader["Direccion"].ToString();
                    persona.Telefono = reader["telefono"].ToString();
                    persona.TipoPersona = "Profesor";

                    list.Add(persona);
                }
            }
            conn.Close();

            return list;
        }
        public void addAlumno(Entidades.Persona p)
        {
            conn.Open();
            
            //id legajo nombre apellido FechaNacimiento Telefono direccion email idPlan idEspecialidad
            string cmdstr = String.Format("SET DATEFORMAT 'YMD';insert into Personas(Legajo, Nombre, Apellido, FechaNacimiento, Telefono, Direccion, email, idPlan, TipoPersona) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')",
                p.Legajo.ToString(),
                p.Nombre,
                p.Apellido,
                p.FechaNacimiento.ToString("yyyy-MM-dd"),
                p.Telefono,
                p.Direccion,
                p.Email,
                p.Plan.ID.ToString(),
                p.TipoPersona);

            SqlCommand cmd = new SqlCommand(cmdstr,conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void addProfesor(Entidades.Persona p)
        {
            conn.Open();

            //id legajo nombre apellido FechaNacimiento Telefono direccion email idPlan idEspecialidad
            string cmdstr = String.Format("SET DATEFORMAT 'YMD';insert into Personas(Legajo, Nombre, Apellido, FechaNacimiento, Telefono, Direccion, email, TipoPersona) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')",
                p.Legajo.ToString(),
                p.Nombre,
                p.Apellido,
                p.FechaNacimiento.ToString("yyyy-MM-dd"),
                p.Telefono,
                p.Direccion,
                p.Email,
                p.TipoPersona);

            SqlCommand cmd = new SqlCommand(cmdstr, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }


        public void updateAlumno(Entidades.Persona p)
        {
            conn.Open();
            string cmdstr = String.Format("SET DATEFORMAT 'YMD';update personas set Legajo = '{0}', Nombre = '{1}', Apellido = '{2}', FechaNacimiento = '{3}', Telefono = '{4}', Direccion = '{5}', email = '{6}', IDPlan = '{7}' where ID = '{8}'",
                p.Legajo.ToString(),
                p.Nombre,
                p.Apellido,
                p.FechaNacimiento.ToString("yyyy-MM-dd"),
                p.Telefono,
                p.Direccion,
                p.Email,
                p.Plan.ID.ToString(),
                p.ID.ToString());

            SqlCommand cmd = new SqlCommand(cmdstr, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void updateProfesor(Entidades.Persona p)
        {
            conn.Open();
            string cmdstr = String.Format("SET DATEFORMAT 'YMD';update personas set Legajo = '{0}', Nombre = '{1}', Apellido = '{2}', FechaNacimiento = '{3}', Telefono = '{4}', Direccion = '{5}', email = '{6}' where ID = '{7}'",
                p.Legajo.ToString(),
                p.Nombre,
                p.Apellido,
                p.FechaNacimiento.ToString("yyyy-MM-dd"),
                p.Telefono,
                p.Direccion,
                p.Email,
                p.ID.ToString());

            SqlCommand cmd = new SqlCommand(cmdstr, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void deleteAlumno(Entidades.Persona p)
        {
            conn.Open();
            string cmdstr = String.Format("delete from personas where ID = '{0}'",
                p.ID.ToString());

            SqlCommand cmd = new SqlCommand(cmdstr, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void deleteProfesor(Entidades.Persona p)
        {
            conn.Open();
            string cmdstr = String.Format("delete from personas where ID = '{0}'",
                p.ID.ToString());

            SqlCommand cmd = new SqlCommand(cmdstr, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }



    }
}
