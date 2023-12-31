﻿using Datos;
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
    public partial class Comision : Form
    {
        private Task<IEnumerable<Entidades.Especialidad>>? l;


        public Comision()
        {

            InitializeComponent();
        }

        private void loadComisiones(string descripcion)
        {
            if (!espLoad || cmbIdPlan.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Negocio.Comision negocio = new Negocio.Comision();
            List<Entidades.Comision> comisionList = negocio.getComisiones(descripcion, (int)cmbIdPlan.SelectedValue);


            DataTable dt = new DataTable();
            dt.Columns.Add("ID Comision", typeof(int));
            dt.Columns.Add("ID Plan", typeof(int));
            dt.Columns.Add("Plan", typeof(string));
            dt.Columns.Add("Especialidad", typeof(string));
            dt.Columns.Add("Año", typeof(int));
            dt.Columns.Add("Comision", typeof(string));

            foreach (Entidades.Comision comision in comisionList)
            {
                DataRow row = dt.NewRow();

                row[0] = comision.ID;
                row[1] = comision.Plan.ID;
                row[2] = comision.Plan.Descripcion;
                row[3] = comision.Plan.Especialidad.Descripcion;
                row[4] = comision.AnioEspecialidad;
                row[5] = comision.Descripcion;

                dt.Rows.Add(row);
            }
            dgvComisiones.DataSource = dt;
            dgvComisiones.Columns[0].Visible = false;
            dgvComisiones.Columns[1].Visible = false;
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
        private void cmbEspecialidad_SelectedValueChanged(object sender, EventArgs e)
        {
            loadPlanes();
        }


        private void loadPlanes()
        {
            if (!espLoad)
                return;

            Negocio.Plan negocio = new Negocio.Plan();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Descripcion", typeof(string));
            List<Entidades.Plan> planes;
            try { planes = negocio.getPlanes((int)cmbEspecialidad.SelectedValue); }
            catch
            {
                planes = negocio.getPlanes(1);
            }
            foreach (Entidades.Plan plan in planes)
            {
                DataRow row = dt.NewRow();
                row[0] = plan.ID;
                row[1] = plan.Descripcion;

                dt.Rows.Add(row);
            }

            

            cmbIdPlan.DataSource = dt;
            cmbIdPlan.ValueMember = "ID";
            cmbIdPlan.DisplayMember = "Descripcion";

        }


        private void Comision_Load(object sender, EventArgs e)
        {
            timer1.Start();
            loadEspecialidades();
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
                com.AnioEspecialidad = Convert.ToInt32(txtAnioEspecialidad.Text);

                Entidades.Plan plan = new Entidades.Plan();
                plan.ID = (int)cmbIdPlan.SelectedValue;
                com.Plan = plan;

                negocio.addComision(com);
                clear();
                loadComisiones(txtBuscar.Text);
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
            int idComision = (int)dgvComisiones.Rows[index].Cells[0].Value;
            Curso curso = new Curso(idComision);
            curso.Show();
        }

        private void clear()
        {
            txtDescripción.Text = "";
            txtAnioEspecialidad.Text = "";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Entidades.Comision com = new Entidades.Comision();
            com.Descripcion = txtDescripción.Text;
            com.ID = ID;
            com.AnioEspecialidad = Convert.ToInt32(txtAnioEspecialidad.Text);

            Entidades.Plan plan = new Entidades.Plan();
            plan.ID = Convert.ToInt32(cmbIdPlan.Text);

            com.Plan = plan;

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
                com.AnioEspecialidad = Convert.ToInt32(txtAnioEspecialidad.Text);

                Entidades.Plan plan = new Entidades.Plan();
                plan.ID = Convert.ToInt32(cmbIdPlan.Text);
                com.Plan = plan;

                negocio.deleteComision(com);
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
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = false;
            cmbIdPlan.Enabled = true;
            cmbEspecialidad.Enabled = true;
            clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvComisiones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvComisiones.SelectedCells[0].RowIndex;
            ID = Convert.ToInt32(dgvComisiones.Rows[index].Cells[0].Value);
            cmbIdPlan.Text = dgvComisiones.Rows[index].Cells[1].Value.ToString();
            txtAnioEspecialidad.Text = dgvComisiones.Rows[index].Cells[4].Value.ToString();
            txtDescripción.Text = dgvComisiones.Rows[index].Cells[5].Value.ToString();

            cmbEspecialidad.Enabled = false;
            cmbIdPlan.Enabled = false;
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void cmbIdPlan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbIdPlan_SelectedValueChanged(object sender, EventArgs e)
        {
            loadComisiones(txtBuscar.Text);
        }

        private void cmbIdPlan_DataSourceChanged(object sender, EventArgs e)
        {
        }

        private void cmbIdPlan_ValueMemberChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (espLoad)
            {
                loadPlanes();
                timer1.Stop();
            }
        }

        private void cmbEspecialidad_SelectedValueChanged_1(object sender, EventArgs e)
        {
            loadPlanes();
        }
    }

}


