using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace Athelete
{
    public class Athelete
    {
        static void Main(string[] args)
        {
             string filePath = @"D:\\\\dotNet\\\\.NETClassesCotiviti\\\\Shandipta\\\\ChsarpClass\\\\Assignments\\\\t.txt";
          //  string filePath = @"D:\\dotNet\\.NETClassesCotiviti\\Shandipta\\ChsarpClass\\Assignments\\Olympics_Athelete_Events.txt";
            AtheleteData athData = new AtheleteData();
            var ath = athData.GetAtheleteData(filePath);

            //List all the players participated from our country.
            var nepaliPlayers = from p in ath 
            where p.noc=="NEP"
            select p;
            foreach(var p in nepaliPlayers){
                Console.WriteLine(p.name);
            }

            //List all chinese players who have won the GOLD.
            var chinesePlayers = from p in ath
            where p.noc=="CHN" && p.medal=="Gold" 
            select p;
             foreach(var p in chinesePlayers){
                Console.WriteLine(p.name);
            }
            

            //List all players from USA and group them by sport they were in. Also order the result by sport.
            var players = from p in ath
            where p.noc == "USA"
        group p by p.sport into sportGroup 
                          orderby sportGroup.Key
                          select sportGroup;
            
                   foreach (var val in players)
            {

                Console.WriteLine($"Group By Sport: {val.Key}");

                foreach (var v in val)
                {
                    Console.WriteLine($"Athelete Name: {v.name}");
                }
            }


            //List all countries with thier medal tally so far. Also, order the list by number of golds won.

var result = ath.Where(ath=>ath.medal!="NA")
    .GroupBy(p => new { p.team, p.medal })
    .Select(g => new 
    {
        team = g.Key.team,
        medal = g.Key.medal,
        count = g.Count()
      
    }).OrderByDescending(g=>g.count);

    foreach(var v in result)    {

         Console.WriteLine($"{v.team} {v.medal} {v.count}");

    }

        }
    }
}