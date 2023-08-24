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
            //SqlCommand cmd = new SqlCommand("select id,AñoEspecialidad, Descripcion,IDPlan,especialidades.id as 'IDEspecialidad',planes.id as 'IDPlan', planes.descripcion as 'plan', especialidades.descripcion as 'descripcion' from comisiones join planes on IDPLAN = planes.id join Especialidades on IDESpecialidad = especialidades.ID", conn);

            SqlCommand cmd = new SqlCommand(@"SELECT comisiones.ID,
                                               comisiones.AñoEspecialidad,
                                               comisiones.Descripcion,
                                               comisiones.IDPlan,
                                               especialidades.ID AS 'IDEspecialidad',
                                               planes.ID AS 'IDPlan_Plan',
                                               planes.Descripcion AS 'plan',
                                               especialidades.Descripcion AS 'descripcion_especialidad'
                                            FROM planes
                                            JOIN comisiones ON planes.ID = comisiones.IDPlan
                                            JOIN Especialidades ON especialidades.ID = comisiones.IDESpecialidad
                                            WHERE comisiones.Descripcion", conn);
            
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Entidades.Comision comision = new Entidades.Comision();
                    comision.ID = (int)reader["ID"];
                    comision.AnioEspecialidad = (int)reader["AñoEspecialidad"];
                    comision.Descripcion = reader["Descripcion"].ToString();

                    Entidades.Especialidad especialidad = new Entidades.Especialidad();
                    especialidad.ID = (int)reader["IDEspecialidad"];
                    especialidad.Descripcion = reader["descripcion_especialidad"].ToString();

                    Entidades.Plan plan = new Entidades.Plan();
                    plan.ID = (int)reader["IDPlan_Plan"];
                    plan.Descripcion = reader["plan"].ToString();
                    plan.Especialidad = especialidad;

                    comision.Plan = plan;

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
            SqlCommand cmd = new SqlCommand(@"SELECT comisiones.ID,
                                               comisiones.AñoEspecialidad,
                                               comisiones.Descripcion,
                                               comisiones.IDPlan,
                                               especialidades.ID AS 'IDEspecialidad',
                                               planes.ID AS 'IDPlan_Plan',
                                               planes.Descripcion AS 'plan',
                                               especialidades.Descripcion AS 'descripcion_especialidad'
                                            FROM planes
                                            JOIN comisiones ON planes.ID = comisiones.IDPlan
                                            JOIN Especialidades ON especialidades.ID = planes.IDESpecialidad
                                            WHERE comisiones.Descripcion LIKE @desc + '%'", conn);
            cmd.Parameters.AddWithValue("@desc", desc);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Entidades.Comision comision = new Entidades.Comision();
                    comision.ID = (int)reader["ID"];
                    comision.AnioEspecialidad = (int)reader["AñoEspecialidad"];
                    comision.Descripcion = reader["Descripcion"].ToString();

                    Entidades.Especialidad especialidad = new Entidades.Especialidad();
                    especialidad.ID = (int)reader["IDEspecialidad"];
                    especialidad.Descripcion = reader["descripcion_especialidad"].ToString();

                    Entidades.Plan plan = new Entidades.Plan();
                    plan.ID = (int)reader["IDPlan_Plan"];
                    plan.Descripcion = reader["plan"].ToString();
                    plan.Especialidad = especialidad;

                    comision.Plan = plan;

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
            cmd.Parameters.AddWithValue("@IDPlan", comision.Plan.ID);
            cmd.Parameters.AddWithValue("@AnioEspecialidad", comision.AnioEspecialidad);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void updateComision(Entidades.Comision comision)
        {
            conn.Open();
            Console.WriteLine("hola");
            string cmdstr = String.Format("UPDATE Comisiones SET descripcion = '{0}', IDPlan = '{1}', AñoEspecialidad = '{2}' WHERE ID = '{3}'",
                comision.Descripcion, comision.Plan.ID.ToString(), comision.AnioEspecialidad.ToString(), comision.ID.ToString() );

            SqlCommand cmd = new SqlCommand(cmdstr, conn);
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



         