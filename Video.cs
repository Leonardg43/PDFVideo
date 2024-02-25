using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDFVideo
{
    public partial class Video : Form
    {
        public Video()
        {
            InitializeComponent();
            this.FormClosing += Video_FormClosing; //Stop Music when form closes
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            PDF pdf = new PDF();
            pdf.ShowDialog();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            if(opf.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = opf.FileName;
            }
        }

        private void Video_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Pause or stop video playback when the form is closing
            axWindowsMediaPlayer1.Ctlcontrols.stop(); // Stop the video
        }
    }
}
