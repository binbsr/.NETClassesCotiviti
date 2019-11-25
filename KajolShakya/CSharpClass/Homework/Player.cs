using System;
using System.Linq;
using System.Collections.Generic;

public class Player
{
   static void Main(string[] args)
   {
        string file = @"D:\\C#\\.NETClassesCotiviti\\KajolShakya\\CSharpClass\\Homework\\Olympics_Athelete_Events.txt";
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

        //List all the players participated from our country. 

        var playersGroupByCountry = from pc in players 
                                     where pc.Team == "Nepal"
                                     select pc;

        Console.WriteLine("Players of Nepal");
        foreach (var ply in playersGroupByCountry)
        {
            Console.WriteLine($"{ply.Name}");
          
        }

        //List all chinese players who have won the GOLD.

        var playersGroupByCountryAndMedal = from pm in players
                                            where pm.Team == "China" && pm.Medal =="Gold"
                                            select pm;

        Console.WriteLine("Chinese players who have won the Gold Medal.");
        foreach (var pl in playersGroupByCountryAndMedal)
        {
            Console.WriteLine($"{pl.Name}");
        }

        //List all players from USA and group them by sport they were in. Also order the result by sport.

        var playersGroupBySport = from ps in players  
                                        where ps.NOC == "USA"
                                        group ps by ps.Sport 
                                        into sportGroup
                                        orderby sportGroup.Key
                                        select sportGroup;

        foreach (var val in playersGroupBySport)
        {
            Console.WriteLine($"Group By Sport: {val.Key}");
            foreach (var v in val)
            {
                Console.WriteLine($"Player Name: {v.Name}");
            }
        }

        //List all countries with thier medal tally so far. Also, order the list by number of golds won.







        
                                        

   }
                
}