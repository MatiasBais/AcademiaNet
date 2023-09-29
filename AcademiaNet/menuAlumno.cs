using Microsoft.VisualBasic;
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
    public partial class menuAlumno : Form
    {
        private Entidades.Usuario usuario;

        public menuAlumno(int idUsuario)
        {
            Negocio.Usuario u = new Negocio.Usuario();
            usuario = u.getUsuario(idUsuario);
            InitializeComponent();
        }

        private void menuAlumno_Load(object sender, EventArgs e)
        {
            if (usuario != null)
            {
                string datos = usuario.Persona.Nombre + "   " + usuario.Persona.Apellido + "    Legajo:  " + usuario.Legajo.ToString();
                label1.Text = datos;
            }
            else
            {
                MessageBox.Show("El usuario no está inicializado correctamente.");
            }
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (usuario != null)
            {
                EstadoAcademico estado = new EstadoAcademico(usuario.ID);
                estado.Show();
            }
            else
            {
                MessageBox.Show("El usuario no está inicializado correctamente.");
            }
        }
    }

}
