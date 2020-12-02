using iText.Kernel.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            var filePath = GetFilePath();
            SplitPdf(filePath);     
        }

        private string GetFilePath()
        {
            var filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                }
            }
            return filePath;
        }

        private void SplitPdf(string filePath)
        {
            using (var pdfDoc = new PdfDocument(new PdfReader(filePath)))
            {
                var outputDir = @"E:\test\";
                var splitter = new CustomSplitter(pdfDoc, outputDir);
                var splittedDocs = splitter.SplitByPageCount(1);

                foreach (var splittedDoc in splittedDocs)
                {
                    splittedDoc.Close();
                }
            }
        }
    }
}
