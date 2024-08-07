using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern.ExampleNumberTow
{
    public interface ITargetLanguage
    {
        string TranslateAndTellToOtherPerson(string words, string convertToWhichLanguage);
    }
}
