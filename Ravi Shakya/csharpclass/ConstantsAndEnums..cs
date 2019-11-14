namespace PropertiesAndEnums
{
    internal class Customer
    {
        public const string CardNo = "XXD87XX";
        // public static readonly string CitizenshipId = "5121";
        public readonly string CitizenshipId;
        public Customer(string ci)
        {
            CitizenshipId = "5121";
        }
        void GetSomething(string x)
        {
            if(x==WeekDay.TuesDay.ToString())
            {
                
            }
        }
    }
            enum WeekDay {SunDay, MonDay, TuesDay, WednesDay, ThursDay, FriDay, SaturDay}



    }
    

