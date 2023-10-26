using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace Datos
{
    public class Persona:Base
    {
       
        public List<Entidades.Persona> getPersonas(string nombre)
        {
            List<Entidades.Persona> list = new List<Entidades.Persona>();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SET DATEFORMAT 'YMD';select nombre, apellido, email, fechaNacimiento, personas.id as 'ID' , direccion, telefono from personas where  (nombre like'" + nombre + "%' or apellido like'"+nombre+"%')", conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Entidades.Persona persona = new Entidades.Persona();
                    persona.Nombre = reader["Nombre"].ToString();
                    persona.Apellido = reader["Apellido"].ToString();
                    persona.Email = reader["email"].ToString();
                    persona.FechaNacimiento = (DateTime)reader["FechaNacimiento"];
                    persona.ID = (int)reader["ID"];
                    persona.Direccion = reader["Direccion"].ToString();
                    persona.Telefono = reader["telefono"].ToString();
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
            string cmdstr = String.Format("SET DATEFORMAT 'YMD';insert into Personas(Nombre, Apellido, FechaNacimiento, Telefono, Direccion, email) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",
                p.Nombre,
                p.Apellido,
                p.FechaNacimiento.ToString("yyyy-MM-dd"),
                p.Telefono,
                p.Direccion,
                p.Email);

            SqlCommand cmd = new SqlCommand(cmdstr, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }



        public void updatePersona(Entidades.Persona p)
        {
            conn.Open();
            string cmdstr = String.Format("SET DATEFORMAT 'YMD';update personas set Nombre = '{0}', Apellido = '{1}', FechaNacimiento = '{2}', Telefono = '{3}', Direccion = '{4}', email = '{5}' where ID = '{6}'",
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

        public void deletePersona(int id)
        {
            conn.Open();
            string cmdstr = String.Format("update personas  set state = 'E' where ID = '{0}'; update usuarios set state= 'E' where idpersona='{0}'",
                id);

            SqlCommand cmd = new SqlCommand(cmdstr, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }


        public Entidades.Persona getPersona(int idPersona)
        {
            Entidades.Persona persona = new Entidades.Persona();
            conn.Open();
            string query = "SET DATEFORMAT 'YMD'; SELECT nombre, apellido, email, fechaNacimiento, direccion, telefono FROM personas WHERE id = @IdPersona";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@IdPersona", idPersona);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    persona.Nombre = reader["nombre"].ToString();
                    persona.Apellido = reader["apellido"].ToString();
                    persona.Email = reader["email"].ToString();
                    persona.FechaNacimiento = (DateTime)reader["fechaNacimiento"];
                    persona.Direccion = reader["direccion"].ToString();
                    persona.Telefono = reader["telefono"].ToString();
                    persona.ID = idPersona; 
                }
            }

            conn.Close();

            return persona;
        }

    }
}
