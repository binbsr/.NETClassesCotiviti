using System;
using System.Collections.Generic;

namespace Collection
{
    public class Collections
    {
        public List<string> GetAnimals()
        {
            var animals = new List<string> { "Dog", "Cat", "Rhino" };
            return animals;
        }

        public Dictionary<string, string> FetchSongs()
        {
            var songs = new Dictionary<string, string>
            {
                ["Kashmire"] = "Rock N Roll",
                ["Baby"] = "Pop",
                ["Hasta Luego"] = "Latin Pop",
            };
            return songs;
        }

        public Dictionary<string, List<string>> FetchSongsAndArtist()
        {
            var songs = new Dictionary<string, List<string>>
            {
                ["Kashmire"] = new List<string> { "Rock N Roll", "Led Zepplin" },
                ["Baby"] = new List<string> { "Pop", "JB" },
                ["Mic Drop"] = new List<string> { "K-pop", "BTS" }
            };
            return songs;
        }
        public List<(string, string, string)> FetchSongsList()
        {
            var songs = new List<(string, string, string)>
            {
                ("Kashmire", "Rock N Roll", "Led Zepplin"),
                ("Baby", "Pop", "JB"),
                ("Hasta Luego", "Latin Pop", "BTS")
        };
            return songs;
        }
    }


}