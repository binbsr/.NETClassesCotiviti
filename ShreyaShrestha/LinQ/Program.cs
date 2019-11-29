using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using System.IO;

namespace LinQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            //LINQ
            //Example1
            //21st Nov 2019
            string[] names = { "Shreya", "Pala", "Bishnu", "Sristi", "Bishnu" };
            //Method syntax
            var orderedNames = names.OrderBy(x => x);
            var fileteredName = names.Where(x => x.StartsWith("S"));
            // foreach(var name in orderedNames)
            // {
            //     Console.WriteLine(name);
            // }

            // foreach (var name in fileteredName)
            // {
            //     Console.WriteLine(name);
            // }

            var students = Collections.GetListOfStudents();

            //Query Expression
            var studentsInMM = from student in students
                               where student.Address == "MM"
                               select student;

            var group = from student in students
                        group student by student.Address into studentGroup
                        orderby studentGroup.Key //here key is address, it will list all the students in the address                               
                        select studentGroup;

            /*22nd Nov 2019*/
            var studentsNameByAddress = from student in students
                                        where student.Address == "MM"
                                        select student.Name;

            //anonymous type
            var studentsNameAndRollNoByAddress = from student in students
                                                 where student.Address == "MM"
                                                 orderby student.Name descending
                                                 select new { student.RollNumber, student.Name };

            // Console.WriteLine($"Roll Number    Name");
            // foreach (var y in studentsNameAndRollNoByAddress)
            // {
            //     Console.WriteLine($"{y.RollNumber}              {y.Name}");
            // }

            //Method syntax
            students.Where(student => student.Address == "MM").Select(x => x.Name);
            //Anonymous type
            students.Where(student => student.Address == "MM").Select(x => new { x.RollNumber, x.Name });

            // foreach(var c in group)
            // {
            //     Console.Write(c.Key);
            //     foreach(var a in c)
            //     {
            //         Console.WriteLine($"-- {a.Name}");
            //     }
            // }

            var studentsGroupByCollege = from student in students
                                         group student by student.Address into studentsGroup
                                         where studentsGroup.Count() <= 2
                                         orderby studentsGroup.Key
                                         select studentsGroup;



            // foreach (var students1 in studentsGroupByCollege)
            // {
            //     Console.WriteLine($"{students1.Key}");
            //     foreach (var student in students1)
            //     {
            //         Console.WriteLine($"\t{student.RollNumber} - {student.Name}");
            //     }
            // }

            /*22nd Nov 2019 */
            //Imperative and Declarative
            int[] numbers = { 2, 3, 4, 5, 6, 7, 8, 9, 66, 556, 565 };

            // declarative way of programming

            var sum = numbers.Sum();

            //imperative way of progaramming -- looping

            int sum1 = 0;
            foreach (var num in numbers)
            {
                sum1 += num;
            }


            // LINQ -- Query Expression and Method Syntax
            //query Expression
            // var evenNumbers = (from number in numbers
            //                   where number%2 ==0 && number <20
            //                   select number).Sum(); 

            var evenNumbers = from number in numbers
                              where number % 2 == 0 && number < 20
                              orderby number ascending
                              select number;

            // foreach (var n in evenNumbers)
            // {
            //     Console.Write(n + " ");
            // }

            //method syntax
            //var evennumbersWithMethodSyntax = numbers.Where(number => number % 2 == 0).Select(x => x).Sum();

            #region Assignment 22nd Noc

            var path = @"D:\DotNetClasses\.NETClassesCotiviti\ShreyaShrestha\DemoFolder\Olympics_Athelete_Events.txt";
            var writePath = @"D:\DotNetClasses\.NETClassesCotiviti\ShreyaShrestha\DemoFolder\Output.txt";

            // 1. List all the players participated from our country.
            var playersParticipatedFromNepal = FileReader.GetAtheletes(path).Where(x => x.Team == "Nepal").Select(x => new { x.Team, x.Name });
            // using (StreamWriter writer = new StreamWriter(writePath))
            // {
            // foreach (var player in playersParticipatedFromNepal)
            // {

            //     Console.SetOut(writer);
            //     Console.WriteLine(player);

            // }

            // }

            // 2. List all chinese players who have won the GOLD.
            var chinesePlayersWhoWonGold = FileReader.GetAtheletes(path).Where(x => x.Team == "China" && x.Medal == "Gold").Select(x => new { x.Team, x.Name, x.Medal });
            // using (StreamWriter writer = new StreamWriter(writePath))
            // {
            //     foreach (var player in chinesePlayersWhoWonGold)
            //     {

            //         Console.SetOut(writer);
            //         Console.WriteLine(player);

            //     }

            // }

            //3. List all players from USA and group them by sport they were in. Also order the result by sport.

            var americanPlayersGroupedBySport = from players in FileReader.GetAtheletes(path)
                                                where players.AbbrebiationOfNameOfCountry == "USA"
                                                group players by players.Sport into playerGroup
                                                orderby playerGroup.Key
                                                select playerGroup;


            // using(StreamWriter writer = new StreamWriter(writePath))
            // foreach (var player in americanPlayersGroupedBySport)
            // {
            //     Console.SetOut(writer);
            //     Console.WriteLine(player.Key);
            //     foreach (var p in player)
            //     {
            //         //Console.SetOut(writer);
            //         Console.WriteLine($"    {p.Name}");
            //     }
            // }

            // 4. List all countries with thier medal tally so far. Also, order the list by number of golds won.
            // string[] customOrder = { "Gold", "Silver", "Bronze", "NA" };
            // var countriesByMedal = FileReader.GetAtheletes(path).GroupBy(p => new { p.Team, p.Medal }).
            // Select(g => new
            // {
            //     team = g.Key.Team,
            //     medal = g.Key.Medal,
            //     count = g.Count(),
            //     goldCount = g.Where(x=>x.Medal == "Gold").Count()
            // }).OrderBy(x => Array.IndexOf(customOrder, x.medal)).ThenByDescending(x => x.goldCount);

            // using (StreamWriter writer = new StreamWriter(writePath))
            // {
            //     foreach (var v in countriesByMedal)
            //     {
            //         Console.SetOut(writer);
            //         Console.WriteLine($"{v.team} {v.medal} {v.count}");

            //     }
            // }


            var countriesByMedal = FileReader.GetAtheletes(path).GroupBy(p => p.Team).
                        Select(g => new
                        {
                            team = g.Key,
                            goldCount = g.Where(x => x.Medal == "Gold").Count(),
                            silverCount = g.Where(x => x.Medal == "Silver").Count(),
                            BronzeCount = g.Where(x => x.Medal == "Bronze").Count(),
                        }).OrderByDescending(x => x.goldCount);



            using (StreamWriter writer = new StreamWriter(writePath))
            {
                foreach (var v in countriesByMedal)
                {
                    Console.SetOut(writer);
                    Console.WriteLine($"{v.team}");
                    Console.WriteLine($"Gold:{v.goldCount} Silver:{v.silverCount} Bronze:{v.BronzeCount}");


                }
            }
            #endregion

            #region 25th Nov 2019
            //Joining
            var faculties = Collections.FetchFaculties();
            var depStudents = from student in students
                              join faculty in faculties on student.FacultyId equals faculty.Id
                              select new { Department = faculty.FacultyName, Student = student };

            var depStudentsGroupedByFacultyId = from x in depStudents group x by x.Department;

            // foreach (var item in depStudentsGroupedByFacultyId)
            // {
            //     Console.WriteLine($"{item.Key}");
            //     foreach (var s in item)
            //         Console.WriteLine($"\t{s.Student.RollNumber} - {s.Student.Name}");
            // }
            #endregion

        }
    }
}
