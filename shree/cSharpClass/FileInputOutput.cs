using System;
using System.Collections.Generic;
using System.Text;
using System.IO;        // for file / directory handling

namespace FileHandling
{
    public class FileInputOutput
    {
        public DirectoryInfo CreateFolder(string path)
        {
            var result = Directory.CreateDirectory(path);
            return result;
        }
        public void CreateFile(string path, string content="")
        {
            //File.Create(path);

            File.WriteAllText(path, content);
            /*
             * here WriteAllText create file if does not exits and write text in the file
            */

            
        }
        public void CreateFile(string path, string[] contents)
        {
            File.WriteAllLines(path, contents);
        }

        internal string[] ReadFile(string path)
        {
            var fileContent=File.ReadAllText(path);
            var lines = fileContent.Split("\n",StringSplitOptions.RemoveEmptyEntries);
            return lines;
        }
    }
}
