using System;

public class SimpleLayout : ILayout
{
    public SimpleLayout()
    {
    }

    public string FormatMessage(string dateTime, string reportType, string message)
    {
        return $"{dateTime} - {reportType} - {message}";
    }
}