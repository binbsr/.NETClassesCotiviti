using LoopsAndConditions;
using Exercise;
using LearningMethods;
using System;
using Generics;
using System.Collections.Generic;


namespace MainProgram 
{
    public class EntryPoint
 {
    public static void Main()
        {
            Methods methods=new Methods();
            char?[] genderCollection = new char?[] { 'F', 'M', 'F', 'M', null, 'M', null, 'F', 'F', 'M', null, null, 'F', 'M', 'M' };
            //ClassWork classWork=new ClassWork();
            //classWork.CalculateMultipleOfFive();
            Iterations iterations=new Iterations();
            //iterations.DefineLoops();
            Conditionals conditions=new Conditionals();
            //conditions.PrintMessage();
            //conditions.GetLargest();
            //conditions.CheckForVowel();
            //conditions.CalculateSumOfNumber();
            //conditions.CheckOddEvenNumber();
           // iterations.LearnNestedLoops();
           //string fullName=methods.GetFullName("Shreya",lastName:"Pradhan"); //named arguements
           //Console.WriteLine(fullName);
            //Console.WriteLine("sum is "+methods.AddTwoNumers(12323244,234566));
           //(int Min,int Max)result=methods.GetMinMax(new int[]{3,4,5,6,7});
            //Console.WriteLine($"Minimum is {result.Min} and Maximum is {result.Max}");
           // Console.WriteLine(methods.CalculateAverageOfAllNumbers(2,4));
            //(int Fcount,int Mcount,int Ocount)genderResult=methods.ClaculateGenderDistibution(genderCollection);
            //Console.WriteLine($"Female count is {genderResult.Fcount} and Male count is {genderResult.Mcount} and others are {genderResult.Ocount}");

           /* generics  TestList<string> list1=new TestList<string>();
            list1.Add("abcd");

            List<short> list=new List<short>();
            list.Add(234);
            list.Add(235);
            list.Add(567);

            List<Student> students=new List<Student>();
            Student st1=new Student{
                name="Shreya",
                rollNo=1233434,
                                
            };
             Student st2=new Student(){
                name="Pradhan",
                rollNo=1233434,
                                
            };
            students.Add(st1);
            students.Add(st2);
            

            Dictionary <int,string> countries=new Dictionary<int,string>();
            countries.Add(1,"USA");
            countries.Add(977,"Nepal");
            countries.Add(91,"India");
            
         
          Dictionary <int,string> countries=new Dictionary<int,string>()
          {
              [1]="USA",
              [977]="Nepal",
              [91]="India"
          };
            
          
            foreach(var item  in countries)
            {
                Console.WriteLine($"{item.Key}-{item.Value}");
            } */

        collections collections=new collections();

            /*  List<string> animals=collections.getAnimals();
             foreach(string animal in animals)
             {
                     Console.WriteLine(animal);
             }

             Dictionary<string,string>album=collections.Fetchsongs();
               foreach(var item  in album)
                 {
                     Console.WriteLine($"{item.Key}-{item.Value}");
                 }

             List<SongsList> Tracks=collections.FetchAllsongs();

             foreach(SongsList song  in Tracks)
                 {
                     Console.WriteLine($"{song.name} is a {song.genre} song and sung by {song.artist}");
                 }
                 */
            List<(string songname,string genre,string artist)> songs = collections.GetallSongs();
            foreach(var song  in songs)
                 {
                     Console.WriteLine($"{song.songname} is a {song.genre} song and sung by {song.artist}");
                 }
            
             
    
 }
}
}