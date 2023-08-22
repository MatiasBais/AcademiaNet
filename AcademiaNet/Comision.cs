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
    public partial class Comision : Form
    {
        public Comision()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loadComisiones(string descripcion)
        {


            Negocio.Comision negocio = new Negocio.Comision();
            List<Entidades.Comision> comisionList = negocio.getComisiones(descripcion);

            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Id Plan", typeof(int));
            dt.Columns.Add("Año Especialidad", typeof(int));
            dt.Columns.Add("Descripcion", typeof(string));

            foreach (Entidades.Comision comision in comisionList)
            {
                DataRow row = dt.NewRow();

                row[0] = comision.ID;
                row[1] = comision.IDPlan;
                row[2] = comision.AnioEspecialidad;
                row[3] = comision.Descripcion;

                dt.Rows.Add(row);
            }

            dgvComisiones.DataSource = dt;


        }


        private void Comision_Load(object sender, EventArgs e)
        {
            loadComisiones("");
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            loadComisiones(txtBuscar.Text);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Negocio.Comision negocio = new Negocio.Comision();
                Entidades.Comision com = new Entidades.Comision();
                com.Descripcion = txtDescripción.Text;
                com.IDPlan = Convert.ToInt32(txtIdPlan.Text);
                com.AnioEspecialidad = Convert.ToInt32(txtAnioEspecialidad.Text);
                negocio.addComision(com);
                clear();
                loadComisiones("");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        int ID = 0;
        private void dgvComisiones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int index = dgvComisiones.SelectedCells[0].RowIndex;
            ID = Convert.ToInt32(dgvComisiones.Rows[index].Cells[0].Value);
            txtIdPlan.Text = dgvComisiones.Rows[index].Cells[1].Value.ToString();
            txtAnioEspecialidad.Text = dgvComisiones.Rows[index].Cells[2].Value.ToString();
            txtDescripción.Text = dgvComisiones.Rows[index].Cells[3].Value.ToString();

            btnAgregar.Enabled = false;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void clear()
        {
            txtDescripción.Text = "";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Entidades.Comision com = new Entidades.Comision();
            com.Descripcion = txtDescripción.Text;
            com.ID = ID;
            com.IDPlan = Convert.ToInt32(txtIdPlan.Text);
            com.AnioEspecialidad = Convert.ToInt32(txtAnioEspecialidad.Text);

            try
            {
                Negocio.Comision negocio = new Negocio.Comision();
                negocio.updateComision(com);
                clear();
                btnAgregar.Enabled = true;
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
                btnCancelar.Enabled = false;
                loadComisiones(txtBuscar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Negocio.Comision negocio = new Negocio.Comision();
                Entidades.Comision com = new Entidades.Comision();
                com.Descripcion = txtDescripción.Text;
                com.ID = ID;
                com.IDPlan = Convert.ToInt32(txtIdPlan.Text);
                com.AnioEspecialidad = Convert.ToInt32(txtAnioEspecialidad.Text);
                negocio.deleteComision(com);
                clear();
                btnAgregar.Enabled = true;
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
                btnCancelar.Enabled = false;
                loadComisiones("");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

}

