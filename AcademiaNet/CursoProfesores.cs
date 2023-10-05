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
    public partial class CursoProfesores : Form
    {
        Entidades.Curso curso;
        public CursoProfesores(Entidades.Curso curso)
        {
            InitializeComponent();
            this.curso = curso;
        }

        private void loadProfesores()
        {
            Negocio.DocentesCurso negocio = new Negocio.DocentesCurso();
            List<Entidades.Usuario> docentesno = negocio.getDocentesNo(curso, txtProf.Text);
            List<Entidades.DocenteCurso> docentes = negocio.getDocentes(curso, txtProfCurso.Text);

            DataTable dt = new DataTable();
            dt.Columns.Add("docente", typeof(int));
            dt.Columns.Add("docentecurso", typeof(int));
            dt.Columns.Add("Legajo", typeof(int));
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Cargo", typeof(string));



            foreach (Entidades.DocenteCurso docente in docentes)
            {
                DataRow row = dt.NewRow();

                row[0] = docente.Docente.ID;
                row[1] = docente.ID;
                row[2] = docente.Docente.Legajo;
                row[3] = docente.Docente.Persona.Apellido + ", " + docente.Docente.Persona.Nombre;
                row[4] = docente.Cargo;

                dt.Rows.Add(row);
            }
            dgvProfCurso.DataSource = dt;
            dgvProfCurso.Columns[0].Visible = false;
            dgvProfCurso.Columns[1].Visible = false;

            dt = new DataTable();
            dt.Columns.Add("docente", typeof(int));
            dt.Columns.Add("Legajo", typeof(int));
            dt.Columns.Add("Nombre", typeof(string));



            foreach (Entidades.Usuario docente in docentesno)
            {
                DataRow row = dt.NewRow();

                row[0] = docente.ID;
                row[1] = docente.Legajo;
                row[2] = docente.Persona.Apellido + ", " + docente.Persona.Nombre;

                dt.Rows.Add(row);
            }
            dgvProf.DataSource = dt;
            dgvProf.Columns[0].Visible = false;


        }
        private void CursoProfesores_Load(object sender, EventArgs e)
        {
            loadProfesores();
            label1.Text = curso.Descripcion + " - " + curso.Materia.Descripcion + " - " + curso.Comision.Descripcion;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (dgvProf.SelectedRows.Count.ToString() == 1.ToString())
            {
                Entidades.DocenteCurso docenteCurso = new Entidades.DocenteCurso();
                docenteCurso.Curso = curso;
                docenteCurso.Docente = new Entidades.Usuario();
                docenteCurso.Docente.ID = Convert.ToInt32(dgvProf.Rows[dgvProf.SelectedRows[0].Index].Cells[0].Value);
                docenteCurso.Cargo = "Auxiliar";
                Negocio.DocentesCurso negocio = new Negocio.DocentesCurso();
                negocio.addDocenteCurso(docenteCurso);

                loadProfesores();

            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvProfCurso.SelectedRows.Count.ToString() == 1.ToString())
            {
                Entidades.DocenteCurso docenteCurso = new Entidades.DocenteCurso();
                docenteCurso.Curso = curso;
                docenteCurso.Docente = new Entidades.Usuario();
                docenteCurso.Docente.ID = Convert.ToInt32(dgvProfCurso.Rows[dgvProfCurso.SelectedRows[0].Index].Cells[0].Value);

                Negocio.DocentesCurso negocio = new Negocio.DocentesCurso();
                negocio.removeDocenteCurso(docenteCurso);

                loadProfesores();

            }

        }

        private void dgvProfCurso_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProfCurso.SelectedRows.Count.ToString() == 1.ToString())
            {
                Entidades.DocenteCurso docenteCurso = new Entidades.DocenteCurso();
                docenteCurso.Curso = curso;
                docenteCurso.Docente = new Entidades.Usuario();
                docenteCurso.Docente.ID = Convert.ToInt32(dgvProfCurso.Rows[dgvProfCurso.SelectedRows[0].Index].Cells[0].Value);
                if (dgvProfCurso.Rows[dgvProfCurso.SelectedRows[0].Index].Cells[4].Value.ToString() == "Auxiliar")
                    docenteCurso.Cargo = "Titular";
                else
                    docenteCurso.Cargo = "Auxiliar";
                Negocio.DocentesCurso negocio = new Negocio.DocentesCurso();
                negocio.updateDocenteCurso(docenteCurso);

                loadProfesores();

            }
        }

        private void txtProf_TextChanged(object sender, EventArgs e)
        {
            loadProfesores();
        }

        private void txtProfCurso_TextChanged(object sender, EventArgs e)
        {
            loadProfesores();
        }
    }
}
