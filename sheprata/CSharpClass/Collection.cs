using System.Collections;
using System.Collections.Generic;
using System;
using Song;
/* Create class named *Collection*, create 3 methods in there:
*GetAnimals()* which returns list of animal names.
*FetchSongs()* which returns list of songs (song name and genre).
Modify 2. to return list of songs (name, genre and artist name).
Call all three methods from *Main()* and print results to console. */



public class Collection{
    public List<String> GetAnimals()
    {
      List<String> animalList = new List<String>();
      animalList.Add("Cat");
      animalList.Add("Dog");
      animalList.Add("Cow");
      return animalList;
    }



    public List<Songs> FetchSongs()
        {
            Songs sng = new Songs()
            {
                songName = "xyz",
                songGenre = "dd",
            };
            Songs sng2= new Songs()
            {
             songName= "ss",
             songGenre = "ee",   
            };

    

            List<Songs> SongList = new List<Songs>();
            SongList.Add(sng2);
            SongList.Add(sng);

            return SongList;
        }

    public Dictionary<string , List<string>> FetchSongDetails()
    {
        var songs = new Dictionary<string, List<string>>
        {
           ["songname"] = new List<String> {"artist", "genre"},
           ["songname"] = new List<String>{"artist","genre"},
           ["ddd"] =  new List<String> {"ddd"},
        };
        return songs;
    }


//using tuple in list
    public List<(string , string, string)> FetchSongDetailsTuple()
    {
        var songs = new List<(string, string,string)>
        {
            ("sds","sdds","dfdf"),
            ("dd","ff","gg")
        };
         return songs;
    }

}



