using System;

namespace PropertiesAndEnums
{


    public class Person
    {
        //private string firstName;
        //private string lastName;
        private string address;
        public string cellno;
        bool hasTB;
        private DateTime dob;


        /*
        public Person(string f, string l)
        {
            firstName = f;
            lastName = l;
        }
        */
        /* public string FirstName
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
        public string FirstName{get; private set;} // can get but cannot set publically but can do inside the class

        /*public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }*/

        public string LastName{get; set;}

        
        //read only property
        public string FullName => $"{FirstName} {LastName}";

        /*public string FullName  // read only properties only get 
        {
            get
            {
                return $"{firstName} {lastName}";
            }
            
        }
        */

        // write only property
        public bool HasBT 
        {
            set { hasTB = value;}
        }
        public string Phone
        {
            get { return cellno; }
            set
            {
                if(value.Length == 10)
                    cellno = value;
            }
        }

        






    }
}