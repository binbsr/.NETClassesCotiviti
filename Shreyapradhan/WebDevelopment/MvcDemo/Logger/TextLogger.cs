using System;
public class TextLogger : IMyLogger
{
   public void LogToConsole(string message) => Console.WriteLine($"{DateTime.Now}{message}");


}