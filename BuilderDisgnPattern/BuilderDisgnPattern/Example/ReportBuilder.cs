using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDisgnPattern.Example
{
    // The Builder Abstract Class specifies methods for creating the different parts
    // of the Product objects.
    public abstract class ReportBuilder
    {
        protected Report reportObject;
        public abstract void SetReportType();
        public abstract void SetReportHeader();
        public abstract void SetReportContent();
        public abstract void SetReportFooter();
        public void CreateNewReport()
        {
            reportObject = new Report();
        }
        public Report GetReport()
        {
            return reportObject;
        }
    }
}
