
using System;
using System.Collections.Generic;
public class Collection
{
    public void getAnimals(List<string> animals)
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
    }

}
