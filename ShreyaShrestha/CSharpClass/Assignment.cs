using System;
using System.Collections.Generic;

namespace Assignments
{
    //Base class
    public class Vegetables
    {
        public string scientificName;
    }

    //child Class
    public class LeafyGreen : Vegetables, IColor
    {
        public int fiberContent;
        public string GetColor()
        {
            string color = "Green";
            Console.WriteLine($"Color of leafy green vegetable is {color}");
            return color;
        }

    }

    //grandchild
    public class Spinach : LeafyGreen
    {
        int iodineContent;
    }


    //base class
    public class Flowers
    {
        public List<string> partsOfFlower;
    }

    //child class 
    public class Sunflower : Flowers, INectar
    {

        public bool ProduceNectar()
        {
            return true;
        }
    }

    //child class
    public class Marigold : Flowers, IColor, INectar
    {
        public string GetColor()
        {
            string color = "Yellow";
            Console.WriteLine($"Color of Marigold is {color}");
            return color;
        }

        public bool ProduceNectar()
        {
            return false;
        }
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

}