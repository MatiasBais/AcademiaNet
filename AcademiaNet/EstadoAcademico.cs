using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademiaNet
{
    public partial class EstadoAcademico : Form
    {

        private Entidades.Usuario usuario;
        public EstadoAcademico(int idUsuario)
        {
            Negocio.Usuario u = new Negocio.Usuario();
            usuario = u.getUsuario(idUsuario);
            InitializeComponent();
        }

        private void EstadoAcademico_Load(object sender, EventArgs e)
        {
            string datos = usuario.Persona.Nombre + " " + usuario.Persona.Apellido + " Legajo:   " + usuario.Legajo;
            label2.Text = datos;
            load_EstadoAcademico(sender, e);
        }

        private void load_EstadoAcademico(object sender, EventArgs e)
        {
            List<Entidades.AlumnosInscripcion> inscripciones = new List<Entidades.AlumnosInscripcion>();
            Negocio.AlumnosInscripciones alumnosInscripcion = new Negocio.AlumnosInscripciones();
            inscripciones = alumnosInscripcion.getInscripciones(usuario);

            DataTable dt = new DataTable();

            dt.Columns.Add("Año", typeof(string));
            dt.Columns.Add("Materia", typeof(string));
            dt.Columns.Add("Estado", typeof(string));
            dt.Columns.Add("Nota", typeof(string));
            dt.Columns.Add("Plan", typeof(string));


            foreach (Entidades.AlumnosInscripcion ai in inscripciones)
            {
                DataRow row = dt.NewRow();

                row[0] = ai.Curso.Comision.AnioEspecialidad;
                row[1] = ai.Curso.Materia.Descripcion;
                row[2] = ai.Condicion;
                row[3] = ai.Nota ==0 ? '-' : ai.Nota.ToString();
                row[4] = usuario.Plan.Descripcion;

                dt.Rows.Add(row);
            }
            dgvEstadoAcademico.DataSource = dt;
      
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
