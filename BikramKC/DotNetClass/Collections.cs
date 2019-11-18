using System.Collections.Generic;

namespace DotNetClass
{
    public class Collections
    {
        public List<string> GetAnimals()
        {
            List<string> list = new List<string> { "Cow", "Buffalo", "Tiger" };
            return list;
        }

        public Dictionary<string, string> FetchSongs()
        {
            Dictionary<string, string> dict = new Dictionary<string, string> { ["Nothing Else Matter"] = "Rock", ["Walk"] = "Heavy Metal", ["Sajha Pakha"] = "Pop" };
            return dict;
        }
        public List<SongDetail> FetchSongDetails()
        {
            List<SongDetail> listSong = new List<SongDetail>();
            SongDetail songdetail1 = new SongDetail { name = "Nothing Else matter", genre = "Rock", artist = "Metallica" };
            SongDetail songdetail2 = new SongDetail { name = "Walk", genre = "Heavy Metal", artist = "Pantera" };
            SongDetail songdetail3 = new SongDetail { name = "Sajha Pakha", genre = "Pop", artist = "Nabin K Bhattarai" };
            listSong.Add(songdetail1);
            listSong.Add(songdetail2);
            listSong.Add(songdetail3);
            return listSong;

        }
        // tuple
        public List<(string, string, string)> FetchSongList()
        {
            var songs = new List<(string, string, string)> {("Nothing Else matter", "Rock", "Metallica"),("Walk", "Heavy Metal", "Pantera"),("Sajha Pakha", "Pop", "Nabin K Bhattarai")};
            return songs;


        }
    }
}
