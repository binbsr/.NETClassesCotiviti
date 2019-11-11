using System.Collections.Generic;
using System;
namespace Collection
{

    public class Collections
    {

        public string animalName;
        public string songName, songGenre;

        //*GetAnimals()* which returns list of animal names.

        public List<string> GetAnimals()
        {
            List<string> animal = new List<string>();
            animal.Add("Elephant");
            animal.Add("Anteater");
            animal.Add("Beaver");
            animal.Add("Llama");
            animal.Add("Alpaca");
            animal.Add("Blue Whale");
            return animal;

        }

        public Dictionary<string, string> FetchSongs()
        {

            //FetchSongs() which returns list of songs (song name and genre).
            Dictionary<string, string> songList =
                    new Dictionary<string, string>(){
                                  {"Kashmir", "Rock"},
                                  {"Wildest dream", "Indi pop"},
                                {"Wanted", "Pop"} };



            return songList;

        }

        //Modify 2. to return list of songs (name, genre and artist name

        public Dictionary<string, List<string>> FetchSongsDetail()
        {

            //FetchSongs() which returns list of songs (song name and genre).


            Dictionary<string, List<string>> songList = new Dictionary<string, List<string>>()
{
    {"Kashmir", new List<string> { "Rock","Led Zeppelin"} },
    {"Wildest dream", new List<string> { "Indi Pop","Taylor Swift" } },
    {"Wanted", new List<string> { "Pop","One Republic" } }
};
            return songList;
        }


    }



}