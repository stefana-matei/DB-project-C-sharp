
namespace Proiect_final_MTP
{
    partial class Documente
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRaportDetaliat = new System.Windows.Forms.Label();
            this.lblDataRaport = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGenRaport = new FontAwesome.Sharp.IconButton();
            this.btnGenFoaieM = new FontAwesome.Sharp.IconButton();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.lblFoaieMatricola = new System.Windows.Forms.Label();
            this.lblDataFoaieM = new System.Windows.Forms.Label();
            this.lblFileUpload = new System.Windows.Forms.Label();
            this.lbxFileName = new System.Windows.Forms.ListBox();
            this.pcbUpload = new System.Windows.Forms.PictureBox();
            this.lblDragDrop = new System.Windows.Forms.Label();
            this.progressBarUpload = new System.Windows.Forms.ProgressBar();
            this.btnSalvareModificari = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUpload)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRaportDetaliat
            // 
            this.lblRaportDetaliat.AutoSize = true;
            this.lblRaportDetaliat.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblRaportDetaliat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRaportDetaliat.Location = new System.Drawing.Point(154, 110);
            this.lblRaportDetaliat.Name = "lblRaportDetaliat";
            this.lblRaportDetaliat.Size = new System.Drawing.Size(191, 27);
            this.lblRaportDetaliat.TabIndex = 28;
            this.lblRaportDetaliat.Text = "Raport detaliat";
            this.lblRaportDetaliat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDataRaport
            // 
            this.lblDataRaport.AutoSize = true;
            this.lblDataRaport.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataRaport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDataRaport.Location = new System.Drawing.Point(648, 115);
            this.lblDataRaport.Name = "lblDataRaport";
            this.lblDataRaport.Size = new System.Drawing.Size(74, 22);
            this.lblDataRaport.TabIndex = 30;
            this.lblDataRaport.Text = "lblDate";
            this.lblDataRaport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDataRaport.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proiect_final_MTP.Properties.Resources.icons8_export_pdf_40;
            this.pictureBox1.Location = new System.Drawing.Point(103, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 46);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // btnGenRaport
            // 
            this.btnGenRaport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(194)))));
            this.btnGenRaport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenRaport.FlatAppearance.BorderSize = 2;
            this.btnGenRaport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenRaport.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenRaport.ForeColor = System.Drawing.Color.Snow;
            this.btnGenRaport.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnGenRaport.IconColor = System.Drawing.Color.Black;
            this.btnGenRaport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGenRaport.Location = new System.Drawing.Point(398, 106);
            this.btnGenRaport.Name = "btnGenRaport";
            this.btnGenRaport.Size = new System.Drawing.Size(109, 37);
            this.btnGenRaport.TabIndex = 26;
            this.btnGenRaport.Text = "Generare ";
            this.btnGenRaport.UseVisualStyleBackColor = false;
            this.btnGenRaport.Click += new System.EventHandler(this.btnGenerareDocument_Click);
            // 
            // btnGenFoaieM
            // 
            this.btnGenFoaieM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(194)))));
            this.btnGenFoaieM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenFoaieM.FlatAppearance.BorderSize = 2;
            this.btnGenFoaieM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenFoaieM.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenFoaieM.ForeColor = System.Drawing.Color.Snow;
            this.btnGenFoaieM.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnGenFoaieM.IconColor = System.Drawing.Color.Black;
            this.btnGenFoaieM.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGenFoaieM.Location = new System.Drawing.Point(398, 186);
            this.btnGenFoaieM.Name = "btnGenFoaieM";
            this.btnGenFoaieM.Size = new System.Drawing.Size(109, 37);
            this.btnGenFoaieM.TabIndex = 42;
            this.btnGenFoaieM.Text = "Generare ";
            this.btnGenFoaieM.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(194)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 2;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Snow;
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCancel.IconColor = System.Drawing.Color.Black;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.Location = new System.Drawing.Point(394, 507);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 37);
            this.btnCancel.TabIndex = 51;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // lblFoaieMatricola
            // 
            this.lblFoaieMatricola.AutoSize = true;
            this.lblFoaieMatricola.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblFoaieMatricola.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFoaieMatricola.Location = new System.Drawing.Point(154, 190);
            this.lblFoaieMatricola.Name = "lblFoaieMatricola";
            this.lblFoaieMatricola.Size = new System.Drawing.Size(197, 27);
            this.lblFoaieMatricola.TabIndex = 43;
            this.lblFoaieMatricola.Text = "Foaie matricola";
            this.lblFoaieMatricola.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDataFoaieM
            // 
            this.lblDataFoaieM.AutoSize = true;
            this.lblDataFoaieM.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataFoaieM.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDataFoaieM.Location = new System.Drawing.Point(648, 195);
            this.lblDataFoaieM.Name = "lblDataFoaieM";
            this.lblDataFoaieM.Size = new System.Drawing.Size(74, 22);
            this.lblDataFoaieM.TabIndex = 45;
            this.lblDataFoaieM.Text = "lblDate";
            this.lblDataFoaieM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDataFoaieM.Visible = false;
            // 
            // lblFileUpload
            // 
            this.lblFileUpload.AutoSize = true;
            this.lblFileUpload.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblFileUpload.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFileUpload.Location = new System.Drawing.Point(154, 310);
            this.lblFileUpload.Name = "lblFileUpload";
            this.lblFileUpload.Size = new System.Drawing.Size(148, 27);
            this.lblFileUpload.TabIndex = 46;
            this.lblFileUpload.Text = "File Upload";
            this.lblFileUpload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbxFileName
            // 
            this.lbxFileName.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxFileName.ItemHeight = 23;
            this.lbxFileName.Location = new System.Drawing.Point(159, 365);
            this.lbxFileName.Name = "lbxFileName";
            this.lbxFileName.Size = new System.Drawing.Size(858, 119);
            this.lbxFileName.TabIndex = 41;
            // 
            // pcbUpload
            // 
            this.pcbUpload.BackColor = System.Drawing.SystemColors.Window;
            this.pcbUpload.Image = global::Proiect_final_MTP.Properties.Resources.icons8_upload_40;
            this.pcbUpload.Location = new System.Drawing.Point(559, 380);
            this.pcbUpload.Name = "pcbUpload";
            this.pcbUpload.Size = new System.Drawing.Size(45, 46);
            this.pcbUpload.TabIndex = 47;
            this.pcbUpload.TabStop = false;
            // 
            // lblDragDrop
            // 
            this.lblDragDrop.AutoSize = true;
            this.lblDragDrop.BackColor = System.Drawing.SystemColors.Window;
            this.lblDragDrop.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDragDrop.Location = new System.Drawing.Point(467, 429);
            this.lblDragDrop.Name = "lblDragDrop";
            this.lblDragDrop.Size = new System.Drawing.Size(238, 22);
            this.lblDragDrop.TabIndex = 48;
            this.lblDragDrop.Text = "Drag and drop files here";
            // 
            // progressBarUpload
            // 
            this.progressBarUpload.Location = new System.Drawing.Point(159, 461);
            this.progressBarUpload.Name = "progressBarUpload";
            this.progressBarUpload.Size = new System.Drawing.Size(858, 23);
            this.progressBarUpload.TabIndex = 49;
            this.progressBarUpload.Visible = false;
            // 
            // btnSalvareModificari
            // 
            this.btnSalvareModificari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(194)))));
            this.btnSalvareModificari.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvareModificari.FlatAppearance.BorderSize = 2;
            this.btnSalvareModificari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvareModificari.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvareModificari.ForeColor = System.Drawing.Color.Snow;
            this.btnSalvareModificari.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSalvareModificari.IconColor = System.Drawing.Color.Black;
            this.btnSalvareModificari.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalvareModificari.Location = new System.Drawing.Point(159, 507);
            this.btnSalvareModificari.Name = "btnSalvareModificari";
            this.btnSalvareModificari.Size = new System.Drawing.Size(192, 37);
            this.btnSalvareModificari.TabIndex = 50;
            this.btnSalvareModificari.Text = "Salvare modificari";
            this.btnSalvareModificari.UseVisualStyleBackColor = false;
            // 
            // Documente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSalvareModificari);
            this.Controls.Add(this.progressBarUpload);
            this.Controls.Add(this.lblDragDrop);
            this.Controls.Add(this.pcbUpload);
            this.Controls.Add(this.lbxFileName);
            this.Controls.Add(this.lblFileUpload);
            this.Controls.Add(this.lblDataFoaieM);
            this.Controls.Add(this.lblFoaieMatricola);
            this.Controls.Add(this.btnGenFoaieM);
            this.Controls.Add(this.lblDataRaport);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblRaportDetaliat);
            this.Controls.Add(this.btnGenRaport);
            this.Name = "Documente";
            this.Size = new System.Drawing.Size(1378, 600);
            this.Load += new System.EventHandler(this.Documente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUpload)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnGenRaport;
        private System.Windows.Forms.Label lblRaportDetaliat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDataRaport;
        private FontAwesome.Sharp.IconButton btnGenFoaieM;
        private FontAwesome.Sharp.IconButton btnCancel;
        private System.Windows.Forms.Label lblFoaieMatricola;
        private System.Windows.Forms.Label lblDataFoaieM;
        private System.Windows.Forms.Label lblFileUpload;
        private System.Windows.Forms.ListBox lbxFileName;
        private System.Windows.Forms.PictureBox pcbUpload;
        private System.Windows.Forms.Label lblDragDrop;
        private System.Windows.Forms.ProgressBar progressBarUpload;
        private FontAwesome.Sharp.IconButton btnSalvareModificari;
    }
}
