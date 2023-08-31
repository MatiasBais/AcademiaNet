using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ModulosUsuario:Base
    {
        public List<Entidades.ModulosUsuario> getPermisos(int id)
        {
            List<Entidades.ModulosUsuario> list = new List<Entidades.ModulosUsuario>();

            string query = String.Format("select modulos.descripcion as 'modulo',modulosusuario.id as 'id', permiteBaja, permiteAlta, permiteConsulta, permiteModificacion, modulos.id as 'idModulo'" +
                " from ModulosUsuario" +
                " join modulos on modulos.id = IDModulo" +
                " where IDTipoUsuario = '{0}' and modulosusuario.state is null", id);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Entidades.Modulo mod = new Entidades.Modulo();
                Entidades.ModulosUsuario permiso = new Entidades.ModulosUsuario();
                mod.Descripcion = reader["modulo"].ToString();
                mod.ID = (int)reader["idModulo"];
                permiso.modulo = mod;
                permiso.ID = (int)reader["id"];
                permiso.Consulta = reader["permiteConsulta"].ToString() == "True" ? true : false;
                permiso.Baja = reader["permiteBaja"].ToString() == "True" ? true : false;
                permiso.Alta = reader["permiteAlta"].ToString() == "True" ? true : false;
                permiso.Modificacion = reader["permiteModificacion"].ToString() == "True" ? true : false;

                list.Add(permiso);


            }

            conn.Close();
            return list;
        }

        public void addPermiso(Entidades.ModulosUsuario permiso , int id)
        {
            string query = String.Format("insert into modulosusuario(idmodulo, idtipousuario, permitealta, permitebaja, permiteconsulta, permitemodificacion) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",
                permiso.modulo.ID,
                id,
                permiso.Alta,
                permiso.Baja,
                permiso.Consulta,
                permiso.Modificacion);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public void updatePermiso(Entidades.ModulosUsuario permiso)
        {
            string query = String.Format("update modulosusuario set permitealta = '{0}', permitebaja = '{1}', permiteconsulta = '{2}', permitemodificacion = '{3}' where id = '{4}'",
                permiso.Alta,
                permiso.Baja,
                permiso.Consulta,
                permiso.Modificacion,
                permiso.ID);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void deletePermiso(int id)
        {
            string query = String.Format("update modulosusuario set state = '{0}' where id='{1}'",
                "E",
                id);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
