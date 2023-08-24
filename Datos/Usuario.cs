using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Usuario : Base
    {
        public List<Entidades.Usuario> getUsuarios(Entidades.Persona p) {

            conn.Open();
            string query = String.Format("select usuarios.ID as 'ID', NombreUsuario, Clave, Habilitado, tipoPersona, Legajo, idPersona, idPlan, planes.descripcion as 'plan', idEspecialidad, especialidades.descripcion as 'especialidad' " +
                "from usuarios " +
                "join planes on idPlan = planes.id " +
                "join especialidades on idEspecialidad=especialidades.id " +
                "where idPersona = {0}",
                p.ID);
            
            SqlCommand cmd = new SqlCommand(query, conn);
            List<Entidades.Usuario> list = new List<Entidades.Usuario>();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Entidades.Usuario usuario = new Entidades.Usuario();
                    usuario.ID = (int)reader["ID"];
                    usuario.NombreUsuario = reader["NombreUsuario"].ToString();
                    usuario.Clave = reader["Clave"].ToString();
                    usuario.Habilitado = reader["Habilitado"].ToString();
                    usuario.TipoPersona = reader["tipoPersona"].ToString();
                    usuario.Legajo = (int)reader["Legajo"];

                    Entidades.Plan plan = new Entidades.Plan();
                    plan.ID = (int)reader["IDPlan"];
                    plan.Descripcion = reader["Plan"].ToString();

                    Entidades.Especialidad especialidad = new Entidades.Especialidad();
                    especialidad.ID = (int)reader["IDEspecialidad"];
                    especialidad.Descripcion = reader["Especialidad"].ToString();

                    plan.Especialidad = especialidad;

                    usuario.Plan = plan;

                    list.Add(usuario);

                }
            }
            conn.Close();

            return list;


        }

        public void addUsuario(Entidades.Usuario usuario, Entidades.Persona persona)
        {
            conn.Open();

            //id legajo nombre apellido FechaNacimiento Telefono direccion email idPlan idEspecialidad
            string cmdstr = String.Format("SET DATEFORMAT 'YMD';insert into Usuarios(NombreUsuario, Clave, Habilitado, TipoPersona, idPersona, Legajo, IDPlan, State) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')",
                usuario.NombreUsuario,
                usuario.Clave,
                usuario.Habilitado,
                usuario.TipoPersona,
                persona.ID,
                usuario.Legajo,
                usuario.Plan.ID,
                usuario.State);

            SqlCommand cmd = new SqlCommand(cmdstr, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void deleteUsuario(int id)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from usuarios where ID=" + id, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void updateUsuario(Entidades.Usuario usuario)
        {
            conn.Open();
            string query = String.Format("update usuarios set NombreUsuario = '{0}', Clave = '{1}', Habilitado = '{2}', TipoPersona = '{3}', IDPlan = '{4}' " +
                "where ID = '{5}'",
                usuario.NombreUsuario,
                usuario.Clave,
                usuario.Habilitado,
                usuario.TipoPersona,
                usuario.Plan.ID,
                usuario.ID);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

        }

    }
}
