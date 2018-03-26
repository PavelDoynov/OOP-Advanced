using System;

public class Logger : ILogger
{
    private IAppender[] appenders;

    public Logger(params IAppender[] appenderArgs)
    {
        this.appenders = appenderArgs;
    }

    private void Log (string dateTime, string reportType, string message)
    {
        foreach (IAppender appender in this.appenders)
        {
            ReportLevel currentReportLevel = (ReportLevel)Enum.Parse(typeof(ReportLevel), reportType);

            if (appender.ReportLevel <= currentReportLevel)
            {
                appender.Append(dateTime, reportType, message);
            }
        }
    }

    public void Error(string dateTime, string message)
    {
        this.Log(dateTime, "Error", message);
    }

    public void Info(string dateTime, string message)
    {
        this.Log(dateTime, "Info", message);
    }

    public void Fatal(string dateTime, string message)
    {
        this.Log(dateTime, "Fatal", message);
    }

    public void Critical(string dateTime, string message)
    {
        this.Log(dateTime, "Critical", message);
    }

    public void Warn(string dateTime, string message)
    {
        this.Log(dateTime, "Warning", message);
    }
}