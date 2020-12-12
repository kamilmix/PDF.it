using iText.Kernel.Pdf;
using iText.Kernel.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDF.it.Utils
{
    public static class PdfHelper
    {
        public static void SplitPdf(string filePath, string outputDir = null)
        {
            if (filePath == string.Empty || filePath == null)
            {
                return;
            }

            if (outputDir == null)
            {
                outputDir = System.IO.Path.GetDirectoryName(filePath) + "\\";
            }

            using (var pdfDoc = new PdfDocument(new PdfReader(filePath)))
            {
                var splitter = new CustomSplitter(pdfDoc, outputDir);
                var splittedDocs = splitter.SplitByPageCount(1);

                foreach (var splittedDoc in splittedDocs)
                {
                    splittedDoc.Close();
                }
            }
            OpenFolderInExplorer(outputDir);
        }

        public static void MergePdf(string[] files, string outputDir)
        {
            PdfDocument outputPdf = new PdfDocument(new PdfWriter(outputDir + "mergeDocument1.pdf"));
            PdfMerger merger = new PdfMerger(outputPdf);

            foreach (string file in files)
            {
                PdfDocument pdfDocument = new PdfDocument(new PdfReader(file));
                merger.Merge(pdfDocument, 1, pdfDocument.GetNumberOfPages());
                pdfDocument.Close();

            }
            outputPdf.Close();
            OpenFolderInExplorer(outputDir);
        }

        private static void OpenFolderInExplorer(string path)
        {
            System.Diagnostics.Process.Start("explorer.exe", path);
        }
    }
}
