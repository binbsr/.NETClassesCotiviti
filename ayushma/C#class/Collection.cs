using System.Collections.Generic;
public class Collection
{
    public List<string> GetAnimals()
    {
        var animals = new List<string> {"Cat", "Dog", "Lion"}; //using var when the returntype is unknown
        return animals;
    }
    public Dictionary<string, List<string>> FetchSongList()
    {
        var songs = new Dictionary<string, List<string>> 
        {
            ["Vultures"] = new List<string> {"Pop","John Mayer"},
            ["ALl of Me"] = new List<string> {"Romatic Pop", "John Legend"},
            ["Why Georgia"] = new List<string> {"Slow Rock", "John Mayer"}
        };
        return songs;
    }
    public List <(string,string,string)> FetchSongDetails1()
    {
        var songs = new List<(string, string, string)>
        {
            ("Vultures","Pop","John Mayer"),
            ("All of Me","Romantic Pop","John Legend"),
            ("Why Georgia","Slow Rock","John Mayer")
        };
        return songs;
    }
}
