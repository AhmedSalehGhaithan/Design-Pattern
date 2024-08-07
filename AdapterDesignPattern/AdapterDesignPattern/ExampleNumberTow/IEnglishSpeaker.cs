﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern.ExampleNumberTow
{
    public interface IEnglishSpeaker
    {
        string AskQuestion(string Words);
        string AnswerForTheQuestion(string Words);
    }
}
