using System;
using System.Collections;
using System.Collections.Generic;
using DotNetClass;
using Properties;
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
            CalculateAverage avg = new CalculateAverage();
            decimal d = avg.CalcAvg(10.2m,10.3m,10.4m);
            Console.WriteLine(d);

            decimal[] num = {10.2m,10.5m,10.4m};
            avg.CalcAvg1(num);
            Console.WriteLine(d);

            (int m, int f, int o) gender = avg.GenderCount();
            Console.WriteLine("Total Male is "+gender.m+" , total Female is "+gender.f+" and total others are "+gender.o);
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
            */
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

        }

    }
}
