namespace Report_Generators.ReportGenerators
{
    public class TabularReportGeneratorFactory : ReportGeneratorFactory
    {
        public override IReportGenerator GenerateReportGenerator()
        {
            return new TabularReportGenerator();
        }
    }
}
