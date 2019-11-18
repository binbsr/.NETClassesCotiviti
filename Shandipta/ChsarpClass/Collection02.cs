using System.Collections.Generic;
namespace Collection{
public class Colletion02{

//Tuple
    public List<(string,string,string)> FetchSongDetail(){

        var songs = new List<(string,string,string)>
        {
                ("Kashmir","Rock","Led Zeppelin"),
                ("Wildest dream", "Indi Pop","Taylor Swift")
          
        };
        return songs;
        }

    }


}