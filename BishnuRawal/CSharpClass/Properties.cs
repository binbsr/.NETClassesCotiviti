using System;

namespace PropertiesAndEnums
{
    public class Person
    {
        private string address;
        private string cellNo;
        private bool hasTB;
        private DateTime dob;

        public Person(string f, string l)
        {
            FirstName = f;
            LastName = l;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Expression bodied definition
        //Read-only property
        public string FullName => $"{FirstName} {LastName}";

        //Write only property
        public bool HasBT
        {
            set => hasTB = value;
        }

        public string Phone
        {
            get { return cellNo; }
            set
            {
                if (value.Length == 10)
                    cellNo = value;
            }
        }
    }
}