using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern.DocumentConversionSystem
{
    public static class DocumentConverterFactory
    {
        public static IDocumentConverter CreateDocumentConverter(int format)
        {
            switch (format)
            {
                case 1:
                    return new DocxConverter();
                case 2:
                    return new PdfConverter();
                case 3:
                    return new TxtConverter();
                default:
                    throw new ArgumentException("Unsupported document format");
            }
        }
    }
}
