using System;

namespace PropertiesAndEnums
{
    public class Person
    {
        public Person(string f, string l)
        {
            firstName = f;
            lastName = l;
        }
        private string firstName;
        private string lastName;
        private string address;
        private DateTime dob;
        private string cellNo;
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


        public string FullName
        {
            get
            {
                return $"{firstName} {lastName}";
            }
          
        }

        public bool HasTB
        {
            set
            {
                HasTB=value;
            }
        }
        public string CellNo
        {
            get
            {
                return cellNo;
            }


        }

    }
}

