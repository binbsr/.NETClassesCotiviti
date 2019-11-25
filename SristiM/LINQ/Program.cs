using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LINQ {
    class Program {
        static void Main (string[] args) {
            //LINQ-Language Integrated Query
            //Example-1
            string[] names = { "Sristi", "Ayushma", "Shreya" };
            var orderedNames = names.OrderBy (x => x); //lamda expression, arrow operation, x (individual item)goes to x as there is one parameter 
            var namesFiltered = names.Where (x => x.StartsWith ("S")); //filter name starting with S

            // foreach (var name in namesFiltered) {
            //     Console.WriteLine (name);

            // }

            //Example-2
            // var students = Collections.FetchStudent ();
            // var result = from student in students
            // //where students.CollgeName="KU"
            // group student by student.CollegeName into studentGroup
            // orderby studentGroup.Key
            // select studentGroup;

            // foreach (var x in result) {
            //     //System.Console.WriteLine (x.Key);
            //     foreach (var s in x) {
            //         System.Console.WriteLine (x.Key + "--" + s.Name);

            //     }
            //}
            //------------------------------------Nov-22 class--------------------------------------------------
            // int[] numbers = { 18, 2, 3, 4, 5, 6, 7, 8, 99, 104 };

            // //Declarative
            // var sum = numbers.Sum ();

            // //Imperative
            // int sum1 = 0;
            // foreach (var num in numbers) {
            //     sum1 += num;
            // }

            // Console.WriteLine ($"The sum of listed integers is {sum1}");

            // //Linq -  Query Expressions and method syntax
            // var evenNumber = from number in numbers
            // where number % 2 == 0 && number < 20
            // orderby number ascending
            // select number;

            // foreach (var n in evenNumber) {
            //     Console.WriteLine (n);
            // }

            // //Method syntax
            // //  Console.WriteLine ("The even numbers less than 20 are");
            // // var evenNumbersWithMethodSyntax = numbers.Where (numbers => numbers % 2 == 0).Select (x => x);

            // //   foreach (var n in evenNumbersWithMethodSyntax) {
            // //     Console.WriteLine (n);
            // // }
            // Console.WriteLine ();

            // // extract the student details from college TU
            // var students = Collections.FetchStudent ();
            // var y = from student in students
            // where student.CollegeName == "KU"
            // orderby student.Name descending
            // //select student.Name;
            // select new { student.RollNo, student.Name }; //anonymous type

            // Console.WriteLine ($"Roll No.  Name");
            // foreach (var n in y) {
            //     Console.WriteLine ($"{n.RollNo}        {n.Name}");
            // }

            // //Using method syntax for the same i.e. to extract the student details from college TU
            // // Console.WriteLine();
            // // Console.WriteLine ("Student from college TU using Method");            
            // // var methodStudents=students.Where (student => student.CollegeName == "TU").Select (x => x.Name);
            // //  foreach (var n in methodStudents) {
            // //     Console.WriteLine ($" {n}");
            // // }
            // // Console.WriteLine();

            // //Using group by
            // var studentGroupedByCollege = from student in students
            // group student by student.CollegeName into studentsGroup
            // where studentsGroup.Count () <= 2
            // orderby studentsGroup.Key
            // select studentsGroup;

            // foreach (var studs in studentGroupedByCollege) //studs is itself collection of students
            // {
            //     Console.WriteLine ($" Collge with less than 2 student -{studs.Key} have given list of students:");
            //     foreach (var stud in studs) {
            //         Console.WriteLine ($"\t{stud.RollNo} - {stud.Name}");
            //     }

            // }

            // Console.WriteLine ();
            // Console.WriteLine ();
            // Console.WriteLine ();

            //------------------------------------------------Nov-22 Assignment----------------------------

            // string FilePath = @"D:\DotNetTraining\.NETClassesCotiviti\BishnuRawal\Homework\Nov22_Excercise\Olympics_Athelete_Events.txt";
            // // var p = new FetchPlayers ();
            // // var pl = p.LoadPlayerData (FilePath);
            // var pl = FetchPlayers.LoadPlayerData (FilePath);

            // //------------------------1.List all the players participated from our country.
            // var ply = (from player in pl where player.Team == "Nepal"
            //     select player).Take (100);

            // Console.WriteLine ("The list of players in Nepal are: ");
            // foreach (var plyr in ply) {
            //     Console.WriteLine ($"{plyr.ID} - {plyr.Name} ");
            // }

            // Console.WriteLine ();
            // Console.WriteLine ();

            // //-------------------------2.List all chinese players who have won the GOLD.
            // var plyrChina = (from player in pl where player.Team == "China" && player.Medal == "Gold"
            //     select player).Take (100);
            // Console.WriteLine ("The list of players in China who won gold medal are are: ");
            // foreach (var plyr in plyrChina) {
            //     Console.WriteLine ($"{plyr.ID} - {plyr.Name} ");
            // }

            // Console.WriteLine ();
            // Console.WriteLine ();

            // //-------------------------3.List all players from USA and group them by sport they were in. Also order the result by sport.
            // var plyrUSA = (from player in pl where player.Team == "United States"
            //     group player by player.Sport into USAPlayerGroup orderby USAPlayerGroup.Key select USAPlayerGroup);
            // Console.WriteLine ("The list of USA players grouped as per their sport are:");
            // foreach (var plyrs in plyrUSA) //studs is itself collection of students
            // {
            //     Console.WriteLine ();
            //     Console.WriteLine ($" USA players as per the Sport -{plyrs.Key} has given list of players:");
            //     foreach (var plyr in plyrs.Take (3)) {
            //         Console.WriteLine ($"{plyrs.Key} : {plyr.ID} - {plyr.Name}");
            //     }
            // }

            // //----------------------As the output rows is huge(15000 lines), writing the content in file
            // using (StreamWriter writer = new StreamWriter (@"D:\DotNetTraining\.NETClassesCotiviti\SristiM\DemoFolder\USA_Sports_Players.txt"))
            // foreach (var country in plyrUSA)
            //     foreach (var plyrs in plyrUSA) //studs is itself collection of students
            // {
            //     writer.WriteLine ();
            //     writer.WriteLine ($" USA players as per the Sport -{plyrs.Key} has given list of players:");
            //     foreach (var plyr in plyrs.Take (3)) {
            //         writer.WriteLine ($"{plyrs.Key} : {plyr.ID} - {plyr.Name}");
            //     }
            // }

            // Console.WriteLine ();
            // Console.WriteLine ();

            // //--------------------------4.List all countries with thier medal tally so far. Also, order the list by number of golds won.            
            // var countryMedalList = (from player in pl.Take (1000) where player.Medal == "Gold" ||
            //     player.Medal == "Silver" ||
            //     player.Medal == "Bronze"
            //     group player by new { player.Team, player.Medal } into GropingByCountryMedal orderby GropingByCountryMedal.Key.Team, GropingByCountryMedal.Key.Medal ascending select new { Team = GropingByCountryMedal.Key.Team, Medal = GropingByCountryMedal.Key.Medal, MedalCount = GropingByCountryMedal.Count () });
            // Console.WriteLine ("The list of countries along with their medal tally are:");
            // foreach (var country in countryMedalList) {

            //     Console.WriteLine ($"{country.Team} - {country.Medal} - {country.MedalCount} ");

            // }

            // Console.WriteLine ();
            // Console.WriteLine ();

            // //---------------------------- Also, order the list by number of golds won.        
            // var countryGoldMedalList = (from player in pl.Take (1000) where player.Medal == "Gold"
            //     group player by new { player.Team, player.Medal } into GropingByCountry orderby GropingByCountry.Count () descending, GropingByCountry.Key.Team ascending select new { Team = GropingByCountry.Key.Team, Medal = GropingByCountry.Key.Medal, MedalCount = GropingByCountry.Count () });
            // Console.WriteLine ("The list of countries along with their Gold medal tally are:");
            // foreach (var country in countryGoldMedalList) {
            //     Console.WriteLine ($"{country.Team} - {country.Medal} - {country.MedalCount}");
            // }

            //--------------------Nov-25 class------------------------------------------

            //Joining
            var students = Collections.FetchStudent ();
            var faculties = Faculty.FetchFaculties ();
            var depStudents = from student in students
            join faclty in faculties on student.FacultyId equals faclty.Id
            select new { Department = faclty.FacultyName, Student = student };

            var depStudentGroupedByFacultyId = from x in depStudents
            group x by x.Department;

            foreach (var dept in depStudentGroupedByFacultyId) {
                Console.WriteLine ($"{dept.Key}");
                foreach (var stud in dept) {
                    Console.WriteLine ($"{stud.Student.RollNo} - {stud.Student.Name}");
                }
            }
        }
    }
}