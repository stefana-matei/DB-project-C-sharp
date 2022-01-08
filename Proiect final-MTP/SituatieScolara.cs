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
    public partial class SituatieScolara : UserControl
    {
        MySqlConnection sqlConnection = Connection.getSqlConnection();

        public SituatieScolara()
        {
            InitializeComponent();
        }


        // incarcare User Control
        private void SituatieScolara_Load(object sender, EventArgs e)
        {
            incarcareAniUniversitari();
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


        // afisare situatia scolara a studentului in functie de anul selectat
        private void cmbAnUniversitar_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblAnUniversitar.Text = "Lista disciplinelor pentru anul " + cmbAnUniversitar.Text + " + note pe prezentari";

            string query =
                    " SELECT note.disciplina," +
                    "        note.an_studiu," +
                    "        note.nr_prezentare," +
                    "        note.data," +
                    "        note.nota " +
                    " FROM note " +
                    " WHERE note.nr_legitimatie = '" + Student.Legitimatie + "'" +
                    "   AND note.an_studiu = '" + Int16.Parse(cmbAnUniversitar.Text) + "'" +
                    " ORDER BY note.an_studiu," +
                    "          note.disciplina," +
                    "          note.nr_prezentare";

            connectToDataBase(query, dgvSituatieScolara);
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
                MessageBox.Show(exception.Message);
            }

            sqlConnection.Close();
        }
    }
}
