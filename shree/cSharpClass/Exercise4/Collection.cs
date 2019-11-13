using SongDetailInformation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4Collection
{
    public class Collection
    {
        public List<string> ReturnAnimalName()
        {
            List<string> AnimalName = new List<string> {"tiger","cat","cow","dog","leopard"};
            return AnimalName;   
        }

        public List<SongDetails> ReturnSongNameGenre()
        {
            SongDetails song1 = new SongDetails()
            {
                songName = "song1",
                songGenre = "jazz",
                artistName=""
            };
            SongDetails song2 = new SongDetails()
            {
                songName = "song2",
                songGenre = "blues",
                artistName = ""
            };
            SongDetails song3 = new SongDetails()
            {
                songName = "song3",
                songGenre = "folk",
                artistName = ""
            };
            SongDetails song4 = new SongDetails()
            {
                songName = "song4",
                songGenre = "Classical",
                artistName = "Tara Devi koirala"                
            };



            List<SongDetails> listOfSong = new List<SongDetails>();
            listOfSong.Add(song1);
            listOfSong.Add(song2);
            listOfSong.Add(song3);
            listOfSong.Add(song4);

            return listOfSong;
        }

    }


}
