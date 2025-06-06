namespace LoggerUsage.ReportGenerator;

internal class LoggerReportGeneratorFactory : ILoggerReportGeneratorFactory
{
    public ILoggerReportGenerator GetReportGenerator(string type) => type switch
    {
        ".json" => new JsonLoggerReportGenerator(),
        ".html" => new HtmlLoggerReportGenerator(),
        _ => throw new NotSupportedException($"The report type '{type}' is not supported.")
    };
}
