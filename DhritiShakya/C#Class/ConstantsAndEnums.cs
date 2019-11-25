namespace PropertiesAndEnums 
{
    internal class Customer
    {
        public const string cardNo="XX786786767";
        public readonly string CitizenshipId;//static will get access from class only no need to create instance
    

    public Customer()
    {
       CitizenshipId="67-87-8655-876";
    }
    

    void GetSomething(int x)
    {
        if (x ==(int)Weekdays.Tuesday)
        {

        }
    }
    }

    enum Weekdays{Sunday,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday}

   
}