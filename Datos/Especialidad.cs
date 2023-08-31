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

        public Entidades.Especialidad getEspecialidad(int ID)
        {
            Entidades.Especialidad especialidad = new Entidades.Especialidad();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from especialidades where State is null and descripcion != '-' and id = " + ID, conn);
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

        public List<Entidades.Especialidad> getEspecialidades()
        {
            List<Entidades.Especialidad> especialidades = new List<Entidades.Especialidad>();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from especialidades where descripcion != '-' and State is null", conn);
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

        public List<Entidades.Especialidad> getEspecialidades(string desc)
        {
            List<Entidades.Especialidad> especialidades = new List<Entidades.Especialidad>();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from especialidades where descripcion like '" + desc + "%' and descripcion != '-' and State is null", conn);
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

        public void addEspecialidad(Entidades.Especialidad especialidad)
        {
            conn.Open();
            string query = String.Format("insert into Especialidades(Descripcion) values ('{0}')", especialidad.Descripcion);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void updateEspecialidad(Entidades.Especialidad especialidad)
        {
            conn.Open();
            string query = String.Format("update Especialidades set descripcion ='{0}' where ID= {1}", especialidad.Descripcion, especialidad.ID);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void deleteEspecialidad(Entidades.Especialidad especialidad)
        {
            conn.Open();
            string query = String.Format("update Especialidades set State = 'E' where ID= {0}", especialidad.ID);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
