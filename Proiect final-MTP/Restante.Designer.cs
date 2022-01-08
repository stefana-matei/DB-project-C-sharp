
namespace Proiect_final_MTP
{
    partial class Restante
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvRestante = new System.Windows.Forms.DataGridView();
            this.cmbAnUniversitar = new System.Windows.Forms.ComboBox();
            this.lblRestante = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestante)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRestante
            // 
            this.dgvRestante.AllowUserToAddRows = false;
            this.dgvRestante.AllowUserToDeleteRows = false;
            this.dgvRestante.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRestante.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRestante.BackgroundColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRestante.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRestante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRestante.EnableHeadersVisualStyles = false;
            this.dgvRestante.Location = new System.Drawing.Point(172, 228);
            this.dgvRestante.MultiSelect = false;
            this.dgvRestante.Name = "dgvRestante";
            this.dgvRestante.RowHeadersVisible = false;
            this.dgvRestante.RowHeadersWidth = 51;
            this.dgvRestante.RowTemplate.Height = 24;
            this.dgvRestante.Size = new System.Drawing.Size(1046, 135);
            this.dgvRestante.TabIndex = 26;
            // 
            // cmbAnUniversitar
            // 
            this.cmbAnUniversitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbAnUniversitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAnUniversitar.FormattingEnabled = true;
            this.cmbAnUniversitar.Location = new System.Drawing.Point(120, 148);
            this.cmbAnUniversitar.Name = "cmbAnUniversitar";
            this.cmbAnUniversitar.Size = new System.Drawing.Size(50, 37);
            this.cmbAnUniversitar.TabIndex = 25;
            this.cmbAnUniversitar.SelectedIndexChanged += new System.EventHandler(this.cmbAnUniversitar_SelectedIndexChanged);
            // 
            // lblRestante
            // 
            this.lblRestante.AutoSize = true;
            this.lblRestante.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblRestante.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRestante.Location = new System.Drawing.Point(115, 107);
            this.lblRestante.Name = "lblRestante";
            this.lblRestante.Size = new System.Drawing.Size(310, 27);
            this.lblRestante.TabIndex = 24;
            this.lblRestante.Text = "Selectati anul universitar";
            this.lblRestante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Restante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvRestante);
            this.Controls.Add(this.cmbAnUniversitar);
            this.Controls.Add(this.lblRestante);
            this.Name = "Restante";
            this.Size = new System.Drawing.Size(1378, 600);
            this.Load += new System.EventHandler(this.Restante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRestante;
        private System.Windows.Forms.ComboBox cmbAnUniversitar;
        private System.Windows.Forms.Label lblRestante;
    }
}
