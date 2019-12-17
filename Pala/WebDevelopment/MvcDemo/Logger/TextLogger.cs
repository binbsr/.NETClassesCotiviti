using System;
public class TextLogger : IMyLogger
{
    public void LogToConsole(string message)
    {
        Console.WriteLine($"{DateTime.Now} {message}");
    }

    public void LogToDb(string message)
    {
        throw new NotImplementedException();
    }

    public void LogToFile(string message)
    {
        throw new NotImplementedException();
    }
}