using LoopsAndConditions;
using LearningMethods;
using System;
using System.Collections;
using System.Collections.Generic;
namespace MainProgram {

    public class EntryPoint {
        public static void Main () {
         
            /*Iterations iter = new Iterations ();
            iter.DefineLoops ();
            iter.LearnNestedLoops ();
            PrintMultipleofFive pf = new PrintMultipleofFive();
            pf.printMFive();
            */
            

            /*Conditionals c = new Conditionals();*/
            /*c.PrintHello();*/
            /*c.CheckIfUserSaysHi();
            c.GetLargest();
            c.CheckVowel();
            CheckForEvenNumbers evenNumbers = new CheckForEvenNumbers();
            evenNumbers.CheckForEvenNumber();
            SumOfNaturalNumbers sum = new SumOfNaturalNumbers();
            sum.NaturalNumbersSum();
            */

            Methods m = new Methods();
            //long s = m.AddThreeNumbers(1,9,1);
            long s = m.sum(2,2,1);
            Console.WriteLine("Sum is "+s);
            

            //Named arguments
            string name = m.GetFullName(lastName: "Shakya", firstName: "Kajol");
            Console.WriteLine("Full Name is "+name+ ".");

            (int Min,int Max) result = m.GetMinMax(new int[] {4, 3, 5, 2, 6});
            /*int m1 = result.Min;
            int m2 = result.Max;
            Console.WriteLine("Minimum number is "+m1+ " and maximum number is "+m2+".");
            */
            /*Console.WriteLine("Minimum number is" +result.Min);
            Console.WriteLine("Maximum number is "+result.Max);*/

            Console.WriteLine($"Minimum no. is {result.Min} and the maximum no. is {result.Max}");

            decimal f = m.AverageThreeArguments(2.7m,3.5m,4.6m);
            Console.WriteLine("Average of 3 decimal arguments is "+f);
            decimal average = m.AverageNArguments(4,5,6);
            Console.WriteLine("Average of given arguments is "+average);


            (int m, int f, int o) gender = m.GetGender();
            Console.WriteLine("Total Male is "+gender.m+" , total Female is "+gender.f+" and total others are "+gender.o);


            TestList<string> list = new TestList<string>();  //Generic
            list.Add("asda");     

            TestList<byte> list1 = new TestList<byte>();
            list1.Add(23); 

            ArrayList arrayList = new ArrayList();   //non Generic
            arrayList.Add("asdada");
            arrayList.Add(2313);

            ArrayList sortedList = new ArrayList();   //non Generic
            sortedList.Add("asdada");
            sortedList.Add(2313);

            List<short> list2 = new List<short>();
            list2.Add(13);
            list2.Add(23);
            list2.Add(232);

            List<Student> students = new List<Student>();
            Student st1 = new Student()
            {
                name = "Kajol"
            };

            //Student st1 = new Student{name = "Kajol"};
            
            Student st2 = new Student()
            {
                name = "Shandipta"
            };

            students.Add(st1);
            students.Add(st2);

            /*Dictionary<int, string> countries = new Dictionary<int, string>();
            countries.Add(1,"USA");
            countries.Add(977,"Nepal");
            countries.Add(91,"India");
            */

            Dictionary<int, string> countries = new Dictionary<int, string>()
            {
                [1] = "USA",
                [977] = "Nepal",
                [91] = "India"
            };

            foreach(var item in countries)
            {
                Console.WriteLine(item.Key + " = " + item.Value);
            }
            
            Console.WriteLine(countries[1]); //USA 1 as a key rather than index


            Collections c = new Collections();
            List<String> animalList = c.GetAnimals();
            Console.WriteLine("List of Animals:");
            foreach (string a in animalList)
            {
                Console.WriteLine(a);
 
            }

            Dictionary<string, string> song = c.FetchSongs();
            Console.WriteLine("Song => Genre");
            foreach (KeyValuePair<string, string> sng in song)
            {
                Console.WriteLine("{0} => {1}", sng.Key, sng.Value);
            }

            /*Dictionary<string, List<string>> songDetail = c.FetchSongsDetail();
            Console.WriteLine("Song | Genre | Singer/Band");
            foreach (var songs in songDetail)
            {
                string key = songs.Key;
                List<string> values = songs.Value;
                Console.WriteLine(key + "| " + string.Join("| ", values));
            }
            */
            List<(string SongName, string Genre, string Artist)> songDetail = c.FetchSongsDetail(); //tuple
            foreach (var songs in songDetail)
            {
                Console.WriteLine($"Song Name = {songs.SongName} Genre = {songs.Genre} Artist = {songs.Artist}");

            }

            Person p = new Person();
            Person p1 = new Person("Kajol");

        }    
    }
}



