using System;

public class XmlLayout : ILayout
{
    public XmlLayout()
    {
    }

    public string FormatMessage(string dateTime, string reportType, string message)
    {
        return "<log>" + Environment.NewLine + 
                                     $"   <date>{dateTime}</date>" + Environment.NewLine +
                                     $"   <level>{reportType}</level>" + Environment.NewLine +
                                     $"   <message>{message}</message>" + Environment.NewLine +
                                     "</log>";
    }
}