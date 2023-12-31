﻿using Entidades;
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

        public List<Entidades.TipoUsuario> getTipoUsuarios()
        {
            List<Entidades.TipoUsuario> list = new List<Entidades.TipoUsuario>();

            string query = "select * from tipoUsuarios where state is null";
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

        public void updateTipoUsuario(Entidades.TipoUsuario tipo)
        {
            string query = String.Format("update tipousuarios set descripcion = '{0}' where id={1}",
                tipo.Descripcion,
                tipo.ID);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void deleteTipoUsuario(int id)
        {
            string query = String.Format("update tipousuarios set STATE = '{0}' where id={1}",
                "E",
                id);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public Entidades.TipoUsuario getTipoUsuario(int idUsuario)
        {
            Entidades.TipoUsuario tipoUsuario = new Entidades.TipoUsuario();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from TipoUsuarios where ID = " + idUsuario, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    tipoUsuario.ID = (int)reader["ID"];
                    tipoUsuario.Descripcion = reader["descripcion"].ToString();
                }
            }
            conn.Close();
            return tipoUsuario;
        }
    }
}
