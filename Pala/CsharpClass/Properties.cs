using System;
namespace PropertiesAndEnums
{
    public class Person
    {


        //(get;set;) auto implemented properties
        private string firstName;
        private string lastName;
        private string address;
        private string cellNo;
        private DateTime dob;

        /*public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                FirstName = value;
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
                LastName = value;
            }
        }
        public string Phone
        {
            get { return cellNo; }
            {
                if (value.Length == 10)
                    cellNo = value;
            }
        }
        public Person(string f, string l)
        {
            firstName = f;
            lastName = l;
        }
        public bool HasBT
        {
            set hasBT=Value;
        }
        //Expression Bodied Defination

        public string FullName => $"{FirstName} {LastName}";*/

    }

}