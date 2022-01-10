using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proiect_final_MTP
{
    public partial class StudentForm : Form
    {
        public bool mouseDown;
        public bool maximize;
        public bool restore;
        Point lastLocation;

        MySqlConnection sqlConnection = Connection.getSqlConnection();

        public StudentForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        // incarcare Form
        private void StudentForm_Load(object sender, EventArgs e)
        {
            if (Student.AnStudiu() == 3)
            {
                btnFoaieMatricola.Visible = true;
            }

            // afisare nume student conectat
            lblLoggedStudentName.Text = Student.Nume + " " + Student.Prenume;
            lblLoggedStudentName.Visible = true;

            btnDiscipline.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Underline);

            situatieFinala.Visible = false;
            restante.Visible = false;
            documente.Visible = false;
            situatieScolara.Show();
        }


        // buton pentru vizualizare situatie scolara
        private void btnSituatieScolara_Click(object sender, EventArgs e)
        {
            btnNoteFinale.Font = new System.Drawing.Font("Georgia", 12F);
            btnRestante.Font = new System.Drawing.Font("Georgia", 12F);
            btnDocumente.Font = new System.Drawing.Font("Georgia", 12F);
            btnFoaieMatricola.Font = new System.Drawing.Font("Georgia", 12F);
            btnDiscipline.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Underline);

            situatieFinala.Visible = false;
            restante.Visible = false;
            documente.Visible = false;
            situatieScolara.Show();
        }


        // buton pentru vizualizarea notelor finale + mediile studentului
        private void btnNoteFinale_Click(object sender, EventArgs e)
        {
            btnDiscipline.Font = new System.Drawing.Font("Georgia", 12F);
            btnRestante.Font = new System.Drawing.Font("Georgia", 12F);
            btnDocumente.Font = new System.Drawing.Font("Georgia", 12F);
            btnFoaieMatricola.Font = new System.Drawing.Font("Georgia", 12F);
            btnNoteFinale.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Underline);

            situatieScolara.Visible = false;
            restante.Visible = false;
            documente.Visible = false;
            situatieFinala.Show();
        }


        // buton pentru vizualizare disciplinele nepromovate
        private void btnRestante_Click(object sender, EventArgs e)
        {
            btnDiscipline.Font = new System.Drawing.Font("Georgia", 12F);
            btnNoteFinale.Font = new System.Drawing.Font("Georgia", 12F);
            btnDocumente.Font = new System.Drawing.Font("Georgia", 12F);
            btnFoaieMatricola.Font = new System.Drawing.Font("Georgia", 12F);
            btnRestante.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Underline);

            situatieScolara.Visible = false;
            situatieFinala.Visible = false;
            documente.Visible = false;
            restante.Show();
        }


        // buton pentru accesare documente
        private void btnDocumente_Click(object sender, EventArgs e)
        {
            btnDiscipline.Font = new System.Drawing.Font("Georgia", 12F);
            btnNoteFinale.Font = new System.Drawing.Font("Georgia", 12F);
            btnRestante.Font = new System.Drawing.Font("Georgia", 12F);
            btnFoaieMatricola.Font = new System.Drawing.Font("Georgia", 12F);
            btnDocumente.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Underline);

            situatieScolara.Visible = false;
            situatieFinala.Visible = false;
            restante.Visible = false;
            documente.Show();
        }


        // buton pentru accesare foaie matricola(pentru student an terminal)
        private void btnFoaieMatricola_Click(object sender, EventArgs e)
        {
            btnDiscipline.Font = new System.Drawing.Font("Georgia", 12F);
            btnNoteFinale.Font = new System.Drawing.Font("Georgia", 12F);
            btnRestante.Font = new System.Drawing.Font("Georgia", 12F);
            btnDocumente.Font = new System.Drawing.Font("Georgia", 12F);
            btnFoaieMatricola.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Underline);

            situatieScolara.Visible = false;
            situatieFinala.Visible = false;
            restante.Visible = false;
            documente.Visible = false;
        }


        // buton de logout
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new StudentLogin().Show();
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
