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
    public partial class menuProfesor : Form
    {
        Entidades.Usuario profesor;
        public menuProfesor(int idusuario)
        {
            Negocio.Usuario negocio = new Negocio.Usuario();
            this.profesor = negocio.getUsuario(idusuario);
            InitializeComponent();
        }

        private void menuProfesor_Load(object sender, EventArgs e)
        {
            label1.Text = profesor.Persona.Apellido + ", " + profesor.Persona.Nombre + "\nLegajo: " + profesor.Legajo.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CursoProfesor cp = new CursoProfesor(profesor);
            cp.Show();
        }
    }
}
