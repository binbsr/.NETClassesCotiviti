using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace FileHandling
{
    public class FileIO
    {   
        string fileContent;
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
        public void CreateFileSW(string fp, string content)
        {
            StreamWriter sw = new StreamWriter(fp);
            sw.WriteLine(content);
            sw.Flush();
            sw.Close();
        }
        public void AppendFileSW(string fp, string content)
        {
            StreamWriter sw = new StreamWriter(fp, true);
            sw.WriteLine(content);
            sw.Flush();
            sw.Close();
        }
        public void ReadFile(string f)
        {
            fileContent =  File.ReadAllText(f);
            // var result = a.Split("\r\n");         
            //return result;
        }
        public int CountChar()
        {
            return fileContent.Length;
        }
        public int CountWord()
        {
            var count = Regex.Matches(fileContent, @"\b\w+\b").Count;
            return count;
        }
        public int CountLine(string fp)
        {
            int count = File.ReadLines(fp).Count();
            return count;
        }
        public int CountSentence()
        {
            return Regex.Matches(fileContent, @"[.?]").Count;  
        }
        public int CountVowel()
        {
            var count = Regex.Matches(fileContent, @"[aeiou]").Count;
            return count;
        }
        public int CountConsonant()
        {
            var count = Regex.Matches(fileContent, @"[b-df-hj-np-tv-z]").Count;
            return count;
        }

        
    }
}