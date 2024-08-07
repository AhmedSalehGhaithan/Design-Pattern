using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document_Format_Converters.DocumentFormatConverters
{
    public interface IDocumentConverter
    {
        void Convert(string inputFile, string outputFile);
    }
}
