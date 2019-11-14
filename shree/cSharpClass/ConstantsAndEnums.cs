using System;
using System.Collections.Generic;
using System.Text;

namespace PropertiesAndEnums
{
    internal class Customer
    {
        public const string CardNo = "ABC123";
        public readonly string CitizenshipNum;      // another way to define constant variable using keyword READ ONLY

        public Customer (string ci)
        {
            CitizenshipNum = "123456";
        }

        void GetSomething(int x)
        {
            if(x==(int)WeekDay.Thursday)
            {

            }

        }
    }
    enum WeekDay { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }

}
