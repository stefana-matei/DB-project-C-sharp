using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Proiect_final_MTP
{
    public partial class Studenti : Form
    {
        public bool mouseDown;
        public bool maximize;
        public bool restore;
        private Point lastLocation;

        MySqlConnection sqlConnection = Connection.getSqlConnection();
        string nr_legitimatie;

        public Studenti()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void Studenti_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            lblUsername.Text = Admin.FullName();
            lblUsername.Visible = true;
            connectToDataBase(sqlConnection);
        }


        // conexiune la baza de date + afisarea datelor din BD in DataGridView
        private void connectToDataBase(MySqlConnection sqlConnection)
        {
            sqlConnection.Open();

            //  afisare studenti in DataGridView de studenti
            string studentiDate = "SELECT * FROM studenti";
            MySqlDataAdapter dataAdapterStudenti = new MySqlDataAdapter(studentiDate, Connection.getConnectBD());
            DataSet dataSetStudenti = new DataSet();
            dataAdapterStudenti.Fill(dataSetStudenti, "studenti");
            dgvStudenti.DataSource = dataSetStudenti.Tables["studenti"].DefaultView;

            sqlConnection.Close();
            dataSetStudenti.Dispose();
            dataAdapterStudenti.Dispose();
        }


        // extragem numarul de legitimatie a studentului selectat din DataGridView
        private void dgvStudenti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvStudenti.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvStudenti.CurrentRow.Selected = true;
                    DataGridViewRow row = this.dgvStudenti.Rows[e.RowIndex];
                    nr_legitimatie = row.Cells["nr_legitimatie"].Value.ToString();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // stergere student selectat din DataGridView din BD
        private void btnStergere_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sunteti sigur ca doriti stergerea studentului cu legitimatie " + nr_legitimatie + " din BD?", "Atentionare", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    string query =
                    " DELETE FROM studenti" +
                    " WHERE nr_legitimatie = " + nr_legitimatie;

                    sqlConnection.Open();
                    MySqlCommand sqlCommand = new MySqlCommand(query, sqlConnection);

                    if (sqlCommand.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Studentul cu legitimatia " + nr_legitimatie + " a fost sters din BD!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Studentul cu legitimatia " + nr_legitimatie + " nu a fost sters din BD, mai incercati!", "Atentionare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
            }
        }


        // buton pentru reincarcarea BD(refresh)
        private void btnRefreshPage_Click(object sender, EventArgs e)
        {
            connectToDataBase(sqlConnection);
        }


        // buton de revenire in pagina principala
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = Instances.getHome();
            home.Show();
        }




        // ---------------------butoane pentru Form-ul Studenti---------------------

        // buton restore
        private void btnRestore_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestore.Visible = false;
            btnMaximize.Location = btnRestore.Location;
            btnMaximize.Visible = true;
        }


        //buton pentru minimize
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            //maximize = false;
        }


        // buton pentru maximize
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximize.Visible = false;
            btnRestore.Location = btnMaximize.Location;
            btnRestore.Visible = true;
        }


        // buton de cancel
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }


        private void panelTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }


        private void panelTitle_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
