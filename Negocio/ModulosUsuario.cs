﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ModulosUsuario
    {
        public List<Entidades.ModulosUsuario> GetPermisos(int id)
        {
            Datos.ModulosUsuario datos = new Datos.ModulosUsuario();
            return datos.getPermisos(id);  
        }

        public void addPermisos(Entidades.TipoUsuario tipo)
        {
            foreach(Entidades.ModulosUsuario permiso in tipo.permisos)
            {
                Datos.ModulosUsuario datos = new Datos.ModulosUsuario();
                datos.addPermiso(permiso, tipo.ID);
            }
        }

        public void updatePermisos(List<Entidades.ModulosUsuario> permisos)
        {
            foreach (Entidades.ModulosUsuario permiso in permisos)
            {
                Datos.ModulosUsuario datos = new Datos.ModulosUsuario();
                datos.updatePermiso(permiso);
            }
        }
        public void deletePermisos(List<Entidades.ModulosUsuario> permisos)
        {
            foreach (Entidades.ModulosUsuario permiso in permisos)
            {
                Datos.ModulosUsuario datos = new Datos.ModulosUsuario();
                datos.deletePermiso(permiso.ID);
            }
        }
    }
}
