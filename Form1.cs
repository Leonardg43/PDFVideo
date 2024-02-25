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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            PDF pdf = new PDF();
            pdf.ShowDialog();
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            Video video = new Video();
            video.ShowDialog();
        }


    }
}
