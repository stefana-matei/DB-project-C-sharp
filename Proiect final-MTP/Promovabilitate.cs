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
    public partial class Promovabilitate : Form
    {
        public bool mouseDown;
        public bool maximize;
        public bool restore;
        private Point lastLocation;


        public Promovabilitate()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void Promovabilitate_Load(object sender, EventArgs e)
        {
            lblImage.Visible = true;
            lblUsername.Text = Admin.Nume + " " + Admin.Prenume;
            lblUsername.Visible = true;
        }


        // buton de revenire in pagina principala
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = Instances.getHome();
            home.Show();
        }


        // buton pentru afisarea promovabilitatii fiecarei discipline
        private void btnPromovabilitateMaterii_Click(object sender, EventArgs e)
        {
            string titlu = "Rata de promovabilitate a disciplinelor";

            string query =
                    " SELECT note.disciplina," +
                    "        note.an_studiu AS an_studiu_disciplina," +
                    "        CONCAT(promovabilitate_disciplina(note.disciplina), '%') AS promovabilitate_disciplina" + // se apeleaza functia ce calculeaza rata de promovare a unei discipline
                    " FROM note" +
                    " GROUP BY note.an_studiu," +
                    "          note.disciplina";

            connectToDataBase(query, titlu);
        }


        // buton pentru afisarea promovabilitatii studentilor
        private void btnPromovabilitateStudenti_Click(object sender, EventArgs e)
        {
            string titlu = "Rata de promovabilitate a studentilor";

            string query =
                    " SELECT studenti.nr_legitimatie," +
                    "        studenti.nume," +
                    "        studenti.prenume," +
                    "        COUNT(note.nr_prezentare) AS prezentari_examene," +
                    "        CONCAT(promovabilitate_student(note.nr_legitimatie), '%') AS rata_promovare" + // se apeleaza functia ce calculeaza rata de promovare a unui student
                    " FROM studenti," +
                    "      note" +
                    " WHERE studenti.nr_legitimatie = note.nr_legitimatie" +
                    " GROUP BY note.nr_legitimatie" +
                    " ORDER BY studenti.nume," +
                    "          studenti.prenume";

            connectToDataBase(query, titlu);
        }


        // buton pentru afisarea studentilor cu doi ani consecutivi nepromovati
        private void btnAniNepromovati_Click(object sender, EventArgs e)
        {
            string titlu = "Studenti cu doi ani consecutivi nepromovati";

            string query =
                    " WITH ani_nepromovati AS" +
                    "   (" +
                    "       SELECT *" +
                    "       FROM studenti" +
                    "       LEFT JOIN" +
                    "         (" +
                    "             SELECT note1.nr_legitimatie," +
                    "                    note1.an_studiu AS primul_an," +
                    "                    MAX(note1.nota) as maxim_nota1," +
                    "                    note2.an_studiu AS al_doilea_an_consecutiv," +
                    "                    MAX(note2.nota) AS maxim_nota2" +
                    "             FROM note AS note1," +
                    "                  note AS note2" +
                    "             WHERE note1.an_studiu + 1 = note2.an_studiu" +
                    "               AND note1.nr_legitimatie = note2.nr_legitimatie" +
                    "             GROUP BY note1.nr_legitimatie, note1.an_studiu" +
                    "         )" +
                    "         AS note_joined USING(nr_legitimatie)" +
                    "       WHERE note_joined.maxim_nota1 < 5" +
                    "         AND note_joined.maxim_nota2 < 5" +
                    "   )" +
                    "" +
                    " SELECT ani_nepromovati.nume," +
                    "        ani_nepromovati.prenume," +
                    "        ani_nepromovati.nr_legitimatie," +
                    "        ani_nepromovati.primul_an," +
                    "        ani_nepromovati.al_doilea_an_consecutiv" +
                    " FROM ani_nepromovati" +
                    " GROUP BY ani_nepromovati.nr_legitimatie," +
                    "          ani_nepromovati.primul_an";

            connectToDataBase(query, titlu);
        }


        // buton pentru afisarea studentilor cu discipline nepromovate
        private void btnDisciplineNepromovate_Click(object sender, EventArgs e)
        {
            string titlu = "Studenti cu discipline nepromovate";

            string query =
                " WITH studenti_discipline_nepromovate AS" +
                "   (" +
                "       SELECT *" +
                "       FROM studenti " +
                "       LEFT JOIN " +
                "         (" +
                "             SELECT nr_legitimatie," +
                "                    disciplina," +
                "                    an_studiu AS an_studiu_disciplina," +
                "                    MAX(nota) AS nota" +
                "             FROM note" +
                "             GROUP BY note.nr_legitimatie," +
                "                      disciplina," +
                "                      note.an_studiu " +
                "         )" +
                "         AS joined USING(nr_legitimatie) " +
                "       WHERE joined.nota < 5" +
                "   )" +
                " SELECT DISTINCT nr_legitimatie," +
                "                 nume," +
                "                 prenume," +
                "                 an_studiu_disciplina," +
                "                 disciplina," +
                "                 nota" +
                " FROM studenti_discipline_nepromovate" +
                " ORDER BY nume," +
                "          prenume," +
                "          an_studiu_disciplina";

            connectToDataBase(query, titlu);
        }


        // metoda ce se apeleaza la fiecare buton pentru a afisa in DataGridView datele din BD 
        private void connectToDataBase(string query, string titluPagina)
        {
            dgvPromovabilitate.Visible = true;
            lblPromovabilitate.Text = titluPagina;
            lblOptiune.Visible = false;

            try
            {
                MySqlConnection sqlConnection = Connection.getSqlConnection();
                sqlConnection.Open();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                dataAdapter.SelectCommand = new MySqlCommand(query, sqlConnection);

                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;

                dgvPromovabilitate.DataSource = bindingSource;


                sqlConnection.Close();
                dataTable.Dispose();
                dataAdapter.Dispose();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }


        // --------------------butoane pentru Form Border-ul Promovabilitate--------------------
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
    }
}
