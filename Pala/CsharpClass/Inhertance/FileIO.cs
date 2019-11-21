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
        /*public void CreateFile(string path, string content = "")
        {
            File.WriteAllText(path, content);
        }*/
        public void CreateFile(string path, string content= "Hello World")
        {
            File.WriteAllText(path,content);
        }
        internal void CreateFile(string path, string[] content)
        {
            File.WriteAllLines(path, content);
        }
        internal string[] ReadFile(string path)
        {
            var fileContent = File.ReadAllText(path);
            var lines = fileContent.Split("\n",System.StringSplitOptions.RemoveEmptyEntries);
            return lines;
        }
         internal int CountWord(string path)
        {
            var fileContent = File.ReadAllText(path);
            var lines = fileContent.Split(" ").Length;
            return lines;
        }
         internal int CountSentence(string path)
        {
            var fileContent = File.ReadAllText(path);
            var lines = fileContent.Split('\r').Length;//next line 
            return lines;
        }
      
    }

}