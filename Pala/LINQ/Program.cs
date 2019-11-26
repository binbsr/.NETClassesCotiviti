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
           /*var students = Collections.FetchStudents();
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
            }*/
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
            //joining 
            /*var faculties = Collections.fetchFaculty();
            var depStudents = from student in students
                            join faculty in faculties on student.facultyId equals faculty.Id
                            select new {Department = faculty.facultyName, Student = student  };// faculty name and student object 
            var depStudentGroupedByFacultyId = from x in depStudents
                                               group x by x.Department;
            //student Faculty name and student name 
             foreach(var item in depStudents)
            {
                Console.WriteLine($"{item.Department} - {item.Student.Name}");
            }                                  
            foreach(var item in depStudentGroupedByFacultyId)
            {
                Console.WriteLine($"{item.Key}");
                foreach (var s in item)
                {
                    Console.WriteLine($"\t{s.Student.rollNo} - {s.Student.Name}");
                }
            }*/

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

                Console.WriteLine($"\t{chinList.Name}");

            }
            //3.List all players from USA and group them by sport they were in Also order the result by sport.
            var usaPlayers = PlayerCollections.PlayerList();
            var usPlayers = from usa in usaPlayers
                            where usa.NOC == "USA" 
                            group usa by usa.Sport into usaSportGroupList
                            orderby usaSportGroupList.Key
                            select usaSportGroupList;
            //Console.WriteLine(usPlayers);
            foreach (var usPlayer in usPlayers)
            {
                Console.WriteLine($"{usPlayer.Key} total atheletes {usPlayer.Count()}");
                foreach (var usaPlayList in usPlayer)
                {
                    Console.WriteLine($"\t{usaPlayList.Id} {usaPlayList.Name}");
                }
            }

            //4.List all countries with thier medal tally so far. Also, order the list by number of golds won.
            PlayerCollections pc1 = new PlayerCollections(); 
            var PlayersGold = PlayerCollections.PlayerList();
            var goldPlayer = from countries in PlayersGold
                             where countries.Medal == "Gold"
                             group countries by countries.Team into groupList
                             orderby groupList.Key descending
                             select new { countryName = groupList.Key,goldCount = groupList.Count()};
            Console.WriteLine($"countryName         GoldCount");              
            /*foreach (var item in goldPlayer)
            {
                 Console.WriteLine($"{item.countryName}     {item.goldCount}");
            }   */
            var PlayersSilver = PlayerCollections.PlayerList();
            var silverPlayer = from countries in PlayersSilver
                               where countries.Medal == "Silver"
                               group countries by countries.Team into groupList
                               orderby groupList.Key descending
                               select new {countryName = groupList.Key,silvercount = groupList.Count()};
            Console.WriteLine($"countryName         SilverCount"); 
            foreach (var item in silverPlayer)
            {
                Console.WriteLine($"{item.countryName} ----   {item.silvercount}");
            }
            var PlayersBronze = PlayerCollections.PlayerList();
            var bronzePlayer = from countries in PlayersBronze
                               where countries.Medal == "Bronze"  
                               group countries by countries.Team into groupList
                               orderby groupList.Key descending
                               select new {countryName= groupList.Key, bronzeCount = groupList.Count()};    
            Console.WriteLine($"countryName         Bronzecount");  
            foreach(var item in bronzePlayer)
            {
                Console.WriteLine($"{item.countryName}        {item.bronzeCount}");
            }
        }
    }
}
            
