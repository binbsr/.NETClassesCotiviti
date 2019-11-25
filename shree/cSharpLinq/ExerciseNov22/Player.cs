using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AssignmentLinq
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Age { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string Team { get; set; }
        public string Noc { get; set; }
        public string Games { get; set; }
        public string Year { get; set; }
        public string Season { get; set; }
        public string City { get; set; }
        public string Sport { get; set; }
        public string Event { get; set; }
        public string Medal { get; set; }

        public List<Player> SetTextLineToList()
        {
            List<Player> playerList = new List<Player>();
            
            string folderPath = @"D:\shree\dot net\.NETClassesCotiviti\shree";
            string filePath = Path.Combine(folderPath, "Olympics_Athelete_Events.txt");
            var fileContent = ReadDataFIle(filePath);
            for (int i = 1; i < fileContent.Length; i++)
            {
                var textLine = fileContent[i].Split(",", System.StringSplitOptions.RemoveEmptyEntries);
                playerList.Add(new Player
                {
                    Id = Convert.ToInt32(textLine[0]),
                    Name=textLine[1],
                    Sex=textLine[2],
                    Age= textLine[3],
                    Height=textLine[4],
                    Weight= textLine[5],
                    Team= textLine[6],
                    Noc= textLine[7],
                    Games= textLine[8],
                    Year= textLine[9],
                    Season= textLine[10],
                    City= textLine[11],
                    Sport= textLine[12],
                    Event= textLine[13],
                    Medal= textLine[14]
                });     
            }
            return playerList;
        }

        public string[] ReadDataFIle(string filePath)
        {
            var readFileContent = File.ReadAllText(filePath).Split("\n", StringSplitOptions.RemoveEmptyEntries);
            return readFileContent;
          
        }
    }
}
