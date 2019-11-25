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

        public  void CreateFile(string path, string content = "Hello Pawan !!!")
        {
            File.WriteAllText(path,content);
        } 

        public void CreateFile(string path, string[] content)
        {
            File.WriteAllLines(path,content);
        }

        internal string[] ReadFile(string path)
        {
            var fileContent = File.ReadAllText(path);
            var lines = fileContent.Split("\n",System.StringSplitOptions.RemoveEmptyEntries);
            return lines;

        }

        internal void CreateFileUsingStreamWriter(string path, string fileContent)
        {
            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine(fileContent);
            sw.Flush();
            sw.Close();

        }

         internal void AppendTextUsingStreamWriter(string path, string texttoappend)
        {
            StreamWriter sw = new StreamWriter(path, true);
            sw.WriteLine(texttoappend);
            sw.Flush();
            sw.Close();

        }
    }
    
}
