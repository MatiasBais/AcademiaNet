using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Negocio
{
    public class AlumnosInscripciones
    {
        public List<Entidades.AlumnosInscripcion> getInscripciones(Entidades.Curso curso)
        {
            Datos.AlumnosInscripcion datos = new Datos.AlumnosInscripcion();
            return datos.getInscripciones(curso);
        }

        public void updateInscripcion(Entidades.AlumnosInscripcion inscripcion)
        {
            Datos.AlumnosInscripcion datos = new Datos.AlumnosInscripcion();
            if (inscripcion.Condicion == "Aprobado")
                if (inscripcion.Nota < 4)
                    throw new Exception("La nota minima para aprobado es 4");
            if (inscripcion.Condicion != "Aprobado")
                inscripcion.Nota = 0;
            
            datos.updateAlumnosInscripcion(inscripcion);
        }
    }
}
