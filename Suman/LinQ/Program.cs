using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
namespace LinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string path=@"D:\Training\.NETClassesCotiviti\Suman\list.txt";
            string [] PlayerList;
            PlayerList = File.ReadAllLines(path);
            List<Player> players = new List<Player>();
            for (int i=1; i<PlayerList.Length;i++)
            {
                players.Add(LoadThePlayer.LoadPlayer(PlayerList[i]));
            }
            HomeWork.NepalPlayer(players);
        }
    }
}
