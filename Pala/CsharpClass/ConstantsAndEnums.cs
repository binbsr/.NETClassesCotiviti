namespace PropertiesAndEnums
{
    internal class Customer
    {
        public const string  CardNo = "84375kdfh";
        public  readonly string  CitizenshipId = "2011/34/56/";
        void GetSomething(string x)
        {
            if (x==WeekDay.TuesDay.ToString())
            {

            }
        }
        public Customer()
        {
            CitizenshipId = "2019/232";
        }




    }
    enum WeekDay{SunDay, MonDay, TuesDay, WedDay, ThursDay, friDay,SaturDay}
    enum MachineState
    {
        PowerOff = 0,
        Running = 5,
        sleeping =10,
        Hibernating = sleeping + 5 
    }
}