using System;
using System.Linq;
using System.Collections.Generic;
using LinQ;
using System.IO;

class Program
{
    public static void Main(string[] args)
    {
        //Imperative and Declarative
        int[] numbers = { 2, 3, 4, 5, 6, 7, 8, 9, 66, 556, 565 };


        //imperative way of progaramming -- looping
        int sum = 0;
        foreach (var num in numbers)
        {
            sum += num;
        }

        // declarative way of programming
        //var sum = numbers.Sum();


        // LINQ -- Query Expression and Method Syntax
        //query Expression
        var evenNumbers = from number in numbers
                          where number % 2 == 0 && number < 20
                          orderby number descending
                          select number;

        // method syntax
        var evenNumbersWithMethodSyntax = numbers.Where(number => number % 2 == 0).Select(x => x);

        foreach (var n in evenNumbers)
        {
            Console.Write(n + " ");
        }

        var students = Collections.GetListOfStudents();

        var y = from student in students
                where student.CollegeName == "MM"
                select student.Name;

        var y1 = from student in students
                 where student.CollegeName == "MM"
                 orderby student.Name ascending
                 select new { student.RollNumber, student.Name };



        var y2 = students.Where(student => student.CollegeName == "MM").Select(x => x.Name);

        var y3 = students.Where(student => student.CollegeName == "MM").Select(x => new { x.RollNumber, x.Name });

        Console.WriteLine($"RollNumber      Name");
        foreach (var n in y1)
        {
            Console.WriteLine($"{n.RollNumber}      {n.Name}");
        }

        var studsGroupedByCollege = from student in students
                                    group student by student.CollegeName into studentsGroup
                                    where studentsGroup.Count() <= 2
                                    orderby studentsGroup.Key
                                    select studentsGroup;


        Console.WriteLine($"Students by college");
        foreach (var studs in studsGroupedByCollege)
        {
            Console.WriteLine($"{studs.Key}");
            foreach (var stud in studs)
            {
                Console.WriteLine($"\t{stud.Name}");
            }

        }
        //var a1 = new Athelete();
        // var e1 = new OlympicsAtheletesEvent("China","CHN","1992 Summer",1992,"Summer","Barcelona","Basketball","Basketball Men's Basketball","NA");

        /*List<OlympicsAtheletesEvent> atheletesEvents= new List<OlympicsAtheletesEvent>();
           atheletesEvents.Add(new OlympicsAtheletesEvent { Id=1,Name="Nitin",Sex='M',Age=30,Height="123",Weight="70",Team="Nepal",NOC="NEP",Games ="1992 Summer",Year =1992,
           Season="Summer",City="Barcelona",Sport="Basketball",Event="Basketball Men's Basketball",Medal="NA"});
           atheletesEvents.Add(new OlympicsAtheletesEvent { Id=2,Name="MAX",Sex='M',Age=30,Height="123",Weight="70",Team="United State of America",NOC="USA",Games ="1992 Summer",Year =1992,
           Season="Summer",City="Barcelona",Sport="Basketball",Event="Basketball Men's Basketball",Medal="NA"});
       */
  /*      string folderPath = @"D:\dotnet_classes\files";
        FileIO fileIO = new FileIO();
        string filePath1 = Path.Combine(folderPath, "NepaliAtheletesList.txt");
        string filePath2 = Path.Combine(folderPath, "ChineseAtheletesList.txt");
        string filePath3 = Path.Combine(folderPath, "USAAtheletesList.txt");
        string filePath4 = Path.Combine(folderPath, "MedalTally.txt");

        var atheletesEvents = EventLists.OlympicsAtheletesEvent();

        // for printing in console 
        // 1. List all the players participated from our country. 

        var nepaliAtheletes = (from ath in atheletesEvents
                              where ath.NOC == "NEP"
                              select new { ath.Id, ath.Name }).Distinct();

        Console.WriteLine("List of Nepali Atheletes");

        foreach (var n in nepaliAtheletes)
        {
            Console.WriteLine($"{n.Id} {n.Name} ");
        }
        Console.WriteLine($"Total is {nepaliAtheletes.Count()}");

        // for printing in console 
        // 2. List all chinese players who have won the GOLD. 

        var chineseAtheletes = from ath in atheletesEvents
                               where ath.NOC == "CHN" && ath.Medal == "Gold"
                               select new { ath.Id, ath.Name };

        Console.WriteLine("List of Chinese Atheletes who won gold medal");

        foreach (var n in chineseAtheletes)
        {
            Console.WriteLine($"{n.Id} {n.Name} ");
        }
        Console.WriteLine($"Total is {chineseAtheletes.Count()}");

        // for printing in console 
        // 3. List all players from USA and group them by sport they were in. Also order the result by sport.

        var americanAtheletesGroup = from ath in atheletesEvents
                                     where ath.NOC == "USA"
                                     group ath by ath.Sport into atheletesGroup
                                     orderby atheletesGroup.Key
                                     select atheletesGroup;

        Console.WriteLine("List of American Atheletes group by sport");

        foreach (var americanAtheletes in americanAtheletesGroup)
        {
            Console.WriteLine($"{americanAtheletes.Key} total atheletes {americanAtheletes.Count()}");
            foreach (var americanAthelete in americanAtheletes)
            {
                Console.WriteLine($"\t{americanAthelete.Id} {americanAthelete.Name}");
            }
        }
        

        // for printing in console 
        // 4. List all countries with thier medal tally so far. Also, order the list by number of golds won.

        var goldTally = from ath in atheletesEvents
                                    where ath.Medal=="Gold"
                                     group ath by ath.Team into atheletesTeam
                                     orderby atheletesTeam.Key descending
                                     select new { Team = atheletesTeam.Key, GoldCount = atheletesTeam.Count()};
                                     
        var silverTally = from ath in atheletesEvents 
                                    where ath.Medal=="Silver"
                                     group ath by ath.Team into atheletesTeam
                                     orderby atheletesTeam.Key descending
                                     select new { Team = atheletesTeam.Key,SilverCount = atheletesTeam.Count()};

        var bronzeTally = from ath in atheletesEvents
                                    where ath.Medal=="Bronze"
                                     group ath by ath.Team into atheletesTeam
                                     orderby atheletesTeam.Key descending
                                     select new { Team = atheletesTeam.Key, BronzeCount = atheletesTeam.Count()};

         var goldSilverTally = from g in goldTally
                        join s in silverTally
                        on g.Team equals s.Team
                        into gsg 
                            from goldSilverGroup in gsg
                            orderby g.GoldCount
                            select new {
                                            Team = goldSilverGroup.Team, GoldCount = g.GoldCount, SilverCount = goldSilverGroup.SilverCount}; 

         var medalTally = from gs in goldSilverTally
                        join b in bronzeTally
                        on gs.Team equals b.Team
                        into mg 
                            from medalGroup in mg
                            orderby gs.GoldCount descending
                            select new {
                                            Team = medalGroup.Team, GoldCount = gs.GoldCount, SilverCount = gs.SilverCount, BronzeCount = medalGroup.BronzeCount};                                        

        Console.WriteLine("List of Medal Tally");
        Console.WriteLine("Country Name         Gold            Silver          Bronze");

        foreach (var medal in medalTally)
        {
          //  Console.WriteLine($"{medal.Team}     {medal.GoldCount}");
           Console.WriteLine($"{medal.Team}         {medal.GoldCount}           {medal.SilverCount}         {medal.BronzeCount}");
            
        }

        
        // for writing in file
        // 1. List all the players participated from our country.
       // var nepAthelete =  nepaliAtheletes.ToArray();

         string[] nameList = new string[1000] ;  
         int i = 0;
        foreach (var n in nepaliAtheletes)
        {
           nameList[i] = $"{n.Id.ToString()} {n.Name}";
           i++;              
        } 
        fileIO.CreateFile(filePath1,nameList);
       

       // for writing in file
       // 2. List all chinese players who have won the GOLD. 
         string[] chineseList = new string[1000] ;  
         int j = 0;
        foreach (var n in chineseAtheletes)
        {
           chineseList[j] = $"{n.Id.ToString()} {n.Name}";
           j++;              
        } 
        fileIO.CreateFile(filePath2,chineseList);

        // for writing in file
       //  3. List all players from USA and group them by sport they were in. Also order the result by sport.
         string[] americanList = new string[100000] ;  
         int k = 0;
         foreach (var americanAtheletes in americanAtheletesGroup)
        {
           americanList[k] = $"{americanAtheletes.Key} total atheletes {americanAtheletes.Count()}";
            foreach (var americanAthelete in americanAtheletes)
            {
                k++;
                americanList[k] = $"\t{americanAthelete.Id} {americanAthelete.Name}";
            }
           k++;              
        } 
        fileIO.CreateFile(filePath3,americanList);

         // for writing in file
       //  4. List all countries with thier medal tally so far. Also, order the list by number of golds won.
         string[] medalList = new string[1000] ;  
         int l = 2;
         medalList[0] = "                           List of Medal Tally";
         medalList[1] = "Country Name                   Gold        Silver      Bronze";

        foreach (var medal in medalTally)
        {
          //  Console.WriteLine($"{medal.Team}     {medal.GoldCount}");
            medalList[l] = $"{medal.Team}                   {medal.GoldCount}       {medal.SilverCount}     {medal.BronzeCount}";
            l++;              
        } 
        fileIO.CreateFile(filePath4,medalList);

*/

        // Joining 

        var faculties = Collections.GetListOfFaculties();
        var depStudents = from student in students
                            join faculty in faculties on student.FacultyId equals faculty.Id
                            select new {Department = faculty.FacultyName, student = student};

        
        var depStudentGroupedByFacultyId = from x in depStudents
                                            group x by x.Department;
                                            
        foreach (var item in depStudents)
        {
            Console.WriteLine($"{item.Department} {item.student.Name}");
            
        }
         
         foreach (var item in depStudentGroupedByFacultyId)
        {
            Console.WriteLine($"{item.Key}");
            foreach (var s in item)
            {
                Console.WriteLine($"\t{s.student.RollNumber} -- {s.student.Name}");
            }
            
        }


       





    }
}