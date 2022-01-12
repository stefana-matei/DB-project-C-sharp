using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace Proiect_final_MTP
{
    public partial class Login : Form
    {
        public bool mouseDown;
        public bool maximize;
        public bool restore;
        Point lastLocation;

        MySqlConnection sqlConnection = Connection.getSqlConnection();

        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        // functionalitate buton de login din Form
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmail.Text.Equals(""))
                {
                    MessageBox.Show("Lipseste email-ul, mai incercati!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtPassword.Text.Equals(""))
                {
                    MessageBox.Show("Lipseste parola, mai incercati!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        // metoda prin care se realizeaza conexiunea unui user existent in aplicatie
        private void login()
        {
            string queryAdmin =
                "SELECT *" +
                " FROM login_administrator" +
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
                        Admin.Nume = dataReader.GetString(1);
                        Admin.Prenume = dataReader.GetString(2);
                        this.Hide(); 
                        new Home().Show();

                    }
                }
                else
                {
                    MessageBox.Show("Utilizator inexistent sau datele introduse sunt gresite!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        // accesare form pentru conectare Student
        private void lblStudentQuestion_Click(object sender, EventArgs e)
        {
            StudentLogin studentLogin = new StudentLogin();
            studentLogin.Show();
            this.Hide();
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
