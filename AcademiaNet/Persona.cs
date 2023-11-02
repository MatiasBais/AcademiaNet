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
    public partial class Persona : Form
    {
        public Persona()
        {
            InitializeComponent();
        }

        void loadPersonas(string nombre)
        {
            //
            Negocio.Persona negocio = new Negocio.Persona();
            dgvPersonas.DataSource = negocio.getPersonas(nombre);
            dgvPersonas.Columns[6].Visible = false;
            dgvPersonas.Columns[7].Visible = false;
        }

        private void Profesor_Load(object sender, EventArgs e)
        {
            loadPersonas(txtBuscar.Text);

        }
        public void clear()
        {
            txtApellido.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Entidades.Persona p = new Entidades.Persona();
            p.Nombre = txtNombre.Text;
            p.Apellido = txtApellido.Text;
            p.Direccion = txtDireccion.Text;
            p.Email = txtEmail.Text;
            p.Telefono = txtTelefono.Text;
            p.FechaNacimiento = dtpFechaNacimiento.Value;





            Negocio.Persona negocio = new Negocio.Persona();
            try
            {
                negocio.addPersona(p);
                clear();
                loadPersonas(txtBuscar.Text);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        int ID = 0;
        private void dgvPersonas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvPersonas.SelectedCells[0].RowIndex;
            Entidades.Persona persona = new Entidades.Persona();
            persona.ID = Convert.ToInt32(dgvPersonas.Rows[index].Cells[6].Value);
            persona.Nombre = "Juan";
            Usuario usuario = new Usuario(persona);
            usuario.ShowDialog();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Entidades.Persona p = new Entidades.Persona();
            p.ID = ID;
            p.Nombre = txtNombre.Text;
            p.Apellido = txtApellido.Text;
            p.Direccion = txtDireccion.Text;
            p.Email = txtEmail.Text;
            p.Telefono = txtTelefono.Text;
            p.FechaNacimiento = dtpFechaNacimiento.Value;

            Negocio.Persona negocio = new Negocio.Persona();

            try
            {
                negocio.updatePersona(p);

                clear();
                btnAgregar.Enabled = true;
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
                btnCancelar.Enabled = false;
                loadPersonas(txtBuscar.Text);
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

            Negocio.Persona negocio = new Negocio.Persona();
            negocio.deletePersona(ID);

            clear();
            btnAgregar.Enabled = true;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = false;
            loadPersonas(txtBuscar.Text);
        }

        private void txtLegajo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            loadPersonas(txtBuscar.Text);
        }

        private void txtLegajo_Leave(object sender, EventArgs e)
        {

        }

        private void dgvPersonas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvPersonas.SelectedCells[0].RowIndex;
            ID = Convert.ToInt32(dgvPersonas.Rows[index].Cells[6].Value);
            txtNombre.Text = dgvPersonas.Rows[index].Cells[0].Value.ToString();
            txtApellido.Text = dgvPersonas.Rows[index].Cells[1].Value.ToString();
            dtpFechaNacimiento.Value = Convert.ToDateTime(dgvPersonas.Rows[index].Cells[2].Value);
            txtTelefono.Text = dgvPersonas.Rows[index].Cells[3].Value.ToString();
            txtDireccion.Text = dgvPersonas.Rows[index].Cells[5].Value.ToString();
            txtEmail.Text = dgvPersonas.Rows[index].Cells[4].Value.ToString();

            btnAgregar.Enabled = false;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
            btnCancelar.Enabled = true;
        }
    }
}
