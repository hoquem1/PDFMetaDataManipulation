using System;
using iText.Kernel.Pdf;

namespace PDFMetaDataManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // The path to the PDF file
            string sourceFile = @"C:\example.pdf";
            // The path to the edited PDF file
            string outputFile = @"C:\example_edited.pdf";

            using (PdfReader reader = new PdfReader(sourceFile))
            {
                using (PdfWriter writer = new PdfWriter(outputFile))
                {
                    using (PdfDocument pdf = new PdfDocument(reader, writer))
                    {
                        // Get the document information
                        PdfDocumentInfo info = pdf.GetDocumentInfo();

                        // Update the title and author
                        info.SetTitle("Some new title");
                        info.SetAuthor("The ROCK");

                        pdf.Close();
                    }
                }
            }
        }
    }
}
