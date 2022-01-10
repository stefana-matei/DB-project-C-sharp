using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_final_MTP
{
    public partial class FoaieMatricola : UserControl
    {
        static string fileName;
        public FoaieMatricola()
        {
            InitializeComponent();
            
        }

        #region File Upload
        private void FoaieMatricola_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }


        private void FoaieMatricola_DragDrop(object sender, DragEventArgs e)
        {
            string[] droppedFiles = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string file in droppedFiles)
            {
                this.timer.Start();
                string fileName = getFileName(file);

                pcbUpload.Visible = false;
                lblDragDrop.Visible = false;
                progressBarUpload.Visible = true;
                FoaieMatricola.fileName = fileName;

                    
            }
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            this.progressBarUpload.Increment(3);

            if(progressBarUpload.Value >= progressBarUpload.Maximum)
            {
                timer.Stop();
                MessageBox.Show("Fisier incarcat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                progressBarUpload.Value = progressBarUpload.Minimum;
                progressBarUpload.Visible = false;
                lbxFileName.Items.Add(FoaieMatricola.fileName);
            }
        }


        private string getFileName(string filePath)
        {
            return Path.GetFileName(filePath);
        }


        // buton de default
        private void btnCancel_Click(object sender, EventArgs e)
        {
            pcbUpload.Visible = true;
            lblDragDrop.Visible = true;
            progressBarUpload.Visible = false;
            lbxFileName.Items.Clear();
        }
        #endregion


        private void btnGenerare_Click(object sender, EventArgs e)
        {
            

        }

    }
}
