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
    public partial class Planes : Form
    {
        public Planes()
        {
            InitializeComponent();
        }

        private void Planes_Load(object sender, EventArgs e)
        {
            loadEspecialidades();
        }

        private void loadEspecialidades()
        {
            Negocio.Especialidad negocio = new Negocio.Especialidad();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Descripcion", typeof(string));
            foreach (Entidades.Especialidad esp in negocio.getEspecialidades())
            {
                DataRow row = dt.NewRow();
                row[0] = esp.ID;
                row[1] = esp.Descripcion;
                dt.Rows.Add(row);
            }
            cmbEspecialidad.ValueMember = "ID";
            cmbEspecialidad.DisplayMember = "Descripcion";
            cmbEspecialidad.DataSource = dt;
        }

        private void loadPlanes()
        {
            Negocio.Plan plan = new Negocio.Plan();
            List<Entidades.Plan> planes = plan.getPlanes((int)cmbEspecialidad.SelectedValue);

            DataTable dt = new DataTable();

            dt.Columns.Add("Descripcion", typeof(string));
            dt.Columns.Add("IDEspecialidad", typeof(int));
            dt.Columns.Add("ID", typeof(int));

            foreach (Entidades.Plan p in planes)
            {
                DataRow row = dt.NewRow();

                row[0] = p.Descripcion;
                row[1] = p.Especialidad.ID;
                row[2] = p.ID;

                dt.Rows.Add(row);
            }
            dgvPlanes.DataSource = dt;
            dgvPlanes.Columns[1].Visible = false;
            dgvPlanes.Columns[2].Visible = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            Entidades.Plan plan = new Entidades.Plan();
            List<Entidades.Plan> planes = new List<Entidades.Plan>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void cmbEspecialidad_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            loadPlanes();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Entidades.Plan plan = new Entidades.Plan();
            plan.Descripcion = txtDescripcion.Text;
            Entidades.Especialidad especialidad = new Entidades.Especialidad();
            especialidad.ID = (int)cmbEspecialidad.SelectedValue;

            plan.Especialidad = especialidad;

            Negocio.Plan p = new Negocio.Plan();
            try
            {
                p.addPlan(plan);

            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            finally
            {
                loadPlanes();
            }

        }

        private void dgvPlanes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvPlanes.SelectedCells[0].RowIndex;

            txtDescripcion.Text = dgvPlanes.Rows[index].Cells[0].Value.ToString();
            cmbEspecialidad.SelectedValue = dgvPlanes.Rows[index].Cells[1].Value;

            btnAgregar.Enabled = false;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
            btnCancelar.Enabled = true;


        }

        private void dgvPlanes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvPlanes.SelectedCells[0].RowIndex;
            int idPlan = (int)dgvPlanes.Rows[index].Cells[2].Value;
            Materias materias = new Materias(idPlan);
            materias.Show();
        }

        public void clear()
        {
            txtDescripcion.Clear();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvPlanes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clear();
            btnAgregar.Enabled = true;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Entidades.Plan plan = new Entidades.Plan();
            plan.Descripcion = txtDescripcion.Text;
            Entidades.Especialidad especialidad = new Entidades.Especialidad();
            especialidad.ID = (int)cmbEspecialidad.SelectedValue;
            int index = dgvPlanes.SelectedCells[0].RowIndex;
            plan.ID = (int)dgvPlanes.Rows[index].Cells[2].Value;

            plan.Especialidad = especialidad;

            Negocio.Plan p = new Negocio.Plan();
            try
            {
                p.updatePlan(plan);
                clear();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            finally
            {
                loadPlanes();
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Negocio.Plan plan = new Negocio.Plan();
            int index = dgvPlanes.SelectedCells[0].RowIndex;
            Entidades.Plan plann = new Entidades.Plan();
            plann.ID = (int)dgvPlanes.Rows[index].Cells[2].Value;
            try
            {
                plan.deletePlan(plann);
                clear();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            finally
            {
                loadPlanes();
            }
        }
    }
}
