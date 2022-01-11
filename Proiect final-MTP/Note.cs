using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Proiect_final_MTP
{
    public partial class Note : Form
    {
        public bool mouseDown;
        public bool maximize;
        public bool restore;
        Point lastLocation;

        MySqlConnection sqlConnection = Connection.getSqlConnection();

        public Note()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        // incarcare Form
        private void Note_Load(object sender, EventArgs e)
        {
            adaugareNota.Visible = false;
            lblUsername.Text = Admin.FullName();
            lblUsername.Visible = true;
            btnBackNoteForm.Visible = false;
            afisareDataGridView(sqlConnection);
        }


        // afisarea datelor din BD in DataGridView
        private void afisareDataGridView(MySqlConnection sqlConnection)
        {
            //  afisare note in DataGridView de note
            string noteDate =
                " SELECT * " +
                " FROM note" +
                " ORDER BY nr_legitimatie," +
                "          disciplina," +
                "          nr_prezentare";

            sqlConnection.Open();

            MySqlDataAdapter dataAdapterNote = new MySqlDataAdapter(noteDate, Connection.getConnectBD());
            DataSet dataSetNote = new DataSet();
            dataAdapterNote.Fill(dataSetNote, "note");
            dgvNote.DataSource = dataSetNote.Tables["note"].DefaultView;

            sqlConnection.Close();
            dataSetNote.Dispose();
            dataAdapterNote.Dispose();
        }


        // adaugare nota unui student 
        private void btnAdaugareNota_Click(object sender, EventArgs e)
        {
            adaugareNota.Visible = true;
            lblNoteForm.Text = "Adaugare nota";
            dgvNote.Visible = false;
            btnBackNoteForm.Visible = true;
        }


        // buton de revenire in pagina principala
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home().Show();
        }


        // buton de revenire la prima pagina a Form-ului Note
        private void btnBackNoteForm_Click(object sender, EventArgs e)
        {
            afisareDataGridView(sqlConnection);
            lblNoteForm.Text = "Note";
            dgvNote.Visible = true;
            adaugareNota.Visible = false;
            btnBackNoteForm.Visible = false;
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
