namespace Document_Format_Converters.DocumentFormatConverters
{
    public class DocxConverterFactory : DocumentConverterFactory
    {
        public override IDocumentConverter CreateConverter()
        {
            return new DocxConverter();
        }
    }
}
