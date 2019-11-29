using System;
using System.Collections.Generic;

class LoadThePlayer
{
    public static Player LoadPlayer(string text)
    {
        Player player= new Player();
        try
        {
            string[] temp;
            temp = text.Split(",");
            player = new Player()
            {
                ID = int.Parse(temp[0]),
                Name = temp[1],
                Sex = char.Parse(temp[2]),
                Age = int.Parse(temp[3]),
                Height = double.Parse(temp[4]),
                Weight = float.Parse(temp[5]),
                Team = temp[6],
                NOC = temp[7],
                Games = temp[8],
                Year = temp[9],
                Season = temp[10],
                City = temp[11],
                Sport = temp[12],
                Event = temp[13],
                Medal = temp[14]
            };
        }
        catch (Exception)
        { }
        return player;
    }
}