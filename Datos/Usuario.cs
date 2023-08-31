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
            string query = String.Format("select usuarios.ID as 'ID', NombreUsuario, Clave, Habilitado, IDtipoPersona, tipousuarios.descripcion as 'tipo', Legajo, idPersona, idPlan, planes.descripcion as 'plan', idEspecialidad, especialidades.descripcion as 'especialidad' " +
                "from usuarios " +
                "join planes on idPlan = planes.id " +
                "join especialidades on idEspecialidad=especialidades.id " +
                "join tipousuarios on tipousuarios.id = idtipopersona " +
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
                    Entidades.TipoUsuario tipo = new Entidades.TipoUsuario();
                    tipo.ID = (int)reader["IDTipoPersona"];
                    tipo.Descripcion = reader["tipo"].ToString();
                    usuario.tipo = tipo;
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
            string cmdstr = String.Format("SET DATEFORMAT 'YMD';insert into Usuarios(NombreUsuario, Clave, Habilitado, IDTipoPersona, idPersona, Legajo, IDPlan) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')",
                usuario.NombreUsuario,
                usuario.Clave,
                usuario.Habilitado,
                usuario.tipo.ID,
                persona.ID,
                usuario.Legajo,
                usuario.Plan == null ? 0 : usuario.Plan.ID);

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
            string query = String.Format("update usuarios set NombreUsuario = '{0}', Clave = '{1}', Habilitado = '{2}', IDTipoPersona = '{3}', IDPlan = '{4}' " +
                "where ID = '{5}'",
                usuario.NombreUsuario,
                usuario.Clave,
                usuario.Habilitado,
                usuario.tipo.ID,
                usuario.Plan == null ? 0 : usuario.Plan.ID,
                usuario.ID);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public Entidades.Usuario getUsuario(Entidades.Usuario usuario)
        {
            conn.Open();
            string query = String.Format("select clave from usuarios where nombreusuario = '{0}'", usuario.NombreUsuario);
            SqlCommand cmd = new SqlCommand(query, conn);
            usuario.Clave = cmd.ExecuteScalar().ToString();
            return usuario;
        }


    }
}
