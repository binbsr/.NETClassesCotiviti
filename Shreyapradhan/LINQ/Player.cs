using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Athelete
{
public class Player
{
    public int Id {get;set;}
    public string Name{get;set;}
    public string sex {get;set;}
    public string Age {get;set;}
    public string Height{get;set;}
    public string Weight{get;set;}
    public string TeamName{get;set;}
    public string NOC{get;set;}
    public string Games{get;set;}
    public string Year{get;set;}
    public string Season{get;set;}
    public string City{get;set;}
    public string Sport{get;set;}
    public string Event {get;set;}

    public string Medal{get;set;}



     public static List<Player> GetPlayers(string path)
        {
            List<Player> players = new List<Player>();
           var lines=FileOperation.ReadFiles(path);
            foreach(var line in lines)
            {
                
                List<string> playerlist=new List<string>();
                playerlist=line.Split(",").ToList();
                Player player = new Player();
                player.Id=int.Parse( playerlist[0]);
                player.Name=playerlist[1];
                player.sex=playerlist[2];
                player.Age = playerlist[3];
                player.Height=playerlist[4];
                player.Weight=playerlist[5];
                player.TeamName=playerlist[6];
                player.NOC=playerlist[7];
                player.Games=playerlist[8];
                player.Year=playerlist[9];
                player.Season=playerlist[10];
                player.City=playerlist[11];
                player.Sport=playerlist[12];
                player.Event=playerlist[13];
                player.Medal=playerlist[14];
                players.Add(player);
                //Console.WriteLine(playerlist[1]);
            }
            return players;

        }



    
}

    
    public  class FileOperation
    {
        
             public static void CreateFile (string path, string[] content)
        {
            File.WriteAllLines (path, content);
          
        }

        public static List<string> ReadFiles(string path)
        {
             var content=File.ReadAllLines(path);
            var lines = content.Skip(1).ToList();
            return lines;
        }

       

    }
}

