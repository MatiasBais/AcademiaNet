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
    public partial class InscripcionAlumno2 : Form
    {
        public Entidades.Usuario usuario;
        public Entidades.Materia materia;
        public InscripcionAlumno2(Entidades.Usuario usuario, Entidades.Materia materia)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.materia = materia;
        }

        void loadComisiones()
        {



            Negocio.Curso negocio = new Negocio.Curso();
            List<Entidades.Curso> cursos = negocio.getCursos(materia.ID);

            if(cursos.Count == 0 )
            {
                MessageBox.Show("No hay cursos con cupos disponibles");
                this.Close();
            }

            DataTable dt = new DataTable();
            //id legajo nombre apellido FechaNacimiento Telefono email Plan idEspecialidad Especialidad
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("IDComision", typeof(int));
            dt.Columns.Add("IDMateria", typeof(int));
            dt.Columns.Add("Comision", typeof(string));
            dt.Columns.Add("Cupo", typeof(int));



            foreach (Entidades.Curso curso in cursos)
            {
                DataRow row = dt.NewRow();

                row[0] = curso.ID;
                row[1] = curso.Comision.ID;
                row[2] = curso.Materia.ID;
                row[3] = curso.Comision.Descripcion;
                row[4] = curso.Cupo;

                dt.Rows.Add(row);
            }
            dgvComisiones.DataSource = dt;
            dgvComisiones.Columns[0].Visible = false;
            dgvComisiones.Columns[1].Visible = false;
            dgvComisiones.Columns[2].Visible = false;
        }
        private void InscripcionAlumno2_Load(object sender, EventArgs e)
        {
            loadComisiones();
        }

        private void dgvComisiones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Negocio.AlumnosInscripciones negocio = new Negocio.AlumnosInscripciones();
            Entidades.AlumnosInscripcion alumnosInscripcion = new Entidades.AlumnosInscripcion();
            alumnosInscripcion.Alumno = usuario;
            alumnosInscripcion.Curso = new Entidades.Curso();
            alumnosInscripcion.Curso.ID = Convert.ToInt32(dgvComisiones.Rows[dgvComisiones.SelectedRows[0].Index].Cells[0].Value);
            negocio.addAlumnosInscripcion(alumnosInscripcion);
            this.Close();
        }
    }
}
