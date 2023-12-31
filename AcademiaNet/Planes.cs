﻿using System;
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
        private Task<IEnumerable<Entidades.Especialidad>>? l;
        public Planes()
        {
            InitializeComponent();
        }

        private async void Planes_Load(object sender, EventArgs e)
        {
            loadEspecialidades();
            timer1.Start();
            loadPlanes();
        }

        public IEnumerable<Entidades.Especialidad> getEspecialidades()
        {
            l = Negocio.Especialidad.GetAll();
            return l.Result;
        }
        bool espLoad = false;
        private async void loadEspecialidades()
        {
            espLoad = false;
            Task<IEnumerable<Entidades.Especialidad>> task = new Task<IEnumerable<Entidades.Especialidad>>(getEspecialidades);
            task.Start();
            cmbEspecialidad.DataSource = await task;
            cmbEspecialidad.ValueMember = "ID";
            cmbEspecialidad.DisplayMember = "Descripcion";
            espLoad = true;
        }

        private void loadPlanes()
        {
            if (!espLoad)
                return;
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
        int ID = 0;
        private void dgvPlanes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvPlanes.SelectedCells[0].RowIndex;
            ID = (int)dgvPlanes.Rows[index].Cells[2].Value;
            txtDescripcion.Text = dgvPlanes.Rows[index].Cells[0].Value.ToString();
            cmbEspecialidad.SelectedValue = dgvPlanes.Rows[index].Cells[1].Value;

            btnAgregar.Enabled = false;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
            btnCancelar.Enabled = true;
            cmbEspecialidad.Enabled = false;


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
            cmbEspecialidad.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Entidades.Plan plan = new Entidades.Plan();
            plan.Descripcion = txtDescripcion.Text;
            Entidades.Especialidad especialidad = new Entidades.Especialidad();
            especialidad.ID = (int)cmbEspecialidad.SelectedValue;
            int index = dgvPlanes.SelectedCells[0].RowIndex;
            plan.ID = ID;

            plan.Especialidad = especialidad;

            Negocio.Plan p = new Negocio.Plan();
            try
            {
                p.updatePlan(plan);
                clear();
                btnAgregar.Enabled = true;
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
                btnCancelar.Enabled = false;
                cmbEspecialidad.Enabled = true;

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
            plann.ID = ID;
            try
            {
                plan.deletePlan(plann);
                clear();
                btnAgregar.Enabled = true;
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
                btnCancelar.Enabled = false;
                cmbEspecialidad.Enabled = true;

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                loadPlanes();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (espLoad)
            {
                loadPlanes();
                timer1.Stop();
            }
        }
    }
}
