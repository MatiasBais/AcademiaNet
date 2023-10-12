using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademiaNet
{
    public partial class InscripcionesPorCurso : Form
    {
        Entidades.Curso curso;
        Entidades.Usuario profesor;
        public InscripcionesPorCurso(Entidades.Curso curso, Entidades.Usuario profesor)
        {
            this.curso = curso;
            this.profesor = profesor;
            InitializeComponent();
        }

        public InscripcionesPorCurso(Entidades.Curso curso)
        {
            this.curso = curso;
            this.profesor = null;
            InitializeComponent();
        }

        public void loadInscripciones()
        {
            Negocio.AlumnosInscripciones negocio = new Negocio.AlumnosInscripciones();
            List<Entidades.AlumnosInscripcion> inscripciones = negocio.getInscripciones(curso);

            DataTable dt = new DataTable();
            //id legajo nombre apellido FechaNacimiento Telefono email Plan idEspecialidad Especialidad
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Apellido", typeof(string));
            dt.Columns.Add("Legajo", typeof(string));
            dt.Columns.Add("Condición", typeof(string));
            dt.Columns.Add("Nota", typeof(int));
            dt.Columns.Add("E-Mail", typeof(string));



            foreach (Entidades.AlumnosInscripcion inscripcion in inscripciones)
            {
                DataRow row = dt.NewRow();

                row[0] = inscripcion.ID;
                row[1] = inscripcion.Alumno.Persona.Nombre;
                row[2] = inscripcion.Alumno.Persona.Apellido;
                row[3] = inscripcion.Alumno.Legajo;
                row[4] = inscripcion.Condicion;
                row[5] = inscripcion.Nota;
                row[6] = inscripcion.Alumno.Persona.Email;

                dt.Rows.Add(row);
            }
            dgvInscripciones.DataSource = dt;
            dgvInscripciones.Columns[0].Visible = false;


        }

        private void InscripcionesPorCurso_Load(object sender, EventArgs e)
        {
            if (profesor == null)
            {
                label1.Visible = false;
                label2.Visible = false;
                nudNota.Visible = false;
                cbxCondicion.Visible = false;
                btnAceptar.Visible = false;
                btnCancelar.Visible = false;
                System.Drawing.Size size = new System.Drawing.Size();
                size.Height = 426;
                size.Width = 495;
                dgvInscripciones.Size = size;
                System.Drawing.Point location = new System.Drawing.Point();
                location.X = 12;
                location.Y = 12;
                dgvInscripciones.Location = location;

            }
            loadInscripciones();
            cbxCondicion.SelectedIndex = 0;
        }

        int ID = 0;

        private void dgvInscripciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvInscripciones.SelectedRows[0].Index;
            ID = (int)dgvInscripciones.Rows[index].Cells[0].Value;
            nudNota.Value = (int)dgvInscripciones.Rows[index].Cells[5].Value;
            if (dgvInscripciones.Rows[index].Cells[4].Value.ToString() == "Inscripto")
                cbxCondicion.SelectedIndex = 0;
            else if (dgvInscripciones.Rows[index].Cells[4].Value.ToString() == "Regular")
                cbxCondicion.SelectedIndex = 1;
            else
                cbxCondicion.SelectedIndex = 2;
            btnAceptar.Enabled = true;
            btnCancelar.Enabled = true;
            cbxCondicion.Enabled = true;

        }

        private void clear()
        {
            nudNota.Value = 0;
            cbxCondicion.SelectedIndex = 0;
            btnAceptar.Enabled = false;
            btnCancelar.Enabled = false;
            nudNota.Enabled = false;
            cbxCondicion.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Entidades.AlumnosInscripcion inscripcion = new Entidades.AlumnosInscripcion();
                inscripcion.ID = ID;
                inscripcion.Nota = Convert.ToInt32(nudNota.Value);
                inscripcion.Condicion = cbxCondicion.Text;
                Negocio.AlumnosInscripciones negocio = new Negocio.AlumnosInscripciones();
                negocio.updateInscripcion(inscripcion);
                clear();
                loadInscripciones();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void cbxCondicion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCondicion.Text == "Aprobado")
                nudNota.Enabled = true;
            else
                nudNota.Value = 0;
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {

            //Create a DataTable
            Negocio.AlumnosInscripciones negocio = new Negocio.AlumnosInscripciones();
            List<Entidades.AlumnosInscripcion> inscripciones = negocio.getInscripciones(curso);

            DataTable dt = new DataTable();
            //id legajo nombre apellido FechaNacimiento Telefono email Plan idEspecialidad Especialidad
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Legajo", typeof(string));
            dt.Columns.Add("Condición", typeof(string));
            dt.Columns.Add("Nota", typeof(int));
            dt.Columns.Add("E-Mail", typeof(string));



            foreach (Entidades.AlumnosInscripcion inscripcion in inscripciones)
            {
                DataRow row = dt.NewRow();

                row[0] = inscripcion.Alumno.Persona.Apellido + ", " + inscripcion.Alumno.Persona.Nombre;
                row[1] = inscripcion.Alumno.Legajo;
                row[2] = inscripcion.Condicion;
                row[3] = inscripcion.Nota;
                row[4] = inscripcion.Alumno.Persona.Email;

                dt.Rows.Add(row);
            }
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ExportToPdf(dt, desktopPath + "\\Inscripciones.pdf");
            MessageBox.Show("Reporte generado en el escritorio con éxito");
        }

        public void ExportToPdf(DataTable dt, string strFilePath)
        {
            var pgSize = new iTextSharp.text.Rectangle(444, 631);
            Document document = new Document(pgSize, 15, 15, 0, 0);
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(strFilePath, FileMode.Create));
            document.Open();
            iTextSharp.text.Font font5 = iTextSharp.text.FontFactory.GetFont(FontFactory.HELVETICA, 5);

            Paragraph title = new Paragraph(string.Format(curso.Materia.Descripcion + " - " + curso.Comision.Descripcion + " - " + curso.AnioCalendario), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 20, iTextSharp.text.Font.BOLD));
            title.Alignment = Element.ALIGN_CENTER;
            document.Add(title);

            Paragraph title3 = new Paragraph(string.Format("--"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 20, iTextSharp.text.Font.BOLD));
            title3.Alignment = Element.ALIGN_CENTER;
            document.Add(title3);

            PdfPTable table = new PdfPTable(dt.Columns.Count);
            PdfPRow row = null;
            float[] widths = new float[dt.Columns.Count];
            for (int i = 0; i < dt.Columns.Count; i++)
                widths[i] = 4f;
            widths[1] = 2f;
            widths[3] = 2f;
            widths[4] = 8f;
            table.SetWidths(widths);

            table.WidthPercentage = 80;
            int iCol = 0;
            string colname = "";
            PdfPCell cell = new PdfPCell(new Phrase("Products"));

            cell.Colspan = dt.Columns.Count;

            foreach (DataColumn c in dt.Columns)
            {
                table.AddCell(new Phrase(c.ColumnName, font5));
            }

            foreach (DataRow r in dt.Rows)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int h = 0; h < dt.Columns.Count; h++)
                    {
                        table.AddCell(new Phrase(r[h].ToString(), font5));
                    }
                }
            }
            document.Add(table);
            document.Close();
        }
    }
}
