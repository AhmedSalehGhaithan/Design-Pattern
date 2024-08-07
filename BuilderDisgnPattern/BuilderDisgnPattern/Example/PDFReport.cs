using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDisgnPattern.Example
{
    // The Following Concrete Builder Implementd the ReportBuilder Abstract Class and 
    // provide specific implementations of the steps for Creating PDFReport. 
    public class PDFReport : ReportBuilder
    {
        public override void SetReportContent()
        {
            reportObject.ReportContent = "PDF Content Section";
        }
        public override void SetReportFooter()
        {
            reportObject.ReportFooter = "PDF Footer";
        }
        public override void SetReportHeader()
        {
            reportObject.ReportHeader = "PDF Header";
        }
        public override void SetReportType()
        {
            reportObject.ReportType = "PDF";
        }
    }
}
