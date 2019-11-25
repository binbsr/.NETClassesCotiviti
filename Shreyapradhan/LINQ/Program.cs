using System;
using System.Linq;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            

           /* int[] numbers ={2,3,4,5,6,767,89,56};
              var students=Collections.FetchStudents();
            var sum=numbers.Sum();

            //linq --> query expression and Method Syntax --> query expression is preffered
            // query expression - get even numbers
            var evenNumbers= from number in numbers
                            where number%2==0 && number <20
                            orderby numbers ascending
                            select number; //evenNumbers  is query variable

            // Method syntax

            var evenNumbersWitMethodSyntax =numbers.Where(number => number%2==0 && number <20 ).Select(number => number);
            foreach (var num in evenNumbers)
            {
                    Console.Write(num+ " ");

            }
            
             foreach (var num in evenNumbersWitMethodSyntax)
            {
                    Console.Write(num+ " ");

            }

           
            var y =from student in students
                where student.CollegeName=="MBM"
                orderby student.Name descending
                select new{student.Name,student.rollNo};

            var x=students.Where(student =>student.CollegeName=="MBM").Select(x=>new{x.Name,x.rollNo});
            Console.WriteLine($"Roll NO.        name");
             foreach (var num in y)
            {
                    Console.WriteLine($"{num.rollNo}        {num.Name}");

            }

            Console.WriteLine("students by college");
            var studentsGroupedByCollege=from student in students
                                         group student by student.CollegeName;

              foreach (var studentgroup in studentsGroupedByCollege)
            {
                    Console.WriteLine($"{studentgroup.Key}");
                    foreach(var stud in studentgroup)
                     {
                          Console.WriteLine($"{stud.rollNo}-{stud.Name}");

                     }

            }

            var studentsGroupedByCollegeno=from student in students
                                         group student by student.CollegeName into studentGroup
                                         where studentGroup.Count()<2
                                         orderby studentGroup.Key
                                         select studentGroup;

            foreach (var studentgroup in studentsGroupedByCollegeno)
            {
                    Console.WriteLine($"{studentgroup.Key}");
                    foreach(var stud in studentgroup)
                     {
                          Console.WriteLine($"{stud.rollNo}-{stud.Name}");

                     }

            }
            */

            string path=@"C:\Users\i10572\.NETClassesCotiviti\Shreyapradhan\LINQ\Olympics_Athelete_Events.txt";
            var content=File.ReadAllLines(path);
            List<Player> players = new List<Player>();
            var lines = content.Skip(1);
            foreach(var line in lines)
            {
                
                List<string> playerlist=new List<string>();
                playerlist=line.Split(",").ToList();
                Player player = new Player();
                player.Id=int.Parse( playerlist[0]);
                player.Name=playerlist[1];
                player.sex=playerlist[2];
                player.Age = playerlist[3];
                player.Height=playerlist[4];
                player.Weight=playerlist[5];
                player.TeamName=playerlist[6];
                player.NOC=playerlist[7];
                player.Games=playerlist[8];
                player.Year=playerlist[9];
                player.Season=playerlist[10];
                player.City=playerlist[11];
                player.Sport=playerlist[12];
                player.Event=playerlist[13];
                player.Medal=playerlist[14];
                players.Add(player);
                //Console.WriteLine(playerlist[1]);
            }

            
            var PlayerBycountry = from player in players
                                      where player.TeamName == "Nepal"
                                      select player.Name;

            var chineeseGoldMedalist= from player in players
                                       where player.TeamName=="China" && player.Medal=="Gold"
                                       select player.Name;

            var AmericanPlayers= from athelete in players
                                 where athelete.TeamName =="USA"
                                 group athelete by athelete.Sport into sportsgroup
                                 orderby sportsgroup ascending
                                 select sportsgroup;

            var CountryMedalTally = from sportsperson in players
                                    group sportsperson by new {sportsperson.TeamName,sportsperson.Medal} into countrygroup
                                    orderby countrygroup.Count() ascending
                                    select countrygroup;

            Console.WriteLine("nepaleese Player");
            foreach (var Nepaleese in PlayerBycountry)
            {

                Console.WriteLine(Nepaleese);
            }  

            Console.WriteLine("Chineese Player with gold Medal");
            foreach(var chineese in chineeseGoldMedalist)
            {
                Console.WriteLine(chineese);
            }         

            Console.WriteLine("American Player with gold Medal");
            foreach (var sportsgroup in AmericanPlayers)
            {
                    Console.WriteLine($"{sportsgroup.Key}");
                    foreach(var play in sportsgroup)
                     {
                          Console.WriteLine(play.Name);

                     }

            }


            foreach (var sportsgroup in CountryMedalTally)
            {
                    Console.WriteLine($"{sportsgroup.Key}");
                    foreach(var play in sportsgroup)
                     {
                          Console.WriteLine(play.Name);

                     }

            }


             



        }
    }
}
