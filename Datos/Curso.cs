using Entidades;
using Microsoft.VisualBasic;
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
        public Entidades.Curso getCurso(int IDMateria, int IDComision)
        {
            Entidades.Curso curso = null;
            conn.Open();

            SqlCommand cmd = new SqlCommand(@"SELECT cursos.ID,
                                    AñoCalendario,
                                    Cupo,
                                    cursos.Descripcion,
                                    IDComision, 
                                    IDMateria
                                 FROM cursos
                                 JOIN comisiones ON IDComision = comisiones.ID
                                 JOIN materias ON IDMateria = materias.ID 
                                 WHERE Cursos.State IS NULL AND IDMateria = @IDMateria AND IDComision = @IDComision;", conn);

            cmd.Parameters.AddWithValue("@IDMateria", IDMateria);
            cmd.Parameters.AddWithValue("@IDComision", IDComision);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    curso = new Entidades.Curso();
                    curso.ID = (int)reader["ID"];
                    curso.AnioCalendario = (int)reader["AñoCalendario"];
                    curso.Cupo = (int)reader["Cupo"];
                    curso.Descripcion = reader["Descripcion"].ToString();

                    Comision comision = new Comision();
                    curso.Comision = comision.getComision(IDComision);

                    Materia materia = new Materia();
                    curso.Materia = materia.getMateria(IDMateria);
                }
            }
            conn.Close();
            return curso;
        }

        public Entidades.Curso getCurso(int IDCurso)
        {
            Entidades.Curso curso = null;
            conn.Open();

            SqlCommand cmd = new SqlCommand(@"SELECT cursos.ID,
                                    AñoCalendario,
                                    Cupo,
                                    cursos.Descripcion,
                                    IDComision, 
                                    IDMateria
                                 FROM cursos
                                 JOIN comisiones ON IDComision = comisiones.ID
                                 JOIN materias ON IDMateria = materias.ID 
                                 WHERE Cursos.State IS NULL AND cursos.id = @IDCurso", conn);

            cmd.Parameters.AddWithValue("@IDCurso", IDCurso);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    curso = new Entidades.Curso();
                    curso.ID = (int)reader["ID"];
                    curso.AnioCalendario = (int)reader["AñoCalendario"];
                    curso.Cupo = (int)reader["Cupo"];
                    curso.Descripcion = reader["Descripcion"].ToString();

                    Comision comision = new Comision();
                    curso.Comision = comision.getComision((int)reader["IDComision"]);

                    Materia materia = new Materia();
                    curso.Materia = materia.getMateria((int)reader["IDMateria"]);
                }
            }
            conn.Close();
            return curso;
        }
        public List<Entidades.Curso> getCursos(int IDMateria)
        {
            List<Entidades.Curso> cursos = new List<Entidades.Curso> ();
            conn.Open();

            SqlCommand cmd = new SqlCommand(@"SELECT cursos.ID,
                                    AñoCalendario,
                                    Cupo,
                                    cursos.Descripcion as 'curso',
                                    IDComision, 
                                    IDMateria,
                                    comisiones.Descripcion as 'comision',
                                    (select count(*) from alumnosinscripciones where idcurso = cursos.id) as 'cupo2'
                                 FROM cursos
                                 JOIN comisiones ON IDComision = comisiones.ID
                                 JOIN materias ON IDMateria = materias.ID 
                                 WHERE Cursos.State IS NULL AND IDMateria = @IDMateria", conn);

            cmd.Parameters.AddWithValue("@IDMateria", IDMateria);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (Convert.ToInt32(reader["cupo"]) > Convert.ToInt32(reader["cupo2"]))
                    {
                        
                        Entidades.Curso curso = new Entidades.Curso();
                        curso = new Entidades.Curso();
                        curso.ID = (int)reader["ID"];
                        curso.AnioCalendario = (int)reader["AñoCalendario"];
                        curso.Cupo = (int)reader["Cupo"];
                        curso.Descripcion = reader["curso"].ToString();

                        curso.Comision = new Entidades.Comision();
                        curso.Comision.ID = (int)reader["IDComision"];
                        curso.Comision.Descripcion = reader["comision"].ToString();

                        Materia materia = new Materia();
                        curso.Materia = materia.getMateria(IDMateria);
                        cursos.Add(curso);
                    }
                }
            }
            conn.Close();
            return cursos;
        }

        public List<Entidades.Curso> getCursos(int anio, int com)
        {
            List<Entidades.Curso> cursos = new List<Entidades.Curso>();
            conn.Open();

            SqlCommand cmd = new SqlCommand(@"SELECT cursos.ID,
                                               AñoCalendario,
                                               Cupo,
                                               cursos.Descripcion,
                                               IDComision, 
                                               IDMateria
                                            FROM cursos
                                            JOIN comisiones ON IDComision = comisiones.ID
                                            JOIN materias ON IDMateria = materias.ID where Cursos.State is null and AñoCalendario = '"+ anio +"' and IDComision = '" + com + "';", conn);

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

        public List<Entidades.Curso> getCursos()
        {
            List<Entidades.Curso> cursos = new List<Entidades.Curso>();
            conn.Open();

            SqlCommand cmd = new SqlCommand(@"SELECT cursos.ID,
                                               AñoCalendario,
                                               Cupo,
                                               cursos.Descripcion,
                                               IDComision, 
                                               IDMateria
                                            FROM cursos
                                            JOIN comisiones ON IDComision = comisiones.ID
                                            JOIN materias ON IDMateria = materias.ID where Cursos.State is null", conn);

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

        public List<Entidades.Curso> getCursos(Entidades.Usuario profesor, int año)
        {
            List<Entidades.Curso> cursos = new List<Entidades.Curso>();
            conn.Open();

            SqlCommand cmd = new SqlCommand(@"SELECT cursos.ID,
                                               AñoCalendario,
                                               Cupo,
                                               cursos.Descripcion,
                                               IDComision, 
                                               IDMateria
                                            FROM cursos
                                            JOIN comisiones ON IDComision = comisiones.ID
                                            JOIN materias ON IDMateria = materias.ID 
                                            JOIN Docentescursos on IDCurso = cursos.ID 
                                            where Cursos.State is null and idDocente = "+profesor.ID + " and AñoCalendario = "+año, conn);

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
                                            JOIN materias ON IDMateria = materia.ID WHERE Cursos.State is null and Descripcion LIKE @desc + '%'", conn);

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
            string cmdstr = String.Format("UPDATE Cursos SET  cupo = '{0}', descripcion = '{1}' " +
                "  WHERE ID = '{2}'",
                curso.Cupo.ToString(), curso.Descripcion, curso.ID.ToString());

            SqlCommand cmd = new SqlCommand(cmdstr, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }



        public void deleteCurso(Entidades.Curso curso)
        {
            conn.Open();
            string query = String.Format("update Cursos set State = 'E' where ID= {0}", curso.ID);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }


    }
}

