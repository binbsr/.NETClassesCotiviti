using System.Collections.Generic;

public class Collection
{
    public List<string> GetAnimals()
    {
        var animals = new List<string> {"Dog", "Tiger", "Lion"};
        return animals;
    }

    public Dictionary<string, string> FetchSongs()
    {
        var songs = new Dictionary<string, string>
        {
            ["abc"] = "aaa",
            ["ab"] = "aaa",
            ["ac"] = "aaa",
            ["acb"] = "aaa",
        };

        return songs;
    }

    public Dictionary<string, List<string>> FetchSongDetails()
    {
        var songs = new Dictionary<string, List<string>>
        {
            ["abc"] = new List<string> { "aaa", "sdfsf"},
            ["ab"] = new List<string> { "aaa", "sdfsf"},
            ["ac"] = new List<string> { "aaa", "sdfsf"}
        };

        return songs;
    }

    public List<(string, string, string)> FetchSongList()
    {
        var songs = new List<(string, string, string)>
        {
            ("sds","sdfsfd", "sdfs"),
            ("sds","sdfsfd", "sdfs"),
            ("sds","sdfsfd", "sdfs")
        };

        return songs;
    }
}