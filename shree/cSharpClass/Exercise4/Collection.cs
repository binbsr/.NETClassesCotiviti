using SongDetailInformation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4Collection
{
    public class Collection
    {
        public List<string> ReturnAnimalName()
        {
            var animalName = new List<string> {"tiger","cat","cow","dog","leopard"};   // or use List<string> animalName
            return animalName;   
        }

        // Fetch song using Dictionary method
        public Dictionary<string, string> FetchSongs()
        {
            var songs = new Dictionary<string, string>
            {
                ["song1"] = "Jazz",
                ["song2"] = "Blues",
                ["song3"] = "Classical"
            };
            return songs;
        }

        // Fetch song using list of dictionary
        public Dictionary<string, List<string>> FetchSongs1()
        {
            var songs = new Dictionary<string, List<string>>
            {
                    ["song1"] = new List<string> { "Genre1", "Ram"},
                    ["song2"] = new List<string> { "Genre2", "Sita" },
                    ["song3"] = new List<string> { "Genre3", "hari" }
             };
             return songs;
        }

        // using List of Tuple 
      /*  public List<(string, string, string)> Fetchsongs2()
        {
            var songs = new List<(string, string, string)>
            {
                ("abc", "adsf", "dafs"),
                ("abc", "adsf", "dafs"),
                ("abc", "adsf", "dafs")
            };
        }
        */
        public List<SongDetails> ReturnSongNameGenre()
        {
            SongDetails song1 = new SongDetails()
            {
                songName = "song1",
                songGenre = "jazz",
                artistName=""
            };
            SongDetails song2 = new SongDetails()
            {
                songName = "song2",
                songGenre = "blues",
                artistName = ""
            };
            SongDetails song3 = new SongDetails()
            {
                songName = "song3",
                songGenre = "folk",
                artistName = ""
            };
            SongDetails song4 = new SongDetails()
            {
                songName = "song4",
                songGenre = "Classical",
                artistName = "Tara Devi koirala"                
            };



            List<SongDetails> listOfSong = new List<SongDetails>();
            listOfSong.Add(song1);
            listOfSong.Add(song2);
            listOfSong.Add(song3);
            listOfSong.Add(song4);

            return listOfSong;
        }

    }


}
