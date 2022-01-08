using iText.Kernel.Pdf;
using MySql.Data.MySqlClient;
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

namespace Proiect_final_MTP
{
    public partial class Documente : UserControl
    {
        MySqlConnection sqlConnection = Connection.getSqlConnection();

        public Documente()
        {
            InitializeComponent();
        }


        private void Documente_Load(object sender, EventArgs e)
        {
            //
        }


        // buton pentru generare PDF
        private void btnGenerareDocument_Click(object sender, EventArgs e)
        {
            //string query =
            //    " SELECT disciplina," +
            //    "        an_studiu," +
            //    "        MAX(nota) AS nota_finala" +
            //    " FROM note" +
            //    " WHERE note.nr_legitimatie = '" + Student.Legitimatie + "'" +
            //    " GROUP BY disciplina," +
            //    "          an_studiu" +
            //    "  ORDER BY an_studiu DESC," +
            //    "           disciplina";

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

            exportDataTableToPDF(dataTable, "Raport_detaliat_" + Student.Nume + "_" + Student.Prenume);
        }


        // metoda prin care se exporta datele studentului intr-un document PDF
        private void exportDataTableToPDF(DataTable dataTable, String fileName)
        {
            
        }


        // creare DataTable cu datele din BD(in functie de query-ul executat)
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
