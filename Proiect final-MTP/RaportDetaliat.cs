using iText.IO.Font.Constants;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace Proiect_final_MTP
{
    public partial class RaportDetaliat : UserControl
    {
        MySqlConnection sqlConnection = Connection.getSqlConnection();

        public RaportDetaliat()
        {
            InitializeComponent();
        }


        // buton pentru generare PDF
        private void btnGenerareDocument_Click(object sender, EventArgs e)
        {
            string query =
                   " SELECT note.disciplina," +
                   "        note.an_studiu," +
                   "        note.nr_prezentare," +
                   "        DATE_FORMAT(note.data, '%d-%m-%Y') AS data," +
                   "        note.nota " +
                   " FROM note " +
                   " WHERE note.nr_legitimatie = '" + Student.Legitimatie + "'" +
                   " ORDER BY note.an_studiu DESC," +
                   "          note.disciplina," +
                   "          note.nr_prezentare";

            DataTable dataTable = makeDataTable(query);

            exportRaport(dataTable, "Raport_detaliat_" + Student.Nume + "_" + Student.Prenume);
        }


        // metoda prin care se exporta datele studentului intr-un document PDF
        private void exportRaport(DataTable dataTable, String fileName)
        {
            PdfWriter pdfWriter = new PdfWriter(fileName);
            PdfDocument pdfDocument = new PdfDocument(pdfWriter);
            Document document = new Document(pdfDocument);
            Style style = new Style();

            PdfFont font = PdfFontFactory.CreateFont(StandardFonts.TIMES_ROMAN);


            #region header
            Paragraph headerParagraph = new Paragraph()
                .Add("Raport detaliat".ToUpper())
                .Add("\nlista disciplinelor contractate".ToUpper())
                .Add("\n(promovate, restante)".ToUpper())
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(16)
                .SetFont(font)
                .SetFontColor(ColorConstants.DARK_GRAY);
            #endregion

            #region data generarii documentului
            Paragraph dataParagraph = new Paragraph()
                .Add("\n" + DateTime.Now.ToShortDateString())
                .SetTextAlignment(TextAlignment.RIGHT)
                .SetFontSize(12)
                .SetFont(font)
                .SetFontColor(ColorConstants.DARK_GRAY);
            #endregion

            #region informatii student
            Paragraph infoParagraph = new Paragraph()
                .Add("Studentul: " + Student.FullName().ToUpper())
                .Add("\nAnul de studiu: ".ToUpper() + Student.AnStudiu())
                .Add("\nSpecializarea: ".ToUpper() + "Informatica")
                .SetTextAlignment(TextAlignment.JUSTIFIED)
                .SetFontSize(12)
                .SetFont(font)
                .SetFontColor(ColorConstants.DARK_GRAY);
            #endregion

            #region linie separatoare
            LineSeparator lineSeparator = new LineSeparator(new SolidLine());
            #endregion

            #region linie noua
            Paragraph newLineParagraph = new Paragraph(new Text("\n"));
            #endregion

            #region tabel
            Table table = new Table(dataTable.Columns.Count, false);
            table.SetMinWidth(100)
                 .SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER)
                 .SetFontSize(10);

            for (int i = 0; i < dataTable.Columns.Count;i++)
            {
                Cell cell = new Cell()
                    .SetBackgroundColor(ColorConstants.GRAY)
                    .SetFont(font)
                    .SetFontSize(10)
                    .SetFontColor(ColorConstants.WHITE)
                    .Add(new Paragraph(dataTable.Columns[i].ColumnName.ToUpper()));

                table.AddCell(cell);
            }

            for(int i = 0; i < dataTable.Rows.Count; i++)
            {
                for(int j = 0; j < dataTable.Columns.Count; j++)
                {
                    table.AddCell(dataTable.Rows[i][j].ToString());
                }
            }
            #endregion

            #region salvare fisier PDF
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = fileName;
            saveFileDialog.DefaultExt = ".pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                document.Add(headerParagraph);
                document.Add(dataParagraph);
                document.Add(infoParagraph);
                document.Add(lineSeparator);
                document.Add(newLineParagraph);
                document.Add(table);
                document.Add(newLineParagraph);
                document.Close();

                MessageBox.Show("Document generat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblDataRaport.Visible = true;
                lblDataRaport.Text = "Data generare: " + DateTime.Now.ToString();


                Process.Start(fileName);
            }
            #endregion
        }


        // creare DataTable cu datele din BD
        private DataTable makeDataTable(string query)
        {
            sqlConnection.Open();

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
            dataAdapter.SelectCommand = new MySqlCommand(query, sqlConnection);

            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            dataTable.Dispose();
            dataAdapter.Dispose();
            sqlConnection.Close();

            return dataTable;
        }
    }
}
