
namespace Proiect_final_MTP
{
    partial class Rapoarte
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
            this.panelButtons = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnRaportNoteFinale = new System.Windows.Forms.Button();
            this.btnRaportStudenti = new System.Windows.Forms.Button();
            this.panelTitlu = new System.Windows.Forms.Panel();
            this.lblOptiune = new System.Windows.Forms.Label();
            this.lblRapoarte = new System.Windows.Forms.Label();
            this.dgvRapoarte = new System.Windows.Forms.DataGridView();
            this.lblImageList = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelTitle.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelTitlu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapoarte)).BeginInit();
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
            this.panelTitle.TabIndex = 6;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            this.panelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseMove);
            this.panelTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseUp);
            // 
            // lblTitluBD
            // 
            this.lblTitluBD.AutoSize = true;
            this.lblTitluBD.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblTitluBD.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitluBD.Location = new System.Drawing.Point(12, 9);
            this.lblTitluBD.Name = "lblTitluBD";
            this.lblTitluBD.Size = new System.Drawing.Size(276, 54);
            this.lblTitluBD.TabIndex = 15;
            this.lblTitluBD.Text = "Gestiunea notelor\r\nsi mediilor studentilor\r\n";
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelButtons.Controls.Add(this.lblImageList);
            this.panelButtons.Controls.Add(this.lblUsername);
            this.panelButtons.Controls.Add(this.lblImage);
            this.panelButtons.Controls.Add(this.btnRaportNoteFinale);
            this.panelButtons.Controls.Add(this.btnRaportStudenti);
            this.panelButtons.Controls.Add(this.btnHome);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButtons.Location = new System.Drawing.Point(0, 78);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(260, 598);
            this.panelButtons.TabIndex = 7;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(52, 15);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(102, 24);
            this.lblUsername.TabIndex = 26;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUsername.Visible = false;
            // 
            // btnRaportNoteFinale
            // 
            this.btnRaportNoteFinale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnRaportNoteFinale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRaportNoteFinale.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnRaportNoteFinale.FlatAppearance.BorderSize = 0;
            this.btnRaportNoteFinale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnRaportNoteFinale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaportNoteFinale.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaportNoteFinale.ForeColor = System.Drawing.Color.White;
            this.btnRaportNoteFinale.Location = new System.Drawing.Point(17, 281);
            this.btnRaportNoteFinale.Name = "btnRaportNoteFinale";
            this.btnRaportNoteFinale.Size = new System.Drawing.Size(182, 53);
            this.btnRaportNoteFinale.TabIndex = 19;
            this.btnRaportNoteFinale.Text = "Raport note finale";
            this.btnRaportNoteFinale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRaportNoteFinale.UseVisualStyleBackColor = false;
            this.btnRaportNoteFinale.Click += new System.EventHandler(this.btnRaportNoteFinale_Click);
            // 
            // btnRaportStudenti
            // 
            this.btnRaportStudenti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnRaportStudenti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRaportStudenti.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnRaportStudenti.FlatAppearance.BorderSize = 0;
            this.btnRaportStudenti.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnRaportStudenti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaportStudenti.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaportStudenti.ForeColor = System.Drawing.Color.White;
            this.btnRaportStudenti.Location = new System.Drawing.Point(17, 210);
            this.btnRaportStudenti.Name = "btnRaportStudenti";
            this.btnRaportStudenti.Size = new System.Drawing.Size(176, 46);
            this.btnRaportStudenti.TabIndex = 18;
            this.btnRaportStudenti.Text = "Raport studenti";
            this.btnRaportStudenti.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRaportStudenti.UseVisualStyleBackColor = false;
            this.btnRaportStudenti.Click += new System.EventHandler(this.btnRaportStudenti_Click);
            // 
            // panelTitlu
            // 
            this.panelTitlu.Controls.Add(this.lblOptiune);
            this.panelTitlu.Controls.Add(this.lblRapoarte);
            this.panelTitlu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitlu.Location = new System.Drawing.Point(260, 78);
            this.panelTitlu.Name = "panelTitlu";
            this.panelTitlu.Size = new System.Drawing.Size(962, 64);
            this.panelTitlu.TabIndex = 19;
            // 
            // lblOptiune
            // 
            this.lblOptiune.AutoSize = true;
            this.lblOptiune.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblOptiune.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOptiune.Location = new System.Drawing.Point(179, 25);
            this.lblOptiune.Name = "lblOptiune";
            this.lblOptiune.Size = new System.Drawing.Size(441, 27);
            this.lblOptiune.TabIndex = 19;
            this.lblOptiune.Text = "- alegeti una din optiunile din meniu";
            this.lblOptiune.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRapoarte
            // 
            this.lblRapoarte.AutoSize = true;
            this.lblRapoarte.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblRapoarte.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRapoarte.Location = new System.Drawing.Point(51, 25);
            this.lblRapoarte.Name = "lblRapoarte";
            this.lblRapoarte.Size = new System.Drawing.Size(122, 27);
            this.lblRapoarte.TabIndex = 17;
            this.lblRapoarte.Text = "Rapoarte";
            this.lblRapoarte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvRapoarte
            // 
            this.dgvRapoarte.AllowUserToAddRows = false;
            this.dgvRapoarte.AllowUserToDeleteRows = false;
            this.dgvRapoarte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRapoarte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRapoarte.BackgroundColor = System.Drawing.Color.MintCream;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRapoarte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRapoarte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRapoarte.EnableHeadersVisualStyles = false;
            this.dgvRapoarte.Location = new System.Drawing.Point(295, 199);
            this.dgvRapoarte.MultiSelect = false;
            this.dgvRapoarte.Name = "dgvRapoarte";
            this.dgvRapoarte.RowHeadersVisible = false;
            this.dgvRapoarte.RowHeadersWidth = 51;
            this.dgvRapoarte.RowTemplate.Height = 24;
            this.dgvRapoarte.Size = new System.Drawing.Size(901, 401);
            this.dgvRapoarte.TabIndex = 20;
            this.dgvRapoarte.Visible = false;
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
            this.lblImageList.TabIndex = 27;
            this.lblImageList.Text = "      ";
            this.lblImageList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblImage.TabIndex = 25;
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
            this.btnHome.Location = new System.Drawing.Point(10, 53);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(143, 47);
            this.btnHome.TabIndex = 10;
            this.btnHome.Text = "Back";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
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
            // Rapoarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1222, 676);
            this.Controls.Add(this.dgvRapoarte);
            this.Controls.Add(this.panelTitlu);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rapoarte";
            this.Text = "Rapoarte";
            this.Load += new System.EventHandler(this.Rapoarte_Load);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.panelTitlu.ResumeLayout(false);
            this.panelTitlu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapoarte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panelTitlu;
        private System.Windows.Forms.Label lblRapoarte;
        private System.Windows.Forms.Button btnRaportNoteFinale;
        private System.Windows.Forms.Button btnRaportStudenti;
        private System.Windows.Forms.DataGridView dgvRapoarte;
        private System.Windows.Forms.Label lblTitluBD;
        private System.Windows.Forms.Label lblOptiune;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Label lblImageList;
    }
}