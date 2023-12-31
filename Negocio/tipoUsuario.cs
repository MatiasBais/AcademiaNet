﻿using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class tipoUsuario
    {

        public List<Entidades.TipoUsuario> getTipoUsuarios()
        {
            Datos.TipoUsuario datos = new Datos.TipoUsuario();
            List<Entidades.TipoUsuario> tipoUsuarios = datos.getTipoUsuarios();
            return tipoUsuarios;
        }

        public void addTipoUsuario(Entidades.TipoUsuario tipo)
        {
            Datos.TipoUsuario datos = new Datos.TipoUsuario();
            int id = datos.addTipoUsuario(tipo);
            Negocio.ModulosUsuario negocio = new Negocio.ModulosUsuario();
            tipo.ID = id;
            negocio.addPermisos(tipo);
        }

        public void updateTipoUsuario(Entidades.TipoUsuario tipo)
        {
            Datos.TipoUsuario datos = new Datos.TipoUsuario();
            datos.updateTipoUsuario(tipo);
            Negocio.ModulosUsuario negocio = new Negocio.ModulosUsuario();
            negocio.updatePermisos(tipo.permisos);
        }

        public void deleteTipoUsuario(Entidades.TipoUsuario tipo)
        {
            Datos.TipoUsuario datos = new Datos.TipoUsuario();
            datos.deleteTipoUsuario(tipo.ID);
            Negocio.ModulosUsuario negocio = new Negocio.ModulosUsuario();
            negocio.deletePermisos(tipo.permisos);
        }
    }
}
