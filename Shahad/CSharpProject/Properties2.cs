using System;

namespace PropertiesAndEnums2
{
    public class Person
    {
        public Person(string f, string l)
        {
            FirstName = f;
            LastName = l;
        }

        private string address;
        private DateTime dob;
        private string cellNo;
        private bool hasTB;
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName => $"{FirstName} {LastName}";


        public bool HasTB
        {
            set => HasTB = value;
            
        }
        // public string CellNo
        // {
        //     get
        //     {
        //         return cellNo;
        //     }

        //     set
        //     {
               
        //     }

        //}

    }
}

