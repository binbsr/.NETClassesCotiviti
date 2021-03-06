using LoopsAndConditions;
using Exercise;
using System;
using LearningMethods;
using System.Collections;
using System.Collections.Generic;
using Collections;
using PropertiesAndEnums;
using Inheritance;
using FileHandling;
using System.IO;

namespace MainProgram
{
    class EntryPoint
    {
        public static void Main()
        {
            /*  Iterations iterations = new Iterations();
              iterations.DefineLoops();
              */
            /*
             Exercise1 e1 = new Exercise1();
             e1.PrintMultipleOfFive();
             */

            /* Console.WriteLine("dsfs");
             Console.WriteLine("dsfs");
             Console.Write("dsfs");

             Console.ReadLine();
             */

            //Conditionals c = new Conditionals();
            //c.PrintHello();
            //c.CheckHello();
            //c.GetLargest();
            // c.checkVowels();
            //c.CheckEven();
            //c.SumOfSquares();

            // Iterations i = new Iterations();
            //i.LearnNestedLoops();    
            /*Methods m = new Methods();
             long s = m.AddTwoNumbers(1232132, 12321321);
             Console.WriteLine("Sum is " + s);

             long s1 = m.AddThreeNumbers(123231,21321321,21321321);
             Console.WriteLine("Sum is "+ s1);

             long s2 = m.Sum(123231,21321321,21321321);
             Console.WriteLine("Sum is "+ s2); 

             string fullName = m.GetFullName("Nitin","Malla");
             m.GetFullName(lastName:"Nitin", firstName:"Malla"); // named arguments
             Console.WriteLine("Full Name is "+ fullName);   

             (int Min,int Max) result = m.GetMinMax(new int[] {4,3,5,2,8});

             Console.WriteLine($"Minimum = {result.Min}, Maxmimum = {result.Max}");
             */

            /*    Exercise2 e = new Exercise2();
                 decimal d = e.CalcualteAverage(12.3M,12321.213M,21321.234M);
                 Console.WriteLine("average is :" +d);

                 decimal avg  = e.CalcualteAvgOfAll(new decimal[] {12.3M,12321.213M,21321.234M});
                  Console.WriteLine("average is :" +avg);

                 (int male,int female, int other) result = e.CountGender();

                 Console.WriteLine($"No.of Males = {result.male} , No. of Females = {result.female} and No. of others = {result.other}");
    */
            /*
            TestList<string> list = new TestList<string>();
            list.Add("gfdgfg");

            TestList<byte> list1 = new TestList<byte>();
            list1.Add(35);

            // non generic list
            ArrayList arrayList = new ArrayList();
            arrayList.Add("sfeew");
            arrayList.Add(23);

            SortedList sortedList = new SortedList();
            sortedList.Add(1, "sdfwewr");

            //generic 

            List<short> list2 = new List<short>();

            list2.Add(324);
            list2.Add(324);
            list2.Add(324);
            list2.Add(324);
            list2.Add(324);
            list2.Add(324);

            List<Student> students = new List<Student>();
            Student st1 = new Student()
            {
                name = "Nitin",
                rollNo = 1
            };
            Student st2 = new Student()
            {
                name = "Bishnu",
                rollNo = 2
            };
            students.Add(st1);
            students.Add(st2);
            //students.AddRange();

          /*  Dictionary<int, string> countries = new Dictionary<int, string>();
            countries.Add(1,"USA");
            countries.Add(977,"Nepal");
            countries.Add(91,"India");
            //countries.Add(1,"USA1"); // key should be always unique
*/
            /*
                  Dictionary<int, string> countries = new Dictionary<int, string>()
                  {
                  [1]="USA",
                  [977]="Nepal",
                  [91]="India"
                  };
                  Console.WriteLine(countries[977]);
                  foreach (var c in countries)
                  {
                      Console.WriteLine(c.Key + " = " + c.Value);

                  }


                  Collection coll = new Collection();
                  var animals = coll.GetAnimals();
                  foreach (string animal in animals)
                  {
                      Console.WriteLine($"{animal}") ; 
                  }

                  var songs = coll.FetchSongs();
                  foreach (var s in songs)
                  {
                      Console.WriteLine($"{s.Key} song is {s.Value} genre");
                  }

                  var songs1 = coll.FetchSongs1();
                  foreach (var s in songs1)
                  {
                      Console.WriteLine($"{s.Key} is {s.Value[0]} genre and artist name is {s.Value[1]}" );

                  }

                 List<(string SongName, string Genre, string ArtistName)> songs2 = coll.FetchSongs3();
                  foreach (var s in songs2)
                  {
                      Console.WriteLine($" song name {s.SongName} genre is {s.Genre} and artist is {s.ArtistName}" );

                  }
                  */
            /*
      Person p = new Person();
      Person p1 = new Person("Shreya");

      PropertiesAndEnums.Person per = new PropertiesAndEnums.Person("Nitin","Malla");
      var x = per.FirstName;
      Console.WriteLine(x);
     // per.FirstName = "Abc";
      x = per.FirstName;
      Console.WriteLine(x);

     //  var card = Customer.CardNo;

*/
            //Student s1 = new Student("Nitin");
            //Student s2 = new Student("Ram");

            // Student s3 = new Student();
            // Student s4 = new Student();
            //Student s5 = new Student();

            // Student.Address ="ktm";

            // s1.RollNo;

            //Student.PrintStudentDetails();
            // built in static class
            // Math.Sin(90);

            // Dog d = new Dog();
            //Puppy puppy = new Puppy();
            // Puppy p = new Puppy();

            // ISaleable p1 = new Snake();  // dependancy injection

            //var p = new Snake();
            //var s = new Puppy(); 

            // Animal a = new Snake();
            // Animal b = new Puppy();

            BaseEmployee fte = new FullTimeEmployee();
            fte.FirstName = "Nitin";
            fte.LastName = "Malla";

            System.Console.WriteLine(fte.GetFullName()); // method hiding
            System.Console.WriteLine(fte.CalculateMonthlySalary()); // method override

            Contractor contra = new Contractor();
            contra.FirstName = "Abc";
            contra.LastName = "test";

            System.Console.WriteLine(contra.GetFullName());


            MotorBike bike1 = new MotorBike();
            System.Console.WriteLine(bike1.BrakingSystem());

            ElecticBike ebike1 = new ElecticBike();
            System.Console.WriteLine(ebike1.BrakingSystem());

            Taxi t1 = new Taxi();
            System.Console.WriteLine(t1.color);
            System.Console.WriteLine(t1.NoOfSheets());
            System.Console.WriteLine(t1.FourWheelDrive());

            string folderPath = @"D:\Nitin\test";
            //string folderPath1 = @"http://textfiles.com/stories/";
            FileIO fileIO = new FileIO();
            var folder = fileIO.CreateFolder(folderPath);
            Console.WriteLine(folder.FullName);
            Console.WriteLine(folder.CreationTime);
            Console.WriteLine(folder.LastAccessTime);

            /*
             string filePath =@"D:\Nitin\test";
             string fileName ="Test1.txt";
             fileIO.CreateFile($@"{filePath}\{fileName}");
             */

            string filePath = Path.Combine(folderPath, "file1.txt");
            string filePath1 = Path.Combine(folderPath, "file2.txt");
            string filePath2 = Path.Combine(folderPath, "production_support.txt");
            string filePath3 = Path.Combine(folderPath, "blackp.txt");

            fileIO.CreateFile(filePath);

            string text = "testing ";

            fileIO.CreateFile(filePath, text);

            string[] texts = { "Hi there", "hello", "Hi" };

            fileIO.CreateFile(filePath1, texts);

            var results = fileIO.ReadFile(filePath3);
            var vowels = 0;
            var specialChars = 0;

            for (int i = 0; i < results.Length; i++)
            {
                Console.WriteLine($"{i + 1} -> {results[i]}");
                var str = results[i];
                for (int j = 0; j < results[i].Length; j++)
                {
                    if (str[j] == 'a' || str[j] == 'e' || str[j] == 'i' || str[j] == 'o' || str[j] == 'u' || str[j] == 'A' || str[j] == 'E' || str[j] == 'I' || str[j] == 'O' || str[j] == 'U')
                    {
                        vowels++;
                    }   

                    if (!((str[j]>='a' && str[j]<='z') || (str[j]>='A' && str[j]<='Z') ||(str[j]>='0' && str[j]<='9')))
                    {
                        specialChars++;
                    }

                }
            }

            System.Console.WriteLine($"No of Vowels --> {vowels} ");
              System.Console.WriteLine($"No of special Characters --> {specialChars} ");


            (int charCount, int lineCount, int wordCount) = fileIO.Count(filePath3);

            Console.WriteLine($"Character Count --> {charCount}");
            Console.WriteLine($"Line Count --> {lineCount}");
            Console.WriteLine($"Word Count --> {wordCount}");

        }
    }
}
