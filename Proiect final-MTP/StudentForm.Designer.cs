
namespace Proiect_final_MTP
{
    partial class StudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTitle = new System.Windows.Forms.Panel();
            this.pictureStudentIcon = new System.Windows.Forms.PictureBox();
            this.lblLoggedStudentName = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnNoteFinale = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnRestante = new System.Windows.Forms.Button();
            this.btnDocumente = new System.Windows.Forms.Button();
            this.btnDiscipline = new System.Windows.Forms.Button();
            this.documente = new Proiect_final_MTP.Documente();
            this.restante = new Proiect_final_MTP.Restante();
            this.situatieFinala = new Proiect_final_MTP.SituatieFinala();
            this.situatieScolara = new Proiect_final_MTP.SituatieScolara();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStudentIcon)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(194)))));
            this.panelTitle.Controls.Add(this.pictureStudentIcon);
            this.panelTitle.Controls.Add(this.lblLoggedStudentName);
            this.panelTitle.Controls.Add(this.btnMinimize);
            this.panelTitle.Controls.Add(this.btnMaximize);
            this.panelTitle.Controls.Add(this.btnCancel);
            this.panelTitle.Controls.Add(this.btnRestore);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.ForeColor = System.Drawing.Color.Black;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1378, 70);
            this.panelTitle.TabIndex = 1;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            this.panelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseMove);
            this.panelTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseUp);
            // 
            // pictureStudentIcon
            // 
            this.pictureStudentIcon.Image = global::Proiect_final_MTP.Properties.Resources.icons8_student_center_30__2_;
            this.pictureStudentIcon.Location = new System.Drawing.Point(25, 20);
            this.pictureStudentIcon.Name = "pictureStudentIcon";
            this.pictureStudentIcon.Size = new System.Drawing.Size(34, 33);
            this.pictureStudentIcon.TabIndex = 15;
            this.pictureStudentIcon.TabStop = false;
            // 
            // lblLoggedStudentName
            // 
            this.lblLoggedStudentName.AutoSize = true;
            this.lblLoggedStudentName.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblLoggedStudentName.ForeColor = System.Drawing.Color.White;
            this.lblLoggedStudentName.Location = new System.Drawing.Point(65, 22);
            this.lblLoggedStudentName.Name = "lblLoggedStudentName";
            this.lblLoggedStudentName.Size = new System.Drawing.Size(187, 27);
            this.lblLoggedStudentName.TabIndex = 14;
            this.lblLoggedStudentName.Text = "Student_Name\r\n";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(194)))));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Image = global::Proiect_final_MTP.Properties.Resources.minimize3;
            this.btnMinimize.Location = new System.Drawing.Point(1214, 24);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(57, 30);
            this.btnMinimize.TabIndex = 12;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(194)))));
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.ForeColor = System.Drawing.Color.Transparent;
            this.btnMaximize.Image = global::Proiect_final_MTP.Properties.Resources.maximize3;
            this.btnMaximize.Location = new System.Drawing.Point(1258, 24);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(57, 30);
            this.btnMaximize.TabIndex = 11;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(194)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancel.Image = global::Proiect_final_MTP.Properties.Resources.close3;
            this.btnCancel.Location = new System.Drawing.Point(1304, 24);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(57, 30);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(194)))));
            this.btnRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestore.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRestore.FlatAppearance.BorderSize = 0;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.ForeColor = System.Drawing.Color.Transparent;
            this.btnRestore.Image = global::Proiect_final_MTP.Properties.Resources.restore3;
            this.btnRestore.Location = new System.Drawing.Point(1142, 23);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(57, 30);
            this.btnRestore.TabIndex = 13;
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Visible = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.btnNoteFinale);
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Controls.Add(this.btnRestante);
            this.panelMenu.Controls.Add(this.btnDocumente);
            this.panelMenu.Controls.Add(this.btnDiscipline);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 70);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1378, 75);
            this.panelMenu.TabIndex = 2;
            // 
            // btnNoteFinale
            // 
            this.btnNoteFinale.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNoteFinale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNoteFinale.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnNoteFinale.FlatAppearance.BorderSize = 0;
            this.btnNoteFinale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(194)))));
            this.btnNoteFinale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoteFinale.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoteFinale.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnNoteFinale.Location = new System.Drawing.Point(219, 22);
            this.btnNoteFinale.Name = "btnNoteFinale";
            this.btnNoteFinale.Size = new System.Drawing.Size(143, 37);
            this.btnNoteFinale.TabIndex = 18;
            this.btnNoteFinale.Text = "Situatie finala";
            this.btnNoteFinale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNoteFinale.UseVisualStyleBackColor = false;
            this.btnNoteFinale.Click += new System.EventHandler(this.btnNoteFinale_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(194)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnLogout.Image = global::Proiect_final_MTP.Properties.Resources.icons8_logout_24;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(1213, 17);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(109, 47);
            this.btnLogout.TabIndex = 17;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnRestante
            // 
            this.btnRestante.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRestante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestante.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnRestante.FlatAppearance.BorderSize = 0;
            this.btnRestante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(194)))));
            this.btnRestante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestante.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestante.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnRestante.Location = new System.Drawing.Point(421, 22);
            this.btnRestante.Name = "btnRestante";
            this.btnRestante.Size = new System.Drawing.Size(99, 37);
            this.btnRestante.TabIndex = 13;
            this.btnRestante.Text = "Restante";
            this.btnRestante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestante.UseVisualStyleBackColor = false;
            this.btnRestante.Click += new System.EventHandler(this.btnRestante_Click);
            // 
            // btnDocumente
            // 
            this.btnDocumente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDocumente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDocumente.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnDocumente.FlatAppearance.BorderSize = 0;
            this.btnDocumente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(194)))));
            this.btnDocumente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocumente.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocumente.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnDocumente.Location = new System.Drawing.Point(583, 22);
            this.btnDocumente.Name = "btnDocumente";
            this.btnDocumente.Size = new System.Drawing.Size(124, 37);
            this.btnDocumente.TabIndex = 12;
            this.btnDocumente.Text = "Documente";
            this.btnDocumente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocumente.UseVisualStyleBackColor = false;
            this.btnDocumente.Click += new System.EventHandler(this.btnDocumente_Click);
            // 
            // btnDiscipline
            // 
            this.btnDiscipline.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDiscipline.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiscipline.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnDiscipline.FlatAppearance.BorderSize = 0;
            this.btnDiscipline.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(194)))));
            this.btnDiscipline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscipline.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscipline.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnDiscipline.Location = new System.Drawing.Point(69, 22);
            this.btnDiscipline.Name = "btnDiscipline";
            this.btnDiscipline.Size = new System.Drawing.Size(114, 37);
            this.btnDiscipline.TabIndex = 11;
            this.btnDiscipline.Text = "Discipline";
            this.btnDiscipline.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiscipline.UseVisualStyleBackColor = false;
            this.btnDiscipline.Click += new System.EventHandler(this.btnSituatieScolara_Click);
            // 
            // documente
            // 
            this.documente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.documente.Location = new System.Drawing.Point(0, 145);
            this.documente.Name = "documente";
            this.documente.Size = new System.Drawing.Size(1378, 600);
            this.documente.TabIndex = 6;
            // 
            // restante
            // 
            this.restante.Location = new System.Drawing.Point(0, 145);
            this.restante.Name = "restante";
            this.restante.Size = new System.Drawing.Size(1378, 600);
            this.restante.TabIndex = 5;
            // 
            // situatieFinala
            // 
            this.situatieFinala.BackColor = System.Drawing.Color.WhiteSmoke;
            this.situatieFinala.Location = new System.Drawing.Point(0, 145);
            this.situatieFinala.Name = "situatieFinala";
            this.situatieFinala.Size = new System.Drawing.Size(1378, 600);
            this.situatieFinala.TabIndex = 4;
            // 
            // situatieScolara
            // 
            this.situatieScolara.BackColor = System.Drawing.Color.WhiteSmoke;
            this.situatieScolara.Dock = System.Windows.Forms.DockStyle.Top;
            this.situatieScolara.Location = new System.Drawing.Point(0, 145);
            this.situatieScolara.Name = "situatieScolara";
            this.situatieScolara.Size = new System.Drawing.Size(1378, 600);
            this.situatieScolara.TabIndex = 3;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1378, 787);
            this.Controls.Add(this.documente);
            this.Controls.Add(this.restante);
            this.Controls.Add(this.situatieFinala);
            this.Controls.Add(this.situatieScolara);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStudentIcon)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblLoggedStudentName;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.PictureBox pictureStudentIcon;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnDiscipline;
        private System.Windows.Forms.Button btnRestante;
        private System.Windows.Forms.Button btnDocumente;
        private SituatieScolara situatieScolara;
        private System.Windows.Forms.Button btnNoteFinale;
        private System.Windows.Forms.Button btnLogout;
        private SituatieFinala situatieFinala;
        private Restante restante;
        private Documente documente;
    }
}