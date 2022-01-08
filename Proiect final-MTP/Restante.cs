using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_final_MTP
{
    public partial class Restante : UserControl
    {
        MySqlConnection sqlConnection = Connection.getSqlConnection();

        public Restante()
        {
            InitializeComponent();
        }


        // incarcare User Control
        private void Restante_Load(object sender, System.EventArgs e)
        {
            incarcareAniUniversitari();
        }


        // incarcare in combobox a anilor universitari ale studentului
        private void incarcareAniUniversitari()
        {
            try
            {
                sqlConnection.Open();

                // selecteaza anii de studiu pentru studentul conectat din tabela note
                string queryAnStudiu =
                    " SELECT DISTINCT an_studiu" +
                    " FROM note" +
                    " WHERE nr_legitimatie = '" + Student.Legitimatie + "'";


                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                dataAdapter.SelectCommand = new MySqlCommand();
                dataAdapter.SelectCommand.Connection = sqlConnection;
                dataAdapter.SelectCommand.CommandText = queryAnStudiu;

                DataTable dataTable = new DataTable();

                dataAdapter.Fill(dataTable);

                // adaugare in combobox-ul cmbNrLegitimatie nr. de legitimatie pentru fiecare student din BD
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    cmbAnUniversitar.Items.Add(dataTable.Rows[i]["an_studiu"]);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            sqlConnection.Close();
        }


        // afisare discipline nepromovate ale studentului 
        private void cmbAnUniversitar_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblRestante.Text = "Lista disciplinelor nepromovate in anul " + cmbAnUniversitar.Text;

            string query =
                " SELECT nr_legitimatie," +
                "        disciplina," +
                "        an_studiu," +
                "        MAX(nota) AS nota_finala" +
                " FROM note" +
                " WHERE note.nr_legitimatie = '" + Student.Legitimatie + "'" +
                "   AND note.an_studiu = '" + Int16.Parse(cmbAnUniversitar.Text) + "'" +
                " GROUP BY disciplina" +
                " HAVING nota_finala < 5" +
                " ORDER BY disciplina";

            connectToDataBase(query, dgvRestante);
        }


        // metoda pentru a afisa in DataGridView datele din BD
        private void connectToDataBase(string query, DataGridView dataGridView)
        {
            try
            {
                sqlConnection.Open();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                dataAdapter.SelectCommand = new MySqlCommand(query, sqlConnection);

                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;

                dataGridView.DataSource = bindingSource;

                dataTable.Dispose();
                dataAdapter.Dispose();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            sqlConnection.Close();
        }
    }
}
