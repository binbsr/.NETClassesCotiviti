using System.Collections.Generic;

namespace Exercise3
{
    public class Collection
    {
        public List<string> GetAnimals()
        {
            List<string> animals = new List<string>();
            animals.Add("Cow");
            animals.Add("Dog");
            animals.Add("Elephant");
            animals.Add("Fox");
            return animals;
        }

        public Dictionary<string, string> FetchSongs()
        {
            Dictionary<string, string> songs = new Dictionary<string, string>();
            songs.Add("Abc", "Love Song");
            songs.Add("XYZ", "HipHop Song");
            songs.Add("123", "Rock Song");
            return songs;
        }

        public class FetchSong
        {
            public string name;
            public string genre;
            public string artistName;
        }

        public Dictionary<string, FetchSong> FetchSongs1()
        {
            FetchSong s1 = new FetchSong()
            {
                name = "Abc",
                genre = "Love Song",
                artistName = "Ram"
            };

            FetchSong s2 = new FetchSong()
            {
                name = "XYZ",
                genre = "HipHop Song",
                artistName = "Shyam"
            };
            FetchSong s3 = new FetchSong()
            {
                name = "123",
                genre = "Rock Song",
                artistName = "Hari"
            };

            Dictionary<string,FetchSong> songlist = new Dictionary<string, FetchSong>();
            songlist.Add("Number 1", s1);
            songlist.Add("Number 2", s2);
            songlist.Add("Number 3", s3);
                       
            return songlist;
        }

}
    


}