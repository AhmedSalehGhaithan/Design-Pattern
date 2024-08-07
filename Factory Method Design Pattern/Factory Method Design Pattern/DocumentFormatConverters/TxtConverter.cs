using System;
namespace Document_Format_Converters.DocumentFormatConverters
{
    public class TxtConverter : IDocumentConverter
    {
        public void Convert(string inputFile, string outputFile)
        {
            Console.WriteLine($"Converting {inputFile} to TXT and saving as {outputFile}.");
            // Actual TXT conversion logic goes here...
        }
    }
}
