using System.Collections.Generic;

public class Collection1
{
    public List<string> GetAnimals()
    {
        List<string> animals = new List<string>{"Dog","Tiger","Lion"};
        return animals;
    }

    public List<string> GetFriends()
    {
        var friends = new List<string>{"Bikram","Pasa","Deepak G"};
        return friends;
    }

     public Dictionary<string, string> Fetchsongs()
    {
        var songs = new Dictionary<string /*Key*/,string/*Values*/>
        {
            ["TNT"] = "ROCK",
            ["Jai Santoshi Maa"] = "Bhajan",
            ["Maya Meri Maya"] = "POP"
        };
        return songs;
    }

    public Dictionary<string, List<string>> FetchsongsDetails()
    {
        var songs = new Dictionary<string /*Key*/,List<string>/*Values*/>
        {
            ["TNT"] = new List<string>{"ROCK","ACDC"},
            ["Jai Santoshi Maa"] = new List<string>{"Bhajan","Anup Jalota"},
            ["Maya Meri Maya"] = new List<string>{"POP","Sanjay Shrestha"}
        };
        return songs;
    }

    public List<(string, string,string)> FetchsongsList()
    {
        var songs = new List<(string ,string,string)>
        {

            ("TNT","ROCK","ACDC"),
            ("Jai Santoshi Maa","Bhajan","Anup Jalota"),
            ("Maya Meri Maya","POP","Sanjay Shrestha")
        };
        return songs;
    }

    
    
}