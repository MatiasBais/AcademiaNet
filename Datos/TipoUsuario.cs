using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class TipoUsuario : Base
    {

        public List<Entidades.TipoUsuario> getTipoUsuarios() {
            List<Entidades.TipoUsuario> list = new List<Entidades.TipoUsuario>();

            string query = "select * from tipoUsuarios";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Entidades.TipoUsuario tipo = new Entidades.TipoUsuario();
                tipo.ID = (int)reader["id"];
                tipo.Descripcion = reader["descripcion"].ToString();
                list.Add(tipo);
            }
            conn.Close();
            return list;
        }
        public int addTipoUsuario(Entidades.TipoUsuario tipo)
        {
            string query = String.Format("insert into tipousuarios(descripcion) OUTPUT INSERTED.ID values ('{0}');", tipo.Descripcion);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int id = (int)cmd.ExecuteScalar();
            conn.Close();
            return id;
        }
    }
}
