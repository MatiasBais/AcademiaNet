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
    public partial class MateriasDelPlan : Form
    {
        Entidades.Plan plan;
        public MateriasDelPlan(Entidades.Plan plan)
        {
            InitializeComponent();
            this.plan = plan;
            label1.Text = plan.Descripcion + " - " + plan.Especialidad.Descripcion;
        }

        public void loadMaterias()
        {
            Negocio.Materia negocio = new Negocio.Materia();
            dgvMaterias.DataSource = negocio.getMaterias(plan.ID);
            dgvMaterias.Columns[0].Visible = false;
            dgvMaterias.Columns[4].Visible = false;
            dgvMaterias.Columns[5].Visible = false;

        }
        private void MateriasDelPlan_Load(object sender, EventArgs e)
        {
            loadMaterias();
        }
    }
}
