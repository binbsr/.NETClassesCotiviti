using System;

namespace PropertiesAndEnum
{
    internal class Customer
    {
        public const string cardNumber = "XXX3456"; // inherently static cons fields are

        public /*static*/ readonly string citizenshipNumber; //= "099878678";

        //public readonly citizenshipNumber = "" this can only be accessed outside the class by creating its instance

        //since readonly variable are only assigned in runtime so passing it in constructor
        public Customer(string cN) //constructor through object banne ho at the runtime and object create garnu vaneko constructor call garne ho
        {
            citizenshipNumber = cN;
        }

        public void GetSomething(int x)
        {
            if(x == (int) WeekDays.Tuesday) //if(x== "Tuesday")- magic strings //type casting from enum to int
            {
                Console.WriteLine("");
            }
        }
        // enum WeekDays
        // {
        //     Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
        // }
    }

    enum WeekDays // enum Weekdays : long integral types are: byte short int long, by default it is int
        {
            Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
        }

    enum MachineState
    {
        PowerOff = 0,
        Running = 5
    }
} 