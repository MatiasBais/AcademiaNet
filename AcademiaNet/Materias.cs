using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AcademiaNet
{
    public partial class Materias : Form
    {
        private Entidades.Plan plan;
        public Materias(int idPlan)
        {
            InitializeComponent();
            Negocio.Plan p = new Negocio.Plan();
            plan = p.getPlan(idPlan);
        }

        private void loadPlan()
        {
            lblPlan.Text = plan.Descripcion;
            lblEspecialidad.Text = plan.Especialidad.Descripcion;

            Negocio.Materia materia = new Negocio.Materia();
            List<Entidades.Materia> materias = materia.getMaterias(plan.ID);

            DataTable dt = new DataTable();

            dt.Columns.Add("Descripcion", typeof(string));
            dt.Columns.Add("Horas Semanales", typeof(int));
            dt.Columns.Add("Horas Totales", typeof(int));
            dt.Columns.Add("ID", typeof(int));

            foreach (Entidades.Materia m in materias)
            {
                DataRow row = dt.NewRow();

                row[0] = m.Descripcion;
                row[1] = m.HSSemanales;
                row[2] = m.HSTotales;
                row[3] = m.ID;

                dt.Rows.Add(row);
            }
            dgvMaterias.DataSource = dt;
            dgvMaterias.Columns[3].Visible = false;
        }
        private void Materias_Load(object sender, EventArgs e)
        {
            loadPlan();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblHSSemanales_Click(object sender, EventArgs e)
        {

        }

        private void txtHSSemanales_TextChanged(object sender, EventArgs e)
        {
        }

        private void dgvMaterias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvMaterias.SelectedCells[0].RowIndex;

            txtDescripcion.Text = dgvMaterias.Rows[index].Cells[0].Value.ToString();
            txtHSSemanales.Text = dgvMaterias.Rows[index].Cells[1].Value.ToString();
            txtHSTotales.Text = dgvMaterias.Rows[index].Cells[2].Value.ToString();

            btnAgregar.Enabled = false;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
            btnCancelar.Enabled = true;
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Entidades.Materia materia = new Entidades.Materia();
            materia.Descripcion = txtDescripcion.Text;
            materia.HSSemanales = Convert.ToInt32(txtHSSemanales.Text);
            materia.HSTotales = Convert.ToInt32(txtHSTotales.Text);
            materia.Plan = plan;
            Negocio.Materia negocio = new Negocio.Materia();
            try
            {
                negocio.addMateria(materia);
                clear();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            finally
            {
                loadPlan();
            }
        }

        private void clear()
        {
            txtDescripcion.Clear();
            txtHSTotales.Text = "0";
            txtHSSemanales.Text = "0";
            btnAgregar.Enabled = true;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Negocio.Materia materia = new Negocio.Materia();
            int index = dgvMaterias.SelectedCells[0].RowIndex;
            materia.deleteMateria((int)dgvMaterias.Rows[index].Cells[3].Value);
            clear();
            loadPlan();


        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Entidades.Materia materia = new Entidades.Materia();
            int index = dgvMaterias.SelectedCells[0].RowIndex;
            materia.ID = (int)dgvMaterias.Rows[index].Cells[3].Value;
            materia.Descripcion = txtDescripcion.Text;
            materia.HSSemanales = Convert.ToInt32(txtHSSemanales.Text);
            materia.HSTotales = Convert.ToInt32(txtHSTotales.Text);
            materia.Plan = plan;

            Negocio.Materia m = new Negocio.Materia();
            try
            {
                m.updateMateria(materia);
                clear();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                loadPlan();
            }
        }

        private void txtHSSemanales_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtHSTotales_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtHSTotales_Leave(object sender, EventArgs e)
        {
            txtHSTotales.Text = txtHSTotales.Text == "" ? "0" : txtHSTotales.Text;
        }

        private void txtHSSemanales_Leave(object sender, EventArgs e)
        {
            txtHSSemanales.Text = txtHSSemanales.Text == "" ? "0" : txtHSSemanales.Text;
        }
    }
}
