using System.Collections.Generic;
public class Collection
{
    public List<string> GetAnimals()
    {
        //when you dont what we will get from result, use var
        var animals = new List<string> { "Dog", "Tiger", "Lion" };
        return animals;
    }

    public Dictionary<string, string> FetchSongs()
    {
        var songs = new Dictionary<string, string>
        {
            ["abc"] = "aaa",
            ["ab"] = "aaa",
            ["ac"] = "aaa",
            ["acb"] = "aaa"
        };

        return songs;
    }

    public Dictionary<string, List<string>> FetchSongDetails()
    {
        var songs = new Dictionary<string, List<string>>
        {
            ["abc"] = new List<string> { "aaa", "sdfs" },
            ["ab"] = new List<string> { "aaa", "sdfs" },
            ["ac"] = new List<string> { "aaa", "sdfs" },
            ["acb"] = new List<string> { "aaa", "sdfs" }
        };

        return songs;
    }

    //alternative of third one using tuple
    public List<(string, string, string)> FetchSongList()
    {
        var songs = new List<(string, string, string)>
         {
             ("asdf", "adsff", "dfgg"),
             ("ert", "sdasdf", "rtywe"),
             ("asfdasd", "asdfs", "asdfasdf")
         };

        return songs;
    }
}


    













     
