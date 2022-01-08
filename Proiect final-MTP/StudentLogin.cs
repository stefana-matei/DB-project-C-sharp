using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Proiect_final_MTP
{
    public partial class StudentLogin : Form
    {

        public bool mouseDown;
        public bool maximize;
        public bool restore;
        Point lastLocation;

        MySqlConnection sqlConnection = Connection.getSqlConnection();

        public StudentLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        // functionalitate buton de login din Form
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmail.Text.Equals("") && txtPassword.Text.Equals(""))
                {
                    MessageBox.Show("Campurile nu sunt completate, mai incearca!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // daca adresa de email introdusa este valida
                    if (isEmail(txtEmail.Text))
                    {
                        login();
                    }
                    else
                        MessageBox.Show("Adresa de email nu are formatul valid!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // metoda prin care se realizeaza conexiunea unui student existent in aplicatie
        private void login()
        {
            string queryAdmin =
                "SELECT *" +
                " FROM login_student" +
                " WHERE email = @email" +
                "   AND password = @password";


            // prepare the connection
            MySqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.Parameters.AddWithValue("@email", txtEmail.Text);
            sqlCommand.Parameters.AddWithValue("@password", txtPassword.Text);
            sqlCommand.CommandText = queryAdmin;
            MySqlDataReader dataReader;


            try
            {
                sqlConnection.Open();
                dataReader = sqlCommand.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Student.Legitimatie = dataReader.GetString(1);
                        Student.Nume = dataReader.GetString(2);
                        Student.Prenume = dataReader.GetString(3);

                        new StudentForm().Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Student inexistent sau datele introduse sunt gresite!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            sqlConnection.Close();
        }


        // validare adresa de email
        public static bool isEmail(string email)
        {
            if (Regex.IsMatch(email, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$"))
            {
                return true;
            }
            else
                return false;
        }


        // stergerea textului din textbox-uri( clear fields)
        private void btnClearFields_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtPassword.Text = "";
        }



        // accesare form pentru conectare Admin
        private void lblAdminLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }


        // ---------------------butoane pentru Form-ul StudentLogin---------------------
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

        // -----------------------------------------------------------------------------
    }
}
