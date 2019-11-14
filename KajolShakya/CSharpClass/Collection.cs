using System.Collections.Generic;

namespace LearningMethods
{
    public class Collections
    {

        //*GetAnimals()* which returns list of animal names.
        public List<string> GetAnimals()
        {
           /* List<string> animal = new List<string>();
            animal.Add("Tiger");
            animal.Add("Lion");
            animal.Add("Monkey");
            animal.Add("Porcupine");
            animal.Add("Rhinocerous");
            animal.Add("Hippopotamus");
            return animal;
            */
            var animal = new List<string> {"Dog", "Tiger", "Lion"};
            return animal;
 
        }

        //*FetchSongs()* which returns list of songs (song name and genre).
        public Dictionary<string, string> FetchSongs()
        {
            /*Dictionary<string, string> songs = new Dictionary<string, string>()
            {
                {"Hello","Pop"},
                {"Kashmir","Rock"}
            };
            */
            var songs = new Dictionary<string,string>
            {
                ["abc"] = "aaa",
                ["dasd"] = "hhjh",
                ["axs"] = "asda"
            };
            return songs;

        }

        //Modify 2. to return list of songs (name, genre and artist name).

        /*public Dictionary<string, List<string>> FetchSongsDetail()
        {*/
            /*Dictionary<string, List<string>> songList = new Dictionary<string, List<string>>()
            {
                {"Kashmir", new List<string>{"Rock", "Led"}},
                {"Wildest Animal", new List<string>{"abs","dfs"}}
            };
            */
            /*var songList = new Dictionary<string, List<string>>
            {
                ["abc"] = new List<string> {"aaa", "sada"},
                ["dsfs"] = new List<string> {"hkajsh", "asgdh"}
            };
            return songList;
        } 
        */

        public List<(string,string,string)> FetchSongsDetail()
        {
            var songList = new List<(string, string, string)>
            {
                ("sdfaf","adas", "asdas"),
                ("sda", "asds", "fdf"),
                ("dfg","gdf","dfs")
            };
            return songList;
        }

    }


}

