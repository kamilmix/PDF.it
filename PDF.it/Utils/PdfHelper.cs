using iText.Kernel.Pdf;
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
            else
            {
                outputDir += "\\";
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

        }
    }
}
