using System.Collections.Generic;
using System;
namespace Collection
{

    public class Collections
    {

        //*GetAnimals()* which returns list of animal names.

        public List<string> GetAnimals()
        {
            List<string> animal = new List<string>();
         //   var animals = new List<string> (){"Dog","Cat"};
            animal.Add("Elephant");
            animal.Add("Anteater");
            animal.Add("Beaver");
            animal.Add("Llama");
            animal.Add("Alpaca");
            animal.Add("Blue Whale");
            return animal;

        }


        //FetchSongs() which returns list of songs (song name and genre).
        public Dictionary<string, string> FetchSongs()
        {
            Dictionary<string, string> songList =
                    new Dictionary<string, string>(){
                                  {"Kashmir", "Rock"},
                                  {"Wildest dream", "Indi pop"},
                                  {"Let's get it on", "R&B/Soul"},
                                  {"Wanted", "Pop"},
                                 {"Lazarus", "Progressive metal"}};
            return songList;

        }


        //Modify 2. to return list of songs (name, genre and artist name)

        public Dictionary<string, List<string>> FetchSongsDetail()
        {


            Dictionary<string, List<string>> songList = new Dictionary<string, List<string>>()
            {
                {"Kashmir", new List<string> { "Rock","Led Zeppelin"} },
                {"Wildest dream", new List<string> { "Indi Pop","Taylor Swift" } },
                {"Let's get it on", new List<string> { "R&B/Soul","Marvin Gaye" } },
                {"Wanted", new List<string> { "Pop","One Republic" } },
                {"Lazarus", new List<string> { "Progressive metal","Porcupine Tree" } }
            };
            return songList;
        }
    }
}

