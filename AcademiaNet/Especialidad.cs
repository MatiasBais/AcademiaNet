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
        private Task<IEnumerable<Entidades.Especialidad>>? l;
        public Especialidad()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public IEnumerable<Entidades.Especialidad> getEspecialidades()
        {
            l = Negocio.Especialidad.GetByDesc(txtBuscar.Text);
            return l.Result;
        }
        private async void loadEspecialidades()
        {
            Task<IEnumerable<Entidades.Especialidad>> task = new Task<IEnumerable<Entidades.Especialidad>>(getEspecialidades);
            task.Start();
            dgvEspecialidades.DataSource = await task;
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

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                //Negocio.Especialidad negocio = new Negocio.Especialidad();
                Entidades.Especialidad esp = new Entidades.Especialidad();
                esp.Descripcion = txtDescripción.Text;
                await Negocio.Especialidad.Add(esp);
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

        }

        private void clear()
        {
            txtDescripción.Text = "";
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
               // Negocio.Especialidad negocio = new Negocio.Especialidad();
                Entidades.Especialidad esp = new Entidades.Especialidad();
                esp.Descripcion = txtDescripción.Text;
                esp.ID = ID;
                await Negocio.Especialidad.Update(esp);
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

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                //Negocio.Especialidad negocio = new Negocio.Especialidad();
                Entidades.Especialidad esp = new Entidades.Especialidad();
                esp.ID = ID;
                await Negocio.Especialidad.Delete(esp);
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
            clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvEspecialidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvEspecialidades.SelectedCells[0].RowIndex;
            ID = Convert.ToInt32(dgvEspecialidades.Rows[index].Cells[1].Value);
            txtDescripción.Text = dgvEspecialidades.Rows[index].Cells[0].Value.ToString();
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
            btnCancelar.Enabled = true;
        }
    }
}
