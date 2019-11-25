using System;
using System.Linq;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Athelete;
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

            string rootpath=@"C:\Users\i10572\.NETClassesCotiviti\Shreyapradhan\LINQ";
            string path=Path.Combine(rootpath,"Olympics_Athelete_Events.txt");
            string path1=Path.Combine(rootpath,"Nepaleeseplayer.txt");
            string path2=Path.Combine(rootpath,"ChineesePlayer.txt");
            string path3=Path.Combine(rootpath,"AmericanPlayer.txt");

            var players=Player.GetPlayers(path);

            
            var PlayerBycountry = from player in players
                                      where player.NOC == "NEP"
                                      select player.Name;

            var chineeseGoldMedalist= from player in players
                                       where player.NOC=="CHN" && player.Medal=="Gold"
                                       select player.Name;

            var AmericanPlayers= from athelete in players
                                 where athelete.NOC =="USA"
                                 group athelete by athelete.Sport into sportsgroup
                                 orderby sportsgroup.Key ascending
                                 select sportsgroup;

            var CountryMedalTally = from sportsperson in players
                                    group sportsperson by new {sportsperson.TeamName,sportsperson.Medal} into countrygroup
                                    orderby countrygroup.Count() ascending
                                    select countrygroup;

            FileOperation.CreateFile(path1,PlayerBycountry.ToArray());
            FileOperation.CreateFile(path2,chineeseGoldMedalist.ToArray());
            
             foreach (var sportsgroup in AmericanPlayers)
            {
                    Console.WriteLine($" grouop -> {sportsgroup.Key}");
                    foreach(var play in sportsgroup)
                     {
                          Console.WriteLine(play.Name);

                     }

            }


        



        }
    }
}
