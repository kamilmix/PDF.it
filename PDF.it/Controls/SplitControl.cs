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
            textBoxDestinationFolder.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\";
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

        private void textBoxSourceFile_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void textBoxSourceFile_DragDrop(object sender, DragEventArgs e)
        {
            var files = (string[])e.Data.GetData(DataFormats.FileDrop);
            textBoxSourceFile.Text = files[0];
        }
    }
}
