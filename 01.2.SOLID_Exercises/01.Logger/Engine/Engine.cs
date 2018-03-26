using System;
using System.Collections.Generic;
using System.Linq;

public class Engine
{
    public void StartUp()
    {
        List<IAppender> appenderList = new List<IAppender>();
        int appenderCount = int.Parse(Console.ReadLine());

        while (appenderCount != 0)
        {
            string[] inputArgs = Console.ReadLine().Split(' ').ToArray();
            appenderList.Add(GetAppender(inputArgs));
            appenderCount--;
        }

        Logger logger = new Logger(appenderList.ToArray());

        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            string[] inputArgs = input.Split('|').ToArray();
            string error = inputArgs[0];
            string dataTime = inputArgs[1];
            string text = inputArgs[2];

            if (error == "INFO")
            {
                logger.Info(dataTime, text);
            }
            else if (error == "WARNING")
            {
                logger.Warn(dataTime, text);
            }
            else if (error == "ERROR")
            {
                logger.Error(dataTime, text);
            }
            else if (error == "CRITICAL")
            {
                logger.Critical(dataTime, text);
            }
            else if (error == "FATAL")
            {
                logger.Fatal(dataTime, text);
            }
        }

        Console.WriteLine(logger);

    }

    //private Logger GetLogger(string[] inputArgs)
    //{
    //    return new Logger(GetAppender(inputArgs));
    //}

    private IAppender GetAppender(string[] inputArgs)
    {
        string appender = inputArgs[0];
        string layout = inputArgs[1];

        if (appender == "ConsoleAppender")
        {
            ConsoleAppender currentAppender = new ConsoleAppender(GetLayout(layout));

            if (inputArgs.Length == 3)
            {
                string error = inputArgs[2];

                if (error == "INFO")
                {
                    currentAppender.ReportLevel = ReportLevel.Info;
                }
                else if (error == "WARNING")
                {
                    currentAppender.ReportLevel = ReportLevel.Warning;
                }
                else if (error == "ERROR")
                {
                    currentAppender.ReportLevel = ReportLevel.Error;
                }
                else if (error == "CRITICAL")
                {
                    currentAppender.ReportLevel = ReportLevel.Critical;
                }
                else if (error == "FATAL")
                {
                    currentAppender.ReportLevel = ReportLevel.Fatal;
                }
            }

            return currentAppender;
        }
        else if (appender == "FileAppender")
        {
            var file = new LogFile();
            FileAppender currentAppender = new FileAppender(GetLayout(layout));
            currentAppender.File = file;

            if (inputArgs.Length == 3)
            {
                string error = inputArgs[2];

                if (error == "INFO")
                {
                    currentAppender.ReportLevel = ReportLevel.Info;
                }
                else if (error == "WARNING")
                {
                    currentAppender.ReportLevel = ReportLevel.Warning;
                }
                else if (error == "ERROR")
                {
                    currentAppender.ReportLevel = ReportLevel.Error;
                }
                else if (error == "CRITICAL")
                {
                    currentAppender.ReportLevel = ReportLevel.Critical;
                }
                else if (error == "FATAL")
                {
                    currentAppender.ReportLevel = ReportLevel.Fatal;
                }
            }


            return currentAppender;
        }
        else
        {
            throw new ArgumentException("Invalid Appender Information");
        }
    }

    private ILayout GetLayout(string layout)
    {
        ILayout currentLayout;
        if (layout == "SimpleLayout")
        {
            currentLayout = new SimpleLayout();
        }
        else if (layout == "XmlLayout")
        {
            currentLayout = new XmlLayout();
        }
        else
        {
            throw new ArgumentException("Invalid Layout Information");
        }
        return currentLayout;
    }
}