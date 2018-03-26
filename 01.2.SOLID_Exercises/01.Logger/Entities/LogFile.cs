using System;
using System.IO;
using System.Text;

public class LogFile
{
    private const string DEFAULT_FILE_NAME = "log.txt";
    private StringBuilder result;

    public LogFile()
    {
        this.result = new StringBuilder();
    }

    public int Size
    {
        get;
        private set;
    }

    public void Write(string result)
    {
        this.result.AppendLine(result);
        File.AppendAllText(DEFAULT_FILE_NAME, result + Environment.NewLine);
        this.Size = this.GetSumOfLetters(this.result.ToString());
    }

    private int GetSumOfLetters(string text)
    {
        int sumResult = 0;

        foreach (char symbol in text)
        {
            if (char.IsLetter(symbol))
            {
                sumResult += symbol;
            }
        }

        return sumResult;
    }
}