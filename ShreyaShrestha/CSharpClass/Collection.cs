using System;
using System.Collections.Generic;

namespace GenericExamples
{
    public class Collection
    {
        public List<string> GetAnimals()
        {
            List<string> animalsList = new List<string> { "Tiger", "Lion", "Fox" };
            return animalsList;

        }


        public Dictionary<string, string> FetchSongs()
        {
            Dictionary<string, string> songs = new Dictionary<string, string> {
                // { "Sayau thunga", "National Song" }, { "Komal tyo Timro", "Pop" } };
            ["Sayau thunga"] = "National Song",
            ["Komal tyo Timro"] = "Pop"
            };
            return songs;

        }

        public Dictionary<string , Song> FetchSongsBySongNameGenreArtist()
        {
            Dictionary<string, Song> songs = new Dictionary<string, Song>();                 
            Song song1 = new Song {genre = "National Song", artistName = "Byakul Maila"};
            Song song2 = new Song {genre = "Pop", artistName = "Sabin Rai"};
            songs.Add("Sayau Thunga", song1);
            songs.Add("Komal tyo timro", song2);
            return songs;

        }

        public Dictionary<string, List<string>> FetchSongsBySongNameGenreArtist1()
        {
            var songsList = new Dictionary<string, List<string>>
            {
                ["abc"] = new List<string>{"aa","ab"},
                ["ab"] = new List<string>{"b", "c"}
            };
            return songsList;
        }

         public List<(string, string, string)> FetchSongsBySongNameGenreArtist2()
        {
            var songsList = new List<(string, string, string)>
            {
               ("a","b","c"),
               ("d","e","f")
            };
            return songsList;
        }

    }

}