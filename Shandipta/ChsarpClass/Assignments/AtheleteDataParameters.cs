using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualBasic.FileIO;
namespace Athelete
{

    public class AtheleteDataParameters
    {
        public int id { get; set; }
        public string name { get; set; }
        public string sex { get; set; }
        public string age { get; set; }
        public string height { get; set; }
        public string weight { get; set; }
        public string team { get; set; }
        public string noc { get; set; }
        public string game { get; set; }
        public string year { get; set; }
        public string season { get; set; }
        public string city { get; set; }
        public string sport { get; set; }
        public string events { get; set; }

        public string medal { get; set; }

    }
    public class AtheleteData
    {


        public List<AtheleteDataParameters> GetAtheleteData(string file)
        {
        TextFieldParser parser = new TextFieldParser(file);
        parser.TextFieldType = FieldType.Delimited;
        parser.SetDelimiters(",");
        parser.CommentTokens = new string[] { "ID" };
        parser.HasFieldsEnclosedInQuotes = true;
            List<AtheleteDataParameters> AetheleteDetails = new List<AtheleteDataParameters>();
           while (!parser.EndOfData)
            {
               var data = parser.ReadFields();
                AetheleteDetails.Add(new AtheleteDataParameters()
                {
                    id = System.Convert.ToInt32(data[0]),
                    name = data[1],
                    sex = data[2],
                    age = data[3],
                    height = data[4],
                    weight = data[5],
                    team = data[6],
                    noc = data[7],
                    game = data[8],
                    year = data[9],
                    season = data[10],
                    events = data[11],
                    city = data[12],
                    sport = data[13],
                    medal = data[14]

                });
            }
            return AetheleteDetails;
        }

    }
}