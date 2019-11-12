using Iterate;
using LoopsAndConditions;
using LearningMethods;
using System;
using System.Collections;
using System.Collections.Generic;
using Song;

namespace main
{

public class EntryPoint {
    public static void Main()
    {
  Person p = new Person();
      p.Read();
      p.Walk();
Iterations iterations = new Iterations();
  iterations.DefineLoops();
  iterations.LearnNestedLoops();

  Conditionals c1 = new Conditionals();
  c1.PrintHello();
  c1.CheckString();
  c1.GetLargest();
  c1.Checkvowels();
  c1.nSumOfSquares();

  Methods m = new Methods();

  decimal average = m.Average(23424234,23424234,34566); // 3 parameters
  Console.WriteLine("Average of 3 num " + average);

  decimal avg = m.Average(23456,5677); //any no of param
  Console.WriteLine("Average of multiple num " + avg);
  
  (int male, int female, int other) countgender = m.CountGender();
  Console.WriteLine("countmale : " + countgender.male);
  Console.WriteLine("countFemale :" + countgender.female);


  TestList<string,string> list = new TestList<string,string>();
  list.Add("test");

  TestList<byte,byte> list1 = new TestList<byte,byte>();
  list1.Add(34);

  List<short> list2 = new List<short>();
  list2.Add(234);
  list2.Add(34);
  list2.Add(345);

  Dictionary<int, string> countrie = new Dictionary<int, string>()
  {
    [1] = "USA",
    [2] = "Nepal",
    [324] = "India",
  };

  Dictionary<int, string> countries = new Dictionary<int, string>();
  countries.Add(1,"Nepal");
  countries.Add(2,"USA");
  countries.Add(3,"India");
  countries.Add(1,"ll"); //key should always be unique will throw error

  Console.WriteLine(countries[1]); //1 is key rather than index

  foreach (var item in countries)
  {
    Console.WriteLine(item.Key + " = " + item.Value);
  }


  List<Student> students = new List<Student>();
  Student st1 = new Student() //inline initialization , initialize while creating object in same line
  {
    name = "Sheprata",
    address = "Jorpati",
    rollNo = 13,
  };
  Student st2 = new Student() 
  {
    name = "Nitin"
  };
  students.Add(st1);
  students.Add(st2);

 Collection collection = new Collection();
 List<string> animal = new List<string>();
  animal = collection.GetAnimals();
  foreach(var item in animal)
  {
    Console.WriteLine("name of animals :" + animal);
  }

  List<Songs> song = new List<Songs>();
  song = collection.FetchSongs();
      foreach (var item in song)
         {
           Console.WriteLine( "artist" + item.artistName);
           Console.WriteLine("song" + item.songName);
           Console.WriteLine("genre" +item.songGenre);
         }

  //var songsfetch = collection.FetchSongDetails();
  List<(string songName, string songGenre, string artist)> songsfetch = collection.FetchSongDetailsTuple();
  foreach (var songs in songsfetch)
  {
    Console.WriteLine($"SongName = {songs.songName} genre is = {songs.songGenre} and artist is = {songs.artist}");
  }





  ArrayList arraylist = new ArrayList(); //nonGeneric --performance issue 
  arraylist.Add("sss");
  arraylist.Add("233");

  long s = m.AddTwoNumbers(23424234,23424234); //parameters
  Console.WriteLine("Sum is " + s);
  long s1 = m.Sum(23456,2345,4556);
  long s2 = m.Sum(456,34543,345345,34534);
  Console.WriteLine(m.GetFullName("sheprata","shrestha"));
  Console.WriteLine(m.GetFullName("sheprata","shrestha","optional"));
  Console.WriteLine(m.GetFullName(lastName : "shrestha",firstName : "shrestha",middleName :"optional")); //named argument
  //int min = m.GetMinMax(new int[] {4,3,5,2,6});
  (int Min, int Max) result = m.GetMinMax(new int[] {4,3,5,6,5});
  Console.WriteLine($"Min Tuple(multiple return) = {result.Min} and Min Tuple(multiple return) = {result.Max}");
     }

  Person p = new Person();

  Person p1 = new Person(45);

}

}