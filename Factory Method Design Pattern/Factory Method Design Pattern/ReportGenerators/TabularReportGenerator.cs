using System;

namespace Report_Generators.ReportGenerators
{
    public class TabularReportGenerator : IReportGenerator
    {
        public void GenerateReport(string data)
        {
            Console.WriteLine($"Generating Tabular Report with data: {data}");
            // Actual logic to generate a tabular report...
        }
    }
}
