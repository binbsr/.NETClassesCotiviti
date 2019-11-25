
using System;
using System.Collections.Generic;
public class Collection
{
    /*public void getAnimals(List<string> animals)
    {
        foreach (string animal in animals)
        {
            Console.WriteLine(animal);
        }
    }

    public void Fetchsongs(Dictionary<string, string> songs)
    {
        foreach (var item in songs)
        {
            Console.WriteLine($"{item.Key} = {item.Value}");
        }
    }
    public void ReturnArtist(Dictionary<string, List<string>> artists)
    {
        foreach (var item in artists)
        {
            Console.WriteLine($"{item.Key} {item.Value[0]} {item.Value[1]}");
        }
    }*/

    /*public List<string> GetAnimals()
    {
        var animals = new List<string>() { "Dog", "Tiger", "Lion" };
        return animals;
    }

    public Dictionary<string,List<string>> FetchSongs()
    {
        var songs = new Dictionary<string,List<string>>
        {
            ["abc"] = new List<string> {"aaa","sdfg"},
            ["cdf"] = new List<string> {"bbb","ddd"},
            ["ac"]  = new List<string> {"cc","fff"},
            ["acb"] = new List<string> {"aaa","fgth"}
        };
        return songs;
    }

    public List<(string,string,string)> FetchSongsDetails1()
    {
        var songs = new List<(string,string,string)> 
        {
            ("taylor","selena","lalal"),
            ("taylor","selena","lalal"),
            ("taylor","selena","lalal")
        };
        return songs;
    }*/

        public List<(string,string,string)> FetchSongList()
    {
        var songs = new List<(string,string,string)> 
        {
            ("taylor","selena","lalal"),
            ("taylor","selena","lalal"),
            ("taylor","selena","lalal")
        };
        return songs;
    }



}
