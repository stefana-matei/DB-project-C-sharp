
namespace Proiect_final_MTP
{
    partial class Home
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
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.lblImageList = new System.Windows.Forms.Label();
            this.btnStudenti = new System.Windows.Forms.Button();
            this.btnPromovabilitate = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.btnMedii = new System.Windows.Forms.Button();
            this.btnRapoarte = new System.Windows.Forms.Button();
            this.btnNote = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.dgvCautareStudenti = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new FontAwesome.Sharp.IconButton();
            this.btnCautareStudent = new FontAwesome.Sharp.IconButton();
            this.lblCautareStudent = new System.Windows.Forms.Label();
            this.lblCautarePic = new System.Windows.Forms.Label();
            this.panelTitle.SuspendLayout();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCautareStudenti)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitle.Controls.Add(this.lblTitluBD);
            this.panelTitle.Controls.Add(this.btnMinimize);
            this.panelTitle.Controls.Add(this.btnMaximize);
            this.panelTitle.Controls.Add(this.btnCancel);
            this.panelTitle.Controls.Add(this.btnRestore);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.ForeColor = System.Drawing.Color.Black;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1222, 72);
            this.panelTitle.TabIndex = 0;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            this.panelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseMove);
            this.panelTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseUp);
            // 
            // lblTitluBD
            // 
            this.lblTitluBD.AutoSize = true;
            this.lblTitluBD.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblTitluBD.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitluBD.Location = new System.Drawing.Point(24, 9);
            this.lblTitluBD.Name = "lblTitluBD";
            this.lblTitluBD.Size = new System.Drawing.Size(276, 54);
            this.lblTitluBD.TabIndex = 14;
            this.lblTitluBD.Text = "Gestiunea notelor\r\nsi mediilor studentilor\r\n";
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
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelButtons.Controls.Add(this.lblImageList);
            this.panelButtons.Controls.Add(this.btnStudenti);
            this.panelButtons.Controls.Add(this.btnPromovabilitate);
            this.panelButtons.Controls.Add(this.lblUsername);
            this.panelButtons.Controls.Add(this.lblImage);
            this.panelButtons.Controls.Add(this.btnMedii);
            this.panelButtons.Controls.Add(this.btnRapoarte);
            this.panelButtons.Controls.Add(this.btnNote);
            this.panelButtons.Controls.Add(this.btnLogout);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButtons.Location = new System.Drawing.Point(0, 72);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(260, 604);
            this.panelButtons.TabIndex = 1;
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
            this.lblImageList.TabIndex = 20;
            this.lblImageList.Text = "      ";
            this.lblImageList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStudenti
            // 
            this.btnStudenti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnStudenti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudenti.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnStudenti.FlatAppearance.BorderSize = 0;
            this.btnStudenti.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnStudenti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudenti.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudenti.ForeColor = System.Drawing.Color.White;
            this.btnStudenti.Location = new System.Drawing.Point(17, 205);
            this.btnStudenti.Name = "btnStudenti";
            this.btnStudenti.Size = new System.Drawing.Size(119, 37);
            this.btnStudenti.TabIndex = 10;
            this.btnStudenti.Text = "Studenti";
            this.btnStudenti.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudenti.UseVisualStyleBackColor = false;
            this.btnStudenti.Click += new System.EventHandler(this.btnStudenti_Click);
            // 
            // btnPromovabilitate
            // 
            this.btnPromovabilitate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnPromovabilitate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPromovabilitate.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnPromovabilitate.FlatAppearance.BorderSize = 0;
            this.btnPromovabilitate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnPromovabilitate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPromovabilitate.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromovabilitate.ForeColor = System.Drawing.Color.White;
            this.btnPromovabilitate.Location = new System.Drawing.Point(17, 461);
            this.btnPromovabilitate.Name = "btnPromovabilitate";
            this.btnPromovabilitate.Size = new System.Drawing.Size(168, 44);
            this.btnPromovabilitate.TabIndex = 15;
            this.btnPromovabilitate.Text = "Promovabilitate";
            this.btnPromovabilitate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPromovabilitate.UseVisualStyleBackColor = false;
            this.btnPromovabilitate.Click += new System.EventHandler(this.btnPromovabilitate_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(57, 24);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(102, 24);
            this.lblUsername.TabIndex = 19;
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
            this.lblImage.Location = new System.Drawing.Point(11, 24);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(40, 24);
            this.lblImage.TabIndex = 18;
            this.lblImage.Text = "      ";
            this.lblImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMedii
            // 
            this.btnMedii.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnMedii.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMedii.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnMedii.FlatAppearance.BorderSize = 0;
            this.btnMedii.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnMedii.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedii.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedii.ForeColor = System.Drawing.Color.White;
            this.btnMedii.Location = new System.Drawing.Point(17, 264);
            this.btnMedii.Name = "btnMedii";
            this.btnMedii.Size = new System.Drawing.Size(119, 48);
            this.btnMedii.TabIndex = 11;
            this.btnMedii.Text = "Medii";
            this.btnMedii.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedii.UseVisualStyleBackColor = false;
            this.btnMedii.Click += new System.EventHandler(this.btnMedii_Click);
            // 
            // btnRapoarte
            // 
            this.btnRapoarte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnRapoarte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRapoarte.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnRapoarte.FlatAppearance.BorderSize = 0;
            this.btnRapoarte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnRapoarte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRapoarte.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRapoarte.ForeColor = System.Drawing.Color.White;
            this.btnRapoarte.Location = new System.Drawing.Point(17, 402);
            this.btnRapoarte.Name = "btnRapoarte";
            this.btnRapoarte.Size = new System.Drawing.Size(140, 41);
            this.btnRapoarte.TabIndex = 14;
            this.btnRapoarte.Text = "Rapoarte";
            this.btnRapoarte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRapoarte.UseVisualStyleBackColor = false;
            this.btnRapoarte.Click += new System.EventHandler(this.btnRapoarte_Click);
            // 
            // btnNote
            // 
            this.btnNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNote.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnNote.FlatAppearance.BorderSize = 0;
            this.btnNote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNote.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNote.ForeColor = System.Drawing.Color.White;
            this.btnNote.Location = new System.Drawing.Point(17, 332);
            this.btnNote.Name = "btnNote";
            this.btnNote.Size = new System.Drawing.Size(92, 46);
            this.btnNote.TabIndex = 12;
            this.btnNote.Text = "Note";
            this.btnNote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNote.UseVisualStyleBackColor = false;
            this.btnNote.Click += new System.EventHandler(this.btnNote_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::Proiect_final_MTP.Properties.Resources.logout;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(15, 63);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(119, 47);
            this.btnLogout.TabIndex = 16;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // txtNume
            // 
            this.txtNume.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNume.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNume.Location = new System.Drawing.Point(315, 177);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(223, 38);
            this.txtNume.TabIndex = 6;
            this.txtNume.MouseLeave += new System.EventHandler(this.txtNume_MouseLeave);
            // 
            // dgvCautareStudenti
            // 
            this.dgvCautareStudenti.AllowDrop = true;
            this.dgvCautareStudenti.AllowUserToAddRows = false;
            this.dgvCautareStudenti.AllowUserToDeleteRows = false;
            this.dgvCautareStudenti.AllowUserToOrderColumns = true;
            this.dgvCautareStudenti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCautareStudenti.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCautareStudenti.BackgroundColor = System.Drawing.Color.MintCream;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCautareStudenti.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCautareStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCautareStudenti.EnableHeadersVisualStyles = false;
            this.dgvCautareStudenti.Location = new System.Drawing.Point(314, 253);
            this.dgvCautareStudenti.MultiSelect = false;
            this.dgvCautareStudenti.Name = "dgvCautareStudenti";
            this.dgvCautareStudenti.ReadOnly = true;
            this.dgvCautareStudenti.RowHeadersVisible = false;
            this.dgvCautareStudenti.RowHeadersWidth = 51;
            this.dgvCautareStudenti.RowTemplate.Height = 24;
            this.dgvCautareStudenti.Size = new System.Drawing.Size(845, 347);
            this.dgvCautareStudenti.TabIndex = 10;
            this.dgvCautareStudenti.Visible = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 2;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Snow;
            this.btnRefresh.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRefresh.IconColor = System.Drawing.Color.Black;
            this.btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRefresh.Location = new System.Drawing.Point(745, 177);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(107, 37);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnCautareStudent
            // 
            this.btnCautareStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnCautareStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCautareStudent.FlatAppearance.BorderSize = 2;
            this.btnCautareStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCautareStudent.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCautareStudent.ForeColor = System.Drawing.Color.Snow;
            this.btnCautareStudent.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCautareStudent.IconColor = System.Drawing.Color.Black;
            this.btnCautareStudent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCautareStudent.Location = new System.Drawing.Point(600, 177);
            this.btnCautareStudent.Name = "btnCautareStudent";
            this.btnCautareStudent.Size = new System.Drawing.Size(107, 37);
            this.btnCautareStudent.TabIndex = 7;
            this.btnCautareStudent.Text = "Cauta";
            this.btnCautareStudent.UseVisualStyleBackColor = false;
            this.btnCautareStudent.Click += new System.EventHandler(this.btnCautareStudent_Click);
            // 
            // lblCautareStudent
            // 
            this.lblCautareStudent.AutoSize = true;
            this.lblCautareStudent.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCautareStudent.Location = new System.Drawing.Point(356, 149);
            this.lblCautareStudent.Name = "lblCautareStudent";
            this.lblCautareStudent.Size = new System.Drawing.Size(156, 19);
            this.lblCautareStudent.TabIndex = 5;
            this.lblCautareStudent.Text = "Cautare studenti";
            // 
            // lblCautarePic
            // 
            this.lblCautarePic.AutoSize = true;
            this.lblCautarePic.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCautarePic.ForeColor = System.Drawing.Color.White;
            this.lblCautarePic.Image = global::Proiect_final_MTP.Properties.Resources.icons8_search_24;
            this.lblCautarePic.Location = new System.Drawing.Point(320, 149);
            this.lblCautarePic.Name = "lblCautarePic";
            this.lblCautarePic.Size = new System.Drawing.Size(40, 24);
            this.lblCautarePic.TabIndex = 19;
            this.lblCautarePic.Text = "      ";
            this.lblCautarePic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1222, 676);
            this.Controls.Add(this.lblCautarePic);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvCautareStudenti);
            this.Controls.Add(this.btnCautareStudent);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lblCautareStudent);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCautareStudenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTitluBD;
        private FontAwesome.Sharp.IconButton btnCautareStudent;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label lblCautareStudent;
        private System.Windows.Forms.DataGridView dgvCautareStudenti;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblImageList;
        private System.Windows.Forms.Button btnStudenti;
        private System.Windows.Forms.Button btnPromovabilitate;
        private System.Windows.Forms.Button btnMedii;
        private System.Windows.Forms.Button btnRapoarte;
        private System.Windows.Forms.Button btnNote;
        private System.Windows.Forms.Label lblCautarePic;
    }
}