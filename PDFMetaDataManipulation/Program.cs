using System;
using iText.Kernel.Pdf;

namespace PDFMetaDataManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // The path to the PDF file
            string sourceFile = @"D:\Working\HoqueConsulting\PDF-metadata\PDFMetaDataManipulation\PDFMetaDataManipulation\example.pdf";
            // The path to the edited PDF file
            string outputFile = @"D:\Working\HoqueConsulting\PDF-metadata\PDFMetaDataManipulation\PDFMetaDataManipulation\example_edited.pdf";

            using (PdfReader reader = new PdfReader(sourceFile))
            {
                using (PdfWriter writer = new PdfWriter(outputFile))
                {
                    using (PdfDocument pdf = new PdfDocument(reader, writer))
                    {
                        // Get the document information
                        PdfDocumentInfo info = pdf.GetDocumentInfo();

                        // Update the title and author
                        info.SetTitle("My New PDF Title");
                        info.SetAuthor("John Doe");

                        pdf.Close();
                    }
                }
            }
        }
    }
}
