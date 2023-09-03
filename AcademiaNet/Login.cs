using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Design.AxImporter;

namespace AcademiaNet
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtNombreUsuario.Text;
            string clave = txtClave.Text;
            Negocio.Usuario negocio = new Negocio.Usuario();
            if (negocio.validarUsuario(nombreUsuario, clave))
            {
                string tipoUsuario = negocio.getTipoUsuario(nombreUsuario, clave);
                MessageBox.Show(tipoUsuario);
                switch (tipoUsuario)
                {
                    case "Administrador":
                        Menu menu = new Menu();
                        this.Hide();
                        menu.ShowDialog();
                        this.Show();
                        break;
                    case "Alumno":
                        menuAlumno menu2 = new menuAlumno();                      
                        this.Hide();
                        menu2.ShowDialog();
                        this.Show();
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrecta");
            }
        }
    }
}
