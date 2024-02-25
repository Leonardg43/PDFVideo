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
    public partial class PDF : Form
    {
        public PDF()
        {
            InitializeComponent();
        }

        private void openPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                axAcroPDF1.src = openFileDialog1.FileName;
            }
        }
    }
}
