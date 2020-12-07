using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PDF.it.Utils;

namespace PDF.it
{
    public partial class SplitControl : UserControl
    {
        public SplitControl()
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
            textBoxDestinationFolder.Text = folderPath + "\\";
        }

        private void button_Click(object sender, EventArgs e)
        {
            var filePath = FileHelper.GetFile();
            textBoxSourceFile.Text = filePath;
        }
    }
}
