using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademiaNet
{
    public partial class Curso : Form
    {
        private Entidades.Comision comision;
        public Curso(int idComision)
        {
            Negocio.Comision c = new Negocio.Comision();
            comision = c.getComision(idComision);
            InitializeComponent();
        }

        private void Curso_Load(object sender, EventArgs e)
        {
            lblAnio.Text = comision.AnioEspecialidad.ToString();
            lblComision.Text = comision.Descripcion.ToString();
            lblPlan.Text = comision.Plan.Descripcion.ToString();
            load_Materias();
            nudAnio.Value = DateAndTime.Now.Year;


        }

        private void load_Cursos(object sender, EventArgs e)
        {
            List<Entidades.Curso> cursos = new List<Entidades.Curso>();
            Negocio.Curso curso = new Negocio.Curso();
            cursos = curso.getCursos(Convert.ToInt32(nudAnio.Value), comision.ID);
            DataTable dt = new DataTable();

            dt.Columns.Add("Materia", typeof(string));
            dt.Columns.Add("Descripcion", typeof(string));
            dt.Columns.Add("Cupos", typeof(int));
            dt.Columns.Add("IDMateria", typeof(int));
            dt.Columns.Add("ID", typeof(int));

            foreach (Entidades.Curso c in cursos)
            {
                DataRow row = dt.NewRow();

                row[0] = c.Materia.Descripcion;
                row[1] = c.Descripcion;
                row[2] = c.Cupo;
                row[3] = c.Materia.ID;
                row[4] = c.ID;

                dt.Rows.Add(row);
            }
            dgvCursos.DataSource = dt;
            dgvCursos.Columns[3].Visible = false;
            dgvCursos.Columns[4].Visible = false;
        }

        private void load_Materias()
        {
            List<Entidades.Materia> materias = new List<Entidades.Materia>();
            Negocio.Materia materia = new Negocio.Materia();
            materias = materia.getMaterias(comision.Plan.ID);
            DataTable dt = new DataTable();

            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Descripcion", typeof(string));

            foreach (Entidades.Materia m in materias)
            {
                DataRow row = dt.NewRow();

                row[0] = m.ID;
                row[1] = m.Descripcion;

                dt.Rows.Add(row);
            }
            cmbMateria.ValueMember = "ID";
            cmbMateria.DisplayMember = "Descripcion";
            cmbMateria.DataSource = dt;
            clear();
        }
        private void modificar_Curso(int index)
        {
            int ID = Convert.ToInt32(dgvCursos.Rows[index].Cells[3].Value);
            cmbMateria.Text = dgvCursos.Rows[index].Cells[0].Value.ToString();

            Negocio.Curso c = new Negocio.Curso();
            Entidades.Curso curso = c.getCurso(ID, comision.ID);

            if (curso != null)
            {
                txtDescripcion.Text = curso.Descripcion;
                txtCupo.Text = curso.Cupo.ToString();
                btnAgregar.Enabled = false;
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
                btnCancelar.Enabled = true;
            }


        }

        private void agregar_Curso(int index)
        {
            Negocio.Curso c = new Negocio.Curso();
            Entidades.Curso curso = c.getCurso(index, comision.ID);

            if (curso != null)
            {
                txtDescripcion.Text = curso.Descripcion;
                txtCupo.Text = curso.Cupo.ToString();
                btnAgregar.Enabled = false;
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
                btnCancelar.Enabled = true;
            }
            else
            {
                txtDescripcion.Text = String.Empty;
                txtCupo.Text = String.Empty;
                btnAgregar.Enabled = true;
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
                btnCancelar.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbMateria_SelectedValueChanged(object sender, EventArgs e)
        {
            int index = (int)cmbMateria.SelectedValue;
            agregar_Curso(index);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dgvCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvCursos.SelectedCells[0].RowIndex;
            modificar_Curso(index);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Negocio.Curso negocio = new Negocio.Curso();
                Entidades.Curso cur = new Entidades.Curso();
                cur.Descripcion = txtDescripcion.Text;
                cur.AnioCalendario = Convert.ToInt32(nudAnio.Value);
                cur.Cupo = Convert.ToInt32(txtCupo.Text);

                Entidades.Materia mat = new Entidades.Materia();
                mat.ID = (int)cmbMateria.SelectedValue;
                cur.Materia = mat;

                cur.Comision = comision;

                negocio.addCurso(cur);
                load_Materias();
                load_Cursos(sender, e);
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clear()
        {
            txtDescripcion.Text = "";
            txtCupo.Text = "";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Negocio.Curso negocio = new Negocio.Curso();
                Entidades.Curso cur = new Entidades.Curso();
                int index = dgvCursos.SelectedCells[0].RowIndex;
                cur.ID = Convert.ToInt32(dgvCursos.Rows[index].Cells[4].Value);
                cur.Descripcion = txtDescripcion.Text;
                cur.Cupo = Convert.ToInt32(txtCupo.Text);

                negocio.updateCurso(cur);
                load_Materias();
                load_Cursos(sender, e);
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Negocio.Curso negocio = new Negocio.Curso();
            Entidades.Curso cur = new Entidades.Curso();
            int index = dgvCursos.SelectedCells[0].RowIndex;
            cur.ID = Convert.ToInt32(dgvCursos.Rows[index].Cells[4].Value);
            negocio.deleteCurso(cur);
            load_Materias();
            load_Cursos(sender, e);
            clear();

        }


        private void txtCupo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvCursos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void verInscriptosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dgvCursos.SelectedCells[0].RowIndex;
            int ID = Convert.ToInt32(dgvCursos.Rows[index].Cells[3].Value);
            cmbMateria.Text = dgvCursos.Rows[index].Cells[0].Value.ToString();

            Negocio.Curso c = new Negocio.Curso();
            Entidades.Curso curso = c.getCurso(ID, comision.ID);
            InscripcionesPorCurso insc = new InscripcionesPorCurso(curso);
            insc.Show();
        }

        private void profesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dgvCursos.SelectedCells[0].RowIndex;
            int ID = Convert.ToInt32(dgvCursos.Rows[index].Cells[3].Value);
            cmbMateria.Text = dgvCursos.Rows[index].Cells[0].Value.ToString();

            Negocio.Curso c = new Negocio.Curso();
            Entidades.Curso curso = c.getCurso(ID, comision.ID);
            CursoProfesores prof = new CursoProfesores(curso);
            prof.Show();
        }
    }
}
