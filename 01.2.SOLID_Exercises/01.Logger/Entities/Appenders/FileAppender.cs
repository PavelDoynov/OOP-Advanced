using System;

public class FileAppender : IAppender
{
    private ILayout layout;

    public FileAppender(ILayout layout)
    {
        this.layout = layout;
    }

    public LogFile File { get; set; }

    public ReportLevel ReportLevel { get; set; }

    public void Append(string dateTime, string reportType, string message)
    {
        string formattedMessage = this.layout.FormatMessage(dateTime, reportType, message);
        this.File.Write(formattedMessage);
    }
}
