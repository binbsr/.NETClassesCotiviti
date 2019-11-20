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
        public void CreateFile(string f, string content = "hello world")
        {
            File.WriteAllText(f,content);
        }
        public void CreateFile(string path, string[] content)
        {
            File.WriteAllLines(path, content);
        }
        public string[] ReadFile(string f)
        {
            var a =  File.ReadAllText(f);
            var result = a.Split("\r\n");
            return result;
        }
    }
}