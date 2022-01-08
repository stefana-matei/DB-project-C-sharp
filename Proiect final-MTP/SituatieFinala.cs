using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Proiect_final_MTP
{
    public partial class SituatieFinala : UserControl
    {
        MySqlConnection sqlConnection = Connection.getSqlConnection();

        public SituatieFinala()
        {
            InitializeComponent();
        }


        // incarcare Form
        private void SituatieFinala_Load(object sender, EventArgs e)
        {
            incarcareAniUniversitari();
            afisareMedii();
        }


        // incarcare in combobox a anilor universitari ai studentului
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


        // afisare mediile studentului
        private void afisareMedii()
        {
            string query =
                " SELECT *" +
                " FROM medii" +
                " WHERE nr_legitimatie = '" + Student.Legitimatie + "'";

            connectToDataBase(query, dgvMedii);
        }


        // afisare note finale a studentului in functie de anul selectat
        private void cmbAnUniversitar_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblNoteFinale.Text = "Note finale ale disciplinelor din anul " + cmbAnUniversitar.Text;

            string query =
                    " SELECT nr_legitimatie," +
                    "        disciplina," +
                    "        an_studiu," +
                    "        MAX(note.nota) AS nota_finala " +
                    " FROM note " +
                    " WHERE note.nr_legitimatie = '" + Student.Legitimatie + "'" +
                    "   AND note.an_studiu = '" + Int16.Parse(cmbAnUniversitar.Text) + "'" +
                    " GROUP BY note.disciplina" +
                    " ORDER BY note.disciplina";

            connectToDataBase(query, dgvSituatieFinala);
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
