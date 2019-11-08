using Iterate;
using LoopsAndConditions;
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

  Conditionals c1 = new Conditionals();
  c1.PrintHello();
  c1.CheckString();
  c1.GetLargest();
  c1.Checkvowels();
  c1.nSumOfSquares();
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