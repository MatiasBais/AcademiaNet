using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Curso : Base
    {

        public List<Entidades.Curso> getCursos()
        {
            List<Entidades.Curso> cursos = new List<Entidades.Curso>();
            conn.Open();

            SqlCommand cmd = new SqlCommand(@"SELECT ID,
                                               AñoCalendario,
                                               Cupo,
                                               Descripcion,
                                               IDComision, 
                                               IDMateria
                                            FROM cursos
                                            JOIN comisiones ON IDComision = comisiones.ID
                                            JOIN materias ON IDMateria = materia.ID", conn);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Entidades.Curso curso = new Entidades.Curso();
                    curso.ID = (int)reader["ID"];
                    curso.AnioCalendario = (int)reader["AñoCalendario"];
                    curso.Cupo = (int)reader["Cupo"];
                    curso.Descripcion = reader["Descripcion"].ToString();

                    int IDComision = (int)reader["IDComision"];
                    Comision comision = new Comision();
                    curso.Comision = comision.getComision(IDComision);

                    int IDMateria = (int)reader["IDMateria"];
                    Materia materia = new Materia();
                    curso.Materia = materia.getMateria(IDMateria);
                    
                    cursos.Add(curso);
                }
            }
            conn.Close();
            return cursos;
        }

        public List<Entidades.Curso> getCursos(string desc)
        {
            List<Entidades.Curso> cursos = new List<Entidades.Curso>();
            conn.Open();
            
            SqlCommand cmd = new SqlCommand(@"SELECT ID,
                                               AñoCalendario,
                                               Cupo,
                                               Descripcion,
                                               IDComision, 
                                               IDMateria
                                            FROM cursos
                                            JOIN comisiones ON IDComision = comisiones.ID
                                            JOIN materias ON IDMateria = materia.ID WHERE Descripcion LIKE @desc + '%'", conn);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Entidades.Curso curso = new Entidades.Curso();
                    curso.ID = (int)reader["ID"];
                    curso.AnioCalendario = (int)reader["AñoCalendario"];
                    curso.Cupo = (int)reader["Cupo"];
                    curso.Descripcion = reader["Descripcion"].ToString();

                    Entidades.Comision comision = new Entidades.Comision();
                    comision.ID = (int)reader["IDComision"];

                    Entidades.Materia materia = new Entidades.Materia();
                    materia.ID = (int)reader["IDMateria"];
                   
                    curso.Comision = comision;
                    curso.Materia = materia;

                    cursos.Add(curso);
                }
            }
            conn.Close();
            return cursos;
        }

        public void addCurso(Entidades.Curso curso)
        {
            conn.Open();

            string query = "INSERT INTO Cursos (AñoCalendario, Cupo, Descripcion, IDComision, IDMateria) " +
                "VALUES (@AnioCalendario, @Cupo, @Descripcion, @IDComision, @IDMateria)";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@AnioCalendario", curso.AnioCalendario);
            cmd.Parameters.AddWithValue("@Cupo", curso.Cupo);
            cmd.Parameters.AddWithValue("@Descripcion", curso.Descripcion);
            cmd.Parameters.AddWithValue("@IDComision", curso.Comision.ID);
            cmd.Parameters.AddWithValue("@IDMateria", curso.Materia.ID);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void updateCurso(Entidades.Curso curso)
        {
            conn.Open();
            string cmdstr = String.Format("UPDATE Cursos SET añocalendario = '{0}', cupo = '{1}', descripcion = '{2}', " +
                " IDComision = '{3}', IDMateria = '{4}' WHERE ID = '{5}'",
                curso.AnioCalendario.ToString(), curso.Cupo.ToString(), curso.Descripcion, curso.Comision.ID.ToString(),
                curso.Materia.ID.ToString(),curso.ID.ToString());

            SqlCommand cmd = new SqlCommand(cmdstr, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }



        public void deleteCurso(Entidades.Curso curso)
        {
            conn.Open();
            string query = String.Format("delete from Cursos where ID= {0}", curso.ID);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }


    }
}

