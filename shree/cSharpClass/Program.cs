using System;
using LoopsCondition;
using Exercise1;
using LearningMethods;
using Exercise3;
using System.Collections;
using System.Collections.Generic;
using LearnGeneric;
using Exercise4Collection;
using SongDetailInformation;
using PropertiesAndEnums;
using LearningInheritance;

namespace cSharpClass
{
    class Program
    {
        /*   public static void Main()
           {
               Iteration iternation1 = new Iteration();
               iternation1.DefineLoops();
           }

               public static void Main()
           {
               Multiple mul = new Multiple();
               mul.PrintMultiple();

           } */

        /*public static void Main()
        {
            Conditional c1 = new Conditional();
             c1.CheckIfUserSaysHello();
             c1.GetLargest();
             c1.UseTernary();
             c1.CheckVowel();
            c1.CheckEvenOdd();
            c1.SumOfSquareOfNumber();

            Methods m1 = new Methods();

             long a, b;
             a = Convert.ToInt64(Console.ReadLine());
             b= Convert.ToInt64(Console.ReadLine());

             long sum = m1.SumOfTwoNumber(a, b);
             Console.WriteLine("Sum of two numbers = " + sum);

            Console.WriteLine("Sum of two numbers = " +m1.Sum(1, 2, 3));
            Console.WriteLine("Sum of two numbers = " +m1.Sum(9, 8));

            m1.GetFullName(lName: "Gurung", fname: "Shree");        // IT IS CALLED NAMED ARGUMENT - this is used to remove argument passing order confusion
            
            (int Min, int Max) result =  m1.GetMinMax(new int[] { 4, 5, 3, 1, 7, 8, 19, 10 });  // this is same as array define and intialize
            Console.WriteLine($"Minimum number = { result.Min} and Maximum number = { result.Max}");  // return minimum value
           }*/


        // calculation of average of three number using normal method
        /* public static void Main()
         {
             decimal a, b, c, avg;
             AverageOfThreeNumber avg1 = new AverageOfThreeNumber();
             Console.WriteLine("Please enter any three number to calculate the average : ");
             a = Convert.ToDecimal(Console.ReadLine());
             b = Convert.ToDecimal(Console.ReadLine());
             c = Convert.ToDecimal(Console.ReadLine());
             avg=avg1.GetAvgOfThreeNum(a,b,c);
             Console.WriteLine($"Average of three number = {avg}");
         } 

        // calculation of average of three number using VARIABLE ARGUMENT method
         public static void Main()
         {
            AverageOfThreeNumber avg1 = new AverageOfThreeNumber();
            Console.WriteLine($"Average of 2 numbers = {avg1.GetAverageOfThreeNum1(2, 3)}");
            Console.WriteLine($"Average of 3 numbers = {avg1.GetAverageOfThreeNum1(10, 20, 30)}");
            Console.WriteLine($"Average of 4 numbers = {avg1.GetAverageOfThreeNum1(10, 20, 30, 40)}");
            Console.WriteLine($"Average of 5 numbers = {avg1.GetAverageOfThreeNum1(1,2,3,4,5)}");
         }      */

        /*  public static void Main()
          {
              Gender g = new Gender();
              (int maleCount, int femaleCount, int otherCount)result = g.GenderCollectionCount(new char?[] { 'F', 'M', 'F', 'M', null, 'M', null, 'F', 'F', 'M', null, null, 'F', 'M', 'M' });
              Console.WriteLine($"Male Count = {result.maleCount} and Female Count = { result.femaleCount} and Other Count = { result.otherCount}");
          }       */

        /*     public static void Main()
         {
             TestList<string> list = new TestList<string>();     //string type list
             list.Add("abc");

             TestList<byte> list1 = new TestList<byte>();        // byte type list
             list1.Add(12);


             // this is arraylist- non generic list 

             ArrayList arraylist = new ArrayList();
             arraylist.Add("abc");
             arraylist.Add(123);


             List<short> lst = new List<short>();       // List <> is in-build GENERIC LIST
             lst.Add(12);
             lst.Add(23);
             lst.Add(45);
             lst.Add(56);
             lst.Add(17);
             lst.Add(23);

             List<Student> students = new List<Student>();           // "students" is list of user defined class STUDENTS
             Student std1 = new Student                      // this is inline class intialization
             {
                 name = "Shree",
                 rollNo = 12,
                 address = "balaju",
                 stream = "Computer",
             };                      
             Student std2 = new Student()            // inline class intialize using ( ) symbol -- ( ) can be or can not be use - both acceptable
             {
                 name = "Krishna"
             };
             students.Add(std1);
             students.Add(std2);

             Dictionary<int, string> countries = new Dictionary<int, string>();  // dictionary is built in generic list that hold two datatypes - KEY & its VALUE
             countries.Add(01, "USA");                                           // KEY must be unique always
             countries.Add(977, "Nepal");
             countries.Add(047, "Norway");
             countries.Add(91, "India");

             foreach(var item in countries)
             {
                 Console.WriteLine(item.Key +"="+item.Value);
             }

             Dictionary<int, string> countries1 = new Dictionary<int, string>()          // this is dicitionary intialization
             {
                 [1] = "USA",
                 [977]="Nepal",
                 [047]="Norway",
                 [91]="India"
             };

         }       */

        //*GetAnimals()* which returns list of animal names.
        /*  public static void Main()
          {
              Collection c1 = new Collection();
              List<string> animalName = new List<string>();
              animalName = c1.ReturnAnimalName();
              foreach (var item in animalName)
              {
                  Console.WriteLine(item);
              }
          }
          */

        /*  public static void Main()
          {
              Collection c1 = new Collection();
              List<SongDetails> songDetail = new List<SongDetails>();
              songDetail = c1.ReturnSongNameGenre();
              foreach (var item in songDetail)
              {
                  if (item.artistName != "")
                      Console.WriteLine($"Song name = {item.songName} and Genre = {item.songGenre} and Artist name = {item.artistName}");
                  else
                      Console.WriteLine($"Song name = {item.songName} and Genre = {item.songGenre}");
              }
          }       */

        // *FetchSongs()*` which returns list of songs (song name and genre).   USING Dictionary Method
        /*
        public static void Main()
        {
            Collection c1 = new Collection();
            var song = c1.FetchSongs();
            foreach (var item in song)
            {
                Console.WriteLine($"song = {item.Key} and Genre = {item.Value}");
            }
        }       */
/*
        public static void Main()
        {
            Collection c1 = new Collection();
            var song = c1.FetchSongs1();
            foreach (var item in song)
            {
                Console.WriteLine($"song = {item.Key} and Genre = {item.Value[0]} and Artist = {item.Value[1]}");
            }
        }
                
        public static void Main()
        {
            Collection c1 = new Collection();
            List<(string songName, string Genre, string Artist)> var songs = c1.Fetchsongs2();
            foreach (var item in songs)
            {
                Console.WriteLine($"song = {item.songName} and Genre = {item.Genre} and Artist = {item.Artist}");
            }
        }       

       public static void Main()
        {
            /* PropertiesAndEnums.Person p = new PropertiesAndEnums.Person("ram", "shyam");
             var x = p.FirstName;
             Console.WriteLine(x);  

            //var x=Customer.CardNo;            // for Constant variable no need to create class object

            //Student.address;            // here address is static variable which is shared by all class object
            // to access STATIC variable, use classname.static_variable name

          //  var x=Student.PrintStudentDetails();
            
            
        } */

        public static void Main()
    {
            //Dog d = new Dog();            // FIRST BASE CLASS CONSTRUCTOR CALLS then only Child class constructor 
            Puppy p = new Puppy();

            Isaleable p1 = new Puppy();      // this is dependancy injection, it is also valid 
            Isaleable p2 = new Snake();
            Animal p3 = new Snake();
            
    }



    }
}