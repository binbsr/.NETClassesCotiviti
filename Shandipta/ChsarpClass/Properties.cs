using System;
namespace Properties
{
    //to use same classname assign different namespace
    public class Person
    {

     //   private string firstName;

        private string lastName;
        private string address;
        private DateTime dbo;
        private string cellNo;
        private bool hasTB;
        //properties has accessor and setter
        //properties cannot be private
        //properties are pascalcase
        //get set and value are the keys of properties
        //access modifier can be assign to get set 

        public Person(string f, string l)
        {
           // firstName = f;
            lastName = l;   
            FirstName02 = f;

        }

        public string FirstName011
        {
            get
            {
              //  return firstName;
                return FirstName02;
            }

            set
            {
              //  firstName = value;
                FirstName02 = value;
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
//readonly properties when no set methods
//expression bodied defination
    /*    public string FullName
        {
            get
            {
                return $"{firstName} {lastName}";
            }
        }*/

              //  public string FullName => $"{firstName} {lastName}";
               public string FullName => $"{FirstName02} {lastName}";


//writeonly property
        public bool HasTB{
      /*      set{
                hasTB=value;
            }*/
            set => hasTB= value;
        }
        public string Phone
        {
            get { return cellNo; }
            set
            {
                if (value.Length == 10)
                {
                    cellNo = value;
                }
            }
        }

        public string FirstName03 {get; private set;} //set cannot be use outside of the class

//auto implemented property
public string FirstName02{get; set;}

    }




}