using System;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string content;
            FileHandling file = new FileHandling();
            content=file.ReadFile(@"D:\Training\test.txt");
            Console.WriteLine("Character = "+ file.CountCharacter(content));
            Console.WriteLine("Word =" + file.CountWords(content));
            Console.WriteLine("Sentence = " + file.CountSentences(content));
            Console.WriteLine("Vowel = " + file.CountVowel(content));
            Console.WriteLine("Special Character = " + file.CountSepcialCharacter(content));

        }
    }
}
