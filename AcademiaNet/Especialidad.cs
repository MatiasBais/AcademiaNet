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
    public partial class Especialidad : Form
    {
        public Especialidad()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loadEspecialidades()
        {
            Negocio.Especialidad negocio = new Negocio.Especialidad();
            dgvEspecialidades.DataSource = negocio.getEspecialidades(txtBuscar.Text);
            dgvEspecialidades.Columns[1].Visible = false;
            dgvEspecialidades.Columns[2].Visible = false;
        }
        private void Especialidad_Load(object sender, EventArgs e)
        {
            loadEspecialidades();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            loadEspecialidades();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Negocio.Especialidad negocio = new Negocio.Especialidad();
                Entidades.Especialidad esp = new Entidades.Especialidad();
                esp.Descripcion = txtDescripción.Text;
                negocio.addEspecialidad(esp);
                clear();
                loadEspecialidades();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        int ID = 0;
        private void dgvEspecialidades_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvEspecialidades.SelectedCells[0].RowIndex;
            ID = Convert.ToInt32(dgvEspecialidades.Rows[index].Cells[1].Value);
            txtDescripción.Text = dgvEspecialidades.Rows[index].Cells[0].Value.ToString();
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
            try
            {
                Negocio.Especialidad negocio = new Negocio.Especialidad();
                Entidades.Especialidad esp = new Entidades.Especialidad();
                esp.Descripcion = txtDescripción.Text;
                esp.ID = ID;
                negocio.updateEspecialidad(esp);
                clear();
                btnAgregar.Enabled = true;
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
                btnCancelar.Enabled = false;
                loadEspecialidades();
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
                Negocio.Especialidad negocio = new Negocio.Especialidad();
                Entidades.Especialidad esp = new Entidades.Especialidad();
                esp.ID = ID;
                negocio.deleteEspecialidad(esp);
                clear();
                btnAgregar.Enabled = true;
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
                btnCancelar.Enabled = false;
                loadEspecialidades();
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
    }
}
