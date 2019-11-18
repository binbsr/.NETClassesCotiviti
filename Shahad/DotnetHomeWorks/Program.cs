using System;
using GetMethods;
using Collection;
using System.Collections.Generic;
using Vehicals;
namespace DotnetHomeWorks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("________________________________CAR1________________________________________");            // AverageOfNumbers obj1 = new AverageOfNumbers();
            // AverageOfNumbers obj2 = new AverageOfNumbers();

            // double showAverageOf3 = obj1.GetAverageOf3(12.5, 12.5, 12.5);
            // Console.WriteLine("The average of 3 numbers is :" + showAverageOf3);

            // double showAverageOfN = obj1.GetAverageOfN(new double[] { 12.5, 12.5, 12.5, 12.5, 15.5 });
            // Console.WriteLine("The average is all the numbers is :" + showAverageOfN);

            // GenderCount obj3 = new GenderCount();
            // (int mcount, int fcount, int ocount) result = obj3.DisplayCount();
            // Console.WriteLine("Male:: " + result.mcount + " Female:: " + result.fcount + " Others:: " + result.ocount);


            // Collections c =new Collections();
            // List<(string Songs, string Genre, string Artist)> songs =c.FetchSongsList();

            // foreach(var displaysongs in songs)
            // {
            //         Console.WriteLine ($"Song Name = {displaysongs.Songs} Genre = {displaysongs.Genre} Artist ={displaysongs.Artist}");
            // }
            //***************************************************************************************************************//

            //1.Default and parameterized constructor
            Cars car1 = new Cars();
            Cars car2 = new Cars("TATA Nexon", "Blue");

            //2.Two auto-implemented properties
            //SET FOR DEFAULT CONSTRUCTOR
            car1.CarName = "Mahindra SUV";
            car1.CarColor = "Maroon";
            car1.Automatic = "Yes";
            var engine = car1.engine;
            var car1name = car1.CarName;
            car1.PrintCarInfo();
            //5.A constant that runtime instances can modify
            Console.WriteLine(car1name + " has " + engine + " Engine");

            Console.WriteLine();

            //GET FROM THE PARAMETERIZED CONSTRUCTOR
            var car2name = car2.CarName;
            var car2color = car2.CarColor;
            Console.WriteLine("Model Name: " + car2name + "| Model COlor: " + car2color);

            Console.WriteLine("________________________________TOPCAR______________________________________");

            Cars allCars = new Cars();
            allCars.PrintHighestSellingCarColors();

            Console.WriteLine();

        }
    }
}
