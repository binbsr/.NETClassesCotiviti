using System;
using System.Collections;
using System.Collections.Generic;
using DotNetClass;
using Properties;
using Inheritances;
using FileHandling;
using System.IO;

namespace MainProgram
{
    class MainClass{
        // Data 
        public static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello World!");
            Iterations iteration1 = new Iterations();
            iteration1.DefineLoops();
            Excercise1 ex1 = new Excercise1();
            ex1.printMultipleOfFive();
            */
           /* Conditions cnd = new Conditions();
            string str = cnd.GetText();
            cnd.PrintHello(str);
            //cnd.GetLargestNumber();
            cnd.PrintVowel();
            cnd.CheckEvenOrOdd();
            cnd.SumOfNaturalNumbers();
            */
           /* CalculateAverage avg = new CalculateAverage();
            decimal d = avg.CalcAvg(10.2m,10.3m,10.4m);
            Console.WriteLine(d);

            decimal[] num = {10.2m,10.5m,10.4m};
            avg.CalcAvg1(num);
            Console.WriteLine(d);

            (int m, int f, int o) gender = avg.GenderCount();
            Console.WriteLine("Total Male is "+gender.m+" , total Female is "+gender.f+" and total others are "+gender.o);
            */
           /* TestList<string> list = new TestList<string>();
            TestList<byte> list1 = new TestList<byte>();

            ArrayList arrayList = new ArrayList();
            arrayList.Add("dfjdjfd");

            List<short list = new TestList<string><short>();
            list.Add(324);
            list.Add(324);
            list.Add(324);
            list.Add(324);
            list.Add(324);
            list.Add(324);
            */
           /* TestList<Student> student = new TestList<Student>();
            Student st1 = new Student()
            {
                name = "Bishnu"

            };
            Student st2 = new Student()
            {
                name = "Bikram"

            };
            student.Add(st1);
            
            student.Add(st2);

            Dictionary <int, string> countries = new Dictionary<int, string>();
            countries.Add(1, "US");
            countries.Add(977, "Nepal");            
            countries.Add(91, "India");
            foreach (var item in countries)
            {
                Console.WriteLine(item.Key + " = " + item.Value);
            }
            */
            /*
            Collections coll = new Collections();
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

            List<SongDetail> resultSongDetails = coll.FetchSongDetails();
            foreach (var item in resultSongDetails)
            {
                Console.WriteLine("Song name is " + item.name + ", and song genre is " + item.genre + ", and the artist is " + item.artist);
            }
            
            List<(string songName, string genre, string artist)> songList = coll.FetchSongList();
            foreach (var item in songList)
            {
                Console.WriteLine($"Song Name: {item.songName}      Song Genre: {item.genre}       Artist: {item.artist}");
            }
            Properties.Person p = new Properties.Person("Bikram", "KC");
            var x = p.FirstName;
            p.FirstName = "abc";
            var y = p.FirstName;
            Console.WriteLine($"First Name : {x} Set Name : {y}");
            p.Address = "Sukedhara";
            Console.WriteLine(p.Address);
            Console.WriteLine(Customer.cardNumber);

            Student st1 = new Student();
            Student.collegeName = "IOE";
            Console.WriteLine(Student.collegeName);
            string colName = Student.GetCollegeName();
            Console.WriteLine(colName);
            */
            /*
            VoteKukur v = new VoteKukur(); // base class constructor is called first
            ISaleable x = new VoteKukur();
            ISaleable y = new GermanShephard();
            x.Buy();
            y.Buy();
            
            IBrakingSystem bs1 = new Car();
            bs1.getBrakingSystem();
            IBrakingSystem bs2 = new SportsBike();
            bs2.getBrakingSystem();
            IBrakingSystem bs3 = new CruiseBike();
            bs3.getBrakingSystem();

            ILegGuard lg1 = new SportsBike();
            ILegGuard lg2 = new CruiseBike();
            System.Console.WriteLine(lg1.hasLegGuard);
            System.Console.WriteLine(lg2.hasLegGuard);
            
            FullTimeEmployee fte = new FullTimeEmployee();
            fte.FirstName = "Bishnu";
            fte.LastName = "Rawal";
            System.Console.WriteLine(fte.GetFullName());

            Contractor con = new Contractor();
            con.FirstName = "Gautam";
            con.LastName = "Rasal";
            System.Console.WriteLine(con.GetFullName());

            BaseEmployee be = new FullTimeEmployee();
            be.FirstName = "Bikram";
            be.LastName = "KC";
            System.Console.WriteLine(be.GetFullName());
            
            System.Console.WriteLine(be.CalculateMonthlySalary());
         
            IBrakingSystem bs1 = new Car();
            bs1.getBrakingSystem();
            IBrakingSystem bs2 = new SportsBike();
            bs2.getBrakingSystem();
            IBrakingSystem bs3 = new CruiseBike();
            bs3.getBrakingSystem();

            ILegGuard lg1 = new SportsBike();
            ILegGuard lg2 = new CruiseBike();
            System.Console.WriteLine(lg1.hasLegGuard);
            System.Console.WriteLine(lg2.hasLegGuard);
            */
           // Homework 19 Nov
            /*
            Vehicle v = new Car();
            // Base class 1 should have a method that can be overriden by child classes
            v.Transport(); 
            // 2. Base class 1 should not allow its instantiation.
            // Vehicle v1 = new Vehicle();
            SportsBike b1 = new SportsBike();
            // 3. Base class 2 should have a method that must be overriden by child classes1.
            b1.Carries(); // abstract function
            // 4. Child class 1 should have a method that hides a parent method.
            System.Console.WriteLine(b1.Suspension()); // method hiding
            //5. Child class 2 should have a propery that hides a property in a parent class.
            CruiseBike b2 = new CruiseBike();           
            System.Console.WriteLine(b2.MaxCC); // Property Hiding
            //6. Child class 2 should have a method that is overriden and uses base class implementation of that method as well.           
            Console.WriteLine(b1.Comfortable());
            Console.WriteLine(b2.Comfortable());
            // 7. Grand child should protect itself from getting inherited.
            // Sealed keyword has been used for this
           
            */



           
           
            // Nov 20 classwork
            string folderPath = @"D:\DotNet\.NETClassesCotiviti\BikramKC\TestDir";
            FileIO fileIO = new FileIO();
            var folder = fileIO.CreateFolder(folderPath);
            string filePath = Path.Combine(folderPath,"file.txt");
            fileIO.CreateFile(filePath);
            string[] text = {"hi", "Hello", "What's up"};
            fileIO.CreateFile(filePath, text);
            string path1 = @"D:\DotNet\.NETClassesCotiviti\BikramKC\TestDir\file1.txt";
            //Console.WriteLine(fileIO.ReadFile(path1));
            /*
            string[] fileContent = fileIO.ReadFile(path1);
            for(int i = 0; i< fileContent.Length; i++)
            {
                Console.WriteLine($"{i+1} {fileContent[i]}");
            }
            */
            string fp = @"D:\DotNet\.NETClassesCotiviti\BikramKC\TestDir\AdventureOfBlackPeter.txt";
            fileIO.ReadFile(path1);           
            Console.WriteLine($"Number Of Characters: {fileIO.CountChar()}");
            Console.WriteLine($"Number of Lines : {fileIO.CountLine(path1)}");
            Console.WriteLine($"Number of Words : {fileIO.CountWord()}"); 
            Console.WriteLine($"Number of Sentence : {fileIO.CountSentence()}"); 
            Console.WriteLine($"Number of vowels : {fileIO.CountVowel()}"); 
            Console.WriteLine($"Number of Consonent : {fileIO.CountConsonant()}");
                    

        }

    }
}
