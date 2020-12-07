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
            PdfHelper.SplitPdf(textBoxSourceFile.Text, textBoxDestinationFolder.Text);     
        }

        private void buttonBrowseDestinationFolder_Click(object sender, EventArgs e)
        {
            var folderPath = FileHelper.GetFolder();
            textBoxDestinationFolder.Text = folderPath;
        }

        private void button_Click(object sender, EventArgs e)
        {
            var filePath = FileHelper.GetFile();
            textBoxSourceFile.Text = filePath;
        }
    }
}
