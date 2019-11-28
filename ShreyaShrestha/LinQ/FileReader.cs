using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;

public static class FileReader
{
    public static List<Athelete> GetAtheletes(string path)
    {
        var content = File.ReadAllLines(path);
        List<Athelete> atheletes = new List<Athelete>();
        foreach (var c in content.Skip(1)) // to skip the attributes which are present in the first line
        {
            var token = 0;
            //var value = c.Split(',');
            var value = Regex.Split(c,",(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))");
            var athelete = new Athelete
            {
                ID = Convert.ToInt32(value[token].Replace("\"", "")),
                Name = value[++token].Replace("\"", ""),
                Sex = value[++token].Replace("\"", ""),
                Age = value[++token].Replace("\"", ""),
                Height = value[++token].Replace("\"", ""),
                Weight = value[++token].Replace("\"", ""),
                Team = value[++token].Replace("\"", ""),
                AbbrebiationOfNameOfCountry = value[++token].Replace("\"", ""),
                Games = value[++token].Replace("\"", ""),
                Year = value[++token].Replace("\"", ""),
                Season = value[++token].Replace("\"", ""),
                City = value[++token].Replace("\"", ""),
                Sport = value[++token].Replace("\"", ""),
                Event = value[++token].Replace("\"", ""),
                Medal = value[++token].Replace("\"", "")
            };
            atheletes.Add(athelete);
        }
        return atheletes;

    }
}