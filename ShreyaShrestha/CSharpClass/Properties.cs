using System;

namespace PropertiesAndEnum
{
    public class Person
    {
        private string lastName; // after implementing auto-implemented, these varaibles are not needed

        private string firstName;
        private string address;

        private string phoneNumber;
        private DateTime dob;

        private string disease;

        //Parameterized constructor to set the fname and lname while instantiating the object
        public Person(string fName, string lName)
        {
            firstName = fName; //FirstName = fName;
            lastName = lName; // LastName = lName
        }
        //Properties: accessor and setter
        public string FirstName { get { return firstName; } set { firstName = value; } } //get the firstname of class Person and assign the value to firstName if value has been set to it.

        //after implementing auto- implemented
        /*public string FirstName 
        {
            get; set;
        }

        public string LastName 
        {
            get; set;
        }
        */
        public string LastName { get { return lastName; } set { lastName = value; } } //all properties have private backing field


        //Validation can also be included
        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                if (value.Length == 10)
                phoneNumber = value;
            }
        }

        //ReadOnly Properties
        // public string FullName
        // {
        //     get => $"{firstName} {lastName}";            }            
        // }

        public string FullName=> ($"{firstName} {lastName}");                    
        
        public string HasTB
        {
            set => disease = value;            
        }

        //Auto-implemented

        public string autoImplemented {get; set;}
    }
}