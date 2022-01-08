
namespace Proiect_final_MTP
{
    partial class Note
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
            this.lblImageList = new System.Windows.Forms.Label();
            this.btnAdaugareNota = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblImageUser = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelTitlu = new System.Windows.Forms.Panel();
            this.lblNoteForm = new System.Windows.Forms.Label();
            this.dgvNote = new System.Windows.Forms.DataGridView();
            this.btnBackNoteForm = new FontAwesome.Sharp.IconButton();
            this.adaugareNota = new Proiect_final_MTP.AdaugareNota();
            this.panelTitle.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelTitlu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNote)).BeginInit();
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
            this.panelTitle.TabIndex = 5;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            this.panelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseMove);
            this.panelTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseUp);
            // 
            // lblTitluBD
            // 
            this.lblTitluBD.AutoSize = true;
            this.lblTitluBD.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblTitluBD.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitluBD.Location = new System.Drawing.Point(3, 9);
            this.lblTitluBD.Name = "lblTitluBD";
            this.lblTitluBD.Size = new System.Drawing.Size(276, 54);
            this.lblTitluBD.TabIndex = 16;
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
            this.panelButtons.Controls.Add(this.lblImageList);
            this.panelButtons.Controls.Add(this.btnAdaugareNota);
            this.panelButtons.Controls.Add(this.lblUsername);
            this.panelButtons.Controls.Add(this.lblImageUser);
            this.panelButtons.Controls.Add(this.btnHome);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButtons.Location = new System.Drawing.Point(0, 78);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(260, 598);
            this.panelButtons.TabIndex = 6;
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
            this.lblImageList.TabIndex = 32;
            this.lblImageList.Text = "      ";
            this.lblImageList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdaugareNota
            // 
            this.btnAdaugareNota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnAdaugareNota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdaugareNota.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnAdaugareNota.FlatAppearance.BorderSize = 0;
            this.btnAdaugareNota.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAdaugareNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdaugareNota.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugareNota.ForeColor = System.Drawing.Color.White;
            this.btnAdaugareNota.Location = new System.Drawing.Point(17, 205);
            this.btnAdaugareNota.Name = "btnAdaugareNota";
            this.btnAdaugareNota.Size = new System.Drawing.Size(152, 37);
            this.btnAdaugareNota.TabIndex = 31;
            this.btnAdaugareNota.Text = "Adaugare nota";
            this.btnAdaugareNota.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdaugareNota.UseVisualStyleBackColor = false;
            this.btnAdaugareNota.Click += new System.EventHandler(this.btnAdaugareNota_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(52, 15);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(102, 24);
            this.lblUsername.TabIndex = 30;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUsername.Visible = false;
            // 
            // lblImageUser
            // 
            this.lblImageUser.AutoSize = true;
            this.lblImageUser.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImageUser.ForeColor = System.Drawing.Color.White;
            this.lblImageUser.Image = global::Proiect_final_MTP.Properties.Resources.user;
            this.lblImageUser.Location = new System.Drawing.Point(6, 15);
            this.lblImageUser.Name = "lblImageUser";
            this.lblImageUser.Size = new System.Drawing.Size(40, 24);
            this.lblImageUser.TabIndex = 29;
            this.lblImageUser.Text = "      ";
            this.lblImageUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnHome.TabIndex = 12;
            this.btnHome.Text = "Back";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitlu
            // 
            this.panelTitlu.Controls.Add(this.lblNoteForm);
            this.panelTitlu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitlu.Location = new System.Drawing.Point(260, 78);
            this.panelTitlu.Name = "panelTitlu";
            this.panelTitlu.Size = new System.Drawing.Size(962, 64);
            this.panelTitlu.TabIndex = 20;
            // 
            // lblNoteForm
            // 
            this.lblNoteForm.AutoSize = true;
            this.lblNoteForm.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblNoteForm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNoteForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNoteForm.Location = new System.Drawing.Point(51, 25);
            this.lblNoteForm.Name = "lblNoteForm";
            this.lblNoteForm.Size = new System.Drawing.Size(70, 27);
            this.lblNoteForm.TabIndex = 17;
            this.lblNoteForm.Text = "Note";
            // 
            // dgvNote
            // 
            this.dgvNote.AllowUserToAddRows = false;
            this.dgvNote.AllowUserToDeleteRows = false;
            this.dgvNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNote.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNote.BackgroundColor = System.Drawing.Color.MintCream;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNote.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNote.EnableHeadersVisualStyles = false;
            this.dgvNote.Location = new System.Drawing.Point(316, 195);
            this.dgvNote.MultiSelect = false;
            this.dgvNote.Name = "dgvNote";
            this.dgvNote.RowHeadersVisible = false;
            this.dgvNote.RowHeadersWidth = 51;
            this.dgvNote.RowTemplate.Height = 24;
            this.dgvNote.Size = new System.Drawing.Size(858, 390);
            this.dgvNote.TabIndex = 19;
            // 
            // btnBackNoteForm
            // 
            this.btnBackNoteForm.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBackNoteForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnBackNoteForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackNoteForm.FlatAppearance.BorderSize = 2;
            this.btnBackNoteForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackNoteForm.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackNoteForm.ForeColor = System.Drawing.Color.Snow;
            this.btnBackNoteForm.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnBackNoteForm.IconColor = System.Drawing.Color.Black;
            this.btnBackNoteForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBackNoteForm.Location = new System.Drawing.Point(987, 619);
            this.btnBackNoteForm.Name = "btnBackNoteForm";
            this.btnBackNoteForm.Size = new System.Drawing.Size(187, 37);
            this.btnBackNoteForm.TabIndex = 18;
            this.btnBackNoteForm.Text = "Vizualizare note";
            this.btnBackNoteForm.UseVisualStyleBackColor = false;
            this.btnBackNoteForm.Click += new System.EventHandler(this.btnBackNoteForm_Click);
            // 
            // adaugareNota
            // 
            this.adaugareNota.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adaugareNota.Location = new System.Drawing.Point(260, 142);
            this.adaugareNota.Name = "adaugareNota";
            this.adaugareNota.Size = new System.Drawing.Size(962, 534);
            this.adaugareNota.TabIndex = 21;
            // 
            // Note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1222, 676);
            this.Controls.Add(this.btnBackNoteForm);
            this.Controls.Add(this.adaugareNota);
            this.Controls.Add(this.panelTitlu);
            this.Controls.Add(this.dgvNote);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Note";
            this.Text = "Note";
            this.Load += new System.EventHandler(this.Note_Load);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.panelTitlu.ResumeLayout(false);
            this.panelTitlu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNote)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelTitlu;
        private System.Windows.Forms.Label lblNoteForm;
        private System.Windows.Forms.DataGridView dgvNote;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblTitluBD;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblImageUser;
        private System.Windows.Forms.Label lblImageList;
        private System.Windows.Forms.Button btnAdaugareNota;
        private AdaugareNota adaugareNota;
        private FontAwesome.Sharp.IconButton btnBackNoteForm;
    }
}