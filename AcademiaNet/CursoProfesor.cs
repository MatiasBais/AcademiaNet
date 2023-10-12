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
    public partial class CursoProfesor : Form
    {
        Entidades.Usuario profesor;
        public CursoProfesor(Entidades.Usuario usuario)
        {
            this.profesor = usuario;
            InitializeComponent();
        }

        private void loadCursos()
        {
            Negocio.Curso negocio = new Negocio.Curso();
            List<Entidades.Curso> cursos = negocio.getCursos(profesor, Convert.ToInt32(nupaño.Value));

            DataTable dt = new DataTable();
            dt.Columns.Add("idCurso", typeof(int));
            dt.Columns.Add("Materia", typeof(string));
            dt.Columns.Add("Comision", typeof(string));
            dt.Columns.Add("Curso", typeof(string));

            foreach (Entidades.Curso curso in cursos)
            {
                DataRow row = dt.NewRow();

                row[0] = curso.ID;
                row[1] = curso.Materia.Descripcion;
                row[2] = curso.Comision.Descripcion;
                row[3] = curso.Descripcion;

                dt.Rows.Add(row);
            }

            dgvCursos.DataSource = dt;
            dgvCursos.Columns[0].Visible = false;


        }
        private void CursoProfesor_Load(object sender, EventArgs e)
        {
            loadCursos();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            loadCursos();
        }

        private void dgvCursos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Entidades.Curso curso = new Entidades.Curso();
            Negocio.Curso negocio = new Negocio.Curso();
            curso = negocio.getCurso(Convert.ToInt32(dgvCursos.Rows[dgvCursos.SelectedRows[0].Index].Cells[0].Value));
            InscripcionesPorCurso insc = new InscripcionesPorCurso(curso, profesor);
            insc.Show();

        }
    }
}
