
namespace Proiect_final_MTP
{
    partial class RaportDetaliat
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRaportDetaliat
            // 
            this.lblRaportDetaliat.AutoSize = true;
            this.lblRaportDetaliat.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblRaportDetaliat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRaportDetaliat.Location = new System.Drawing.Point(117, 124);
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
            this.lblDataRaport.Location = new System.Drawing.Point(597, 129);
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
            this.pictureBox1.Location = new System.Drawing.Point(87, 64);
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
            this.btnGenRaport.Location = new System.Drawing.Point(371, 122);
            this.btnGenRaport.Name = "btnGenRaport";
            this.btnGenRaport.Size = new System.Drawing.Size(109, 37);
            this.btnGenRaport.TabIndex = 26;
            this.btnGenRaport.Text = "Generare ";
            this.btnGenRaport.UseVisualStyleBackColor = false;
            this.btnGenRaport.Click += new System.EventHandler(this.btnGenerareDocument_Click);
            // 
            // Documente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.lblDataRaport);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblRaportDetaliat);
            this.Controls.Add(this.btnGenRaport);
            this.Name = "Documente";
            this.Size = new System.Drawing.Size(1378, 600);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnGenRaport;
        private System.Windows.Forms.Label lblRaportDetaliat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDataRaport;
    }
}
