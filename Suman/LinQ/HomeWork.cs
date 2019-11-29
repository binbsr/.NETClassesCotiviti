using System;
using System.Collections.Generic;
using System.Linq;

class HomeWork
{
    public static void NepalPlayer(List<Player> players)
    {
        var x = from player in players
        where player.Team == "NEPAL"
        select new { player.ID, player.Name};
        foreach(var n in x)
        Console.WriteLine(n.ID + " "+ n.Name);
    }
    public static void ChinesePlayerWonGold(Player[] players)
    {

    }
    public static void USAPlayer(Player[] players)
    {

    }
    public static void CountriesMedal(Player[] players)
    {

    }
}