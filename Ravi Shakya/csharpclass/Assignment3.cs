using System;
using System.Collections.Generic;

namespace Practice
{
    public class Collection
    {
        public void GetAnimals(List<string> animals)
        {
            foreach (string animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
        public void FetchSongs(Dictionary<string,string> songs)
        {
            foreach (var item in songs)
            {
                Console.WriteLine($"{item.Key} = {item.Value}");
            }
        }
        public void AddArtists(Dictionary<String, List<string>> songsgenre)
        {
            foreach (var item in songsgenre)
            {
                Console.WriteLine($"{item.Key} {item.Value[0]} {item.Value[0]}");

            }
        }
        
    }
}