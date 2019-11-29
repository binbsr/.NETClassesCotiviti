using AssignmentLinq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace cSharpLinq
{
    class Program
    {
       /* static void Main(string[] args)
        {
           Console.WriteLine("Hello World!");
            

           /* LINQ is language integrated language
             * 
             * programming language type:
             * 
             * IMPERETIVE  --> it is step by step approach.Like Loop
             * example: 
                
                int[] number = { 2, 3, 4, 5, 6, 7, 8, 9,18,16,20,22 };
            //sum=sum of all array item using loop

            // DECLARATIVE
            //sum = number.Sum();        // here Sum( ) is inbuilt funtion given by Linq language

            //  Way to use LINQ
            //   1.  Query Expressions   --> start with FROM and ends with SELECT

            // get even numbers from number [] 
            var evenNumber = (from num in number
                              where num % 2 == 0 && num < 20 
                              orderby num ascending
                              select num);

          //  2.Method Syntax
                var evenNumber1 = number.Where(num=>num%2==0).Select(x=>x);

            foreach (var n in evenNumber)
            {
                Console.Write(n + " ");
            }

            Console.Write('\n');

            var students=Collections.FetchStudents();

            var a = from student in students
                    where student.CollegeName == "mbm"
                    orderby student.Name ascending
                    select student;

            var stdGroupBy = from std1 in students
                             group std1 by std1.CollegeName into groupStudent
                             where groupStudent.Count()<=2
                             orderby groupStudent.Key
                             select groupStudent;

            /*   var b = from student in students
                       where student.CollegeName == "mbm"
                       select new { student.RollNo, student.CollegeName };     

            // this will give roll no and college name

            students.Where(stdnt => stdnt.CollegeName == "mbm").Select(x => x.Name);

            //  students.Where(stdnt => stdnt.CollegeName == "mbm").Select(x=>new { x.RollNo, x.CollegeName });

            Console.WriteLine("Roll No    Name");
            foreach (var n in a)
            {
                Console.WriteLine($"{n.RollNo}          {n.Name}");
            }

            Console.WriteLine("\n");
            foreach (var i in stdGroupBy)
            {
                Console.WriteLine($"{i.Key}");
                foreach (var j in i)
                {
                    Console.WriteLine($"\t{j.RollNo}      {j.Name}        {j.CollegeName}");
                }
            }

        }     */  
    
        static void Main(string [] args)
        {
                 Player player1 = new Player();
                 List<Player> p1 = new List<Player>();
                 p1 = player1.SetTextLineToList();

                Console.WriteLine("Player From our country");

                var playerFromOutCountry = from player in p1
                                           where player.Noc == "CHN"  && player.Medal=="Gold"
                                           select new { player.Id, player.Name, player.Medal};

                 foreach (var i in playerFromOutCountry)
                 {
                     Console.WriteLine($"{i.Id}      {i.Name}       {i.Medal}");

                 }      

                Console.WriteLine(playerFromOutCountry.Count());

/*                var plyrFromChinaGold = from player in p1
                                        where player.Team == "China" && player.Medal == "Gold"
                                        select new { player.Id, player.Name, player.Noc};
                foreach (var i in plyrFromChinaGold)
                { 
                    Console.WriteLine($"{i.Id}      {i.Name}    {i.Noc}");

                }

                Console.WriteLine("Player From USA Group by Sports");
                var plyrFromUSA = from player in p1
                                  where player.Noc == "USA"
                                  group player by player.Sport into playerUSAGroup
                                  orderby playerUSAGroup.Key
                                  select playerUSAGroup;
                foreach (var playerUSAGroupBySports in plyrFromUSA)
                {
                    foreach (var i in playerUSAGroupBySports)
                    {
                        Console.WriteLine($"{i.Name}    {i.Sport}");
                    }
                }

           var countryListWithMedalTally = from player in p1
                                           group player by player.Medal into playerListGroupbyMedal
                                           orderby playerListGroupbyMedal.Key descending
                                           select playerListGroupbyMedal;

               foreach (var playerListGroupbyMedal in countryListWithMedalTally)
               {
               //Console.WriteLine(playerListGroupbyMedal.Key);
                   foreach (var i in playerListGroupbyMedal)
                   {
                       Console.WriteLine($"{i.Team}    {i.Medal}");
                   }
               }

           

            var medalCountNepal = from medalCount in p1
                                  where medalCount.Team=="China" && medalCount.Medal== "Bronze"
                                  group medalCount by medalCount.Team into countMedal
                                  select countMedal;

            foreach (var i in medalCountNepal)
            {
                Console.WriteLine(medalCountNepal.Count());
            }
            

            var goldMedalistCountry = from listCountry in p1
                                          group listCountry by listCountry.Noc into listofCountrywithGoldMedal
                                          where listofCountrywithGoldMedal.Key == "Gold"
                                          select listofCountrywithGoldMedal.Count();
            foreach (var listofCountrywithGoldMedal in goldMedalistCountry)
            {
                foreach (var i in listofCountrywithGoldMedal)
                {
                    Console.WriteLine($"{i.Team}        {i.Medal}");
                }
            }   */


       // JOINING

       var student = Collections.FetchStudents();
       var faculty = Collections.FetchFacutly();
       var depStudents = from std1 in student
                         join fac in faculty on std1.FactultyId equals fac.FacultyId
                         select new { std1.Name, std1.CollegeName, fac.FacultyName, fac.FacultyHead, std1.RollNo };

       foreach (var i in depStudents)
       {
           Console.WriteLine($"{i.Name}    {i.CollegeName}     {i.FacultyName}     {i.FacultyHead}");
       }

       var deptStudentGroupByFacutlyId = from x in depStudents
                                         group x by x.FacultyName;

       foreach (var item in deptStudentGroupByFacutlyId)
       {
           Console.WriteLine($"{item.Key}");
           foreach (var i in item)
           {
               Console.WriteLine($"\t{i.Name}      {i.RollNo}");
           }
       }
       
        }
    }
}
