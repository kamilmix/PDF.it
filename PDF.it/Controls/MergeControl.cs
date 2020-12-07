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

namespace PDF.it.Controls
{
    public partial class MergeControl : UserControl
    {
        public MergeControl()
        {
            InitializeComponent();
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                listBox1.Items.Add(file);
            }
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void buttonMerge_Click(object sender, EventArgs e)
        {
            var files = listBox1.Items.OfType<string>().ToArray();
            PdfHelper.MergePdf(files, textBoxDestinationFolder.Text);
        }

        private void buttonBrowseDestinationFolder_Click(object sender, EventArgs e)
        {
            var folderPath = FileHelper.GetFolder();
            textBoxDestinationFolder.Text = folderPath + "\\";
        }
    }
}
