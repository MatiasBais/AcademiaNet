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
        
        private void login()
        {
            string nombreUsuario = txtNombreUsuario.Text;
            string clave = txtClave.Text;
            Negocio.Usuario usuario = new Negocio.Usuario();
            int idUsuario = usuario.validarUsuario(nombreUsuario, clave);
            if (idUsuario != 0)
            {
                string tipoUsuario = usuario.getTipoUsuario(idUsuario);
                MessageBox.Show(tipoUsuario);
                switch (tipoUsuario)
                {
                    case "Administrador":
                        Menu menu = new Menu();
                        menu.Show();
                        this.Hide();
                        break;
                    case "Alumno":
                        menuAlumno menu2 = new menuAlumno(idUsuario);
                        menu2.Show();
                        this.Hide();
                        break;
                    case "Profesor":
                        menuProfesor menu3 = new menuProfesor();
                        menu3.Show();
                        this.Hide();
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

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            login();
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                login();
            }
        }
    }
}
