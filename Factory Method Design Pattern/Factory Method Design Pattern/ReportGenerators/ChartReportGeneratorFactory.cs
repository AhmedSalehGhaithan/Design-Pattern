namespace Report_Generators.ReportGenerators
{
    public class ChartReportGeneratorFactory : ReportGeneratorFactory
    {
        public override IReportGenerator GenerateReportGenerator()
        {
            return new ChartReportGenerator();
        }
    }
}
