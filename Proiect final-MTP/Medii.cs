using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Proiect_final_MTP
{
    public partial class Medii : Form
    {
        public bool mouseDown;
        public bool maximize;
        public bool restore;
        Point lastLocation;

        MySqlConnection sqlConnection = Connection.getSqlConnection();

        public Medii()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void Medii_Load(object sender, EventArgs e)
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

            //  afisare medii in DataGridView de medii
            string mediiDate = "SELECT * FROM medii";
            MySqlDataAdapter dataAdapterMedii = new MySqlDataAdapter(mediiDate, Connection.getConnectBD());
            DataSet dataSetMedii = new DataSet();
            dataAdapterMedii.Fill(dataSetMedii, "medii");
            dgvMedii.DataSource = dataSetMedii.Tables["medii"].DefaultView;

            sqlConnection.Close();
            dataSetMedii.Dispose();
            dataAdapterMedii.Dispose();
        }


        // buton de revenire in pagina principala
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home().Show();
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
