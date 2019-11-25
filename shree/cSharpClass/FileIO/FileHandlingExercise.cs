using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileHandling
{
    public class FileHandlingExercise
    {
        public int NumberOfCharacter(string path)
        {
            var numberOfCharacter = File.ReadAllLines(path).Length;
            return numberOfCharacter;
        }
    }
}
