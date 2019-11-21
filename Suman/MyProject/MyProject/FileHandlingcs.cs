using System;
using System.IO;
using System.Text.RegularExpressions;

namespace MyProject
{
    public class FileHandling
    {
        //public void CreateFile(string path, string content) => File.WriteAllText(path, content);
        public string ReadFile(string path)
        {
            var content = File.ReadAllText(path);
            return content;
        }
        public int CountCharacter(string text) => text.Length;

        public int CountWords(string text)
        {
            var res = text.Split();
            return res.Length;
        }
        public int CountSentences(string text)
        {
            var res = text.Split(". ");
            return res.Length;
        }
        public int CountVowel(string text)
        {
            int count = 0;
            foreach (char a in text.ToLower())
            {
                if ("aeiou".Contains(a))
                    count++;
            }
            return count;
        }
        public int CountSepcialCharacter(string text)
        {
            return void;
        }
    }
}
