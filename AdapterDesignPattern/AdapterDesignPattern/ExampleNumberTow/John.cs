using AdapterDesignPattern.ExampleNumberOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern.ExampleNumberTow
{
    public class John : IEnglishSpeaker
    {
        public string AskQuestion(string Words)
        {
            Console.WriteLine("Question Asked by John [English Speaker and Can understand only English] : " + Words);
            ITargetLanguage target = new TranslatorAdapter();
            string replyFromDavid = target.TranslateAndTellToOtherPerson(Words, "French");
            return replyFromDavid;
        }

        public string AnswerForTheQuestion(string Words)
        {
            string reply = null;
            if (Words.Equals("where are you?", StringComparison.InvariantCultureIgnoreCase))
            {
                reply = "I am in USA";
            }
            return reply;
        }
    }
}
