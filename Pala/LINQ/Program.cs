using System;
using System.Linq;
using System.Collections.Generic;
using FileHandling;
using System.IO;
//imperative and declaratative programming language
//

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  //LINQ language intregated  Query
              //Example
              /*string[] names = { "Bishnu", "Pawan", "Shristi", "pala" };
              //var orderedNames = names.OrderBy(x => x);//Lamda expression order by 
              var namesFiltered = names.Where(x => x.StartsWith("S"));//method syntax to use linq
              foreach (var name in namesFiltered)
              {
                  Console.WriteLine(name);
              }       */
            //xample2
            var students = Collections.FetchStudents();
            var result = from student in students  //query expression to use linq 
                         group student by student.CollegeName into studentGroup
                         orderby studentGroup.Key
                         select studentGroup;
            foreach (var x in result)
            {
                System.Console.WriteLine(x.Key);
                foreach (var s in x)
                {
                    System.Console.WriteLine("--" + s.Name);
                }
            }
          //impreative and declarative
          //forloop is imperative step by step method
          //int[] numbers = { 2, 3, 4, 5, 6, 7, 8, 9, 20 };
          //Declerative
          //var sum = numbers.Sum();//declarative way of defining function we dont know the functionality of the AIP
          //Imperative
          //int sum1 = 0;
          // foreach (int num in numbers)
          //{
          //sum1 += num;
          //}
          //LINQ - Query Expression and Method Syntax
          //Query Expression Syntax - Get evn number
          /* var evenNumbers = from number in numbers
                             where number % 2 == 0 && number < 20
                             orderby number ascending
                             select number;*/
          //Method syntax
          //evenNumbers = numbers.Where(number => number % 2 == 0).Select(x => x);

          /*var evenNumbersWithMethodSyntax = numbers.Where(number => number % 2 == 0).Select(x => x);
          foreach (var n in evenNumbers)
          {
              Console.WriteLine(n + " ");
          }

          var students = Collections.FetchStudents();
          var y = from student in students  //query expression to use linq 
                  where student.CollegeName == "MBM"
                  orderby student.Name descending
                  select student.Name;*/
          // Select new {student.RollNo, student.Name}
          //students.Where(student=>student.CollegeName =="mbm").Select (x=>x.Name);

          //student group by cpllege
          /*var studentGroupByCollege = from student in students
                                      group student by student.CollegeName into studentGroup
                                      where studentGroup.Count() <= 2
                                      orderby studentGroup.Key
                                      select studentGroup;*/


            PlayerCollections pc = new PlayerCollections();
            var players = PlayerCollections.PlayerList();
            var NepaliPalyers = from PlayerList in players
                                where PlayerList.NOC == "NEP"
                                select new { PlayerList.Name };

            Console.WriteLine($"Nepali Players List ");
            foreach (var nepList in NepaliPalyers)
            {

                Console.WriteLine($"\t{nepList}");

            }
            //List all Chinese Player
            var chinesePlayers = PlayerCollections.PlayerList();
            var chinsPlayerList = from chinese in chinesePlayers
                                  where chinese.NOC == "CHN" && chinese.Medal == "Gold"
                                  select new { chinese.Id, chinese.Name };

            Console.WriteLine($"Chinese Players List with gold Medal ");
            foreach (var chinList in chinesePlayers)
            {

                Console.WriteLine($"\t{chinList}");

            }
            //List all players from USA and group them by sport they were in Also order the result by sport.
            var usaPlayers = PlayerCollections.PlayerList();
            var usPlayers = from usa in usaPlayers
                            where usa.NOC == "USA"
                            group usa by usa.Sport into usaSportGroupList
                            orderby usaSportGroupList.Key
                            select usaSportGroupList;
            //Console.WriteLine(usPlayers);

            string[] usaPlayerList = new string[100000];
            int i = 0;
            foreach (var usPlayer in usPlayers)
            {
                Console.WriteLine($"{usPlayer.Key} total atheletes {usPlayer.Count()}");
                foreach (var usaPlayList in usPlayer)
                {
                    i++;
                    Console.WriteLine($"\t{usaPlayList.Id} {usaPlayList.Name}");
                }
                i++;
            }
























        }
    }
}
