namespace PropertiesAndEnums
{
    internal class Customer
    {
        public const string CardNo = "XXXX353ERGTXX89";
        public readonly string CitizenshipId;

        public Customer()
        {
            CitizenshipId = "2019/232";
        }

        void GetSomething(int x)
        {
            if (x == (int)WeekDay.TuesDay)
            {

            }
        }
    }

    enum WeekDay { SunDay, monDay, TuesDay, WednesDay, ThrusDay, FriDay, SaturDay }

    enum MachineState
    {
        PowerOff = 0,
        Running = 5,
        Sleeping = 10,
        Hibernating = Sleeping + 5
    }
}