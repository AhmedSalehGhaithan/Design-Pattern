namespace Document_Format_Converters.DocumentFormatConverters
{
    public class DocumentService
    {
        public void ExportDocument(DocumentConverterFactory factory, string inputFile,string outputFile)
        {
            IDocumentConverter converter = factory.CreateConverter();
            converter.Convert(inputFile, outputFile);
        }
    }
}
