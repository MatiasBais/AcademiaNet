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
        public Entidades.Plan getPlan(int idPlan)
        {
            Entidades.Plan plan = new Entidades.Plan();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select planes.ID as ID, planes.descripcion, esp.ID as 'IDEspecialidad', esp.descripcion as 'DescripcionEspecialidad'  from planes join especialidades esp on esp.ID = planes.IDEspecialidad where planes.ID =" + idPlan, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    plan.ID = (int)reader["ID"];
                    plan.Descripcion = reader["descripcion"].ToString();
                    Entidades.Especialidad especialidad = new Entidades.Especialidad();
                    especialidad.ID = (int)reader["IDEspecialidad"];
                    especialidad.Descripcion = reader["DescripcionEspecialidad"].ToString();
                    plan.Especialidad = especialidad;
                }
            }
            conn.Close();
            return plan;

        }

        public List<Entidades.Plan> getPlanes( int idEspecialidad)
        {
            List<Entidades.Plan> planes = new List<Entidades.Plan>();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select planes.ID as ID, planes.descripcion, esp.ID as 'IDEspecialidad', esp.descripcion as 'DescripcionEspecialidad'  from planes join especialidades esp on esp.ID = planes.IDEspecialidad where idEspecialidad =" + idEspecialidad, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Entidades.Plan plan = new Entidades.Plan();
                    plan.ID = (int)reader["ID"];
                    plan.Descripcion = reader["descripcion"].ToString();
                    Entidades.Especialidad especialidad = new Entidades.Especialidad();
                    especialidad.ID = (int)reader["IDEspecialidad"];
                    especialidad.Descripcion = reader["DescripcionEspecialidad"].ToString();
                    plan.Especialidad = especialidad;
                    planes.Add(plan);
                }
            }
            conn.Close();
            return planes;

        }
        public List<Entidades.Plan> getPlanes(string desc)
        {
            List<Entidades.Plan> planes = new List<Entidades.Plan>();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select planes.id as 'ID', planes.descripcion as 'descripcion', IDEspecialidad, especialidades.descripcion as 'Especialidad' from planes join Especialidades on especialidades.ID = IDEspecialidad where planes.descripcion like '" + desc+"%'", conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Entidades.Plan plan = new Entidades.Plan();
                    plan.ID = (int)reader["ID"];
                    plan.Descripcion = reader["descripcion"].ToString();
                    Entidades.Especialidad esp = new Entidades.Especialidad();
                    esp.ID = (int)reader["IDEspecialidad"];
                    esp.Descripcion = reader["Especialidad"].ToString();
                    plan.Especialidad = esp;
                    planes.Add(plan);
                }
            }
            conn.Close();
            return planes;

        }

        public void addPlan(Entidades.Plan plan)
        {
            conn.Open();
            string query = String.Format("insert into Planes(Descripcion, IDEspecialidad) values ('{0}','{1}')", plan.Descripcion, plan.Especialidad.ID);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void deletePlan(Entidades.Plan plan)
        {
            conn.Open();
            string cmdstr = String.Format("delete from planes where ID = '{0}'",
                plan.ID.ToString());

            SqlCommand cmd = new SqlCommand(cmdstr, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void updatePlan(Entidades.Plan p)
        {
            conn.Open();
            string cmdstr = String.Format("update planes set Descripcion = '" + p.Descripcion + "', IDEspecialidad = " + p.Especialidad.ID + "  where ID =" + p.ID);
            SqlCommand cmd = new SqlCommand(cmdstr, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
