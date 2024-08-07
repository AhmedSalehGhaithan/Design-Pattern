namespace Document_Format_Converters.DocumentFormatConverters
{
    public class TxtConverterFactory : DocumentConverterFactory
    {
        public override IDocumentConverter CreateConverter()
        {
            return new TxtConverter();
        }
    }
}
