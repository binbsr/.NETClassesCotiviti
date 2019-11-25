using System.IO;

namespace FileHandling 
{
    public class FileIO
    {
       internal string[] ReadFile(string path)
        {
            var fileContent = File.ReadAllText(path);
            var lines = fileContent.Split("\n",System.StringSplitOptions.RemoveEmptyEntries);
            return lines;
        }
    }
}