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
    public partial class Profesor : Form
    {
        public Profesor()
        {
            InitializeComponent();
        }

        void loadProfesores(string nombre)
        {
            //
            Negocio.Persona negocio = new Negocio.Persona();
            dgvPersonas.DataSource = negocio.getProfesores(nombre);
            dgvPersonas.Columns[7].Visible = false;
            dgvPersonas.Columns[8].Visible = false;
            dgvPersonas.Columns[9].Visible = false;
            dgvPersonas.Columns[10].Visible = false;
        }

        private void Profesor_Load(object sender, EventArgs e)
        {
            loadProfesores(textBox1.Text);

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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Entidades.Persona p = new Entidades.Persona();
            p.Legajo = Convert.ToInt32(txtLegajo.Text);
            p.Nombre = txtNombre.Text;
            p.Apellido = txtApellido.Text;
            p.Direccion = txtDireccion.Text;
            p.Email = txtEmail.Text;
            p.Telefono = txtTelefono.Text;
            p.TipoPersona = "Profesor";
            p.FechaNacimiento = dtpFechaNacimiento.Value;





            Negocio.Persona negocio = new Negocio.Persona();
            try
            {
                negocio.addProfesor(p);
                clear();
                loadProfesores(textBox1.Text);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        int ID = 0;
        private void dgvPersonas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //legajo nombre apellido fechanac telefono direccion email
            int index = dgvPersonas.SelectedCells[0].RowIndex;
            ID = Convert.ToInt32(dgvPersonas.Rows[index].Cells[9].Value);
            txtLegajo.Text = dgvPersonas.Rows[index].Cells[0].Value.ToString();
            txtNombre.Text = dgvPersonas.Rows[index].Cells[1].Value.ToString();
            txtApellido.Text = dgvPersonas.Rows[index].Cells[2].Value.ToString();
            dtpFechaNacimiento.Value = Convert.ToDateTime(dgvPersonas.Rows[index].Cells[3].Value);
            txtTelefono.Text = dgvPersonas.Rows[index].Cells[4].Value.ToString();
            txtDireccion.Text = dgvPersonas.Rows[index].Cells[5].Value.ToString();
            txtEmail.Text = dgvPersonas.Rows[index].Cells[6].Value.ToString();

            btnAgregar.Enabled = false;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Entidades.Persona p = new Entidades.Persona();
            p.ID = ID;
            p.Legajo = Convert.ToInt32(txtLegajo.Text);
            p.Nombre = txtNombre.Text;
            p.Apellido = txtApellido.Text;
            p.Direccion = txtDireccion.Text;
            p.Email = txtEmail.Text;
            p.Telefono = txtTelefono.Text;
            p.TipoPersona = "Profesor";
            p.FechaNacimiento = dtpFechaNacimiento.Value;

            Negocio.Persona negocio = new Negocio.Persona();

            try { 
                negocio.updateProfesor(p);

                clear();
                btnAgregar.Enabled = true;
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
                btnCancelar.Enabled = false;
                loadProfesores(textBox1.Text);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clear();
            btnAgregar.Enabled = true;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Entidades.Persona p = new Entidades.Persona();
            p.ID = ID;
            p.Legajo = Convert.ToInt32(txtLegajo.Text);
            p.Nombre = txtNombre.Text;
            p.Apellido = txtApellido.Text;
            p.Direccion = txtDireccion.Text;
            p.Email = txtEmail.Text;
            p.Telefono = txtTelefono.Text;
            p.TipoPersona = "Profesor";
            p.FechaNacimiento = dtpFechaNacimiento.Value;

            Negocio.Persona negocio = new Negocio.Persona();
            negocio.deleteProfesor(p);

            clear();
            btnAgregar.Enabled = true;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = false;
            loadProfesores(textBox1.Text);
        }

        private void txtLegajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            loadProfesores(textBox1.Text);
        }

        private void txtLegajo_Leave(object sender, EventArgs e)
        {
            if (txtLegajo.Text == "")
                txtLegajo.Text = "0";
        }
    }
}
