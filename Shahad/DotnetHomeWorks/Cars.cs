using System;

namespace Vehicals
{

    //7. An enumeraiton list within that namespace that this class genuinely need
    enum VEHICAL
    {
        White = 1,
        Maroon = 2,
        Blue = 3
    }


    public class Cars
    {
        private string auto;
        public string vehicalType;
        public string modelName;
        public string modelColor;
        public readonly string engine = "V-6";
        public Cars()
        {
            vehicalType = "SUV";

            //A constant that can be changed at compile time          
            engine = "V-8";

        }

        public Cars(string name, string color)
        {
            modelName = name;
            modelColor = color;

        }

        public string CarName
        {
            get
            {
                return modelName;
            }

            set
            {
                modelName = value;
            }

        }

        public string CarColor
        {
            get
            {
                return modelColor;
            }
            set
            {
                modelColor = value;
            }


        }
        public string Automatic
        {
            get
            {
                return auto;
            }
            set
            {
                {
                    auto = value;
                }

            }


        }


        public string Engine
        {
            get
            {
                return engine;
            }


        }

        public void PrintCarInfo()
        {
            Console.WriteLine("Model Name: " + modelName + "|  Model COlor: " + modelColor + "|  Automatic:" + auto);

        }


        public void PrintHighestSellingCarColors()
        {
            Console.WriteLine(VEHICAL.White + " color SUVs are in " + (int)VEHICAL.White + "st Position");
        }


    }

}
