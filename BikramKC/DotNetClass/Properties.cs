using System;
namespace Properties
{
    public class Person
    {
        private int phNo;
        private string fName;
        private string lName;
        private DateTime dob;
        private bool hasBT;
        public string FirstName
        {
            get
            {
                return fName;

            }
            set
            {
                fName = value;
            }
        }
        // Read Only properties
        public string FullName
        {
            get
            {
                return $"{fName} {lName}";
            }
        }
        /*
        public bool HasBT
        {
            set 
            {
                hasBT = value;
            }
        }
        */
        public Person(string f, string l)
        {
            fName = f;
            lName = l;
        }
        public string Address {get;  set;}

    }
}