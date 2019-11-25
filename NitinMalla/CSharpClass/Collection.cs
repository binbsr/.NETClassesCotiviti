namespace Collections
{
    using System.Collections.Generic;

    public class Collection
    {
               public List<string> GetAnimals()
        {
            List<string> list = new List<string> { "Cow", "Goat", "Tiger", "Leopard" };
            list.Add("Rihno");

            return list;
        }

        public Dictionary<string, string> FetchSongs()
        {
            Dictionary<string, string> dict = new Dictionary<string, string> { ["Song1"] = "Romantic", ["Song2"] = "Rock", ["Song3"] = "Pop" };
            return dict;
        }

       public class Song
           {
               public string name;
               public string genre;
              public  string artistName;
           }
        public Dictionary<string, List<string>> FetchSongs1()
        {
                     
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>> { ["Song1"] = new List<string>{"Romantic","Sajin"}, ["Song2"] = new List<string>{"Rock","Saroj"}, ["Song3"] = new List<string>{"Pop","Shyam"} };
            
            return dict;
        }

        public Dictionary<string, Song> FetchSongs2()
        {         
            Song s1 = new Song() { name="Song1", genre="Romantic", artistName="Sajin" };
            Song s2 = new Song() { name="Song2", genre="Rock", artistName="Saroj" };
            Song s3 = new Song() { name="Song3", genre="Pop", artistName="Shyam" };

             Dictionary<string,Song> dict = new Dictionary<string, Song> { ["1"] = s1, ["2"] = s2, ["3"] = s3 };
            
            return dict;
        }

        public List<(string, string, string)> FetchSongs3()
        {
            var songs = new List<(string,string,string)>
            {
                ("Song1","Romantic","Sajin"),
                ("Song2","Rock","Saroj"),
                ("Song3","Pop","Shyam")
            };
            return songs;
        }


           


    }
}