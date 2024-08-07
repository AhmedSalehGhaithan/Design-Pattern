using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDisgnPattern.Example
{
    public class Report
    {
        public string ReportType { get; set; }
        public string ReportHeader { get; set; }
        public string ReportFooter { get; set; }
        public string ReportContent { get; set; }
        public void DisplayReport()
        {
            Console.WriteLine("Report Type :" + ReportType);
            Console.WriteLine("Header :" + ReportHeader);
            Console.WriteLine("Content :" + ReportContent);
            Console.WriteLine("Footer :" + ReportFooter);
        }
    }
}
