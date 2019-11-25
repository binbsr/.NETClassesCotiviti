using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.VisualBasic.FileIO;

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
public class MedalTable
{
    public string country { get; set; }
    public int goldCount { get; set; }
    public int silverCount { get; set; }
    public int bronzeCount { get; set; }

    // Question No 4
    public List<MedalTable> GetMedalTable(List<Player> dataTable)
    {
        var res = from a in dataTable
                   group a by a.noc into b
                   select new MedalTable
                   {
                       country = b.Key,
                       goldCount = b.Select(x => new
                       {
                           x.team,
                           x.medal
                       }).Where(y => y.medal.ToLower() == "gold").Count(),
                       silverCount = b.Select(x => new
                       {
                           x.team,
                           x.medal
                       }).Where(y => y.medal.ToLower() == "silver").Count(),
                       bronzeCount = b.Select(x => new
                       {
                           x.team,
                           x.medal
                       }).Where(y => y.medal.ToLower() == "bronze").Count()
                   };
        return res.ToList();
    }
    public void WriteToFile(List<MedalTable> dataTable, string fp)
    {
        StreamWriter sw = new StreamWriter(fp);
        sw.WriteLine(string.Join(",", "Country", "Total Gold", "Total Silver", "Total Bronze"));
        foreach (var item in dataTable.OrderByDescending(x => x.goldCount))
        {
            sw.WriteLine(string.Join(",", item.country, item.goldCount, item.silverCount, item.bronzeCount));
        }
        sw.Flush();
        sw.Close();
    }

}
public class DataOperation
{
    public static List<Player> dataTable;
    public List<string> PlayerList { get; set; }
    public string sport { get; set; }
    /*
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
        plr.sex = char.TryParse(dataRow[2], out var a) ? a : (char?)null;
        plr.age = byte.TryParse(dataRow[3], out var b) ? b : (byte?)null;
        plr.height = int.TryParse(dataRow[4], out var c) ? c : (int?)null;
        plr.weight = float.TryParse(dataRow[5], out var d) ? d : (float?)null;
        plr.team = dataRow[6];
        plr.noc = dataRow[7];
        plr.games = dataRow[8];
        plr.year = int.TryParse(dataRow[9], out var e) ? e : (int?)null;
        plr.season = dataRow[10];
        plr.city = dataRow[11];
        plr.sport = dataRow[12];
        plr.evnt = dataRow[13];
        plr.medal = dataRow[14] == "NA" ? null : dataRow[14];
        return plr;
    }
    */
    public List<Player> TextParser(string fp)
    {
        TextFieldParser parser = new TextFieldParser(fp);
        parser.TextFieldType = FieldType.Delimited;
        parser.SetDelimiters(",");
        parser.CommentTokens = new string[] { "ID" };
        parser.HasFieldsEnclosedInQuotes = true;
        List<Player> playerList = new List<Player>();
        while (!parser.EndOfData)
        {
            var dataRow = parser.ReadFields();
            Player plr = new Player();
            plr.iD = int.TryParse(dataRow[0], out var x) ? x : (int?)null;
            plr.name = dataRow[1].Replace("\"", "");
            plr.sex = char.TryParse(dataRow[2], out var a) ? a : (char?)null;
            plr.age = byte.TryParse(dataRow[3], out var b) ? b : (byte?)null;
            plr.height = int.TryParse(dataRow[4], out var c) ? c : (int?)null;
            plr.weight = float.TryParse(dataRow[5], out var d) ? d : (float?)null;
            plr.team = dataRow[6];
            plr.noc = dataRow[7];
            plr.games = dataRow[8];
            plr.year = int.TryParse(dataRow[9], out var e) ? e : (int?)null;
            plr.season = dataRow[10];
            plr.city = dataRow[11];
            plr.sport = dataRow[12];
            plr.evnt = dataRow[13];
            plr.medal = dataRow[14];
            playerList.Add(plr);

        }
        return playerList;

    }
    // Question no 1 : 
    public List<Player> GetNepaliPlayer(List<Player> dataTable)
    {
        var nepPlayers = dataTable.Where(x => x.noc.ToLower() == "nep").ToList();
        return nepPlayers;
    }
    // Question No 2:
    public List<Player> GetChineaseWithGold(List<Player> dataTable)
    {
        var chnPlayers = dataTable.Where(x => x.noc.ToLower() == "chn" && x.medal.ToLower() == "gold").ToList();
        return chnPlayers;
    }
    // Question No 3:
    public List<DataOperation> GetUSPlayer(List<Player> dataTable)
    {
        var usPlayers = from a in dataTable
                        where a.noc.ToLower() == "usa"
                        group a by a.sport into grp
                        orderby grp.Key
                        select new DataOperation
                        {
                            sport = grp.Key,
                            PlayerList = grp.Select(x => x.name).ToList()

                        };
        return usPlayers.ToList();

    }
    public void WriteToFile(List<Player> dataTable, string fp)
    {
        StreamWriter sw = new StreamWriter(fp);
        sw.WriteLine(string.Join(",", "Team Name", "Player Name", "Sport", "Medal"));
        foreach (var item in dataTable)
        {
            sw.WriteLine(string.Join(",", item.team, item.name, item.sport, item.medal));
        }
        sw.Flush();
        sw.Close();
    }
    public void WriteToFile(List<DataOperation> dataTable, string fp)
    {
        StreamWriter sw = new StreamWriter(fp);
        sw.WriteLine(string.Join(",", "Sports", "Player Name"));
        foreach (var item in dataTable)
        {
            sw.WriteLine(item.sport);
            foreach (var plr in item.PlayerList)
            {
                sw.WriteLine($", \"{plr}\"");

            }
        }
        sw.Flush();
        sw.Close();
    }

}
