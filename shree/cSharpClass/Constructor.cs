using System;
using System.Collections.Generic;
using System.Text;

namespace PropertiesAndEnums
{
    public class Person
    {
        
        
        private string address;
        private string cellNo;
        private DateTime dob;
        private bool hasTB;

        private static string scientificName = "Homo Sapiens";

    /*    public Person(string f, string l)
        {
            firstName = f;
            lastName = l;
        } */

        //  datatype CONST and READONLY is similar but readonly can be changed in runtime

        // it is constructor (name must be same as class name) and no return type
       // public Person()         // default constructor
        //{

        //}
        //  public Person(string name) { this.name = name; }           // class data name = string value name

       // public Person(string name) => this.name = name;     // another way of parameterized constructor

    
        /*
        public string FirstName // property name   // this is property - getter and setter i.e. get value and set value
    {
        get
        {
            return firstName;       // this backing field of property
        }
        set
        {
            firstName = value;
        }
    }
    */

        public string FirstName { get; set; }

       // public string FirstName { get; private set; }  // here no one can set property outside the class but can be set inside the class

        public string PhoneNum
        {
            get
            {
                return cellNo;
            }
            set
            {
                if (cellNo.Length == 10)
                    cellNo = value;
            }
        }

        public string LastName { get; set; }  // this is revised code format for properties for single line get and set
                                                // it is call auto implemented property


        public string Address { get; set; }

        // for auto impletemented property, no need to define class data variable
        // but need property
        public string FullName => $"{FirstName} {LastName}";

        public bool HasTB
        {
            set
            => hasTB = value;       // inline
        }
    }
}


