using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Proiect_final_MTP
{
    public partial class Rapoarte : Form
    {
        public bool mouseDown;
        public bool maximize;
        public bool restore;
        Point lastLocation;

        MySqlConnection sqlConnection = Connection.getSqlConnection();

        public Rapoarte()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void Rapoarte_Load(object sender, EventArgs e)
        {
            lblImage.Visible = true;
            lblUsername.Text = Admin.FullName();
            lblUsername.Visible = true;
        }


        // buton de revenire in pagina principala
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = Instances.getHome();
            home.Show();
        }


        // buton pentru a afisa raport cu anul de studiu curent pentru fiecare student
        // ordonate alfabetic dupa nume, prenume
        private void btnRaportStudenti_Click(object sender, EventArgs e)
        {
            string titlu = "Raport studenti";

            string query =
                    " SELECT *" +
                    " FROM studenti " +
                    " LEFT JOIN " +
                    "   (" +
                    "       SELECT nr_legitimatie," +
                    "              MAX(an_studiu) AS an_studiu" +
                    "       FROM note" +
                    "       GROUP BY note.nr_legitimatie" +
                    "   )" +
                    "   AS joined USING(nr_legitimatie)" +
                    " ORDER BY studenti.nume," +
                    "          studenti.prenume";

            connectToDataBase(query, titlu);
        }


        // buton pentru afisare raport cu notele finale la disciplinele promovate
        private void btnRaportNoteFinale_Click(object sender, EventArgs e)
        {
            string titlu = "Raport detaliat cu notele finale la disciplinele promovate";

            string query =
                    " SELECT studenti.nume," +
                    "        studenti.prenume," +
                    "        studenti.nr_legitimatie," +
                    "        note.disciplina," +
                    "        note.an_studiu," +
                    "        MAX(note.nota) AS nota_finala " +
                    " FROM studenti," +
                    "      note " +
                    " WHERE studenti.nr_legitimatie = note.nr_legitimatie " +
                    " GROUP BY note.nr_legitimatie," +
                    "          note.disciplina,note.an_studiu " +
                    " HAVING nota_finala >= 5 " +
                    " ORDER BY studenti.nume," +
                    "          studenti.prenume," +
                    "          note.an_studiu," +
                    "          note.disciplina";

            connectToDataBase(query, titlu);
        }


        // metoda ce se apeleaza la fiecare buton pentru a afisa in DataGridView datele din BD 
        private void connectToDataBase(string query, string titluPagina)
        {
            dgvRapoarte.Visible = true;
            lblRapoarte.Text = titluPagina;
            lblOptiune.Visible = false;

            try
            {
                sqlConnection.Open();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                dataAdapter.SelectCommand = new MySqlCommand(query, sqlConnection);

                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;

                dgvRapoarte.DataSource = bindingSource;


                sqlConnection.Close();
                dataTable.Dispose();
                dataAdapter.Dispose();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }


        // ---------------------butoane pentru Form-ul Rapoarte---------------------


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

        // restore
        private void btnRestore_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestore.Visible = false;
            btnMaximize.Location = btnRestore.Location;
            btnMaximize.Visible = true;
        }
    }
}
