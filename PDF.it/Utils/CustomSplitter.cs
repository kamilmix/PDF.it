using iText.Kernel.Pdf;
using iText.Kernel.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDF.it
{
    class CustomSplitter : PdfSplitter
    {
        private int _order;
        private readonly string _destinationFolder;

        public CustomSplitter(PdfDocument pdfDocument, string destinationFolder) : base(pdfDocument)
        {
            _destinationFolder = destinationFolder;
            _order = 0;
        }

        protected override PdfWriter GetNextPdfWriter(PageRange documentPageRange)
        {
            return new PdfWriter(_destinationFolder + "splitDocument1_" + _order++ + ".pdf");
        }
    }
}
