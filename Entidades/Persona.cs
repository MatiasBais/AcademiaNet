using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona : Padre
    {

        public string Nombre { get; set; }

        public string Apellido { get; set; }    

        public string Email { get; set; }

        public string Telefono { get; set; }

        public string Direccion { get; set; }

        public DateTime FechaNacimiento  { get; set; }  

        public int Legajo { get; set; }

        public string TipoPersona { get; set; }

        public Plan Plan { get; set; }
    }
}
