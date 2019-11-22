using System;

namespace PropertiesAndEnums
{
public class Person
{
    
    //private string lastName;
    private string address;
    private string cellNo;
    public bool hasTB;
    private DateTime dob;

    
    public Person(string f,string l)
    {
        FirstName=f;
        lastName=l;
    }

        public Person()
        {
        }

        public string FirstName {get;set;}//Property--backend name of this property is firstName
    public string lastName {get;set;}
    //  public string LastName
    // {
    //   get
    //   {
    //     return lastName;
    //   }
    //   set
    //   {
    //       lastName=value;
    //   }
    //Readonly property
//public string FullName=>  $"{FirstName} {lastName}";    
      public string FullName
    {
      get
      {
        return $"{FirstName} {lastName}";
      }
      set
      {
         FullName=value;
      }
    }
      public string Phone
      {
          get
          {
              return cellNo;
          }
          set
          {
              if (value.Length==10)
              {
                  cellNo=value;
              }
          }
      }
    //   public bool hasBT
    //   {
    //       set 
    //       {
    //           hasTB=value;
    //       }
    //   }
       public bool hasBT//Writeonly property
      {
          set => hasTB=value;
        
      }
    }

}

