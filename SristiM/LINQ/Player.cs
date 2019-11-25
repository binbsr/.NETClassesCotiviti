//------------------------------------------------Nov-22 Assignment----------------------------

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Player {

    public int ID { get; set; }
    public string Name { get; set; }
    public char? Sex { get; set; }
    public int? Age { get; set; }
    public float? Height { get; set; }
    public float? Weight { get; set; }
    public string Team { get; set; }
    public string NOC { get; set; }
    public string Games { get; set; }
    public int? Year { get; set; }
    public string Season { get; set; }
    public string City { get; set; }
    public string Sport { get; set; }
    public string Event { get; set; }
    public string Medal { get; set; }

}

public class FetchPlayers {

    public static List<Player> LoadPlayerData (string fp) {
        List<Player> dataTable = File.ReadAllLines (fp).Skip (1).Select (x => Splitcolumns (x)).ToList ();
        return dataTable;
    }

    public static Player Splitcolumns (string eachLine) {
        var eachColumn = eachLine.Split (",");
        Player plyr = new Player ();
        plyr.ID = int.Parse (eachColumn[0]);
        plyr.Name = eachColumn[1];
        plyr.Sex = char.TryParse (eachColumn[2], out char s) ? s : (char?) null;
        plyr.Age = byte.TryParse (eachColumn[3], out byte a) ? a : (byte?) null;
        plyr.Height = int.TryParse (eachColumn[4], out int h) ? h : (int?) null;
        plyr.Weight = float.TryParse (eachColumn[5], out float w) ? w : (float?) null;
        plyr.Team = eachColumn[6];
        plyr.NOC = eachColumn[7];
        plyr.Games = eachColumn[8];
        plyr.Year = int.TryParse (eachColumn[9], out var y) ? y : (int?) null;
        plyr.Season = eachColumn[10];
        plyr.City = eachColumn[11];
        plyr.Sport = eachColumn[12];
        plyr.Event = eachColumn[13];
        plyr.Medal = eachColumn[14];
        return plyr;
    }

 
}