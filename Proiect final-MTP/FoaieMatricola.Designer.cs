
namespace Proiect_final_MTP
{
    partial class FoaieMatricola
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
            this.components = new System.ComponentModel.Container();
            this.lblDataGenerare = new System.Windows.Forms.Label();
            this.lblFoaieMatricola = new System.Windows.Forms.Label();
            this.lblFileUpload = new System.Windows.Forms.Label();
            this.lbxFileName = new System.Windows.Forms.ListBox();
            this.pcbUpload = new System.Windows.Forms.PictureBox();
            this.pcbGenerate = new System.Windows.Forms.PictureBox();
            this.btnGenerare = new FontAwesome.Sharp.IconButton();
            this.lblDragDrop = new System.Windows.Forms.Label();
            this.progressBarUpload = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnSalvareModificari = new FontAwesome.Sharp.IconButton();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUpload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGenerate)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDataGenerare
            // 
            this.lblDataGenerare.AutoSize = true;
            this.lblDataGenerare.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataGenerare.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDataGenerare.Location = new System.Drawing.Point(598, 196);
            this.lblDataGenerare.Name = "lblDataGenerare";
            this.lblDataGenerare.Size = new System.Drawing.Size(74, 22);
            this.lblDataGenerare.TabIndex = 34;
            this.lblDataGenerare.Text = "lblDate";
            this.lblDataGenerare.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDataGenerare.Visible = false;
            // 
            // lblFoaieMatricola
            // 
            this.lblFoaieMatricola.AutoSize = true;
            this.lblFoaieMatricola.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblFoaieMatricola.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFoaieMatricola.Location = new System.Drawing.Point(197, 112);
            this.lblFoaieMatricola.Name = "lblFoaieMatricola";
            this.lblFoaieMatricola.Size = new System.Drawing.Size(197, 27);
            this.lblFoaieMatricola.TabIndex = 32;
            this.lblFoaieMatricola.Text = "Foaie matricola";
            this.lblFoaieMatricola.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFileUpload
            // 
            this.lblFileUpload.AutoSize = true;
            this.lblFileUpload.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblFileUpload.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFileUpload.Location = new System.Drawing.Point(197, 282);
            this.lblFileUpload.Name = "lblFileUpload";
            this.lblFileUpload.Size = new System.Drawing.Size(148, 27);
            this.lblFileUpload.TabIndex = 35;
            this.lblFileUpload.Text = "File Upload";
            this.lblFileUpload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbxFileName
            // 
            this.lbxFileName.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxFileName.ItemHeight = 23;
            this.lbxFileName.Location = new System.Drawing.Point(202, 337);
            this.lbxFileName.Name = "lbxFileName";
            this.lbxFileName.Size = new System.Drawing.Size(858, 119);
            this.lbxFileName.TabIndex = 0;
            // 
            // pcbUpload
            // 
            this.pcbUpload.BackColor = System.Drawing.SystemColors.Window;
            this.pcbUpload.Image = global::Proiect_final_MTP.Properties.Resources.icons8_upload_40;
            this.pcbUpload.Location = new System.Drawing.Point(602, 352);
            this.pcbUpload.Name = "pcbUpload";
            this.pcbUpload.Size = new System.Drawing.Size(45, 46);
            this.pcbUpload.TabIndex = 36;
            this.pcbUpload.TabStop = false;
            // 
            // pcbGenerate
            // 
            this.pcbGenerate.Image = global::Proiect_final_MTP.Properties.Resources.icons8_export_pdf_40;
            this.pcbGenerate.Location = new System.Drawing.Point(142, 102);
            this.pcbGenerate.Name = "pcbGenerate";
            this.pcbGenerate.Size = new System.Drawing.Size(38, 46);
            this.pcbGenerate.TabIndex = 33;
            this.pcbGenerate.TabStop = false;
            // 
            // btnGenerare
            // 
            this.btnGenerare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(194)))));
            this.btnGenerare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerare.FlatAppearance.BorderSize = 2;
            this.btnGenerare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerare.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerare.ForeColor = System.Drawing.Color.Snow;
            this.btnGenerare.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnGenerare.IconColor = System.Drawing.Color.Black;
            this.btnGenerare.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGenerare.Location = new System.Drawing.Point(202, 168);
            this.btnGenerare.Name = "btnGenerare";
            this.btnGenerare.Size = new System.Drawing.Size(109, 37);
            this.btnGenerare.TabIndex = 31;
            this.btnGenerare.Text = "Generare ";
            this.btnGenerare.UseVisualStyleBackColor = false;
            this.btnGenerare.Click += new System.EventHandler(this.btnGenerare_Click);
            // 
            // lblDragDrop
            // 
            this.lblDragDrop.AutoSize = true;
            this.lblDragDrop.BackColor = System.Drawing.SystemColors.Window;
            this.lblDragDrop.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDragDrop.Location = new System.Drawing.Point(510, 401);
            this.lblDragDrop.Name = "lblDragDrop";
            this.lblDragDrop.Size = new System.Drawing.Size(238, 22);
            this.lblDragDrop.TabIndex = 37;
            this.lblDragDrop.Text = "Drag and drop files here";
            // 
            // progressBarUpload
            // 
            this.progressBarUpload.Location = new System.Drawing.Point(202, 433);
            this.progressBarUpload.Name = "progressBarUpload";
            this.progressBarUpload.Size = new System.Drawing.Size(858, 23);
            this.progressBarUpload.TabIndex = 38;
            this.progressBarUpload.Visible = false;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
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
            this.btnSalvareModificari.Location = new System.Drawing.Point(202, 479);
            this.btnSalvareModificari.Name = "btnSalvareModificari";
            this.btnSalvareModificari.Size = new System.Drawing.Size(192, 37);
            this.btnSalvareModificari.TabIndex = 39;
            this.btnSalvareModificari.Text = "Salvare modificari";
            this.btnSalvareModificari.UseVisualStyleBackColor = false;
            this.btnSalvareModificari.Click += new System.EventHandler(this.btnSalvareModificari_Click);
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
            this.btnCancel.Location = new System.Drawing.Point(437, 479);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 37);
            this.btnCancel.TabIndex = 40;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FoaieMatricola
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSalvareModificari);
            this.Controls.Add(this.progressBarUpload);
            this.Controls.Add(this.lblDragDrop);
            this.Controls.Add(this.pcbUpload);
            this.Controls.Add(this.lbxFileName);
            this.Controls.Add(this.lblFileUpload);
            this.Controls.Add(this.lblDataGenerare);
            this.Controls.Add(this.pcbGenerate);
            this.Controls.Add(this.lblFoaieMatricola);
            this.Controls.Add(this.btnGenerare);
            this.Name = "FoaieMatricola";
            this.Size = new System.Drawing.Size(1378, 600);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FoaieMatricola_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FoaieMatricola_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.pcbUpload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGenerate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDataGenerare;
        private System.Windows.Forms.PictureBox pcbGenerate;
        private System.Windows.Forms.Label lblFoaieMatricola;
        private FontAwesome.Sharp.IconButton btnGenerare;
        private System.Windows.Forms.Label lblFileUpload;
        private System.Windows.Forms.ListBox lbxFileName;
        private System.Windows.Forms.PictureBox pcbUpload;
        private System.Windows.Forms.Label lblDragDrop;
        private System.Windows.Forms.ProgressBar progressBarUpload;
        private System.Windows.Forms.Timer timer;
        private FontAwesome.Sharp.IconButton btnSalvareModificari;
        private FontAwesome.Sharp.IconButton btnCancel;
    }
}
