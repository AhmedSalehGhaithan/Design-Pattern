using AdapterDesignPattern.ExampleNumberOne;
using AdapterDesignPattern.ExampleNumberTow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] employeesArray = new string[5, 4]
            {
                {"101","John","SE","10000"},
                {"102","Smith","SE","20000"},
                {"103","Dev","SSE","30000"},
                {"104","Pam","SE","40000"},
                {"105","Sara","SSE","50000"}
            };
            //The EmployeeAdapter Makes it possible to work with Two Incompatible Interfaces
            Console.WriteLine("HR system passes employee string array to Adapter\n");
            ITarget target = new EmployeeAdapter();
            target.ProcessCompanySalary(employeesArray);


            //Console.WriteLine("_____________________________________________");
            //string replyFromDavid = new John().AskQuestion("how are you?");
            //Console.WriteLine("Reply From David [French Speaker can Speak and Understand only French] :  " + replyFromDavid);
            //Console.WriteLine();
            //string replyFromJohn = new David().AskQuestion("où êtes-vous?");
            //Console.WriteLine("Reply From John [English Speaker can Speak and Understand only English] :  " + replyFromJohn);



            Console.ReadKey();
        }
    }
}
