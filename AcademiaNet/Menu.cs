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
            Especialidad esp = new Especialidad();
            esp.ShowDialog();
        }

        private void administrarPlanesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Planes planes = new Planes();
            planes.ShowDialog();
        }

        private void administrarComisionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Comision comisiones = new Comision();
            comisiones.ShowDialog();
        }

        private void administrarTiposDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoUsuario tipo = new TipoUsuario();
            tipo.ShowDialog();
        }


        private void comisionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
