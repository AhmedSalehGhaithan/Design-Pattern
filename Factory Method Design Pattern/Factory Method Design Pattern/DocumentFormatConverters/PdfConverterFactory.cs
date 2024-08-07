namespace Document_Format_Converters.DocumentFormatConverters
{
    internal class PdfConverterFactory : DocumentConverterFactory
    {
        public override IDocumentConverter CreateConverter()
        {
            return new PdfConverter();
        }
    }
}
