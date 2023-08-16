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

namespace AcademiaNet
{
    public partial class Alumnos : Form
    {
        public Alumnos()
        {
            InitializeComponent();
        }

        private void loadEspecialidades()
        {
            Negocio.Especialidad negocio = new Negocio.Especialidad();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Descripcion", typeof(string));
            foreach(Entidades.Especialidad esp in negocio.getEspecialidades())
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
            if (cmbEspecialidad.SelectedValue == null)
                return;
            Negocio.Plan negocio = new Negocio.Plan();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Descripcion", typeof(string));
            foreach (Entidades.Plan plan in negocio.getPlanes((int)cmbEspecialidad.SelectedValue))
            {
                DataRow row = dt.NewRow();
                row[0] = plan.ID;
                row[1] = plan.Descripcion;

                dt.Rows.Add(row);
            }

            cmbPlan.ValueMember = "ID";
            cmbPlan.DisplayMember = "Descripcion";

            cmbPlan.DataSource = dt;
        }
        private void loadALumnos()
        {
            Negocio.Persona negocio = new Negocio.Persona();
            List<Entidades.Persona> personaList = negocio.getAlumnos();

            DataTable dt = new DataTable();
            //id legajo nombre apellido FechaNacimiento Telefono email Plan idEspecialidad Especialidad
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("Legajo", typeof(int));
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Apellido", typeof(string));
            dt.Columns.Add("FechaNacimiento", typeof(DateTime));
            dt.Columns.Add("Telefono", typeof(string));
            dt.Columns.Add("Direccion", typeof(string));
            dt.Columns.Add("Email", typeof(string));
            dt.Columns.Add("idPlan", typeof(int));
            dt.Columns.Add("Plan", typeof(int));
            dt.Columns.Add("idEspecialidad", typeof(int));
            dt.Columns.Add("Especialidad", typeof(string));

            foreach (Entidades.Persona persona in personaList)
            {
                DataRow row = dt.NewRow();

                row[0] = persona.ID;
                row[1] = persona.Legajo;
                row[2] = persona.Nombre;
                row[3] = persona.Apellido;
                row[4] = persona.FechaNacimiento;
                row[5] = persona.Telefono;
                row[6] = persona.Direccion;
                row[7] = persona.Email;
                row[8] = persona.Plan.ID;
                row[9] = persona.Plan.Descripcion;
                row[10] = persona.Plan.Especialidad.ID;
                row[11] = persona.Plan.Especialidad.Descripcion;

                dt.Rows.Add(row);
            }
            dgvPersonas.DataSource = dt;
            dgvPersonas.Columns[0].Visible = false;
            dgvPersonas.Columns[8].Visible = false;
            dgvPersonas.Columns[10].Visible = false;
            loadEspecialidades();
        }
        private void Persona_Load(object sender, EventArgs e)
        {
            
            loadALumnos();
            
        }

        private void cmbEspecialidad_SelectedValueChanged(object sender, EventArgs e)
        {
            loadPlanes();
        }

        public void clear()
        {
            txtApellido.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtEmail.Clear();
            txtLegajo.Text = "0";
            txtTelefono.Clear();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Entidades.Persona p = new Entidades.Persona();
            p.Legajo = Convert.ToInt32(txtLegajo.Text);
            p.Nombre = txtNombre.Text;
            p.Apellido = txtApellido.Text;
            p.Direccion = txtDireccion.Text;
            p.Email = txtEmail.Text;
            p.Telefono = txtTelefono.Text;
            p.TipoPersona = "Alumno";
            p.FechaNacimiento = dtpFechaNacimiento.Value;
            Entidades.Plan plan = new Entidades.Plan();
            plan.ID = (int)cmbPlan.SelectedValue;


            p.Plan = plan;


            Negocio.Persona negocio = new Negocio.Persona();
            try
            {
                negocio.addPersona(p);
                clear();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            finally
            {
                loadALumnos();
            }

        }

        private void txtLegajo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtLegajo_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtLegajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLegajo_Leave(object sender, EventArgs e)
        {
            if (txtLegajo.Text == "")
                txtLegajo.Text = "0";
        }
    }
}
