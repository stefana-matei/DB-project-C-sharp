
namespace Proiect_final_MTP
{
    partial class Studenti
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblTitluBD = new System.Windows.Forms.Label();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnRefreshPage = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.dgvStudenti = new System.Windows.Forms.DataGridView();
            this.panelTitlu = new System.Windows.Forms.Panel();
            this.btnStergere = new FontAwesome.Sharp.IconButton();
            this.lblStergereStudent = new System.Windows.Forms.Label();
            this.lblStudenti = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitle.SuspendLayout();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).BeginInit();
            this.panelTitlu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitle.Controls.Add(this.lblTitluBD);
            this.panelTitle.Controls.Add(this.btnRestore);
            this.panelTitle.Controls.Add(this.btnMinimize);
            this.panelTitle.Controls.Add(this.btnMaximize);
            this.panelTitle.Controls.Add(this.btnCancel);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.ForeColor = System.Drawing.Color.Black;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1222, 78);
            this.panelTitle.TabIndex = 1;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            this.panelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseMove);
            this.panelTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseUp);
            // 
            // lblTitluBD
            // 
            this.lblTitluBD.AutoSize = true;
            this.lblTitluBD.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblTitluBD.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitluBD.Location = new System.Drawing.Point(7, 9);
            this.lblTitluBD.Name = "lblTitluBD";
            this.lblTitluBD.Size = new System.Drawing.Size(276, 54);
            this.lblTitluBD.TabIndex = 17;
            this.lblTitluBD.Text = "Gestiunea notelor\r\nsi mediilor studentilor\r\n";
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestore.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRestore.FlatAppearance.BorderSize = 0;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRestore.Image = global::Proiect_final_MTP.Properties.Resources.restore3;
            this.btnRestore.Location = new System.Drawing.Point(986, 23);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(57, 30);
            this.btnRestore.TabIndex = 13;
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Visible = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMinimize.Image = global::Proiect_final_MTP.Properties.Resources.minimize3;
            this.btnMinimize.Location = new System.Drawing.Point(1058, 24);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(57, 30);
            this.btnMinimize.TabIndex = 12;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMaximize.Image = global::Proiect_final_MTP.Properties.Resources.maximize3;
            this.btnMaximize.Location = new System.Drawing.Point(1102, 24);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(57, 30);
            this.btnMaximize.TabIndex = 11;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Image = global::Proiect_final_MTP.Properties.Resources.close3;
            this.btnCancel.Location = new System.Drawing.Point(1148, 24);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(57, 30);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelButtons.Controls.Add(this.btnRefreshPage);
            this.panelButtons.Controls.Add(this.lblUsername);
            this.panelButtons.Controls.Add(this.lblImage);
            this.panelButtons.Controls.Add(this.btnHome);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButtons.Location = new System.Drawing.Point(0, 78);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(260, 598);
            this.panelButtons.TabIndex = 2;
            // 
            // btnRefreshPage
            // 
            this.btnRefreshPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnRefreshPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshPage.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnRefreshPage.FlatAppearance.BorderSize = 0;
            this.btnRefreshPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnRefreshPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshPage.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshPage.ForeColor = System.Drawing.Color.White;
            this.btnRefreshPage.Image = global::Proiect_final_MTP.Properties.Resources.refresh;
            this.btnRefreshPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefreshPage.Location = new System.Drawing.Point(12, 67);
            this.btnRefreshPage.Name = "btnRefreshPage";
            this.btnRefreshPage.Size = new System.Drawing.Size(167, 47);
            this.btnRefreshPage.TabIndex = 30;
            this.btnRefreshPage.Text = "Refresh";
            this.btnRefreshPage.UseVisualStyleBackColor = false;
            this.btnRefreshPage.Click += new System.EventHandler(this.btnRefreshPage_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(53, 25);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(102, 24);
            this.lblUsername.TabIndex = 21;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUsername.Visible = false;
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImage.ForeColor = System.Drawing.Color.White;
            this.lblImage.Image = global::Proiect_final_MTP.Properties.Resources.user;
            this.lblImage.Location = new System.Drawing.Point(7, 25);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(40, 24);
            this.lblImage.TabIndex = 20;
            this.lblImage.Text = "      ";
            this.lblImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::Proiect_final_MTP.Properties.Resources.back;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(12, 120);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(143, 47);
            this.btnHome.TabIndex = 11;
            this.btnHome.Text = "Back";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // dgvStudenti
            // 
            this.dgvStudenti.AllowUserToAddRows = false;
            this.dgvStudenti.AllowUserToDeleteRows = false;
            this.dgvStudenti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStudenti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudenti.BackgroundColor = System.Drawing.Color.MintCream;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudenti.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudenti.EnableHeadersVisualStyles = false;
            this.dgvStudenti.Location = new System.Drawing.Point(316, 186);
            this.dgvStudenti.MultiSelect = false;
            this.dgvStudenti.Name = "dgvStudenti";
            this.dgvStudenti.RowHeadersVisible = false;
            this.dgvStudenti.RowHeadersWidth = 51;
            this.dgvStudenti.RowTemplate.Height = 24;
            this.dgvStudenti.Size = new System.Drawing.Size(880, 386);
            this.dgvStudenti.TabIndex = 11;
            this.dgvStudenti.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudenti_CellClick);
            // 
            // panelTitlu
            // 
            this.panelTitlu.Controls.Add(this.btnStergere);
            this.panelTitlu.Controls.Add(this.lblStergereStudent);
            this.panelTitlu.Controls.Add(this.lblStudenti);
            this.panelTitlu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitlu.Location = new System.Drawing.Point(260, 78);
            this.panelTitlu.Name = "panelTitlu";
            this.panelTitlu.Size = new System.Drawing.Size(962, 64);
            this.panelTitlu.TabIndex = 21;
            // 
            // btnStergere
            // 
            this.btnStergere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnStergere.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStergere.FlatAppearance.BorderSize = 2;
            this.btnStergere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStergere.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStergere.ForeColor = System.Drawing.Color.Snow;
            this.btnStergere.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnStergere.IconColor = System.Drawing.Color.Black;
            this.btnStergere.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStergere.Location = new System.Drawing.Point(831, 21);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(105, 37);
            this.btnStergere.TabIndex = 22;
            this.btnStergere.Text = "Stergere";
            this.btnStergere.UseVisualStyleBackColor = false;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // lblStergereStudent
            // 
            this.lblStergereStudent.AutoSize = true;
            this.lblStergereStudent.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStergereStudent.Location = new System.Drawing.Point(605, 30);
            this.lblStergereStudent.Name = "lblStergereStudent";
            this.lblStergereStudent.Size = new System.Drawing.Size(209, 20);
            this.lblStergereStudent.TabIndex = 22;
            this.lblStergereStudent.Text = "Stergere student din BD";
            // 
            // lblStudenti
            // 
            this.lblStudenti.AutoSize = true;
            this.lblStudenti.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblStudenti.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStudenti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStudenti.Location = new System.Drawing.Point(51, 25);
            this.lblStudenti.Name = "lblStudenti";
            this.lblStudenti.Size = new System.Drawing.Size(111, 27);
            this.lblStudenti.TabIndex = 17;
            this.lblStudenti.Text = "Studenti";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 628);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 22);
            this.label1.TabIndex = 23;
            this.label1.Text = "* Selectati din tabel studentul ce doriti sa il eliminati din BD ";
            // 
            // Studenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1222, 676);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelTitlu);
            this.Controls.Add(this.dgvStudenti);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Studenti";
            this.Text = "Studenti";
            this.Load += new System.EventHandler(this.Studenti_Load);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).EndInit();
            this.panelTitlu.ResumeLayout(false);
            this.panelTitlu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.DataGridView dgvStudenti;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblTitluBD;
        private System.Windows.Forms.Panel panelTitlu;
        private System.Windows.Forms.Label lblStudenti;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Label lblStergereStudent;
        private FontAwesome.Sharp.IconButton btnStergere;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefreshPage;
    }
}