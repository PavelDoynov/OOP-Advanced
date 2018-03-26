using System;

public class ConsoleAppender : IAppender
{
    private ILayout layout;

    public ConsoleAppender(ILayout layout)
    {
        this.layout = layout;
    }

    public ReportLevel ReportLevel { get; set; }

    public void Append(string dateTime, string reportType, string message)
    {
        string formattedMsg = this.layout.FormatMessage(dateTime, reportType, message);
        Console.WriteLine(formattedMsg);
    }
}