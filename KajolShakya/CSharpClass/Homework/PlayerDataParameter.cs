using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.VisualBasic.FileIO;


public class PlayerDataParameter
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
  /*  public List<PlayerDataParameter> FetchPlayers(string filename)
    {
        List<PlayerDataParameter> players = new List<PlayerDataParameter>();
        string[] lines = System.IO.File.ReadAllLines(filename);
        lines = lines.Skip(1).ToArray();

        foreach (string line in lines)
        {
            string[] data = line.Split(',');
            players.Add(new PlayerDataParameter(){
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
    } */



    public List<PlayerDataParameter> FetchPlayers(string file)
        {
        TextFieldParser parser = new TextFieldParser(file);
        
        parser.TextFieldType = FieldType.Delimited;
        parser.SetDelimiters(",");
        parser.CommentTokens = new string[] { "ID" };
        parser.HasFieldsEnclosedInQuotes = true;
            List<PlayerDataParameter> players = new List<PlayerDataParameter>();
           while (!parser.EndOfData)
            {
               var data = parser.ReadFields();
                players.Add(new PlayerDataParameter()
                {
                    ID = System.Convert.ToInt32(data[0]),
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




