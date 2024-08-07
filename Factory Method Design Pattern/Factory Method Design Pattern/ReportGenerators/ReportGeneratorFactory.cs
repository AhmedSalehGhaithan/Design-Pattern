namespace Report_Generators.ReportGenerators
{
    public abstract class ReportGeneratorFactory
    {
        public abstract IReportGenerator GenerateReportGenerator();
    }
}
