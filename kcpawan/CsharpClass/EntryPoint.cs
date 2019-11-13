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

--------------------------------------------------------
using Excercise;
using LoopsAndConditions;

namespace MainProgram
{
    public class EntryPoint
    {

        public static void Main()
        {
            Excercise1 ex1 = new Excercise1();
            ex1.PrintMultipleOfFive();
        }
    }
}
*/
using System;
using LearningMethods;
using LoopsAndConditions;

namespace MainProgram
{
    public class EntryPoint
    {
        public static void Main()
        {
            Methods m = new Methods(); 
            //Named arguments           
            string name = m.GetFullName(lastName: "Rawal", firstName: "Rawal");
            (int Min, int Max) result = m.GetMinMax(new int[] {4, 3, 5, 2, 6});

            Console.WriteLine($"Minimum = {result.Min} and Largest = {result.Max}");
        }
    }
}
