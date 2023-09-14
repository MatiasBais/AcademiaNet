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
    public partial class InscripcionesPorCurso : Form
    {
        public InscripcionesPorCurso()
        {
            InitializeComponent();
        }

        public void loadInscripciones()
        {
            Negocio.AlumnosInscripciones negocio = new Negocio.AlumnosInscripciones();
            Entidades.Curso curso = new Entidades.Curso();
            curso.ID = 1;
            List<Entidades.AlumnosInscripcion> inscripciones = negocio.getInscripciones(curso);

            DataTable dt = new DataTable();
            //id legajo nombre apellido FechaNacimiento Telefono email Plan idEspecialidad Especialidad
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Apellido", typeof(string));
            dt.Columns.Add("Legajo", typeof(string));
            dt.Columns.Add("Condición", typeof(string));
            dt.Columns.Add("Nota", typeof(int));



            foreach (Entidades.AlumnosInscripcion inscripcion in inscripciones)
            {
                DataRow row = dt.NewRow();

                row[0] = inscripcion.ID;
                row[1] = inscripcion.Alumno.Persona.Nombre;
                row[2] = inscripcion.Alumno.Persona.Apellido;
                row[3] = inscripcion.Alumno.Legajo;
                row[4] = inscripcion.Condicion;
                row[5] = inscripcion.Nota;

                dt.Rows.Add(row);
            }
            dgvInscripciones.DataSource = dt;
            dgvInscripciones.Columns[0].Visible = false;


        }

        private void InscripcionesPorCurso_Load(object sender, EventArgs e)
        {
            loadInscripciones();
            cbxCondicion.SelectedIndex = 0;
        }

        int ID = 0;

        private void dgvInscripciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvInscripciones.SelectedRows[0].Index;
            ID = (int)dgvInscripciones.Rows[index].Cells[0].Value;
            nudNota.Value = (int)dgvInscripciones.Rows[index].Cells[5].Value;
            if (dgvInscripciones.Rows[index].Cells[4].Value.ToString() == "Inscripto")
                cbxCondicion.SelectedIndex = 0;
            else if (dgvInscripciones.Rows[index].Cells[4].Value.ToString() == "Regular")
                cbxCondicion.SelectedIndex = 1;
            else
                cbxCondicion.SelectedIndex = 2;
            btnAceptar.Enabled = true;
            btnCancelar.Enabled = true;
            cbxCondicion.Enabled = true;

        }

        private void clear()
        {
            nudNota.Value = 0;
            cbxCondicion.SelectedIndex = 0;
            btnAceptar.Enabled = false;
            btnCancelar.Enabled = false;
            nudNota.Enabled = false;
            cbxCondicion.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Entidades.AlumnosInscripcion inscripcion = new Entidades.AlumnosInscripcion();
                inscripcion.ID = ID;
                inscripcion.Nota = Convert.ToInt32(nudNota.Value);
                inscripcion.Condicion = cbxCondicion.Text;
                Negocio.AlumnosInscripciones negocio = new Negocio.AlumnosInscripciones();
                negocio.updateInscripcion(inscripcion);
                clear();
                loadInscripciones();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void cbxCondicion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCondicion.Text == "Aprobado")
                nudNota.Enabled = true;
            else
                nudNota.Value = 0;
        }
    }
}
