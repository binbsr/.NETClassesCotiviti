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
        public char Sex { get; set; }
        public byte Age { get; set; }
        public byte Height { get; set; }
        public byte Weight { get; set; }
        public string Team { get; set; }
        public string Noc { get; set; }
        public string Games { get; set; }
        public short Year { get; set; }
        public string Season { get; set; }
        public string City { get; set; }
        public string Sport { get; set; }
        public string Event { get; set; }
        public string Medal { get; set; }

        public void SetDataTable()
        {

        }

        public void ReadDataFIle(string filePath)
        {
            
            IEnumerable<string> p = File.ReadAllLines(filePath);
            //.Split("\n", StringSplitOptions.RemoveEmptyEntries);

            List<Player> plr = p.OfType<Player>().ToList();
            foreach (var i in p)
            {
                foreach (Player p1 in plr)
                {
                    Console.WriteLine(p1.Id);
                }
            }
           // return plr;
        }
    }
}
