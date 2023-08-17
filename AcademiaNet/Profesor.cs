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

        void loadProfesores()
        {
            //
            Negocio.Persona negocio = new Negocio.Persona();
            dgvPersonas.DataSource = negocio.getProfesores();
            dgvPersonas.Columns[7].Visible = false;
            dgvPersonas.Columns[8].Visible = false;
            dgvPersonas.Columns[9].Visible = false;
            dgvPersonas.Columns[10].Visible = false;
        }

        private void Profesor_Load(object sender, EventArgs e)
        {
            loadProfesores();
            
        }

    }
}
