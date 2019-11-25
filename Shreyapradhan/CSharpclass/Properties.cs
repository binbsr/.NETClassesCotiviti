
using System;
namespace PropertiesAndEnums
{
    public class Person
    {
    private  string firstName;

    
    private  string lastName;
    private string cellNo;
    private bool hasTB;
     private DateTime dob;


     public Person(string f,string l,string a)
     {
         firstName=f;
         lastName=l;
         Address=a;
     }
     public string Address {get; private set;}

     public string FullName   //readonly 
    {
        get
         {
          return $"{firstName} {lastName}";
         }

    }

    /*
      expression Bodied defination

       public string FullName => $"{firstName} {lastName}"; //readonly 
        

     */
    
    

      
    public string FirstName
    {
        get
        {
            return firstName;
        }

        set
        {
                firstName=value;
        }
    }

    public string LastName
    {
        get
        {
            return lastName; // lastname is the  backing field
        }

        set
        {
                lastName=value;
        }
    }

    

    public bool HasBT // writeonly property
    {
        set
         {
            hasTB=value;
         }

    }
    /*
    public bool HasBT 
    {
        set=>hasTB=value;

    }
     */
     
     

     public string Phone
    {
        get
        {
            return cellNo; // lastname is the  backing field
        }

        set
        {
                if(value.Length==10)
                  cellNo=value;
        }
    }
     

    }
}

/*
     properties

     accessor and setter

     variable --> camel case
     properties,classname , method name --> pascal case
     

 */
    
