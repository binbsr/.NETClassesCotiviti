using System;
namespace DisplayMenu
{

    public class HomeScreen
    {
        int choice = 0;
        public int DisplayMenu()
        {
            Console.WriteLine("Enter Action");
            Console.WriteLine("1:Add");
            Console.WriteLine("2: Display");
            Console.WriteLine("3:Exit");
            choice = Convert.ToInt32(Console.ReadLine());
            return (choice);
        }

    }
}