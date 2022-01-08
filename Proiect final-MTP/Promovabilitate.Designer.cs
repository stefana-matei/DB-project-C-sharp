
namespace Proiect_final_MTP
{
    partial class Promovabilitate
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblTitluForm = new System.Windows.Forms.Label();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnDisciplineNepromovate = new System.Windows.Forms.Button();
            this.btnAniNepromovati = new System.Windows.Forms.Button();
            this.lblImageList = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.btnPromovabilitateStudenti = new System.Windows.Forms.Button();
            this.btnPromovabilitateMaterii = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelTitlu = new System.Windows.Forms.Panel();
            this.lblOptiune = new System.Windows.Forms.Label();
            this.lblPromovabilitate = new System.Windows.Forms.Label();
            this.dgvPromovabilitate = new System.Windows.Forms.DataGridView();
            this.panelTitle.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelTitlu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromovabilitate)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitle.Controls.Add(this.lblTitluForm);
            this.panelTitle.Controls.Add(this.btnRestore);
            this.panelTitle.Controls.Add(this.btnMinimize);
            this.panelTitle.Controls.Add(this.btnMaximize);
            this.panelTitle.Controls.Add(this.btnCancel);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.ForeColor = System.Drawing.Color.Black;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1222, 78);
            this.panelTitle.TabIndex = 7;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            this.panelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseMove);
            this.panelTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseUp);
            // 
            // lblTitluForm
            // 
            this.lblTitluForm.AutoSize = true;
            this.lblTitluForm.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblTitluForm.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitluForm.Location = new System.Drawing.Point(12, 9);
            this.lblTitluForm.Name = "lblTitluForm";
            this.lblTitluForm.Size = new System.Drawing.Size(276, 54);
            this.lblTitluForm.TabIndex = 15;
            this.lblTitluForm.Text = "Gestiunea notelor\r\nsi mediilor studentilor\r\n";
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
            this.panelButtons.Controls.Add(this.btnDisciplineNepromovate);
            this.panelButtons.Controls.Add(this.btnAniNepromovati);
            this.panelButtons.Controls.Add(this.lblImageList);
            this.panelButtons.Controls.Add(this.lblUsername);
            this.panelButtons.Controls.Add(this.lblImage);
            this.panelButtons.Controls.Add(this.btnPromovabilitateStudenti);
            this.panelButtons.Controls.Add(this.btnPromovabilitateMaterii);
            this.panelButtons.Controls.Add(this.btnHome);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButtons.Location = new System.Drawing.Point(0, 78);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(260, 598);
            this.panelButtons.TabIndex = 8;
            // 
            // btnDisciplineNepromovate
            // 
            this.btnDisciplineNepromovate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnDisciplineNepromovate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisciplineNepromovate.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnDisciplineNepromovate.FlatAppearance.BorderSize = 0;
            this.btnDisciplineNepromovate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnDisciplineNepromovate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisciplineNepromovate.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisciplineNepromovate.ForeColor = System.Drawing.Color.White;
            this.btnDisciplineNepromovate.Location = new System.Drawing.Point(17, 482);
            this.btnDisciplineNepromovate.Name = "btnDisciplineNepromovate";
            this.btnDisciplineNepromovate.Size = new System.Drawing.Size(176, 86);
            this.btnDisciplineNepromovate.TabIndex = 31;
            this.btnDisciplineNepromovate.Text = "Studenti cu discipline nepromovate";
            this.btnDisciplineNepromovate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDisciplineNepromovate.UseVisualStyleBackColor = false;
            this.btnDisciplineNepromovate.Click += new System.EventHandler(this.btnDisciplineNepromovate_Click);
            // 
            // btnAniNepromovati
            // 
            this.btnAniNepromovati.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnAniNepromovati.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAniNepromovati.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnAniNepromovati.FlatAppearance.BorderSize = 0;
            this.btnAniNepromovati.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAniNepromovati.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAniNepromovati.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAniNepromovati.ForeColor = System.Drawing.Color.White;
            this.btnAniNepromovati.Location = new System.Drawing.Point(17, 379);
            this.btnAniNepromovati.Name = "btnAniNepromovati";
            this.btnAniNepromovati.Size = new System.Drawing.Size(176, 86);
            this.btnAniNepromovati.TabIndex = 30;
            this.btnAniNepromovati.Text = "Ani consecutivi nepromovati";
            this.btnAniNepromovati.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAniNepromovati.UseVisualStyleBackColor = false;
            this.btnAniNepromovati.Click += new System.EventHandler(this.btnAniNepromovati_Click);
            // 
            // lblImageList
            // 
            this.lblImageList.AutoSize = true;
            this.lblImageList.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImageList.ForeColor = System.Drawing.Color.White;
            this.lblImageList.Image = global::Proiect_final_MTP.Properties.Resources.list;
            this.lblImageList.Location = new System.Drawing.Point(12, 157);
            this.lblImageList.Name = "lblImageList";
            this.lblImageList.Size = new System.Drawing.Size(40, 24);
            this.lblImageList.TabIndex = 29;
            this.lblImageList.Text = "      ";
            this.lblImageList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(52, 15);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(102, 24);
            this.lblUsername.TabIndex = 28;
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
            this.lblImage.Location = new System.Drawing.Point(6, 15);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(40, 24);
            this.lblImage.TabIndex = 27;
            this.lblImage.Text = "      ";
            this.lblImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPromovabilitateStudenti
            // 
            this.btnPromovabilitateStudenti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnPromovabilitateStudenti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPromovabilitateStudenti.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnPromovabilitateStudenti.FlatAppearance.BorderSize = 0;
            this.btnPromovabilitateStudenti.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnPromovabilitateStudenti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPromovabilitateStudenti.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromovabilitateStudenti.ForeColor = System.Drawing.Color.White;
            this.btnPromovabilitateStudenti.Location = new System.Drawing.Point(16, 293);
            this.btnPromovabilitateStudenti.Name = "btnPromovabilitateStudenti";
            this.btnPromovabilitateStudenti.Size = new System.Drawing.Size(182, 71);
            this.btnPromovabilitateStudenti.TabIndex = 19;
            this.btnPromovabilitateStudenti.Text = "Promovabilitate studenti";
            this.btnPromovabilitateStudenti.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPromovabilitateStudenti.UseVisualStyleBackColor = false;
            this.btnPromovabilitateStudenti.Click += new System.EventHandler(this.btnPromovabilitateStudenti_Click);
            // 
            // btnPromovabilitateMaterii
            // 
            this.btnPromovabilitateMaterii.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnPromovabilitateMaterii.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPromovabilitateMaterii.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnPromovabilitateMaterii.FlatAppearance.BorderSize = 0;
            this.btnPromovabilitateMaterii.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnPromovabilitateMaterii.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPromovabilitateMaterii.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromovabilitateMaterii.ForeColor = System.Drawing.Color.White;
            this.btnPromovabilitateMaterii.Location = new System.Drawing.Point(17, 205);
            this.btnPromovabilitateMaterii.Name = "btnPromovabilitateMaterii";
            this.btnPromovabilitateMaterii.Size = new System.Drawing.Size(176, 58);
            this.btnPromovabilitateMaterii.TabIndex = 18;
            this.btnPromovabilitateMaterii.Text = "Promovabilitate discipline";
            this.btnPromovabilitateMaterii.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPromovabilitateMaterii.UseVisualStyleBackColor = false;
            this.btnPromovabilitateMaterii.Click += new System.EventHandler(this.btnPromovabilitateMaterii_Click);
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
            this.btnHome.Location = new System.Drawing.Point(10, 53);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(144, 47);
            this.btnHome.TabIndex = 10;
            this.btnHome.Text = "Back";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitlu
            // 
            this.panelTitlu.Controls.Add(this.lblOptiune);
            this.panelTitlu.Controls.Add(this.lblPromovabilitate);
            this.panelTitlu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitlu.Location = new System.Drawing.Point(260, 78);
            this.panelTitlu.Name = "panelTitlu";
            this.panelTitlu.Size = new System.Drawing.Size(962, 64);
            this.panelTitlu.TabIndex = 20;
            // 
            // lblOptiune
            // 
            this.lblOptiune.AutoSize = true;
            this.lblOptiune.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblOptiune.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOptiune.Location = new System.Drawing.Point(262, 25);
            this.lblOptiune.Name = "lblOptiune";
            this.lblOptiune.Size = new System.Drawing.Size(441, 27);
            this.lblOptiune.TabIndex = 18;
            this.lblOptiune.Text = "- alegeti una din optiunile din meniu";
            this.lblOptiune.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPromovabilitate
            // 
            this.lblPromovabilitate.AutoSize = true;
            this.lblPromovabilitate.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblPromovabilitate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPromovabilitate.Location = new System.Drawing.Point(51, 25);
            this.lblPromovabilitate.Name = "lblPromovabilitate";
            this.lblPromovabilitate.Size = new System.Drawing.Size(205, 27);
            this.lblPromovabilitate.TabIndex = 17;
            this.lblPromovabilitate.Text = "Promovabilitate";
            this.lblPromovabilitate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvPromovabilitate
            // 
            this.dgvPromovabilitate.AllowUserToAddRows = false;
            this.dgvPromovabilitate.AllowUserToDeleteRows = false;
            this.dgvPromovabilitate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPromovabilitate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPromovabilitate.BackgroundColor = System.Drawing.Color.MintCream;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPromovabilitate.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPromovabilitate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPromovabilitate.EnableHeadersVisualStyles = false;
            this.dgvPromovabilitate.Location = new System.Drawing.Point(295, 194);
            this.dgvPromovabilitate.MultiSelect = false;
            this.dgvPromovabilitate.Name = "dgvPromovabilitate";
            this.dgvPromovabilitate.RowHeadersVisible = false;
            this.dgvPromovabilitate.RowHeadersWidth = 51;
            this.dgvPromovabilitate.RowTemplate.Height = 24;
            this.dgvPromovabilitate.Size = new System.Drawing.Size(879, 419);
            this.dgvPromovabilitate.TabIndex = 21;
            this.dgvPromovabilitate.Visible = false;
            // 
            // Promovabilitate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1222, 676);
            this.Controls.Add(this.dgvPromovabilitate);
            this.Controls.Add(this.panelTitlu);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Promovabilitate";
            this.Text = "Promovabilitate";
            this.Load += new System.EventHandler(this.Promovabilitate_Load);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.panelTitlu.ResumeLayout(false);
            this.panelTitlu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromovabilitate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblTitluForm;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnPromovabilitateStudenti;
        private System.Windows.Forms.Button btnPromovabilitateMaterii;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panelTitlu;
        private System.Windows.Forms.Label lblOptiune;
        private System.Windows.Forms.Label lblPromovabilitate;
        private System.Windows.Forms.DataGridView dgvPromovabilitate;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Label lblImageList;
        private System.Windows.Forms.Button btnDisciplineNepromovate;
        private System.Windows.Forms.Button btnAniNepromovati;
    }
}