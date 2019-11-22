using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Player
{
    public int? iD { get; set; }
    public string name { get; set; }
    public char? sex { get; set; }
    public byte? age { get; set; }
    public int? height { get; set; }
    public float? weight { get; set; }
    public string team { get; set; }
    public string noc { get; set; }
    public string games { get; set; }
    public int? year { get; set; }
    public string season { get; set; }
    public string city { get; set; }
    public string sport { get; set; }
    public string evnt { get; set; }
    public string medal { get; set; }
    
}
public class DataOperation
{
    public List<Player> LoadData(string fp)
    {
        List<Player> dataTable = File.ReadAllLines(fp).Skip(1).Select(x => SplitColumns(x)).ToList();
        return dataTable;
    } 
    public Player SplitColumns(string dataLine)
    {
        var dataRow = dataLine.Split(",");
        Player plr = new Player();
        plr.iD = int.Parse(dataRow[0]);
        plr.name = dataRow[1];        
        plr.sex = char.TryParse(dataRow[2], out var a) ? a : (char?) null;        
        plr.age = byte.TryParse(dataRow[3], out var b) ? b : (byte?) null;
        plr.height = int.TryParse(dataRow[4], out var c) ? c : (int?) null;
        plr.weight = float.TryParse(dataRow[5] , out var d) ? d : (float?) null;
        plr.team = dataRow[6];
        plr.noc = dataRow[7];
        plr.games = dataRow[8];
        plr.year = int.TryParse(dataRow[9], out var e) ? e  : (int?) null;
        plr.season = dataRow[10];
        plr.city = dataRow[11];
        plr.sport = dataRow[12];
        plr.evnt = dataRow[13];
        plr.medal = dataRow[14];
        return plr;
    }

    
}