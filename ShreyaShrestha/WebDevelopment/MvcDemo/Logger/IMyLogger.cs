public interface IMyLogger
{
    void LogToConsole(string message);
    void LogToFile(string message);
    void LogToDb(string message);
}