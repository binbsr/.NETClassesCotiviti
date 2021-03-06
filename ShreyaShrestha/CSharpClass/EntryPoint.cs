using LoopsAndConditions;
using LearnNewMethods;
using Exercise;
using System;
using System.Collections;
using System.Collections.Generic;
using GenericExamples;
using Assignments;
using PropertiesAndEnum;
using Inheritance;
using FileHandler;
using System.IO;
namespace MainProgram
{
    public class EntryPoint
    {
        public static void Main()
        {
            /*when LoopsAndConditions are not imported using using keyword
            we can simply write 
            LoopsAndConditions. Iterations iterations = new Iterations(); */

            Iterations iterations = new Iterations();
            // iterations.DefineLoops();

            // ClassWork exercise1 = new ClassWork();
            // exercise1.PrintMultiplesOfFive();

            Conditionals conditionals = new Conditionals();
            //conditionals.CheckIfUserSaysHello();
            //conditionals.ReturnLargestNumber();
            //conditionals.CheckVowel();
            //conditionals.CheckIfInputCharIsVowel();
            //conditionals.CheckEvenNumber();
            //conditionals.CalculateTheSumOfFirstNNaturalNumbers();
            //iterations.LearnNestedLoops();
            Methods learnNewMethods = new Methods();
            //long sum = learnNewMethods.ReturnSum(3456,46768);
            //Console.WriteLine("Sum of two long numbers is " + sum);
            // long sum = learnNewMethods.Sum(10,2,4);
            // Console.WriteLine(sum);
            //string fullName = learnNewMethods.GetFullName(firstName:"Shreya", lastName:"Shrestha"); //named Arguments
            // Console.WriteLine(fullName);

            //Calling using tuple
            //(int Min, int Max) result = learnNewMethods.GetMinAndMax(new int[]{3,6,4,2,8,1});
            //Console.WriteLine($"{result.Min}, {result.Max}");

            //average of 3 decimal numbers
            //Console.WriteLine(learnNewMethods.GetAverageOfThreeDecimalNumber(2.3M,8.9M,5.6M));

            //average of n decimal numbers
            // Console.WriteLine(learnNewMethods.GetAverageOfNDecimalNumbers(new decimal[] { 0.3M, 2.5M, 5.6M, 6.9M }));
            // Console.WriteLine(learnNewMethods.GetAverageOfNDecimalNumbers(new decimal[] {2.9M,8.5m }));

            //genderCount
            // (int femaleCount, int maleCount, int nullCount) gendersCount = learnNewMethods.GetGenderCount();
            // Console.WriteLine($"Female count is {gendersCount.femaleCount}, Male count is {gendersCount.maleCount} and Null count is {gendersCount.nullCount}");

            //Generics
            // Generics<string> list = new Generics<string> ();
            // list.Add("sdfs");

            // Generics<byte> list1 = new Generics<byte> ();
            // list1.Add(34);

            //non - generic
            ArrayList arrayList = new ArrayList();
            arrayList.Add("sdfg");
            arrayList.Add(234);

            //Generics
            List<short> list = new List<short>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(1);
            list.Add(1);

            //list of custom data types
            List<Student> students = new List<Student>();

            //Inline initialization like in lists
            Student st1 = new Student { name = "Shreya" };

            Student st2 = new Student();
            {
                st2.name = "Bishnu";
            };
            //sudents.Add(new Student) is also valid

            students.Add(st1);
            students.Add(st2);
            // Dictionary<int, string> countries = new Dictionary<int, string>();
            // countries.Add(1, "USA");
            // countries.Add(00977, "Nepal");
            // countries.Add(91, "India");

            // Dictionary<int, string> countries = new Dictionary<int, string>()
            // {
            //     [1] = "USA",
            //     [00977] = "Nepal",
            //     [91] = "India"
            // };

            // foreach (var item in countries)
            // {
            //     Console.WriteLine(item.Key + " = " + item.Value);
            // }

            //GetAnimals()
            TestList generics = new TestList();
            Collection c = new Collection();
            // foreach(var e in c.GetAnimals())
            // {
            //     Console.WriteLine(e);
            // }



            //for fetching songName and genre
            // foreach(var songList in c.FetchSongs())
            // {
            //     Console.WriteLine(songList.Key + ", " + songList.Value);
            // }


            //for fetching songName, genre and artist by class
            // List<Song> songs = new List<Song>();            
            // Song song1 = new Songs { songName = "Sayau Thunga", genre = "National Song", artistName = "Bimal Maila"};
            // Song song2 = new Songs {songName = "Komal tyo timro" , genre = "Pop" , artistName = "Sabin Rai"};
            // songs.Add(song1);
            // songs.Add(song2);


            // foreach(var song in songs)
            // {
            //     Console.WriteLine(song.songName + ", " + song.genre + ", " + song.artistName);
            // }

            // foreach(var item in c.FetchSongsBySongNameGenreArtist())
            // {
            //     Console.WriteLine(item.Key + "," + item.Value.genre + ", " + item.Value.artistName );
            // }

            // foreach(var item in c.FetchSongsBySongNameGenreArtist1())
            // {
            //     Console.WriteLine($"Song name = {item.Key}, Genre = {item.Value}");
            // }

            // List<(string songName, string genre, string artist)> songs = c.FetchSongsBySongNameGenreArtist2();
            // foreach(var item in songs)
            // {
            //     Console.WriteLine($"Song Name = {item.songName}, Genre = {item.genre}, Artist = {item.artist}");
            // }    

            // Person p = new Person(); //since the fields are private we cannot access the fields using p.name or p.age
            // Person p1 = new Person("Shreya");

            // PropertiesAndEnum.Person p = new PropertiesAndEnum.Person("Shreya", "Shrestha");
            // var x = p.FirstName;
            // var y = p.LastName;
            // x = p.FullName;
            // // p.FirstName = "abc";
            // // x = p.FirstName;
            // //Console.WriteLine($"{x}, {y}");
            // Console.WriteLine(x);

            // Customer customer = new Customer("");
            // var a = Customer.cardNumber;
            // var z = Customer.citizenshipNumber;
            //var z = customer.citizenshipNumber;
            //Dog d = new Dog();
            //    Puppy p = new Puppy();
            //    ISaleable p1 = new Puppy();

            // Marigold marigold = new Marigold();
            // LeafyGreen leafyGreen = new LeafyGreen();
            // Sunflower sunflower = new Sunflower();
            // Console.WriteLine($"Does Marigold produce nectar? {marigold.ProduceNectar()}");

            // BaseEmployee fte = new FullTimeEmployee(); // this will not call baseclass this is called runtime polymorphism, even if the obj is of base class, it will check if the methods are overridden and if there is, then it calls the overriden method 
            // // if the method has been hidden not overriden then, it calls the method of base class
            // fte.FirstName = "Bishnu";
            // fte.LastName = "Rawal";            
            // Console.WriteLine(fte.GetFullName()); // Method hiding
            // Console.WriteLine(fte.CalculateSalary()); //Method overriding using virtual

            // Contractor contractor = new Contractor();
            // contractor.FirstName = "Kajol";
            // contractor.LastName = "Agarwal";
            // Console.WriteLine(contractor.GetFullName());

            //Assignment 19th Nov
            // LeafyGreen lg = new LeafyGreen();
            // // 1.
            // lg.Sell();
            // //3. 
            // Sunflower sf = new Sunflower();
            // Console.WriteLine(sf.GetScientificName());     
            // //4.
            // lg.FiberContent = 0.5;
            // Console.WriteLine(lg.GetFiberContent());
            // //5. 
            // Marigold mg = new Marigold();
            // mg.FlowerParts = "Leaves";
            // //6.
            // Console.WriteLine(mg.GetFlowerParts());

            //File Handling
            //Directory.CreateDirectory(string path) can be done directly in the main function
            FileIO fileIO = new FileIO();

            //Directory
            string folderPath = @"D:\DotNetClasses\.NETClassesCotiviti\ShreyaShrestha\DemoFolder";
            // var folder = fileIO.CreateFolder(folderPath);
            // Console.WriteLine(folder.FullName);
            // Console.WriteLine(folder.CreationTime);
            // Console.WriteLine(folder.LastAccessTime);
            // Console.WriteLine(folder.Attributes);

            //File
            // string filePath1 = Path.Combine(folderPath, "Test.txt"); //can simply concatenate 
            // string text = "Hello World!";

            // //WriteAllText method overrides the text file
            // fileIO.CreateFile(filePath1, "This is for file handling");
            // fileIO.CreateFile(filePath1, text);

            // string[] content = { "Hello there!", "How are you doing?", "Are you having a great time?" };
            // string filePath2 = Path.Combine(folderPath, "ArrayText.txt");
            // fileIO.CreateFile(filePath2, content);

            // string filePath3 = @"C:\Users\i81378\Documents\Nucleus.txt";
            // var result = fileIO.ReadFile(filePath3);
            // for(byte i = 0 ; i < result.Length; i++)
            // {
            //     Console.WriteLine($"{i+1}: {result[i]}");
            // }
            string filePath4 = Path.Combine(folderPath, "StreamWriter.txt");
            string text = "abdjfkjs";
            fileIO.CreateFileAnotherWay(filePath4, text);

            //Assignment 
            FileInterAction fia = new FileInterAction();
            string filePath = Path.Combine(folderPath, "TheAdventureWorks.txt");
            //Console.WriteLine($"The numbers of character in the text file is {fia.ReadCharacter(filePath)}");
            //Console.WriteLine($"The numbers of words in the text file is {fia.ReadWords(filePath)}"); //8678
            //Console.WriteLine($"The numbers of sentences in the text file is {fia.ReadSentence(filePath)}"); //660 
            //Console.WriteLine($"The numbers of vowels in the text file is {fia.ReadVowels(filePath)}");
            //Console.WriteLine($"The numbers of special characters in the text file is {fia.ReadSpecialCharacters(filePath)}"); //47107
        }
    }
}

