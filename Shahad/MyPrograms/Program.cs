using System;
using Students;
using DisplayMenu;

namespace MyPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeScreen screen = new HomeScreen();
            AddStudent st1 = new AddStudent();

            int userchoice = screen.DisplayMenu();

            switch (userchoice)
            {
                case 1:
                    Console.WriteLine("\nEnter the student name to add");
                    string name = Console.ReadLine();
                    st1.addStudentInfo(name);
                    screen.DisplayMenu();
                    break;
                case 2:

                    st1.getStudentInfo(); ;
                    screen.DisplayMenu();
                    break;


                default:

                    break;
            }
        }

    }
}

