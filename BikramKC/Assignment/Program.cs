using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DataOperation dtOp = new DataOperation();
            string filePath = @"D:\DotNet\Olympics_Athelete_Events.txt";
            List<Player> dataTable = dtOp.LoadData(filePath);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{dataTable[i].iD}   {dataTable[i].name}   {dataTable[i].sex}   {dataTable[i].age}   {dataTable[i].height}   {dataTable[i].weight}   {dataTable[i].team}   {dataTable[i].noc}   {dataTable[i].games}   {dataTable[i].year}   {dataTable[i].season}   {dataTable[i].city}   {dataTable[i].sport}   {dataTable[i].evnt}    {dataTable[i].medal}");
            }
            // Print Nepali Players
           /* var nepaliPlayer = from plr1 in dataTable where plr1.team.ToLower() == "nepal" select new {plr1.name,plr1.team};

            Console.WriteLine("List of Nepali Player:");
            foreach (var item in nepaliPlayer)
            {
                 Console.WriteLine($"{item.name}    {item.team}");
            }
            var chineasePlayerWithGold = from plr1 in dataTable where plr1.team.ToLower() == "china" && plr1.medal.ToLower() == "gold" select new {plr1.name, plr1.medal};

            Console.WriteLine("List of Chinease Player who won Gold:");
            foreach (var item2 in chineasePlayerWithGold)
            {
                Console.WriteLine($"{item2.name}    {item2.medal}");
            }

            var usPlayer = from plr3 in dataTable  where plr3.noc.ToLower() == "usa" orderby  plr3.sport select new {plr3.name, plr3.sport};

            Console.WriteLine("List of US Player grouped by Sports and ordered by sports:");
            foreach (var item3 in usPlayer)
            {
                Console.WriteLine($"{item3.name}    {item3.sport}");
            }
            */
            var medalByCountry = from mdl in dataTable  group mdl by new {mdl.noc, mdl.medal} into plrGroup  select new {team = plrGroup.Key.noc , medal = plrGroup.Key.medal, cnt = plrGroup.Count()};

            Console.WriteLine("List of US Player grouped by Sports and ordered by sports:");
            foreach (var item3 in medalByCountry)
            {
                Console.WriteLine($"{item3.team}    {item3.medal}   {item3.cnt}");
            }
                
        }
    }
}
