using System;
using System.Collections.Generic;
using System.IO;
using FileHandling;

namespace LINQ
{
    //class Players
    public class Player
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Age { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string Team { get; set; }
        public string NOC { get; set; }
        public string Games { get; set; }
        public string Year { get; set; }
        public string Season { get; set; }
        public string City { get; set; }
        public string Sport { get; set; }
        public string Event { get; set; }
        public string Medal { get; set; }
    }

    public class PlayerCollections
    {
        public static List<Player> PlayerList()
        {

            List<Player> playerList = new List<Player>();
            string folderPath = @"D:\PalaKansakar\.NETClassesCotiviti\Pala\LINQ\TextFiles";
            string filePath1 = Path.Combine(folderPath, "Olympics_Athelete_Events.txt");
            //List<OlympicsAtheleteEvents> = new List<OlympicsAtheleteEvents>;
            FileIO fileIO = new FileIO();
            var result = fileIO.ReadFile(filePath1);
            Console.WriteLine(result.Length);
            for (int i = 1; i < result.Length; i++)
            {
                var str = result[i].Split(",", System.StringSplitOptions.RemoveEmptyEntries);
                playerList.Add(new Player { Id=int.Parse(str[0]),Name=str[1],Sex=str[2],Age=str[3],Height=str[4],Weight=str[5],Team=str[6],NOC=str[7],Games =str[8],Year =str[9],
                    Season=str[10],City=str[11],Sport=str[12],Event=str[13],Medal=str[14]});
            }
            return playerList;
        }
        internal string[] ReadFile(string path)
        {
            var fileContent = File.ReadAllText(path);
            var lines = fileContent.Split("\n",System.StringSplitOptions.RemoveEmptyEntries);
            return lines;
        }
    }
}