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
    public class Modulo:Base
    {
        public List<Entidades.Modulo> getModulos()
        {
            List<Entidades.Modulo> modulos= new List<Entidades.Modulo>();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select ID, Descripcion from modulos where State is null", conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Entidades.Modulo mod = new Entidades.Modulo();
                    mod.ID = (int)reader["ID"];
                    mod.Descripcion = reader["descripcion"].ToString();
                    modulos.Add(mod);
                }
            }
            conn.Close();
            return modulos;
        }

        public void addModulo(Entidades.Modulo modulo)
        {
            conn.Open();
            string query = String.Format("insert into Modulos(Descripcion) values ('{0}')", modulo.Descripcion);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void deleteModulo(int ID)
        {
            conn.Open();
            string cmdstr = String.Format("update modulos set State = 'E' where ID = '{0}'", ID.ToString());
            SqlCommand cmd = new SqlCommand(cmdstr, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void updateModulo(Entidades.Modulo modulo)
        {
            conn.Open();
            string cmdstr = String.Format("update modulos set Descripcion = '{0}' where ID = '{1}'", modulo.Descripcion, modulo.ID.ToString());
            SqlCommand cmd = new SqlCommand(cmdstr, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

        }
    }
}
