using System;
namespace Properties
{

    internal class Customer
    {

        public const string CardNo = "XXXXX123XXX001";
        public readonly string citizenshipId;
        //if constant, need to initalize right where it created. constant is inheritently staic
        //static is access from class level


        //runtime variables can be created on constructor
        public Customer()
        {
            citizenshipId = "212/222";

        }

        void GetSomething(string x)
        {
            if (x == WeekDay.martes.ToString())
           // if(x == (int)WeekDay.martes)
            {
                Console.WriteLine("Yes it is Tuesday i.e. Martes");
            }

        }
    }


    //Enum is use to set fix set of possible data like days in a week
    //integral type of numbers are allowed in enum
    //to remove magic values enum is used
    enum WeekDay { domingo, lunes, martes, meracules, jueves, vernes, sabado };
    


}