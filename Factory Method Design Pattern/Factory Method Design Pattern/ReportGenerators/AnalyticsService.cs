namespace Report_Generators.ReportGenerators
{
    public class AnalyticsService
    {
        public void CreateReport(ReportGeneratorFactory factory, string data)
        {
            IReportGenerator reportGenerator = factory.GenerateReportGenerator();
            reportGenerator.GenerateReport(data);
        }
    }
}
