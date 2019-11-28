// using LearningMethods;
// using LoopsAndConditions;
// using System;
// using UsingMethods;
// using System.Collections.Generic;
// using System.Collections;
// using PropertiesAndEnums;
// using Inheritance;
// using System.IO;
// using FileHandling;
// // using Practice;

// namespace MainProgram
// {
//     public class EntryPoint
//     {
//         public static void Main()
//         {
//             //Iterations iterations = new Iterations();
//             //iterations.DefineLoops();
//             // Exercise1 exercise =new Exercise1();
//             //exercise.ByteArrays();
//             // Conditionals c = new Conditionals ();
//             //c.CheckInput();
//             //c.GetLargest();
//             //c.CheckIfVowel();
//             //Assignments a = new Assignments ();
//             //a.CheckEvenOrOdd();
//             // a.SumOfSquares();
//             //iterations.LearnNestedLoops();
//             Methods m = new Methods();
//             // long s = m.AddTwoNumbers(2343234, 23425235);
//             //long s = m.Sum(2343234, 23425235);
//             // long s1 = m.Sum(2343234, 23425235, 322);
//             //Console.Writeline("Sum is " +s);
//             //string name = m.GetFullName (lastName:"Shakya",firstName:"Ravi"); //named arguments
//             //Console.WriteLine("Your Full Name is: " + name); 
//             //(int min, int max) result = m.GetMinMax(new int[] {4, 3, 5, 6, 7, 8, 10});
//             //Console.WriteLine("Min is : " + result.min);
//             //Console.WriteLine("Max is : " + result.max);
//             //Assignment2 x = new Assignment2();
//             //float output= x.CalcAverage(3.3F, 2.1F, 6.9F);
//             //Console.WriteLine("Avg of 3 Decimal number is " + output);
//             //decimal output = x.CalcAllAverage (new decimal[] {231.151,3.2,4.5,6.5,1.102});
//             //Console.WriteLine ("Average of All Decimal Number is : " + output);
//             // char?[] genders = (new char?[] { 'F', 'M', 'F', 'M', null, 'M', null, 'F', 'F', 'M', null, null, 'F', 'M', 'M' });
//             // (int male, int female, int others) output = x.CountGender(genders);
//             // Console.WriteLine($"Total no of Males = {output.male}, Total no of Females = {output.female}, Total no of Other Gener = {output.others}");

//             // //Generic: used when collections have multiple datatypes
//             // Testlist<string> list = new Testlist<string>();
//             // list.Add("sdfsd");

//             // Testlist<byte> list1 = new Testlist<byte>();
//             // list1.Add(34);

//             // //non-Generic:
//             // ArrayList arrayList = new ArrayList();
//             // arrayList.Add("sdfsfs");
//             // arrayList.Add("2343");

//             // List<short> list2 = new List<short>();
//             // list2.Add(324);
//             // list2.Add(324);
//             // list2.Add(324);
//             // list2.Add(324);
//             // list2.Add(324);
//             // list2.Add(324);
//             // list2.Add(324);

//             // List<Student> students = new List<Student>();
//             // Student st1 = new Student()
//             // {
//             //     name = "Ravi",
//             // };

//             // Student st2 = new Student()
//             // {
//             //     name = "Bikram",
//             // };
//             // students.Add(st1);
//             // students.Add(st2);

//             // // Dictionary <int, string> countries = new Dictionary<int, string>();
//             // //countries.Add(1, "USA");
//             // //countries.Add(977, "Nepal");
//             // //countries.Add(91, "India");
//             // //Console.WriteLine(countries[1]);

//             // //foreach (var item in countries)
//             // //{
//             //     //Console.WriteLine(item.Key + " = " + item.Value);
//             // //}

//             // Dictionary<int, string> countries1 = new Dictionary<int, string>()
//             // {
//             //     [1] = "USA",
//             //     [977] ="Nepal",
//             //     [91] = "India"
//             // };
//             // Console.WriteLine (countries1[1]);
//             // foreach (var item in countries1)
//             // {
//             //   Console.WriteLine(item.Key + " = " + item.Value);

//             // }
//             //list of animals name
//             //   Collection c = new Collection();

//             //   List<string> animallists = c.GetAnimals();
//             //  Console.WriteLine("List of Animals:");
//             //  foreach(string a in animallists)
//             //  {
//             //    Console.WriteLine(a);
//             //  }
//             //  Console.WriteLine("..............................");


//             //list of songs and genre


//             //modifying the above to return the list of songs name, genre and artist name  

//             //  List<(string SongName, string Genre, string Artist)>songs =c.FetchSongsList();
//             //  foreach(var song in songs)
//             //  {
//             //    Console.WriteLine($"Song Name = {song.SongName} Genre = {song.Genre} Artist = {song.Artist}");

//             //  }
//             // Person p = new Person();
//             // Person p1 = new Person ("Ravi");

//             //   PropertiesAndEnums.Person p = new PropertiesAndEnums.Person("Ravi","Shakya");
//             //   var x = p.FirstName;
//             //   p.FirstName = "Ravi";
//             //   x = p.FirstName;
//             //   Console.WriteLine();

//             //  var x = Customer.CardNo;
//             //  Customer c =new Customer();

//             //  Student s1 = new Student( ); //s1 is the instance

//             //   Student s2 = new Student();
//             //    Student s3 = new Student();
//             //     Student s4 = new  Student();
//             //      Student s5 = new Student();
//             //     //  Student.PrintStudentDetails();

//             //  Math.Sin(324);

//             //Student.address

//             //ISaleable p= new Snake();
//             //  var p = new Snake();
//             //  var s = new Puppy();
//             // ILivesOnLand p = new Mammals();
//             // ILivesOnLand q = new Reptiles();
//             // ILivesOnWater w = new Amphibians();

//             //  BaseEmployee fte = new FullTimeEmployee();
//             //   fte.FirstName = "Ravi";
//             //   fte.LastName = "Shakya";
//             //   System.Console.WriteLine (fte.GetFullName()); //method hiding
//             //   System.Console.WriteLine (fte.CalculateMonthlySalary()); //method override 

//             //   Contractor contra = new Contractor();
//             //   contra.FirstName = "RaviKrishna";
//             //   contra.LastName = "Shrestha";
//             //   System.Console.WriteLine (contra.GetFullName());
//             string folderpath = @"D:\C#\.NetClassesCotiviti\DhritiShakya\DemoFolder";
//             string filepath = Path.Combine(folderpath, "testfile.txt");
//             string filepath1 = Path.Combine(folderpath, "testfile1.txt");
//             string filepath2 = Path.Combine(folderpath, "testfile2.txt");
//             string text = "This is a test file";
//             FileIO fileIO = new FileIO();
//             var folder = fileIO.CreateFolder(folderpath);
//             //fileIO.CreateFile(filepath);
//             fileIO.CreateFile(filepath, text);

//             string[] texts = { "Hi there", "hello", "hi" };
//             string[] texts1 = { "Hi there", "hello", "hi" };
//             fileIO.CreateFile(filepath1, texts);
//             fileIO.CreateFile(filepath2, texts1);
//             var result = fileIO.ReadFile(filepath2);
//             for (byte i = 0; i < result.Length; i++)
//             {
//                 Console.WriteLine($"{i + 1}-{result[i]}");
//             }

























//         }
//     }

// }
