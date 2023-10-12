using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace AcademiaNet
{
    public partial class EstadoAcademico : Form
    {

        private Entidades.Usuario usuario;
        public EstadoAcademico(int idUsuario)
        {
            Negocio.Usuario u = new Negocio.Usuario();
            usuario = u.getUsuario(idUsuario);
            InitializeComponent();
        }

        private void EstadoAcademico_Load(object sender, EventArgs e)
        {
            string datos = usuario.Persona.Nombre + " " + usuario.Persona.Apellido + " Legajo:   " + usuario.Legajo;
            label2.Text = datos;
            load_EstadoAcademico(sender, e);
        }

        private void load_EstadoAcademico(object sender, EventArgs e)
        {
            List<Entidades.AlumnosInscripcion> inscripciones = new List<Entidades.AlumnosInscripcion>();
            Negocio.AlumnosInscripciones alumnosInscripcion = new Negocio.AlumnosInscripciones();
            inscripciones = alumnosInscripcion.getInscripciones(usuario);

            DataTable dt = new DataTable();

            dt.Columns.Add("Año", typeof(string));
            dt.Columns.Add("Materia", typeof(string));
            dt.Columns.Add("Estado", typeof(string));
            dt.Columns.Add("Nota", typeof(string));
            dt.Columns.Add("Plan", typeof(string));


            foreach (Entidades.AlumnosInscripcion ai in inscripciones)
            {
                DataRow row = dt.NewRow();

                row[0] = ai.Curso.Comision.AnioEspecialidad;
                row[1] = ai.Curso.Materia.Descripcion;
                row[2] = ai.Condicion;
                row[3] = ai.Nota == 0 ? '-' : ai.Nota.ToString();
                row[4] = usuario.Plan.Descripcion;

                dt.Rows.Add(row);
            }
            dgvEstadoAcademico.DataSource = dt;

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

            //Create a DataTable
            List<Entidades.AlumnosInscripcion> inscripciones = new List<Entidades.AlumnosInscripcion>();
            Negocio.AlumnosInscripciones alumnosInscripcion = new Negocio.AlumnosInscripciones();
            inscripciones = alumnosInscripcion.getInscripciones(usuario);

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Año", typeof(string));
            dataTable.Columns.Add("Materia", typeof(string));
            dataTable.Columns.Add("Estado", typeof(string));
            dataTable.Columns.Add("Nota", typeof(string));
            dataTable.Columns.Add("Plan", typeof(string));


            foreach (Entidades.AlumnosInscripcion ai in inscripciones)
            {
                DataRow row = dataTable.NewRow();

                row[0] = ai.Curso.Comision.AnioEspecialidad;
                row[1] = ai.Curso.Materia.Descripcion;
                row[2] = ai.Condicion;
                row[3] = ai.Nota == 0 ? '-' : ai.Nota.ToString();
                row[4] = usuario.Plan.Descripcion;

                dataTable.Rows.Add(row);
            }
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ExportToPdf(dataTable, desktopPath + "\\estadoAcademico.pdf");
            MessageBox.Show("Reporte generado en el escritorio con éxito");

        }

        public void ExportToPdf(DataTable dt, string strFilePath)
        {
            var pgSize = new iTextSharp.text.Rectangle(444, 631);
            Document document = new Document(pgSize, 15, 15, 0, 0);
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(strFilePath, FileMode.Create));
            document.Open();
            iTextSharp.text.Font font5 = iTextSharp.text.FontFactory.GetFont(FontFactory.HELVETICA, 5);

            Paragraph title = new Paragraph(string.Format(usuario.Persona.Apellido + ", " + usuario.Persona.Nombre), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 20, iTextSharp.text.Font.BOLD));
            title.Alignment = Element.ALIGN_CENTER;
            document.Add(title);

            Paragraph title2 = new Paragraph(string.Format(usuario.Plan.Descripcion + " - " + usuario.Plan.Especialidad.Descripcion), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD));
            title2.Alignment = Element.ALIGN_CENTER;
            document.Add(title2);

            Paragraph title3 = new Paragraph(string.Format("--"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 20, iTextSharp.text.Font.BOLD));
            title3.Alignment = Element.ALIGN_CENTER;
            document.Add(title3);

            PdfPTable table = new PdfPTable(dt.Columns.Count);
            PdfPRow row = null;
            float[] widths = new float[dt.Columns.Count];
            for (int i = 0; i < dt.Columns.Count; i++)
                widths[i] = 4f;

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
