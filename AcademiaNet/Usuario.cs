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
    public partial class Usuario : Form
    {
        private Entidades.Persona Persona { get; set; }
        public Usuario(Entidades.Persona persona)
        {
            this.Persona = persona;
            InitializeComponent();
        }

        private void loadTipos()
        {
            Negocio.tipoUsuario negocio = new Negocio.tipoUsuario();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Descripcion", typeof(string));
            foreach (Entidades.TipoUsuario tipo in negocio.getTipoUsuarios())
            {
                DataRow row = dt.NewRow();
                row[0] = tipo.ID;
                row[1] = tipo.Descripcion;
                dt.Rows.Add(row);
            }
            cmbTipo.ValueMember = "ID";
            cmbTipo.DisplayMember = "Descripcion";

            cmbTipo.DataSource = dt;
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
            dt.Columns.Add("idTipo", typeof(string));
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
                row[5] = usuario.tipo.Descripcion;
                row[6] = usuario.tipo.ID;
                row[7] = usuario.Plan.ID;
                row[8] = usuario.Plan.Descripcion;
                row[9] = usuario.Plan.Especialidad.ID;
                row[10] = usuario.Plan.Especialidad.Descripcion;

                dt.Rows.Add(row);
            }
            dgvUsuarios.DataSource = dt;
            dgvUsuarios.Columns[0].Visible = false;
            dgvUsuarios.Columns[3].Visible = false;
            dgvUsuarios.Columns[6].Visible = false;
            dgvUsuarios.Columns[7].Visible = false;
            dgvUsuarios.Columns[9].Visible = false;
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
            cmbHabilitado.SelectedIndex = 0;
            loadUsuarios();
            loadTipos();

        }

        private void cmbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadPlanes();
        }

        private void clear()
        {
            txtClave.Clear();
            txtNombreUsuario.Clear();
            txtLegajo.Text = "0";
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try { 
                Entidades.Usuario usuario = new Entidades.Usuario();
                usuario.NombreUsuario = txtNombreUsuario.Text;
                usuario.Clave = txtClave.Text;
                usuario.tipo = new Entidades.TipoUsuario();
                usuario.tipo.ID = (int)cmbTipo.SelectedValue;
                usuario.Habilitado = cmbHabilitado.Text;
                usuario.Legajo = Convert.ToInt32(txtLegajo.Text);
                usuario.Plan = null;

                if (cmbTipo.Text == "Alumno")
                {
                    Entidades.Plan plan = new Entidades.Plan();
                    plan.ID = (int)cmbPlan.SelectedValue;
                    usuario.Plan = plan;
                }

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
            string habilitado = dgvUsuarios.Rows[index].Cells[4].Value.ToString();
            if (habilitado == "Habilitado")
                cmbHabilitado.SelectedIndex = 0;
            else
                cmbHabilitado.SelectedIndex = 1;
            cmbTipo.SelectedValue = dgvUsuarios.Rows[index].Cells[6].Value;
            cmbEspecialidad.SelectedValue = dgvUsuarios.Rows[index].Cells[9].Value;
            cmbPlan.SelectedValue = dgvUsuarios.Rows[index].Cells[7].Value;

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
                usuario.tipo = new Entidades.TipoUsuario();
                usuario.tipo.ID = (int)cmbTipo.SelectedValue;
                usuario.Habilitado = cmbHabilitado.Text;
                usuario.Legajo = Convert.ToInt32(txtLegajo.Text);
                usuario.Plan = null;

                if (cmbTipo.Text == "Alumno") { 
                    Entidades.Plan plan = new Entidades.Plan();
                    plan.ID = (int)cmbPlan.SelectedValue;
                    usuario.Plan = plan;
                }

                
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

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbTipo.Text == "Alumno")
            {
                cmbEspecialidad.Visible = true;
                cmbPlan.Visible = true;
                lblEspecialidad.Visible = true;
                lblPlan.Visible = true;

            }
            else
            {
                cmbEspecialidad.Visible = false;
                cmbPlan.Visible = false;
                lblEspecialidad.Visible = false;
                lblPlan.Visible = false;
            }
        }
    }
}
