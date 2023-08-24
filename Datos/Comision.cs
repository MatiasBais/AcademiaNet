using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class Comision : Base
    {
        public List<Entidades.Comision> getComisiones()
        {
            List<Entidades.Comision> comisiones = new List<Entidades.Comision>();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from comisiones", conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Entidades.Comision comision = new Entidades.Comision();
                    comision.ID = (int)reader["ID"];
                    comision.IDPlan = (int)reader["IDPlan"];
                    comision.AnioEspecialidad = (int)reader["AñoEspecialidad"];
                    comision.Descripcion = reader["Descripcion"].ToString();

                    comisiones.Add(comision);
                }
            }
            conn.Close();
            return comisiones;
        }

        public List<Entidades.Comision> getComisiones(string desc)
        {
            List<Entidades.Comision> comisiones = new List<Entidades.Comision>();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from comisiones where descripcion like '" + desc + "%'", conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Entidades.Comision comision = new Entidades.Comision();
                    comision.ID = (int)reader["ID"];
                    comision.IDPlan = (int)reader["IDPlan"];
                    comision.AnioEspecialidad = (int)reader["AñoEspecialidad"];
                    comision.Descripcion = reader["Descripcion"].ToString();

                    comisiones.Add(comision);
                }
            }
            conn.Close();
            return comisiones;
        }

        public void addComision(Entidades.Comision comision)
        {
            conn.Open();

            string query = "INSERT INTO Comisiones (Descripcion, IDPlan, AñoEspecialidad) VALUES (@Descripcion, @IDPlan, @AnioEspecialidad)";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@Descripcion", comision.Descripcion);

            if (comision.IDPlan.HasValue)
            {
                cmd.Parameters.AddWithValue("@IDPlan", comision.IDPlan.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@IDPlan", DBNull.Value);
            }

            if (comision.AnioEspecialidad.HasValue)
            {
                cmd.Parameters.AddWithValue("@AnioEspecialidad", comision.AnioEspecialidad.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@AnioEspecialidad", DBNull.Value);
            }

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void updateComision(Entidades.Comision comision)
        {
            conn.Open();
            string query = String.Format("update Comisiones set descripcion = {0}, IDPlan = {1}, AñoEspecialidad = {2} where ID = {3}",
                comision.Descripcion, comision.IDPlan, comision.AnioEspecialidad, comision.ID);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }



        public void deleteComision(Entidades.Comision comision)
        {
            conn.Open();
            string query = String.Format("delete from Comisiones where ID= {0}", comision.ID);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }


    }
}



         