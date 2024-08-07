namespace Report_Generators.ReportGenerators
{
    public class SummaryReportGeneratorFactory : ReportGeneratorFactory
    {
        public override IReportGenerator GenerateReportGenerator()
        {
            return new SummaryReportGenerator();
        }
    }
}
