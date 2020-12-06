using PDF.it.Utils;
using System;
using System.Windows.Forms;

namespace PDF.it
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var filePath = FileHelper.GetFile();
            PdfHelper.SplitPdf(filePath);     
        }  
 
    }
}
