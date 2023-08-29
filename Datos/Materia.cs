using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Materia: Base
    {
        public Entidades.Materia getMateria(int ID)
        {
            Entidades.Materia materia = new Entidades.Materia();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from materias where ID = " + ID, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    materia.ID = (int)reader["ID"];
                    materia.Descripcion = reader["descripcion"].ToString();
                    materia.HSSemanales = (int)reader["HSSemanales"];
                    materia.HSTotales = (int)reader["HSTotales"];
                    int IDPlan = (int)reader["IDPlan"];
                    Plan plan = new Plan();
                    materia.Plan = plan.getPlan(IDPlan);
                }
            }
            conn.Close();
            return materia;
        }

        public List<Entidades.Materia> getMaterias(int IDPlan)
        {
            List<Entidades.Materia> materias = new List<Entidades.Materia>();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from materias where State is null and IDPlan = "+ IDPlan, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Entidades.Materia materia = new Entidades.Materia();
                    materia.ID = (int)reader["ID"];
                    materia.Descripcion = reader["descripcion"].ToString();
                    materia.HSSemanales = (int)reader["HSSemanales"];
                    materia.HSTotales = (int)reader["HSTotales"];
                    Plan plan = new Plan();
                    materia.Plan = plan.getPlan(IDPlan);
                    materias.Add(materia);
                }
            }
            conn.Close();
            return materias;
        }

        public void addMateria(Entidades.Materia materia)
        {
            if (validarMateria(materia, add:true))
            {
                conn.Open();
                String sql = String.Format("insert into materias (descripcion, HSSemanales, HSTotales, IDPlan) values ('" + materia.Descripcion + "','" + materia.HSSemanales.ToString() + "','" + materia.HSTotales.ToString() + "','" + materia.Plan.ID.ToString() + "')");
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void deleteMateria(Entidades.Materia materia)
        {
            conn.Open();
            string cmdstr = String.Format("update Materias set State = 'E' where ID = '{0}'",
                materia.ID.ToString());

            SqlCommand cmd = new SqlCommand(cmdstr, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void updateMateria(Entidades.Materia m)
        {
            if (validarMateria(m))
            {
                conn.Open();
                string cmdstr = String.Format("update materias set Descripcion = '" + m.Descripcion + "', HSSemanales = '" + m.HSSemanales + "', HSTotales = '" + m.HSTotales + "'  where ID =" + m.ID);
                SqlCommand cmd = new SqlCommand(cmdstr, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        private bool validarMateria(Entidades.Materia materia, bool add = false)
        {
            Plan plan = new Plan();
            if(plan.getPlan(materia.Plan.ID) == null && add)
            {
                return false;
            }
            if(materia.HSSemanales <= 0 || materia.HSSemanales>materia.HSTotales)
            {
                return false;
            }
            return true;
        }
    }
}
