namespace PropertiesAndEnums
{
    internal class Customer
    {
        public const string CardNo = "xxxxTYUI345";
        public readonly string CitizenshipId = "2011/12/12/45";

        public Customer()
        {
            CitizenshipId = "123";
        }

        void GetSomeThing(string x)
        {
            if (x == WeekDay.Tuesday.ToString())
            {

            }
        }

        void GetSomeThing(int x)
        {
            if (x ==(int)WeekDay.Tuesday)
            {

            }
        }


    }

    enum WeekDay { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }
    
    enum MachineState
    {
        PowerOff = 10
    }



}