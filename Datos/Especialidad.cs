using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{
    public class Especialidad : Base
    {
        
        public List<Entidades.Especialidad> getEspecialidades()
        {
            List<Entidades.Especialidad> especialidades = new List<Entidades.Especialidad>();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from especialidades", conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Entidades.Especialidad especialidad = new Entidades.Especialidad();
                    especialidad.ID = (int)reader["ID"];
                    especialidad.Descripcion = reader["descripcion"].ToString();
                    especialidades.Add(especialidad);
                }
            }
            conn.Close();
            return especialidades;
        }

        public Entidades.Especialidad getEspecialidad(int ID)
        {
            Entidades.Especialidad especialidad = new Entidades.Especialidad();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from especialidades where ID = " + ID, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    especialidad.ID = (int)reader["ID"];
                    especialidad.Descripcion = reader["descripcion"].ToString();
                }
            }
            conn.Close();
            return especialidad;
        }
    }
}
