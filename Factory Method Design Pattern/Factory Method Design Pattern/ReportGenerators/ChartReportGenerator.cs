using System;

namespace Report_Generators.ReportGenerators
{
    public class ChartReportGenerator : IReportGenerator
    {
        public void GenerateReport(string data)
        {
            Console.WriteLine($"Generating Chart Report with data: {data}");
        }
    }
}
