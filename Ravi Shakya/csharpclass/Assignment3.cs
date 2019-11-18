// using System;
// using System.Collections.Generic;

// namespace Practice
// {
//     public class Collection
//     {
//         public List<string> GetAnimals(List<string> animals)
//         {
//             var animals = new List<string> { "Cat", "Dog", "Tiger", "Dinosaurus" };
//             return animals;
//         public Dictionary<string, string> FetchSongs()
//         {
//             var songs = new Dictionary<string, string>
//             {
//                 ["BackInBlack"] = "ClassicRock",
//                 ["WhiskeyInTheJar"] = "HeavyMetal",
//                 ["HighwayToHell"] = "ClassicRock",
//                 ["One"] = "HeavyMetal"
//             };
//             return songs;
//         }
//         public Dictionary<string, List<string>> FetchSongsDetail()
//         {
//             var songs = new Dictionary<string, List<string>>
//             {
//                 ["BackInBlack"] = new List<string> { "ClassicRock", "AC/DC" },
//                 ["WhiskeyInTheJar"] = new List<string> { "HeavyMetal", "Metalica" },
//                 ["HighwayToHell"] = new List<string> { "ClassicRock", "AC/DC" },
//                 ["One"] = new List<string> { "HeavyMetal", "Metalica" }
//             };
//             return songs;
//         }
//         public List<(string, string, string)> FetchSongsList()
//         {
//             var songs = new List<(string, string, string)>
//             {
//                ("BackInBlack","ClassicRock", "AC/DC"),
//                 ("WhiskeyInTheJar","HeavyMetal", "Metalica"),
//             ("HighwayToHell","ClassicRock", "AC/DC" ),
//                 ("One","HeavyMetal", "Metalica" )
//             };
//         return songs;
//         }

//         internal List<string> GetAnimals()
//         {
//             throw new NotImplementedException();
//         }
//     }
// }