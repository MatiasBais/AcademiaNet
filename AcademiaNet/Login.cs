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
            Entidades.Usuario usuario = new Entidades.Usuario();
            usuario.NombreUsuario = txtNombreUsuario.Text;
            usuario.Clave = txtClave.Text;
            Negocio.Usuario negocio = new Negocio.Usuario();
            if (negocio.validarUsuario(usuario))
            {
                Menu menu = new Menu();
                this.Hide();
                menu.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrecta");
            }
        }
    }
}
