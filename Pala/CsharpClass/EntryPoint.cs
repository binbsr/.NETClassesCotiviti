using LoopsAndConditions;
using Exercise;
using LearningMethods;
using System;
using System.Collections;
using System.Collections.Generic;

namespace MainProgram
{
    public class EntryPoint
    {
        public static void Main()
        {
            /*when LoopsAndConditions are not imported using using keyword
            we can simply write 
            LoopsAndConditions. Iterations iterations = new Iterations(); */

            // Iterations iterations = new Iterations();
            // iterations.DefineLoops();

            //ClassWork exercise1 = new ClassWork();
            //exercise1.PrintMultiplesOfFive();
            //Conditionals c = new Conditionals();
            //c.PrintMessage();
            //c.GetLarge();
            //c.Vowels();
            //c.IsEven();
            //c.SumSqNaturalNum();
            //Methods m = new Methods();
            //long s = m.AddTwoNumbers(23456,56789);//parameters
            //long s1 = m.AddThreeNumbers(23456,56789,1234);//parameters
            //Console.WriteLine("Sum is = " + s);
            //Console.WriteLine("Sum is = " + s1);
            //string fullName= m.GetFullName(firstName: "Pala",lastName: "Kansakar");//Named Arguments
            //Console.WriteLine(fullName);
            //int min = m.GetMin(new int[] {4,3,5,2,6});
            //(int Min,int Max) minMax = m.GetMinMax(new int[] {4,3,5,2,6});
            //Console.WriteLine($"Minimum = {minMax.Min} and Largest = {minMax.Max}");
            // int mi = minMax.min;
            //int ma = minMax.max;
            //float Result = m.AvgDec(1.2F,2.2F,4.5F);
            //Console.WriteLine("Average of 3 Decimal number is " + Result);
            //float Result = m.AvgAll(3.2F,2.2F,6.2F,5.4F);
            //Console.WriteLine(Result);
            //char?[] genderCollection = new char?[] { 'F', 'M', 'F', 'M', null, 'M', null, 'F', 'F', 'M', null, null, 'F', 'M', 'M' };
            //string Result= m.GetGender(genderCollection);
            //Console.WriteLine(Result);
            //(int m,int f,int o) Gen=m.GetGenderTuple(genderCollection);
            //Console.WriteLine($"Male = {Gen.m} Female = {Gen.f} others = {Gen.o}"); 

            //GENERIC -> DATATYPE AS ARGUEMENT
            //TestList<String> list = new TestList<String>() ;
            //list.Add("sdfsd");
            //TestList<byte> list1 = new TestList<byte>() ;
            //list1.Add(34);
            //NONGENERIC
            //ArrayList arrayList = new ArrayList();
            //arrayList.Add("sdfg");
            //arrayList.Add(2342);

            //GENRIC
            //List<short> list = new List<short>();
            //ist.Add(324);
            //list.Add(324);
            //list.Add(324);
            //list.Add(324);
            //list.Add(324);
            //list.Add(324);

            //List<Student> students = new List<Student>();
            //Student st1 = new Student { name = "Bishnu" };
            //Student st2 = new Student()
            //{
            //    name = "Bikran"

            //};

            //students.Add(new Student();
            //students.Add(st1);
            //students.Add(st2);

            //Dictionary<int, string> countries = new Dictionary<int, string>()//key should be unique
            //{
            //  [1] = "USA",
            // [977] = "NEPAL",
            // [91] = "INDIA"
            //};
            // countries.Add(1,"USA");
            // countries.Add(977,"Nepal");
            //countries.Add(91,"india");
            //foreach (var item in countries)
            //{
            // Console.WriteLine(item.Key + "=" + item.Value);
            //}
            // Create class named *Collection*, create 3 methods in there:*GetAnimals()* which returns list of animal names.
            List<string> animals = new List<string>() { "Rat", "Cat" };
            Collection collectionName = new Collection();
            collectionName.getAnimals(animals);

            //*FetchSongs()* which returns list of songs (song name and genre).
            Dictionary<string, string> songsGenre = new Dictionary<string, string>()
            {
                ["BlankSpace"] = "Pop",
                ["OffTheChain"] = "TeenPop",
                ["wolves"] = "ElectronicMusic"
            };
            collectionName.Fetchsongs(songsGenre);
            //Modify 2. to return list of songs (name, genre and artist name).
            Dictionary<string, List<string>> Fetchsongs1 = new Dictionary<string, List<string>>
            {
                ["BlankSpace"] = new List<string> { "POP", "TaylorSwift" },
                ["OffTheChain"] = new List<string> { "TeenPop", "Selena" },
                ["wolves"] = new List<string> { "ElectronicMusic", "SelenaGomez" }
            };

            collectionName.ReturnArtist(Fetchsongs1);
        }
    }
}
