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
    public partial class Plan : Form
    {
        public Plan()
        {
            InitializeComponent();
        }

        private void clear()
        {
            txtDescripción.Text = "";
        }

        void loadPlanes()
        {
            Negocio.Plan negocio = new Negocio.Plan();
            List<Entidades.Plan> list = negocio.getPlanes(txtBuscar.Text);

            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Descripcion", typeof(string));
            dt.Columns.Add("IDEspecialidad", typeof(int));
            dt.Columns.Add("Especialidad", typeof(string));

            foreach (Entidades.Plan plan in list)
            {
                DataRow row = dt.NewRow();

                row[0] = plan.ID;
                row[1] = plan.Descripcion;
                row[2] = plan.Especialidad.ID;
                row[3] = plan.Especialidad.Descripcion;

                dt.Rows.Add(row);
            }

            dgvPlanes.DataSource = dt;
            dgvPlanes.Columns[0].Visible = false;
            dgvPlanes.Columns[2].Visible = false;
        }

        void loadEspecialidades()
        {
            Negocio.Especialidad negocio = new Negocio.Especialidad();
            cmbEspecialidad.DataSource = negocio.getEspecialidades();
            cmbEspecialidad.ValueMember = "ID";
            cmbEspecialidad.DisplayMember = "Descripcion";
        }
        private void Plan_Load(object sender, EventArgs e)
        {
            loadPlanes();
            loadEspecialidades();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            loadPlanes();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try { 

                Entidades.Plan plan = new Entidades.Plan();
                Negocio.Plan negocio = new Negocio.Plan();
                Entidades.Especialidad esp = new Entidades.Especialidad();

                plan.Descripcion = txtDescripción.Text;
                esp.ID = (int)cmbEspecialidad.SelectedValue;
                plan.Especialidad = esp;
                
                negocio.addPlan(plan);
                loadPlanes();

                clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clear();
            btnAgregar.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        int ID = 0;

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try { 
                Entidades.Plan plan = new Entidades.Plan();
                Entidades.Especialidad esp = new Entidades.Especialidad();
                Negocio.Plan negocio = new Negocio.Plan();

                plan.ID = ID;
                plan.Descripcion = txtDescripción.Text;
                esp.ID = (int)cmbEspecialidad.SelectedValue;
                plan.Especialidad = esp;

                negocio.updatePlan(plan);

                clear();
                btnAgregar.Enabled = true;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                btnCancelar.Enabled = false;
                loadPlanes();
            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Entidades.Plan plan = new Entidades.Plan();
                Negocio.Plan negocio = new Negocio.Plan();

                plan.ID = ID;

                negocio.deletePlan(plan);

                clear();
                
                btnAgregar.Enabled = true;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                btnCancelar.Enabled = false;
                loadPlanes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvPlanes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvPlanes.SelectedCells[0].RowIndex;
            ID = (int)dgvPlanes.Rows[index].Cells[0].Value;
            txtDescripción.Text = dgvPlanes.Rows[index].Cells[1].Value.ToString();
            cmbEspecialidad.SelectedValue = (int)dgvPlanes.Rows[index].Cells[2].Value;
            btnAgregar.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnCancelar.Enabled = true;
        }
    }
}
