
namespace Proiect_final_MTP
{
    partial class SituatieScolara
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
            this.cmbAnUniversitar = new System.Windows.Forms.ComboBox();
            this.lblAnUniversitar = new System.Windows.Forms.Label();
            this.dgvSituatieScolara = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSituatieScolara)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbAnUniversitar
            // 
            this.cmbAnUniversitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbAnUniversitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAnUniversitar.FormattingEnabled = true;
            this.cmbAnUniversitar.Location = new System.Drawing.Point(120, 120);
            this.cmbAnUniversitar.Name = "cmbAnUniversitar";
            this.cmbAnUniversitar.Size = new System.Drawing.Size(50, 37);
            this.cmbAnUniversitar.TabIndex = 22;
            this.cmbAnUniversitar.SelectedIndexChanged += new System.EventHandler(this.cmbAnUniversitar_SelectedIndexChanged);
            // 
            // lblAnUniversitar
            // 
            this.lblAnUniversitar.AutoSize = true;
            this.lblAnUniversitar.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblAnUniversitar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAnUniversitar.Location = new System.Drawing.Point(115, 79);
            this.lblAnUniversitar.Name = "lblAnUniversitar";
            this.lblAnUniversitar.Size = new System.Drawing.Size(310, 27);
            this.lblAnUniversitar.TabIndex = 21;
            this.lblAnUniversitar.Text = "Selectati anul universitar";
            this.lblAnUniversitar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvSituatieScolara
            // 
            this.dgvSituatieScolara.AllowUserToAddRows = false;
            this.dgvSituatieScolara.AllowUserToDeleteRows = false;
            this.dgvSituatieScolara.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSituatieScolara.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSituatieScolara.BackgroundColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSituatieScolara.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSituatieScolara.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSituatieScolara.EnableHeadersVisualStyles = false;
            this.dgvSituatieScolara.Location = new System.Drawing.Point(172, 200);
            this.dgvSituatieScolara.MultiSelect = false;
            this.dgvSituatieScolara.Name = "dgvSituatieScolara";
            this.dgvSituatieScolara.RowHeadersVisible = false;
            this.dgvSituatieScolara.RowHeadersWidth = 51;
            this.dgvSituatieScolara.RowTemplate.Height = 24;
            this.dgvSituatieScolara.Size = new System.Drawing.Size(1046, 293);
            this.dgvSituatieScolara.TabIndex = 23;
            // 
            // SituatieScolara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.dgvSituatieScolara);
            this.Controls.Add(this.cmbAnUniversitar);
            this.Controls.Add(this.lblAnUniversitar);
            this.Name = "SituatieScolara";
            this.Size = new System.Drawing.Size(1378, 600);
            this.Load += new System.EventHandler(this.SituatieScolara_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSituatieScolara)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAnUniversitar;
        private System.Windows.Forms.Label lblAnUniversitar;
        private System.Windows.Forms.DataGridView dgvSituatieScolara;
    }
}
