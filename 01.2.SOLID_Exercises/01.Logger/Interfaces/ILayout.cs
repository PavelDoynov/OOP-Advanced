using System;

public interface ILayout
{
    string FormatMessage(string dateTime, string reportType, string message);
}