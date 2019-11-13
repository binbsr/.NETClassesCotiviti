using System;
namespace PropertiesAndEnums
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private string address;
        private string cellNo;
       // private bool HasBT;
        private DateTime dob;
       
        public Person(string f, string l)
        {
            firstName = f;
            lastName = l;
        } 
        /*
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
        }*/

        public string FirstName { get; set; }
        public string LastName { get; set; }
       
        //Expression booled definition
        //Read only property
        public string FullName => $"{FirstName} {LastName}";

        //write only property
        public bool HasBT
        {
           set => HasBT = value;
        }

        //readonly properties
        /*
        public string FullName
        {
            get
            {
                return $"{firstName} {lastName}";
            }
        }

        public bool HasBT
        {
            set
            {
                HasBT = value;
            }
        }   */

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