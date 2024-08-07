using System;

namespace Report_Generators.ReportGenerators
{
    public class SummaryReportGenerator : IReportGenerator
    {
        public void GenerateReport(string data)
        {
            Console.WriteLine($"Generating Summary Report with data: {data}");
            // Actual logic to generate a summary report...
        }
    }
}
