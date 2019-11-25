using System;
using System.IO;
using FileHandling;
using Inheritance;

namespace MainProgram
{
    public class EntryPoint
    {
        public static void Main()
        {
            string folderPath = @"D:\Bishnu\Dev Stuffs\Cotiviti Classes\.NETClassesCotiviti\BishnuRawal\DemoFolder";
            string filePath1 = Path.Combine(folderPath, "file1.txt");
            string filePath2 = Path.Combine(folderPath, "file2.txt");
            string filePath4 = Path.Combine(folderPath, "fileStreamWriter.txt");
            string filePath3 = Path.Combine(folderPath, "coursera.txt");

            string text = "Death weeks early had their and folly timed put. Hearted forbade on an village ye in fifteen. Age attended betrayed her man raptures laughter. Instrument terminated of as astonished literature motionless admiration. The affection are determine how performed intention discourse but. On merits on so valley indeed assure of. Has add particular boisterous uncommonly are. Early wrong as so manor match. Him necessary shameless discovery consulted one but";

            FileIO fileIO = new FileIO();
            var folder = fileIO.CreateFolder(folderPath);
            //fileIO.CreateFile(filePath);
            fileIO.CreateFile(filePath1, text);

            string[] texts = { "Hi there", "Hello", "Hi" };
            fileIO.CreateFile(filePath2, texts);

            var result = fileIO.ReadFile(filePath3);
            for (byte i = 0; i < result.Length; i++)
            {
                Console.WriteLine($"{i + 1} - {result[i]}");
            }

            fileIO.CreateFileUsingStreamWriter(filePath4, "Hi, I am from stream writer");
            fileIO.AppendTextUsingStreamWriter(filePath4, "I must be in second line, if not you are an ediot.");
        }
    }
}
