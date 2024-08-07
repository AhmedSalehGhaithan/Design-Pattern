using System;
namespace Document_Format_Converters.DocumentFormatConverters
{
    public class DocxConverter : IDocumentConverter
    {
        public void Convert(string inputFile, string outputFile)
        {
            Console.WriteLine($"Converting {inputFile} to DOCX and saving as {outputFile}.");
            // Actual DOCX conversion logic goes here...
        }
    }
}
