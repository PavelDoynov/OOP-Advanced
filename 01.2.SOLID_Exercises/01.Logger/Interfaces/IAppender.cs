using System;

public interface IAppender
{
    void Append(string dateTime, string reportType, string message);

    ReportLevel ReportLevel { get; set; }
}