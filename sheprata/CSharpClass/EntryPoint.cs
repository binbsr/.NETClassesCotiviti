using Iterate;
using LoopsAndConditions;
using LearningMethods;
using System;
namespace main
{

public class EntryPoint {
    public static void Main()
    {
  Person p = new Person();
      p.Read();
      p.Walk();
Iterations iterations = new Iterations();
  iterations.DefineLoops();
  iterations.LearnNestedLoops();

  Conditionals c1 = new Conditionals();
  c1.PrintHello();
  c1.CheckString();
  c1.GetLargest();
  c1.Checkvowels();
  c1.nSumOfSquares();

  Methods m = new Methods();
  long s = m.AddTwoNumbers(23424234,23424234); //parameters
  Console.WriteLine("Sum is " + s);
  long s1 = m.Sum(23456,2345,4556);
  long s2 = m.Sum(456,34543,345345,34534);
  Console.WriteLine(m.GetFullName("sheprata","shrestha"));
  Console.WriteLine(m.GetFullName("sheprata","shrestha","optional"));
  Console.WriteLine(m.GetFullName(lastName : "shrestha",firstName : "shrestha",middleName :"optional")); //named argument
  //int min = m.GetMinMax(new int[] {4,3,5,2,6});
  (int Min, int Max) result = m.GetMinMax(new int[] {4,3,5,6,5});
  Console.WriteLine($"Min Tuple(multiple return) = {result.Min} and Min Tuple(multiple return) = {result.Max}");
     }

}

class Person
{
//Data
string firstname;
string lastName;
int age;
string address;

 internal void Read(){
 }

 internal void Walk(){
 }
}

}