using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Modulo
    {
        public List<Entidades.Modulo> getModulos()
        {
            Datos.Modulo p = new Datos.Modulo();
            return p.getModulos();
        }

        public void addModulo(Entidades.Modulo modulo)
        {
            Datos.Modulo p = new Datos.Modulo();
            p.addModulo(modulo);
        }

        public void updateModulo(Entidades.Modulo modulo)
        {
            if (modulo.Descripcion == "")
                throw (new Exception("Falta descripción"));
            Datos.Modulo m = new Datos.Modulo();
            m.updateModulo(modulo);
        }

        public void deleteModulo(int ID)
        {
            Datos.Modulo m = new Datos.Modulo();
            m.deleteModulo(ID);
        }
    }
}
