using System.IO;
namespace FileHandling
{
    public class FileIO
    {
        public DirectoryInfo CreateFolder(string path)
        {
            var result = Directory.CreateDirectory(path);
            return result;
        }

        public void CreateFile (string path)
        {
               // File.Create(path);
                File.WriteAllText(path,"Hello World");

        }
        
        public void CreateFile (string path, string content ="Hello World")
        {
            File.WriteAllText(path,content);
        }

        public void CreateFile (string path, string[] content)
        {
            File.WriteAllLines (path, content);
        }

        internal string[] ReadFile(string path)
        {
            var fileContent = File.ReadAllText(path);
            var lines = fileContent.Split("\n",System.StringSplitOptions.RemoveEmptyEntries);

            return lines;
        }

        public (int, int, int) Count(string path)
        {
            var fileContent = File.ReadAllText(path);
            var CharCount = fileContent.Length;            //total char 
            var LinesCount = fileContent.Split('\r').Length;       //total lines
            var WordsCount = fileContent.Split(' ').Length;                   

            return (CharCount, LinesCount, WordsCount);
        }

        
    }

}