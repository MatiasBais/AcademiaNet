using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Plan:Base
    {
        
        public List<Entidades.Plan> getPlanes( int idEspecialidad)
        {
            List<Entidades.Plan> planes = new List<Entidades.Plan>();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from planes where idEspecialidad ="+idEspecialidad, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Entidades.Plan plan = new Entidades.Plan();
                    plan.ID = (int)reader["ID"];
                    plan.Descripcion = reader["descripcion"].ToString();
                    planes.Add(plan);
                }
            }
            conn.Close();
            return planes;

        }
    }
}
