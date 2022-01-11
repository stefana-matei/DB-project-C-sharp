using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Proiect_final_MTP
{
    public partial class AdaugareNota : UserControl
    {

        MySqlConnection sqlConnection = Connection.getSqlConnection();

        public AdaugareNota()
        {
            InitializeComponent();
        }


        // incarcare Form
        private void AdaugareNota_Load(object sender, EventArgs e)
        {
            dtpData.Format = DateTimePickerFormat.Custom;
            dtpData.CustomFormat = "yyyy-MM-dd";
            //disableButtonAdd();

            #region DataBase
            try
            {
                sqlConnection.Open();

                // selecteaza numarul de legitimatii din tabela de studenti
                string queryNrLegitimatie =
                    " SELECT nr_legitimatie" +
                    " FROM studenti" +
                    " ORDER BY nr_legitimatie ";

                // selecteaza disciplinele din tabela note
                string queryDiscipline =
                    " SELECT DISTINCT disciplina" +
                    " FROM note" +
                    " ORDER BY an_studiu," +
                    "          disciplina";


                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                dataAdapter.SelectCommand = new MySqlCommand();
                dataAdapter.SelectCommand.Connection = sqlConnection;
                dataAdapter.SelectCommand.CommandText = queryNrLegitimatie;

                DataTable dataTableNrLegitimatie = new DataTable();
                DataTable dataTableDiscipline = new DataTable();

                dataAdapter.Fill(dataTableNrLegitimatie);

                // adaugare in combobox-ul cmbNrLegitimatie nr. de legitimatie pentru fiecare student din BD
                for (int i = 0; i < dataTableNrLegitimatie.Rows.Count; i++)
                {
                    cmbNrLegitimatie.Items.Add(dataTableNrLegitimatie.Rows[i]["nr_legitimatie"]);
                }


                dataAdapter.SelectCommand = new MySqlCommand();
                dataAdapter.SelectCommand.Connection = sqlConnection;
                dataAdapter.SelectCommand.CommandText = queryDiscipline;

                dataAdapter.Fill(dataTableDiscipline);

                // adaugare in combobox-ul cmbDiscipline disciplinele din BD
                for (int i = 0; i < dataTableDiscipline.Rows.Count; i++)
                {
                    cmbDiscipline.Items.Add(dataTableDiscipline.Rows[i]["disciplina"]);
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            sqlConnection.Close();
            #endregion

            cmbDiscipline.SelectedIndex = 0;
            cmbNrLegitimatie.SelectedIndex = 0;
        }


        // buton pentru adaugarea unei note unui student in BD
        private void btnAdaugareNota_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAnStudiu.Text.Equals(""))
                {
                    MessageBox.Show("Lipseste anul de studiu, mai incercati!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtNrPrezentare.Text.Equals(""))
                {
                    MessageBox.Show("Lipseste nr-ul prezentarii, mai incercati!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (txtNotaStudent.Text.Equals(""))
                {
                    MessageBox.Show("Lipseste nota, mai incercati!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(isNumber(txtAnStudiu.Text))
                    {
                        if (isNumber(txtNrPrezentare.Text))
                        {
                            if (isGrade(txtNotaStudent.Text))
                            {
                                adaugareNota();
                            }
                            else
                            {
                                MessageBox.Show("Nota invalida, mai incercati!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nr-ul prezentarii trebuie sa fie un numar, mai incercati!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Anul de studiu trebuie sa fie un numar, mai incercati!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // event dupa ce este luat cursorul mouse-ului 
        // de pe textbox-ul in care se introduce nota
        //private void txtNotaStudent_MouseLeave(object sender, EventArgs e)
        //{
        //    if (txtNotaStudent.Text != string.Empty && txtAnStudiu.Text != string.Empty && txtNrPrezentare.Text != string.Empty)
        //    {
        //        btnAdaugareNota.Enabled = true;
        //    }
        //}


        // adaugarea unei note
        private void adaugareNota()
        {
            bool succes = false;

            try
            {
                //  query pentru a introduce o nota in tabela Note
                string query =
                "INSERT INTO `note` (`nr_legitimatie`, `disciplina`, `an_studiu`, `nr_prezentare`, `data`, `nota`) " +
                "VALUES (@nr_legitimatie, @disciplina, @an_studiu, @nr_prezentare, @data, @nota);";

                sqlConnection.Open();
                MySqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.Parameters.AddWithValue("@nr_legitimatie", cmbNrLegitimatie.Text);
                sqlCommand.Parameters.AddWithValue("@disciplina", cmbDiscipline.Text);
                sqlCommand.Parameters.AddWithValue("@an_studiu", Int16.Parse(txtAnStudiu.Text));
                sqlCommand.Parameters.AddWithValue("@nr_prezentare", Int16.Parse(txtNrPrezentare.Text));
                sqlCommand.Parameters.AddWithValue("@data", dtpData.Text);
                sqlCommand.Parameters.AddWithValue("@nota", Double.Parse(txtNotaStudent.Text));

                sqlCommand.CommandText = query;
                if (sqlCommand.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Nota a fost adaugata cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    succes = true;
                }
                else
                {
                    MessageBox.Show("Nota nu  a fost adaugata in BD, mai incercati!", "Atentionare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            sqlConnection.Close();


            if (succes)
            {
                //disableButtonAdd();
                cmbNrLegitimatie.Text = null;
                cmbDiscipline.Text = null;
                txtAnStudiu.Text = "";
                txtNrPrezentare.Text = "";
                dtpData.Text = null;
                txtNotaStudent.Text = "";
            }
        }


        //  verificare daca parametrul dat este un numar
        private bool isNumber(string number)
        {
            if (Regex.IsMatch(number, @"^[0-9]+$"))
            {
                return true;
            }
            else
                return false;
        }

        // verificare daca parametrul dat este o nota valida
        private bool isGrade(string number)
        {
            if (Regex.IsMatch(number, @"^([1-9]{1}|10)$"))
                return true;
            else
                return false;
        }


        // metoda prin care butonul de adaugare se dezactiveaza
        private void disableButtonAdd()
        {
            if (txtAnStudiu.Text == string.Empty && txtNrPrezentare.Text == string.Empty && txtNotaStudent.Text == string.Empty)
            {
                btnAdaugareNota.Enabled = false;
            }
        }

    }
}
