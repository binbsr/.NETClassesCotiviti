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

        public Dictionary<string , Songs> FetchSongsBySongNameGenreArtist()
        {
            Dictionary<string, Songs > songs = new Dictionary<string, Songs>();                 
            Songs song1 = new Songs {genre = "National Song", artistName = "Byakul Maila"};
            Songs song2 = new Songs {genre = "Pop", artistName = "Sabin Rai"};
            songs.Add("Sayau Thunga", song1);
            songs.Add("Komal tyo timro", song2);
            return songs;

        }

    }

}