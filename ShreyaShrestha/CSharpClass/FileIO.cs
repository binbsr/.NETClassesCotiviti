using System;
using System.IO;

namespace FileHandler
{
    public class FileIO
    {
        public DirectoryInfo CreateFolder(string path)
        {
            var result = Directory.CreateDirectory(path); //class kai naam bata call gariracha obj banako chaina.. so they are static
            return result;
        }

        public void CreateFile(string path, string text = "")
        {
            // var result = File.Create(path);
            // return result;
            File.WriteAllText(path, text); //WriteAllTest writes also and if the file doesnt exist then it creates files too
            // the target file is overriden by WriteAllText method
        }

        public void CreateFile(string path, string[] content)
        {
            File.WriteAllLines(path, content);
        }

        internal string[] ReadFile(string path)
        {
            string[] lines = File.ReadAllText(path).Split("\n", System.StringSplitOptions.RemoveEmptyEntries);
            return lines; //ReadAllText when file type is unknwn 
        }

    }


}