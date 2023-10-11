using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DocenteCurso : Base
    {
        public List<Entidades.DocenteCurso> getDocentes(Entidades.Curso curso, string filtro)
        {
            List<Entidades.DocenteCurso> docentes = new List<Entidades.DocenteCurso>();
            conn.Open();

            SqlCommand cmd = new SqlCommand(@"SELECT cargo, nombre, apellido, legajo, usuarios.id as 'docente', docentescursos.id as 'docentecurso'
                                                from docentescursos
                                                join usuarios on iddocente = usuarios.id
                                                join personas on idpersona = personas.id
                                                where idcurso = @IDCurso and (nombre like'" + filtro + "%' or apellido like'"+filtro+"%' or legajo like '"+filtro+"%')"
            , conn);

            cmd.Parameters.AddWithValue("@IDCurso", curso.ID);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Entidades.DocenteCurso docente = new Entidades.DocenteCurso();
                    docente.Cargo = reader["cargo"].ToString();
                    docente.ID = Convert.ToInt32(reader["docentecurso"]);
                    
                    docente.Docente = new Entidades.Usuario();
                    docente.Docente.Legajo = Convert.ToInt32(reader["legajo"]);
                    docente.Docente.ID = Convert.ToInt32(reader["docente"]);

                    docente.Docente.Persona = new Entidades.Persona();
                    docente.Docente.Persona.Nombre = reader["nombre"].ToString();
                    docente.Docente.Persona.Apellido = reader["apellido"].ToString();
                    
                    docentes.Add(docente);
                }
            }
            conn.Close();
            return docentes;
        }

        public List<Entidades.Usuario> getDocentesNo(Entidades.Curso curso, string filtro)
        {
            List<Entidades.Usuario> docentes = new List<Entidades.Usuario>();
            conn.Open();

            SqlCommand cmd = new SqlCommand(@"SELECT nombre, apellido, legajo, usuarios.id as 'docente'
                                                from usuarios
                                                join personas on idpersona = personas.id
                                                where usuarios.idtipopersona = 4 and usuarios.id not in (select iddocente from docentescursos where idcurso = @IDCurso)  and (nombre like'" + filtro + "%' or apellido like'" + filtro + "%' or legajo like '" + filtro + "%')"
            , conn);

            cmd.Parameters.AddWithValue("@IDCurso", curso.ID);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Entidades.Usuario docente = new Entidades.Usuario();

                    docente.Legajo = Convert.ToInt32(reader["legajo"]);
                    docente.ID = Convert.ToInt32(reader["docente"]);

                    docente.Persona = new Entidades.Persona();
                    docente.Persona.Nombre = reader["nombre"].ToString();
                    docente.Persona.Apellido = reader["apellido"].ToString();

                    docentes.Add(docente);
                }
            }
            conn.Close();
            return docentes;
        }

        public void addDocenteCurso(Entidades.DocenteCurso docenteCurso)
        {
            conn.Open();

            string query = "INSERT INTO DocentesCursos (IDDocente, IDCurso, cargo) " +
                "VALUES (@IDDocente, @IDCurso, @Cargo)";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@IDDocente", docenteCurso.Docente.ID);
            cmd.Parameters.AddWithValue("@IDCurso", docenteCurso.Curso.ID);
            cmd.Parameters.AddWithValue("@Cargo", docenteCurso.Cargo);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void removeDocenteCurso(Entidades.DocenteCurso docenteCurso)
        {
            conn.Open();

            string query = "delete from DocentesCursos where IDDocente = @IDDocente and IDCurso = @IDCurso ";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@IDDocente", docenteCurso.Docente.ID);
            cmd.Parameters.AddWithValue("@IDCurso", docenteCurso.Curso.ID);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void updateDocenteCurso(Entidades.DocenteCurso docenteCurso)
        {
            conn.Open();

            string query = "update DocentesCursos set Cargo = 'Auxiliar' where IDCurso = @IDCurso and Cargo='Titular';" +
                "update DocentesCursos set Cargo = @Cargo where IDDocente = @IDDocente and IDCurso = @IDCurso;";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@IDDocente", docenteCurso.Docente.ID);
            cmd.Parameters.AddWithValue("@IDCurso", docenteCurso.Curso.ID);
            cmd.Parameters.AddWithValue("@Cargo", docenteCurso.Cargo);

            cmd.ExecuteNonQuery();
            conn.Close();
        }


    }
}
