using System;
using System.Linq;
using System.Collections.Generic;
 
public class Player
{
   static void Main(string[] args)
   {
        string file = @"D:\C#\.NetClassesCotiviti\DhritiShakya\Olympics_Athelete_Events.txt";
        PlayerData p = new PlayerData();
        var players = p.FetchPlayers(file);
        var result = from pp in players
                    group pp by pp.Name;
        foreach(var x in result)
            {
                System.Console.WriteLine(x.Key);
                foreach(var s in x)
                {
                    System.Console.WriteLine(s.ID);
                }
            }

            var playersGroupByCountry = from pc in players 
                                     where pc.Team == "Nepal"
                                     select pc;
 
        Console.WriteLine("Players of Nepal");
        foreach (var pl in playersGroupByCountry)
        {
            Console.WriteLine($"{pl.Name}");
          
        }

        var playersWhoWonGold= from pc1 in players 
                            where pc1.Team=="China" && pc1.Medal=="Gold" 
                            select pc1;

        Console.WriteLine("Chinese players who won gold");
        foreach (var pl in playersGroupByCountry)
        {
            Console.WriteLine($"{pl.Name}");
          
        }
   }
}
 