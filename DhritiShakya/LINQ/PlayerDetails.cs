using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
 
public class PlayerDetails
{
    public int ID{get; set;}
    public string Name{get; set;}
 
    public string Sex{get; set;}
 
    public string Age{get; set;}
 
    public string Height{get; set;}
 
    public string Weight{get; set;}
    public string Team{get; set;}
    public string NOC{get; set;}
 
    public string Games{get; set;}
 
    public string Year{get; set;}
 
    public string Season{get; set;}
 
    public string City{get; set;}
 
    public string Sport{get; set;}
 
    public string Event{get; set;}
 
    public string Medal{get; set;} 
}
 
public class PlayerData
{
    public List<PlayerDetails> FetchPlayers(string filename)
    {
        List<PlayerDetails> players = new List<PlayerDetails>();
        string[] lines = System.IO.File.ReadAllLines(filename);
        lines = lines.Skip(1).ToArray();
 
        foreach (string line in lines)
        {
            string[] data = line.Split(',');
            players.Add(new PlayerDetails(){
                 ID =  System.Convert.ToInt32(data[0]),
                    Name = data[1],
                    Sex = data[2],
                    Age = data[3],
                    Height = data[4],
                    Weight = data[5],
                    Team = data[6],
                    NOC = data[7],
                    Games = data[8],
                    Year = data[9],
                    Season = data[10],
                    Event = data[11],
                    City = data[12],
                    Sport = data[13],
                    Medal = data[14]
 
            });
 
           
        }
        return players;
    }
}

