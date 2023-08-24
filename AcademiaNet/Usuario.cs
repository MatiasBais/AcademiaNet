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
    public partial class Usuario : Form
    {
        private Entidades.Persona Persona { get; set; }
        public Usuario(Entidades.Persona persona)
        {
            this.Persona = persona;
            InitializeComponent();
        }

        private void loadUsuarios()
        {
            Negocio.Usuario negocio = new Negocio.Usuario();
            List<Entidades.Usuario> usuarioList = negocio.getUsuarios(this.Persona);

            DataTable dt = new DataTable();
            //id legajo nombre apellido FechaNacimiento Telefono email Plan idEspecialidad Especialidad
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("Legajo", typeof(int));
            dt.Columns.Add("Nombre de Usuario", typeof(string));
            dt.Columns.Add("Clave", typeof(string));
            dt.Columns.Add("Habilitado", typeof(string));
            dt.Columns.Add("Tipo de Usuario", typeof(string));
            dt.Columns.Add("idPlan", typeof(int));
            dt.Columns.Add("Plan", typeof(string));
            dt.Columns.Add("idEspecialidad", typeof(int));
            dt.Columns.Add("Especialidad", typeof(string));

            foreach (Entidades.Usuario usuario in usuarioList)
            {
                DataRow row = dt.NewRow();

                row[0] = usuario.ID;
                row[1] = usuario.Legajo;
                row[2] = usuario.NombreUsuario;
                row[3] = usuario.Clave;
                row[4] = usuario.Habilitado;
                row[5] = usuario.TipoPersona;
                row[6] = usuario.Plan.ID;
                row[7] = usuario.Plan.Descripcion;
                row[8] = usuario.Plan.Especialidad.ID;
                row[9] = usuario.Plan.Especialidad.Descripcion;

                dt.Rows.Add(row);
            }
            dgvUsuarios.DataSource = dt;
            dgvUsuarios.Columns[0].Visible = false;
            dgvUsuarios.Columns[6].Visible = false;
            dgvUsuarios.Columns[8].Visible = false;
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

        private void Usuario_Load(object sender, EventArgs e)
        {
            cmbTipo.SelectedIndex = 0;
            loadUsuarios();

        }

        private void cmbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadPlanes();
        }

        private void clear()
        {
            txtClave.Clear();
            txtHabilitado.Clear();
            txtNombreUsuario.Clear();
            txtLegajo.Text = "0";
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try { 
                Entidades.Usuario usuario = new Entidades.Usuario();
                usuario.NombreUsuario = txtNombreUsuario.Text;
                usuario.Clave = txtClave.Text;
                usuario.TipoPersona = cmbTipo.Text;
                usuario.Habilitado = txtHabilitado.Text;
                usuario.State = "TRUE";

                Entidades.Plan plan = new Entidades.Plan();
                plan.ID = (int)cmbPlan.SelectedValue;

                usuario.Plan = plan;

                Negocio.Usuario negocio = new Negocio.Usuario();
                negocio.addUsuario(usuario, this.Persona);

                loadUsuarios();
                clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void txtLegajo_Leave(object sender, EventArgs e)
        {
            txtLegajo.Text = txtLegajo.Text == "" ? "0":txtLegajo.Text;
        }

        private void txtLegajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        int ID = 0;
        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvUsuarios.SelectedRows[0].Index;
            ID = (int)dgvUsuarios.Rows[index].Cells[0].Value;
            txtLegajo.Text = dgvUsuarios.Rows[index].Cells[1].Value.ToString();
            txtNombreUsuario.Text = dgvUsuarios.Rows[index].Cells[2].Value.ToString();
            txtClave.Text = dgvUsuarios.Rows[index].Cells[3].Value.ToString();
            txtHabilitado.Text = dgvUsuarios.Rows[index].Cells[4].Value.ToString();
            string tipo = dgvUsuarios.Rows[index].Cells[5].Value.ToString();
            if (tipo == "Alumno")
                cmbTipo.SelectedIndex = 0;
            else if (tipo == "Profesor")
                cmbTipo.SelectedIndex = 1;
            else
                cmbTipo.SelectedIndex = 2;
            cmbEspecialidad.SelectedValue = dgvUsuarios.Rows[index].Cells[8].Value;
            cmbPlan.SelectedValue = dgvUsuarios.Rows[index].Cells[6].Value;

            btnAgregar.Enabled = false;
            btnCancelar.Enabled = true;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clear();
            btnAgregar.Enabled = true;
            btnCancelar.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Negocio.Usuario negocio = new Negocio.Usuario();
                negocio.deleteUsuario(ID);
                clear();
                btnAgregar.Enabled = true;
                btnCancelar.Enabled = false;
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
                loadUsuarios();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Negocio.Usuario negocio = new Negocio.Usuario();
                Entidades.Usuario usuario = new Entidades.Usuario();
                usuario.ID = ID;
                usuario.NombreUsuario = txtNombreUsuario.Text;
                usuario.Clave = txtClave.Text;
                usuario.TipoPersona = cmbTipo.Text;
                usuario.Habilitado = txtHabilitado.Text;

                Entidades.Plan plan = new Entidades.Plan();
                plan.ID = (int)cmbPlan.SelectedValue;

                usuario.Plan = plan;
                negocio.updateUsuario(usuario);
                clear();
                btnAgregar.Enabled = true;
                btnCancelar.Enabled = false;
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
                loadUsuarios();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
