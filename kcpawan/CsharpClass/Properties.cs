using System;

namespace PropertiesAndEnums
{
    public class Person
    {
        public Person (string f, string l, string c)
        {
            firstName = f;
            lastName = l;
            cellNo = c;
        }
        private string firstName;
        private string lastName;

        private string Address;

        private string cellNo;

        private DateTime DOB;

        private bool hasTB;

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string Phone
        {
            get {return cellNo;}
            set 
            {
                if(value.Length == 10)
                cellNo = value;
            }
        }

        public string FullName
        {
            get
            {
                return $"{firstName}{lastName}";
            }
        }

        public bool HasTB
        {
            set
            {
                hasTB = value;
            }
        }

        // Auto Implemented Properties
        public string FirstNameAI{get; set;}
        public string LastNameAI{get; set;}

        public string FullNameAI => $"{FirstNameAI}{LastNameAI}";
    }

    internal class Customer
    {
        public const string CardNo = "XXXXX12345XXXXX";

        public readonly string CitizenshipID;

        public Customer()
        {
            CitizenshipID = "19831125XXXX12345";
        }

        void GetSomething(int x)
        {
            if(x == (int)WeekDay.Tuesday)
            {

            }
        }
    }

    enum WeekDay : long{ Sunday, Monday, Tuesday, Wednesday, Thrusday, Friday, Saturday}

}