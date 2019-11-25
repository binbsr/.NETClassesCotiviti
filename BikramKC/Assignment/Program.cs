using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DataOperation dtOp = new DataOperation();
            
            string curDir = Directory.GetCurrentDirectory();
            string filePath = Path.Join(curDir, @"InputFiles\Olympics_Athelete_Events.txt"); 
            //@"D:\Research\DotNet\.NETClassesCotiviti\BikramKC\TestDir\Olympics_Athelete_Events.txt";
            // List<Player> dataTable = dtOp.LoadData(filePath);
            List<Player> dataTable = dtOp.TextParser(filePath);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{dataTable[i].iD}   {dataTable[i].name}   {dataTable[i].sex}   {dataTable[i].age}   {dataTable[i].height}   {dataTable[i].weight}   {dataTable[i].team}   {dataTable[i].noc}   {dataTable[i].games}   {dataTable[i].year}   {dataTable[i].season}   {dataTable[i].city}   {dataTable[i].sport}   {dataTable[i].evnt}    {dataTable[i].medal}");
            }

            // Print Nepali Players
            var nepaliPlayer = dtOp.GetNepaliPlayer(dataTable);
            string npPlayersFp = Path.Join(curDir, @"OutputFiles\NepaliPlayers.csv");
            dtOp.WriteToFile(nepaliPlayer, npPlayersFp);
            // Chinease player with Gold
            var chnPlayerWithgold = dtOp.GetChineaseWithGold(dataTable);
            string chnPlayerWithgoldFp = Path.Join(curDir, @"OutputFiles\ChineasePlayer.csv");
            dtOp.WriteToFile(chnPlayerWithgold,chnPlayerWithgoldFp);

            // US Players grouped by sports
            var usPlayers = dtOp.GetUSPlayer(dataTable);
            string usPlayersFp = Path.Join(curDir, @"OutputFiles\USPlayer.csv");
            dtOp.WriteToFile(usPlayers,usPlayersFp);
            
            
            // Medal Table ordered by Gold
            MedalTable mt = new MedalTable();
            var result = mt.GetMedalTable(dataTable);
            string medTableFp = Path.Join(curDir, @"OutputFiles\MedalTable.csv");
            mt.WriteToFile(result,medTableFp);

            

        }
    }
}
