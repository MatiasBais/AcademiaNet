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
    public partial class TipoUsuario : Form
    {
        public TipoUsuario()
        {
            InitializeComponent();
        }

        private void cbxPersonasConsulta_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxPersonasConsulta.Checked == false)
            {
                cbxPersonasAlta.Checked = false;
                cbxPersonasAlta.Enabled = false;
                cbxPersonasBaja.Checked = false;
                cbxPersonasBaja.Enabled = false;
                cbxPersonasModificacion.Checked = false;
                cbxPersonasModificacion.Enabled = false;

            }
            else
            {
                cbxPersonasAlta.Enabled = true;
                cbxPersonasBaja.Enabled = true;
                cbxPersonasModificacion.Enabled = true;
            }
        }

        private void cbxUsuariosConsulta_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxUsuariosConsulta.Checked == false)
            {
                cbxUsuariosAlta.Checked = false;
                cbxUsuariosAlta.Enabled = false;
                cbxUsuariosBaja.Checked = false;
                cbxUsuariosBaja.Enabled = false;
                cbxUsuariosModificacion.Checked = false;
                cbxUsuariosModificacion.Enabled = false;

            }
            else
            {
                cbxUsuariosAlta.Enabled = true;
                cbxUsuariosBaja.Enabled = true;
                cbxUsuariosModificacion.Enabled = true;
            }
        }

        private void cbxEspecialidadesConsulta_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxEspecialidadesConsulta.Checked == false)
            {
                cbxEspecialidadesAlta.Checked = false;
                cbxEspecialidadesAlta.Enabled = false;
                cbxEspecialidadesBaja.Checked = false;
                cbxEspecialidadesBaja.Enabled = false;
                cbxEspecialidadesModificacion.Checked = false;
                cbxEspecialidadesModificacion.Enabled = false;

            }
            else
            {
                cbxEspecialidadesAlta.Enabled = true;
                cbxEspecialidadesBaja.Enabled = true;
                cbxEspecialidadesModificacion.Enabled = true;
            }
        }

        private void cbxPlanesConsulta_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxPlanesConsulta.Checked == false)
            {
                cbxPlanesAlta.Checked = false;
                cbxPlanesAlta.Enabled = false;
                cbxPlanesBaja.Checked = false;
                cbxPlanesBaja.Enabled = false;
                cbxPlanesModificacion.Checked = false;
                cbxPlanesModificacion.Enabled = false;

            }
            else
            {
                cbxPlanesAlta.Enabled = true;
                cbxPlanesBaja.Enabled = true;
                cbxPlanesModificacion.Enabled = true;
            }
        }

        private void cbxMateriasConsulta_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxMateriasConsulta.Checked == false)
            {
                cbxMateriasAlta.Checked = false;
                cbxMateriasAlta.Enabled = false;
                cbxMateriasBaja.Checked = false;
                cbxMateriasBaja.Enabled = false;
                cbxMateriasModificacion.Checked = false;
                cbxMateriasModificacion.Enabled = false;

            }
            else
            {
                cbxMateriasAlta.Enabled = true;
                cbxMateriasBaja.Enabled = true;
                cbxMateriasModificacion.Enabled = true;
            }
        }

        private void cbxCursosConsulta_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxCursosConsulta.Checked == false)
            {
                cbxCursosAlta.Checked = false;
                cbxCursosAlta.Enabled = false;
                cbxCursosBaja.Checked = false;
                cbxCursosBaja.Enabled = false;
                cbxCursosModificacion.Checked = false;
                cbxCursosModificacion.Enabled = false;

            }
            else
            {
                cbxCursosAlta.Enabled = true;
                cbxCursosBaja.Enabled = true;
                cbxCursosModificacion.Enabled = true;
            }
        }

        private void cbxInscripcionesConsulta_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxInscripcionesConsulta.Checked == false)
            {
                cbxInscripcionesAlta.Checked = false;
                cbxInscripcionesAlta.Enabled = false;
                cbxInscripcionesBaja.Checked = false;
                cbxInscripcionesBaja.Enabled = false;
                cbxInscripcionesModificacion.Checked = false;
                cbxInscripcionesModificacion.Enabled = false;

            }
            else
            {
                cbxInscripcionesAlta.Enabled = true;
                cbxInscripcionesBaja.Enabled = true;
                cbxInscripcionesModificacion.Enabled = true;
            }
        }

        private void cbxNotasConsulta_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxNotasConsulta.Checked == false)
            {
                cbxNotasAlta.Checked = false;
                cbxNotasAlta.Enabled = false;
                cbxNotasBaja.Checked = false;
                cbxNotasBaja.Enabled = false;
                cbxNotasModificacion.Checked = false;
                cbxNotasModificacion.Enabled = false;

            }
            else
            {
                cbxNotasAlta.Enabled = true;
                cbxNotasBaja.Enabled = true;
                cbxNotasModificacion.Enabled = true;
            }
        }

        private void loadTipoUsuarios()
        {
            Negocio.tipoUsuario negocio = new Negocio.tipoUsuario();
            dgvTipoUsuario.DataSource = negocio.getTipoUsuarios();
            dgvTipoUsuario.Columns[1].Visible = true;
            dgvTipoUsuario.Columns[2].Visible = false;

        }
        private void TipoUsuario_Load(object sender, EventArgs e)
        {
            loadTipoUsuarios();
        }

        private void loadPermisos()
        {
            Negocio.ModulosUsuario negocio = new Negocio.ModulosUsuario();
            List<Entidades.ModulosUsuario> permisos = negocio.GetPermisos(ID);
            foreach(Entidades.ModulosUsuario permiso in permisos)
            {
                if(permiso.modulo.Descripcion == "Personas")
                {
                    idPermisos[0] = permiso.ID;
                    cbxPersonasConsulta.Checked = permiso.Consulta;
                    cbxPersonasAlta.Checked = permiso.Alta;
                    cbxPersonasBaja.Checked = permiso.Baja;
                    cbxPersonasModificacion.Checked = permiso.Modificacion;
                }
                else if (permiso.modulo.Descripcion == "Usuarios")
                {
                    idPermisos[1] = permiso.ID;
                    cbxUsuariosConsulta.Checked = permiso.Consulta;
                    cbxUsuariosAlta.Checked = permiso.Alta;
                    cbxUsuariosBaja.Checked = permiso.Baja;
                    cbxUsuariosModificacion.Checked = permiso.Modificacion;
                }
                else if (permiso.modulo.Descripcion == "Especialidades")
                {
                    idPermisos[2] = permiso.ID;
                    cbxEspecialidadesConsulta.Checked = permiso.Consulta;
                    cbxEspecialidadesAlta.Checked = permiso.Alta;
                    cbxEspecialidadesBaja.Checked = permiso.Baja;
                    cbxEspecialidadesModificacion.Checked = permiso.Modificacion;
                }
                else if (permiso.modulo.Descripcion == "Planes")
                {
                    idPermisos[3] = permiso.ID;
                    cbxPlanesConsulta.Checked = permiso.Consulta;
                    cbxPlanesAlta.Checked = permiso.Alta;
                    cbxPlanesBaja.Checked = permiso.Baja;
                    cbxPlanesModificacion.Checked = permiso.Modificacion;
                }
                else if (permiso.modulo.Descripcion == "Materias")
                {
                    idPermisos[4] = permiso.ID;
                    cbxMateriasConsulta.Checked = permiso.Consulta;
                    cbxMateriasAlta.Checked = permiso.Alta;
                    cbxMateriasBaja.Checked = permiso.Baja;
                    cbxMateriasModificacion.Checked = permiso.Modificacion;
                }
                else if (permiso.modulo.Descripcion == "Cursos")
                {
                    idPermisos[5] = permiso.ID;
                    cbxCursosConsulta.Checked = permiso.Consulta;
                    cbxCursosAlta.Checked = permiso.Alta;
                    cbxCursosBaja.Checked = permiso.Baja;
                    cbxCursosModificacion.Checked = permiso.Modificacion;
                }
                else if (permiso.modulo.Descripcion == "Inscripciones")
                {
                    idPermisos[6] = permiso.ID;
                    cbxInscripcionesConsulta.Checked = permiso.Consulta;
                    cbxInscripcionesAlta.Checked = permiso.Alta;
                    cbxInscripcionesBaja.Checked = permiso.Baja;
                    cbxInscripcionesModificacion.Checked = permiso.Modificacion;
                }
                else if (permiso.modulo.Descripcion == "Notas")
                {
                    idPermisos[7] = permiso.ID;
                    cbxNotasConsulta.Checked = permiso.Consulta;
                    cbxNotasAlta.Checked = permiso.Alta;
                    cbxNotasBaja.Checked = permiso.Baja;
                    cbxNotasModificacion.Checked = permiso.Modificacion;
                }
            }

        }
        int ID = 0;
        int[] idPermisos = new int[8];
        private void dgvTipoUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvTipoUsuario.SelectedRows[0].Index;
            ID =Convert.ToInt32( dgvTipoUsuario.Rows[index].Cells[1].Value);
            txtDescripcion.Text = dgvTipoUsuario.Rows[index].Cells[0].Value.ToString();
            loadPermisos();
            btnAgregar.Enabled = false;
            btnCancelar.Enabled = true;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            btnAgregar.Enabled = true;
            btnCancelar.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;

            txtDescripcion.Clear();
            cbxPersonasConsulta.Checked = false;
            cbxUsuariosConsulta.Checked = false;
            cbxEspecialidadesConsulta.Checked = false;
            cbxPlanesConsulta.Checked = false;
            cbxMateriasConsulta.Checked = false;
            cbxCursosConsulta.Checked = false;
            cbxInscripcionesConsulta.Checked = false;
            cbxNotasConsulta.Checked = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try { 
                Entidades.TipoUsuario tipo = new Entidades.TipoUsuario();
                tipo.Descripcion = txtDescripcion.Text;
                tipo.permisos = new List<Entidades.ModulosUsuario>();

                //Personas
                Entidades.ModulosUsuario permiso1 = new Entidades.ModulosUsuario();
                permiso1.modulo = new Entidades.Modulo();
                permiso1.modulo.ID = 1;
                permiso1.Consulta = cbxPersonasConsulta.Checked;
                permiso1.Alta = cbxPersonasAlta.Checked;
                permiso1.Baja = cbxPersonasBaja.Checked;
                permiso1.Modificacion = cbxPersonasModificacion.Checked;

                tipo.permisos.Add(permiso1);

                //Usuarios
                Entidades.ModulosUsuario permiso2 = new Entidades.ModulosUsuario();
                permiso2.modulo = new Entidades.Modulo();
                permiso2.modulo.ID = 2;
                permiso2.Consulta = cbxUsuariosConsulta.Checked;
                permiso2.Alta = cbxUsuariosAlta.Checked;
                permiso2.Baja = cbxUsuariosBaja.Checked;
                permiso2.Modificacion = cbxUsuariosModificacion.Checked;

                tipo.permisos.Add(permiso2);

                //Especialidades
                Entidades.ModulosUsuario permiso3 = new Entidades.ModulosUsuario();
                permiso3.modulo = new Entidades.Modulo();
                permiso3.modulo.ID = 3;
                permiso3.Consulta = cbxEspecialidadesConsulta.Checked;
                permiso3.Alta = cbxEspecialidadesAlta.Checked;
                permiso3.Baja = cbxEspecialidadesBaja.Checked;
                permiso3.Modificacion = cbxEspecialidadesModificacion.Checked;

                tipo.permisos.Add(permiso3);

                //Planes
                Entidades.ModulosUsuario permiso4 = new Entidades.ModulosUsuario();
                permiso4.modulo = new Entidades.Modulo();
                permiso4.modulo.ID = 4;
                permiso4.Consulta = cbxPlanesConsulta.Checked;
                permiso4.Alta = cbxPlanesAlta.Checked;
                permiso4.Baja = cbxPlanesBaja.Checked;
                permiso4.Modificacion = cbxPlanesModificacion.Checked;

                tipo.permisos.Add(permiso4);

                //Materias
                Entidades.ModulosUsuario permiso5 = new Entidades.ModulosUsuario();
                permiso5.modulo = new Entidades.Modulo();
                permiso5.modulo.ID = 5;
                permiso5.Consulta = cbxMateriasConsulta.Checked;
                permiso5.Alta = cbxMateriasAlta.Checked;
                permiso5.Baja = cbxMateriasBaja.Checked;
                permiso5.Modificacion = cbxMateriasModificacion.Checked;

                tipo.permisos.Add(permiso5);

                //Cursos
                Entidades.ModulosUsuario permiso6 = new Entidades.ModulosUsuario();
                permiso6.modulo = new Entidades.Modulo();
                permiso6.modulo.ID = 6;
                permiso6.Consulta = cbxCursosConsulta.Checked;
                permiso6.Alta = cbxCursosAlta.Checked;
                permiso6.Baja = cbxCursosBaja.Checked;
                permiso6.Modificacion = cbxCursosModificacion.Checked;

                tipo.permisos.Add(permiso6);

                //Inscripciones
                Entidades.ModulosUsuario permiso7 = new Entidades.ModulosUsuario();
                permiso7.modulo = new Entidades.Modulo();
                permiso7.modulo.ID = 7;
                permiso7.Consulta = cbxInscripcionesConsulta.Checked;
                permiso7.Alta = cbxInscripcionesAlta.Checked;
                permiso7.Baja = cbxInscripcionesBaja.Checked;
                permiso7.Modificacion = cbxInscripcionesModificacion.Checked;

                tipo.permisos.Add(permiso7);

                //Notas
                Entidades.ModulosUsuario permiso8 = new Entidades.ModulosUsuario();
                permiso8.modulo = new Entidades.Modulo();
                permiso8.modulo.ID = 8;
                permiso8.Consulta = cbxNotasConsulta.Checked;
                permiso8.Alta = cbxNotasAlta.Checked;
                permiso8.Baja = cbxNotasBaja.Checked;
                permiso8.Modificacion = cbxNotasModificacion.Checked;

                tipo.permisos.Add(permiso8);

                Negocio.tipoUsuario negocio = new Negocio.tipoUsuario();
                negocio.addTipoUsuario(tipo);

                loadTipoUsuarios();

                txtDescripcion.Clear();
                cbxPersonasConsulta.Checked = false;
                cbxUsuariosConsulta.Checked = false;
                cbxEspecialidadesConsulta.Checked = false;
                cbxPlanesConsulta.Checked = false;
                cbxMateriasConsulta.Checked = false;
                cbxCursosConsulta.Checked = false;
                cbxInscripcionesConsulta.Checked = false;
                cbxNotasConsulta.Checked = false;
            }
            catch(Exception ex )
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Entidades.TipoUsuario tipo = new Entidades.TipoUsuario();
                tipo.ID = ID;
                tipo.Descripcion = txtDescripcion.Text;
                tipo.permisos = new List<Entidades.ModulosUsuario>();

                //Personas
                Entidades.ModulosUsuario permiso1 = new Entidades.ModulosUsuario();
                permiso1.ID = idPermisos[0];
                permiso1.modulo = new Entidades.Modulo();
                permiso1.modulo.ID = 1;
                permiso1.Consulta = cbxPersonasConsulta.Checked;
                permiso1.Alta = cbxPersonasAlta.Checked;
                permiso1.Baja = cbxPersonasBaja.Checked;
                permiso1.Modificacion = cbxPersonasModificacion.Checked;

                tipo.permisos.Add(permiso1);

                //Usuarios
                Entidades.ModulosUsuario permiso2 = new Entidades.ModulosUsuario();
                permiso2.ID = idPermisos[1];
                permiso2.modulo = new Entidades.Modulo();
                permiso2.modulo.ID = 2;
                permiso2.Consulta = cbxUsuariosConsulta.Checked;
                permiso2.Alta = cbxUsuariosAlta.Checked;
                permiso2.Baja = cbxUsuariosBaja.Checked;
                permiso2.Modificacion = cbxUsuariosModificacion.Checked;

                tipo.permisos.Add(permiso2);

                //Especialidades
                Entidades.ModulosUsuario permiso3 = new Entidades.ModulosUsuario();
                permiso3.ID = idPermisos[2];
                permiso3.modulo = new Entidades.Modulo();
                permiso3.modulo.ID = 3;
                permiso3.Consulta = cbxEspecialidadesConsulta.Checked;
                permiso3.Alta = cbxEspecialidadesAlta.Checked;
                permiso3.Baja = cbxEspecialidadesBaja.Checked;
                permiso3.Modificacion = cbxEspecialidadesModificacion.Checked;

                tipo.permisos.Add(permiso3);

                //Planes
                Entidades.ModulosUsuario permiso4 = new Entidades.ModulosUsuario();
                permiso4.ID = idPermisos[3];
                permiso4.modulo = new Entidades.Modulo();
                permiso4.modulo.ID = 4;
                permiso4.Consulta = cbxPlanesConsulta.Checked;
                permiso4.Alta = cbxPlanesAlta.Checked;
                permiso4.Baja = cbxPlanesBaja.Checked;
                permiso4.Modificacion = cbxPlanesModificacion.Checked;

                tipo.permisos.Add(permiso4);

                //Materias
                Entidades.ModulosUsuario permiso5 = new Entidades.ModulosUsuario();
                permiso5.ID = idPermisos[4];
                permiso5.modulo = new Entidades.Modulo();
                permiso5.modulo.ID = 5;
                permiso5.Consulta = cbxMateriasConsulta.Checked;
                permiso5.Alta = cbxMateriasAlta.Checked;
                permiso5.Baja = cbxMateriasBaja.Checked;
                permiso5.Modificacion = cbxMateriasModificacion.Checked;

                tipo.permisos.Add(permiso5);

                //Cursos
                Entidades.ModulosUsuario permiso6 = new Entidades.ModulosUsuario();
                permiso6.ID = idPermisos[5];
                permiso6.modulo = new Entidades.Modulo();
                permiso6.modulo.ID = 6;
                permiso6.Consulta = cbxCursosConsulta.Checked;
                permiso6.Alta = cbxCursosAlta.Checked;
                permiso6.Baja = cbxCursosBaja.Checked;
                permiso6.Modificacion = cbxCursosModificacion.Checked;

                tipo.permisos.Add(permiso6);

                //Inscripciones
                Entidades.ModulosUsuario permiso7 = new Entidades.ModulosUsuario();
                permiso7.ID = idPermisos[6];
                permiso7.modulo = new Entidades.Modulo();
                permiso7.modulo.ID = 7;
                permiso7.Consulta = cbxInscripcionesConsulta.Checked;
                permiso7.Alta = cbxInscripcionesAlta.Checked;
                permiso7.Baja = cbxInscripcionesBaja.Checked;
                permiso7.Modificacion = cbxInscripcionesModificacion.Checked;

                tipo.permisos.Add(permiso7);

                //Notas
                Entidades.ModulosUsuario permiso8 = new Entidades.ModulosUsuario();
                permiso8.ID = idPermisos[7];
                permiso8.modulo = new Entidades.Modulo();
                permiso8.modulo.ID = 8;
                permiso8.Consulta = cbxNotasConsulta.Checked;
                permiso8.Alta = cbxNotasAlta.Checked;
                permiso8.Baja = cbxNotasBaja.Checked;
                permiso8.Modificacion = cbxNotasModificacion.Checked;

                tipo.permisos.Add(permiso8);

                Negocio.tipoUsuario negocio = new Negocio.tipoUsuario();
                negocio.updateTipoUsuario(tipo);

                loadTipoUsuarios();

                txtDescripcion.Clear();
                cbxPersonasConsulta.Checked = false;
                cbxUsuariosConsulta.Checked = false;
                cbxEspecialidadesConsulta.Checked = false;
                cbxPlanesConsulta.Checked = false;
                cbxMateriasConsulta.Checked = false;
                cbxCursosConsulta.Checked = false;
                cbxInscripcionesConsulta.Checked = false;
                cbxNotasConsulta.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Entidades.TipoUsuario tipo = new Entidades.TipoUsuario();
                tipo.permisos = new List<Entidades.ModulosUsuario>();
                tipo.ID = ID;

                //Personas
                Entidades.ModulosUsuario permiso1 = new Entidades.ModulosUsuario();
                permiso1.ID = idPermisos[0];

                tipo.permisos.Add(permiso1);

                //Usuarios
                Entidades.ModulosUsuario permiso2 = new Entidades.ModulosUsuario();
                permiso2.ID = idPermisos[1];

                tipo.permisos.Add(permiso2);

                //Especialidades
                Entidades.ModulosUsuario permiso3 = new Entidades.ModulosUsuario();
                permiso3.ID = idPermisos[2];

                tipo.permisos.Add(permiso3);

                //Planes
                Entidades.ModulosUsuario permiso4 = new Entidades.ModulosUsuario();
                permiso4.ID = idPermisos[3];

                tipo.permisos.Add(permiso4);

                //Materias
                Entidades.ModulosUsuario permiso5 = new Entidades.ModulosUsuario();
                permiso5.ID = idPermisos[4];

                tipo.permisos.Add(permiso5);

                //Cursos
                Entidades.ModulosUsuario permiso6 = new Entidades.ModulosUsuario();
                permiso6.ID = idPermisos[5];

                tipo.permisos.Add(permiso6);

                //Inscripciones
                Entidades.ModulosUsuario permiso7 = new Entidades.ModulosUsuario();
                permiso7.ID = idPermisos[6];

                tipo.permisos.Add(permiso7);

                //Notas
                Entidades.ModulosUsuario permiso8 = new Entidades.ModulosUsuario();
                permiso8.ID = idPermisos[7];

                tipo.permisos.Add(permiso8);

                Negocio.tipoUsuario negocio = new Negocio.tipoUsuario();
                negocio.deleteTipoUsuario(tipo);

                loadTipoUsuarios();

                txtDescripcion.Clear();
                cbxPersonasConsulta.Checked = false;
                cbxUsuariosConsulta.Checked = false;
                cbxEspecialidadesConsulta.Checked = false;
                cbxPlanesConsulta.Checked = false;
                cbxMateriasConsulta.Checked = false;
                cbxCursosConsulta.Checked = false;
                cbxInscripcionesConsulta.Checked = false;
                cbxNotasConsulta.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
