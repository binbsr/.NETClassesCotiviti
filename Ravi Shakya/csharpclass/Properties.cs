using System;
namespace PropertiesAndEnums
{

    public class Person
    {
        private string firstName;
        private string lastName;
        private string address;
        private bool hasTB;
        private string cellNo;
        private DateTime dob;

        public Person(string f, string l)
        {
            firstName = f;
            lastName = l;
        }
        //autom implemented properties
        public string FirstName {get; set;}
        public string LastName {get; set;}

        //Expression bodied definition
        //Read only property {Read only property has only get}
        public string FullName => $"{FirstName} {LastName}";

        // // public string LastName
        // {
        //     get { return lastName; }
        //     set
        //     {
        //         lastName = value;
        //     }
        // }
        // public string FirstName
        // {
        //     get { return firstName; }
        //     set
        //     {
        //         firstName = value;
        //     }
        // }
        
        public bool HasTB //write only property {write only property has only set}
        {
            set=> hasTB = value;
        }
        public string PhoneNo
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
