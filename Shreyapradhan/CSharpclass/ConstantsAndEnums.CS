namespace PropertiesAndEnums
{

   internal  class Customer
    {
      
      public const string CardNO="XXXX454667";
      public  readonly string CitizenshipNo;

      /* difference between const and readonly is const is static  inherently while readonly is not.. and const can not
      be updated ever while readonly can be updated in runtime... i.e. only in constuctor */

       public Customer() //constructor  executes only in run time
                 {
                     CitizenshipNo="123";
                 }

        void GetSomething(string x)
        {    
            if(x==WeekDay.Tuesday.ToString())
            {

            }

        }
        void GetSomething(int x)
        {    
            if(x==(int)WeekDay.Tuesday)
            {

            }

        }

    }

    
        /* 
           enums are used when you have fixed set of values. usully define in class level.. i.e. inside a namespace
           enum is integral type{int, byte , long , short}

           implements single value of truth
         */

         enum WeekDay: long{ Sunday, Monday , Tuesday, wednesday, Thursday, Friday, Saturday };

         enum MachineState{

             PowerOff=0,
             Running =5,
             Sleeping =10,
             Hibernating=Sleeping+5
         
         }

}