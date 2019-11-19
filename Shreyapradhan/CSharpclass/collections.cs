using System.Collections.Generic;
using System;
using Exercise;
public class collections{

    public List<string> getAnimals( )
    {
         List<string> animals=new List<string>(){"rat","cat"};
        return animals;
    }

     public Dictionary<string,string> Fetchsongs()
    {
        Dictionary<string,string>tracks=new Dictionary<string, string>{["blankspace"]="pop",
              ["sunflower"]="hiphop",
              ["Killer"]="Rock"};

          return tracks;        
         
    }

    public Dictionary<string,List<string>> FetchAllSongsInAlbum()
    {
        var songs=new Dictionary<string, List<string>>{
              ["blankspace"]= new List<string>{"pop","Taylor Swift"},
              ["sunflower"]=new List<string>{"hip hop","Post Malone"},
              ["Killer"]=new List<string>{"Rock","Queen"}};
          return songs;    
    }
    
    public List<(string,string,string)> GetallSongs()
    {
            var songs= new List<(string,string,string)>
            {
                ("blankspace","pop","TaylorSwift"),
                ("sunflower","hip hop","Post Malone"),
                ("Killer","Rock","Queen")
            };
            return songs;
    }
    public List<SongsList> FetchAllsongs()
    {
         List<SongsList> disc=new List<SongsList>();
            SongsList track1=new SongsList{
                name="Blankspace",
                genre="pop",
                artist="Taylor swift"
                                
            };
             SongsList track2=new SongsList{
                name="killer",
                genre="Rock",
                artist="Queen"
                                
            };
            disc.Add(track1);
            disc.Add(track2);
            
             return disc;
         
    }
}