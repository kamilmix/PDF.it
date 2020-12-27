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
            textBoxDestinationFolder.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\";
        }

        private void listBoxPdfToMerge_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                listBoxPdfToMerge.Items.Add(file);
            }

            SetDragAndDropLabelVisibility();
        }

        private void listBoxPdfToMerge_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void buttonMerge_Click(object sender, EventArgs e)
        {
            var files = listBoxPdfToMerge.Items.OfType<string>().ToArray();
            PdfHelper.MergePdf(files, textBoxDestinationFolder.Text);
        }

        private void buttonBrowseDestinationFolder_Click(object sender, EventArgs e)
        {
            var folderPath = FileHelper.GetFolder();
            textBoxDestinationFolder.Text = folderPath + "\\";
        }

        private void buttonClearList_Click(object sender, EventArgs e)
        {
            listBoxPdfToMerge.Items.Clear();
            SetDragAndDropLabelVisibility();
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            var filePath = FileHelper.GetFile();
            listBoxPdfToMerge.Items.Add(filePath);
            SetDragAndDropLabelVisibility();

        }

        private void SetDragAndDropLabelVisibility()
        {
            labelDragDrop.Visible = listBoxPdfToMerge.Items.Count == 0;
        }
    }
}
