using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademiaNet
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void administrarPersonasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.ShowDialog();
        }

        private void administrarEspecialidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void administrarPlanesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void administrarComisionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void administrarTiposDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void comisionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void especialidadesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Especialidad esp = new Especialidad();
            esp.ShowDialog();
        }

        private void planesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Planes planes = new Planes();
            planes.ShowDialog();
        }

        private void comisionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Comision comi = new Comision();
            comi.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
