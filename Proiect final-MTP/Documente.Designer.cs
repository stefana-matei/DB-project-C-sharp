
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGenerareDocument = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRaportDetaliat
            // 
            this.lblRaportDetaliat.AutoSize = true;
            this.lblRaportDetaliat.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblRaportDetaliat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRaportDetaliat.Location = new System.Drawing.Point(155, 96);
            this.lblRaportDetaliat.Name = "lblRaportDetaliat";
            this.lblRaportDetaliat.Size = new System.Drawing.Size(822, 27);
            this.lblRaportDetaliat.TabIndex = 28;
            this.lblRaportDetaliat.Text = "Raport detaliat - lista disciplinelor contractate (promovate, restante)";
            this.lblRaportDetaliat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proiect_final_MTP.Properties.Resources.icons8_export_pdf_40;
            this.pictureBox1.Location = new System.Drawing.Point(100, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 46);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // btnGenerareDocument
            // 
            this.btnGenerareDocument.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(194)))));
            this.btnGenerareDocument.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerareDocument.FlatAppearance.BorderSize = 2;
            this.btnGenerareDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerareDocument.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerareDocument.ForeColor = System.Drawing.Color.Snow;
            this.btnGenerareDocument.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnGenerareDocument.IconColor = System.Drawing.Color.Black;
            this.btnGenerareDocument.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGenerareDocument.Location = new System.Drawing.Point(160, 152);
            this.btnGenerareDocument.Name = "btnGenerareDocument";
            this.btnGenerareDocument.Size = new System.Drawing.Size(109, 37);
            this.btnGenerareDocument.TabIndex = 26;
            this.btnGenerareDocument.Text = "Generare ";
            this.btnGenerareDocument.UseVisualStyleBackColor = false;
            this.btnGenerareDocument.Click += new System.EventHandler(this.btnGenerareDocument_Click);
            // 
            // Documente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblRaportDetaliat);
            this.Controls.Add(this.btnGenerareDocument);
            this.Name = "Documente";
            this.Size = new System.Drawing.Size(1378, 600);
            this.Load += new System.EventHandler(this.Documente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnGenerareDocument;
        private System.Windows.Forms.Label lblRaportDetaliat;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
