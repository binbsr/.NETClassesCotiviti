/*
class E 
{
    public void Main()
    {
        Person p  = new Person();
        p.walk
    }
}

Public class person
{
    // This is Data
    string firstname;
    string lastName;
    int age;
    string address;

    Internal void Walk()
    {

    }

    Internal void Read()
    {

    }



}
*/
using System;
using System.Collections.Generic;
using Excercise;
using LearningMethods;
using LoopsAndConditions;
using PropertiesAndEnums;

namespace MainProgram
{
    public class EntryPoint
    {

        public static void Main()
        {
            //Excercise1 ex1 = new Excercise1();
            //ex1.PrintMultipleOfFive();
            
            
            //Iterations ex1 = new Iterations();
            //ex1.LearnNestedLoops();

           // Methods m = new Methods();
            //long s = m.AddTwoNumbers(5,10);
            //Console.WriteLine("Sum is " + s);
          /*  
            Methods m = new Methods();
            long s = m.Sum(5,10);
            long s1 =m.Sum(5,5,10);
            Console.WriteLine("Sum is :"+s1);
            Console.WriteLine("Sum is :"+s);

            Methods fn = new Methods();
            string j = fn.GetFullName("Pawan","KC");
            Console.WriteLine("Hello "+j);
        

            //Methods fn = new Methods();
            //Named Argument
            string n = fn.GetFullName(lastName:"Pawan",firstName:"KC");
            Console.WriteLine("Good Morning Mr."+n);

            
            (int Min, int Max) result = fn.GetMinMax(new int[]{10,50,2,54,8,91,23,99});
            int min = result.Min;
            int max = result.Max;
            Console.WriteLine("The Smallest is :"+ min);
            Console.WriteLine("The Largest is :"+max);
            */

           /* Collection1 c = new Collection1();
            List<(string SongName, string Genre, string Artist)> songs = c.FetchsongsList();
            
            foreach(var song in songs)
                {
                    Console.WriteLine($"Song Name={song.SongName} Genre ={song.Genre} Artist = {song.Artist}");
                }
            */

            PropertiesAndEnums.Person p = new PropertiesAndEnums.Person("Pawan","KC", "98419418850");
            var x = p.FirstName;
            var y = p.LastName;
            var z = p.Phone;
            Console.WriteLine(y+", "+x);      
            Console.WriteLine("Cell No: "+z); 


            Console.WriteLine("****************************************************");
            
            p.FirstNameAI = "Pawan";                
            Console.WriteLine(p.FirstNameAI);


            Console.WriteLine("****************************************************");

            var a = Customer.CardNo;
            Customer c = new Customer();
            var b = c.CitizenshipID;

        }
    }
}