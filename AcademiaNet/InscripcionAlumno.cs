using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademiaNet
{
    public partial class InscripcionAlumno : Form
    {
        public Entidades.Usuario usuario;
        public InscripcionAlumno(Entidades.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void loadMaterias()
        {
            Negocio.Materia negocio = new Negocio.Materia();
            List<Entidades.Materia> materias = new List<Entidades.Materia>();
            materias = negocio.getMaterias(usuario.Plan.ID);

            Negocio.AlumnosInscripciones aineg = new Negocio.AlumnosInscripciones();
            List<Entidades.AlumnosInscripcion> inscriptas = new List<Entidades.AlumnosInscripcion>();
            inscriptas = aineg.getInscripciones(usuario);
            List<Entidades.Materia> materiasinsc = new List<Entidades.Materia>();

            foreach(Entidades.AlumnosInscripcion ai in inscriptas)
            {
                materiasinsc.Add(ai.Curso.Materia);
            }

            List<Entidades.Materia> results = materias.Where(f => !materiasinsc.Any(t => t.ID == f.ID)).ToList();

            dgvMaterias.DataSource = results;
            dgvMaterias.Columns[0].Visible = false;
            dgvMaterias.Columns[3].Visible = false;
            dgvMaterias.Columns[4].Visible = false;
            dgvMaterias.Columns[5].Visible = false;
            dgvMaterias.Columns[1].HeaderText = "Descripción";
            dgvMaterias.Columns[2].HeaderText = "Horas Semanales";

        }

        private void InscripcionAlumno_Load(object sender, EventArgs e)
        {
            loadMaterias();
        }

        private void dgvMaterias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Entidades.Materia materia = new Entidades.Materia();
            materia.ID = Convert.ToInt32(dgvMaterias.Rows[dgvMaterias.SelectedRows[0].Index].Cells[0].Value);
            InscripcionAlumno2 insc = new InscripcionAlumno2(usuario, materia);
            insc.ShowDialog();
            loadMaterias();
        }
    }
}
