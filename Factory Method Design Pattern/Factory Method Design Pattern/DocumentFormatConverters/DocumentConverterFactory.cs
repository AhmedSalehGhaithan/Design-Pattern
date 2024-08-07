using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document_Format_Converters.DocumentFormatConverters
{
    public abstract class DocumentConverterFactory
    {
        public abstract IDocumentConverter CreateConverter();
    }
}
