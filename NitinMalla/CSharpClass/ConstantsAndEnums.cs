namespace PropertiesAndEnums
{
    internal class Customer
    {
        public const string CardNo = "XXXX98989JUKIKIKK";

        public readonly string CitizenshipId;

        public Customer()
        {
            CitizenshipId = "2013/21";
        }

        void GetSomeThing(int  x)
        {
            if (x == (int)WeekDay.Tuesday)
            {

            }
        }
    }

    enum WeekDay { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }

    enum MachineState
    {
        PowerOff = 0,
        Running = 5,
        Sleeping  =20,
        Hibernating = Sleeping+5
    }

}