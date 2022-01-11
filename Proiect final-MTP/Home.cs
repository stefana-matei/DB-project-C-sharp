using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Proiect_final_MTP
{
    public partial class Home : Form
    {
        public bool mouseDown;
        public bool maximize;
        public bool restore;
        Point lastLocation;

        MySqlConnection sqlConnection = Connection.getSqlConnection();

        public Home()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        // incarcare Form
        private void Home_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            lblUsername.Text = Admin.Nume + " " + Admin.Prenume;
            lblUsername.Visible = true;

            disableButtonsSearch();
        }


        // buton de logout
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            new Login().Show();
        }


        // afisare date din BD in DataGridView
        private void afisareDataGridView(string query)
        {
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, Connection.getConnectBD());
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "studenti");
            dgvCautareStudenti.DataSource = dataSet.Tables["studenti"].DefaultView;

            sqlConnection.Close();
            dataAdapter.Dispose();
            dataSet.Dispose();
        }


        // metoda prin care butoanele din sectiunea cautare se dezactiveaza
        private void disableButtonsSearch()
        {
            if (txtNume.Text == string.Empty)
            {
                btnCautareStudent.Enabled = false;
                btnRefresh.Enabled = false;
            }
        }


        // event dupa ce este luat cursorul mouse-ului 
        // de pe textbox-ul in care se introduce numele studentului
        private void txtNume_MouseLeave(object sender, EventArgs e)
        {
            if (txtNume.Text != string.Empty)
            {
                btnCautareStudent.Enabled = true;
                btnRefresh.Enabled = true;
            }
        }


        // buton de cautare a unui student dupa nume
        private void btnCautareStudent_Click(object sender, EventArgs e)
        {
            // query executat
            string query = "SELECT *" +
                          " FROM studenti " +
                          " WHERE nume LIKE '%" + txtNume.Text + "%'" +
                          "   OR prenume LIKE '%" + txtNume.Text + "%'";

            dgvCautareStudenti.Visible = true;
            afisareDataGridView(query);
        }


        // buton de refresh pentru cautare
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtNume.Text = "";
            dgvCautareStudenti.DataSource = null;
            disableButtonsSearch();
        }


        // buton pentru afisare a tuturor studentilor din BD intr-un nou Form
        private void btnStudenti_Click(object sender, EventArgs e)
        {
            Studenti studenti = new Studenti();
            this.Hide();
            studenti.Show();
        }


        // buton pentru afisarea mediilor studentilor din BD intr-un nou Form
        private void btnMedii_Click(object sender, EventArgs e)
        {
            Medii medii = new Medii();
            this.Hide();
            medii.Show();
        }


        // buton pentru afisarea notelor studentilor din BD intr-un nou Form
        private void btnNote_Click(object sender, EventArgs e)
        {
            Note note = new Note();
            this.Hide();
            note.Show();
        }


        // buton pentru afisarea ratei de promovabilitate a disciplinelor/studentilor + alte statistici
        private void btnPromovabilitate_Click(object sender, EventArgs e)
        {
            Promovabilitate promovabilitate = new Promovabilitate();
            this.Hide();
            promovabilitate.Show();
        }


        // buton pentru afisarea form-ului cu rapoarte
        private void btnRapoarte_Click(object sender, EventArgs e)
        {
            Rapoarte rapoarte = new Rapoarte();
            this.Hide();
            rapoarte.Show();
        }


        #region butoane pentru Form
        // butonul de inchidere a form-ului
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


        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            //maximize = false;
        }


        private void btnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximize.Visible = false;
            btnRestore.Location = btnMaximize.Location;
            btnRestore.Visible = true;
        }


        private void btnRestore_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestore.Visible = false;
            btnMaximize.Location = btnRestore.Location;
            btnMaximize.Visible = true;
        }
        #endregion
    }
}
