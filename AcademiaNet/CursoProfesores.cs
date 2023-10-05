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
    public partial class CursoProfesores : Form
    {
        Entidades.Curso curso;
        public CursoProfesores(Entidades.Curso curso)
        {
            InitializeComponent();
            this.curso = curso;
        }

        private void loadProfesores()
        {
            Negocio.DocentesCurso negocio = new Negocio.DocentesCurso();
            dgvProf.DataSource = negocio.getDocentesNo(curso);
            dgvProfCurso.DataSource = negocio.getDocentes(curso);
        }
        private void CursoProfesores_Load(object sender, EventArgs e)
        {
            loadProfesores();

        }
    }
}
