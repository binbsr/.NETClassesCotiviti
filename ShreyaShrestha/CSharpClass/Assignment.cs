using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Assignments
{
    //Base class

    //2. base class 1 should not allow its instantiation
    public abstract class Vegetables
    {
        public string scientificName;

        //1. method that can be overriden by child class
        public virtual void Sell()
        {

        }

        //5. property that is hidden by child class
        public double FiberContent { get; set; }

        //4. method that is hidden by child class
        public double GetFiberContent() => FiberContent;
    }

    //child Class
    public class LeafyGreen : Vegetables, IColor
    {
        //5. property of base class that is hidden by child class
        public new double FiberContent { get; set; }
        public string GetColor()
        {
            string color = "Green";
            Console.WriteLine($"Color of leafy green vegetable is {color}");
            return color;
        }

        // 1. method of base class that has been overriden
        public override void Sell() => Console.WriteLine("The leafy greens can be sold");

        //4. method of base class that is hidden by child class
        public new double GetFiberContent() => FiberContent;
        //public string GetAntioxidentName() => "Zeaxanthin"; //6. method that is hidden by child class

    }

    //grandchild

    //7. grand child should protect itself from getting inherited
    public sealed class Spinach : LeafyGreen
    {
        public int IodineContent { get; set; }

        // public new string GetAntioxidentName() => $"{base.GetAntioxidentName()}, Lutein"; //6. method that hides parent's method and also implements base class method

    }


    //base class
    public abstract class Flowers
    {

        // 3. method that must be overriden by child classes
        public abstract string GetScientificName();

        // 5. property that is hidden by child class
        public string FlowerParts { get; set; }

        //6. Method that is overriden and will be implemented in child class as well
        public string GetFlowerParts() => "Stem";

    }

    //child class 1
    public class Sunflower : Flowers, INectar
    {

        public bool ProduceNectar()
        {
            return true;
        }


        //3. method of base class that has been overriden
        public override string GetScientificName()
        {
            return "Helianthus";
        }




    }

    //child class 2
    public class Marigold : Flowers, IColor, INectar
    {

        //5. property of parent class that has been hidden by child class
        public new string FlowerParts { get; set; }
        public string GetColor()
        {
            string color = "Yellow";
            Console.WriteLine($"Color of Marigold is {color}");
            return color;
        }

        //3. method of base class that has been overriden
        public override string GetScientificName()
        {
            return "Tagetes";
        }

        public bool ProduceNectar()
        {
            return false;
        }

        //6. Method of base class that is overriden and implemented in child class as well

        public new string GetFlowerParts() => $"{base.GetFlowerParts()}, {FlowerParts}";
    }

    //interfaces
    interface IColor
    {
        public string GetColor();
    }

    interface INectar
    {
        public bool ProduceNectar();
    }

    public class FileInterAction
    {

        internal int ReadCharacter(string path)
        {
            int results = 0;
            var text = File.ReadAllText(path);
            foreach (char c in text)
            {
                if (!char.IsWhiteSpace(c))
                {
                    results++;
                }
            }
            return results;

        }

        internal int ReadWords(string path)
        {
            int results = 0;
            var text = File.ReadAllText(path);
            foreach (char c in text)
            {
                if (c.Equals(' ') || c.Equals('\n'))
                {
                    results++;
                }
            }
            return results;
        }

        internal int ReadSentence(string path)
        {
            int results = 0;
            var text = File.ReadAllText(path);
            foreach (char c in text)
            {
                if (c.Equals('.') || c.Equals('?'))
                {
                    results++;
                }
            }
            return results;
        }

        internal int ReadVowels(string path)
        {
            int results = 0;
            var text = File.ReadAllText(path);
            string vowels = "aeiouAEIOU";
            foreach (char c in text)
            {
                if (!char.IsWhiteSpace(c) && vowels.IndexOf(c) >= 0)
                {
                    results++;
                }
            }
            return results;
        }

        internal int ReadSpecialCharacters(string path)
        {
            int results = 0;
            var text = File.ReadAllText(path);
            // foreach(char c in text)
            // {
            // if(c !>= 'a' && c !<= 'z' && c!>=0 && c!<=9 && !char.IsWhiteSpace(c))
            // {
            //     results++;
            // }
            results = text.Count(c => !char.IsLetterOrDigit(c)) + text.Count(c => !char.IsWhiteSpace(c));
            //}
            return results;
        }
    }
}