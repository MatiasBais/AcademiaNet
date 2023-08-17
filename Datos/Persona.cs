using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace Datos
{
    public class Persona
    {
        SqlConnection conn = new SqlConnection("Server=MATIASLAPTOP\\SQLEXPRESS;Database=academia;Trusted_Connection=True;");
        public List<Entidades.Persona> getAlumnos()
        {
            List<Entidades.Persona> list = new List<Entidades.Persona>();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SET DATEFORMAT 'YMD';select nombre, apellido, email, legajo, fechaNacimiento, personas.id as 'ID' , direccion, telefono, especialidades.id as 'IDEspecialidad', planes.id as 'IDPlan', planes.descripcion as 'plan', especialidades.descripcion as 'descripcion' from personas join planes on IDPLAN = planes.id join Especialidades on IDESpecialidad = especialidades.ID where tipoPersona ='Alumno'", conn);
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

        public void addPersona(Entidades.Persona p)
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

        public void updatePersona(Entidades.Persona p)
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

        public void deletePersona(Entidades.Persona p)
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
