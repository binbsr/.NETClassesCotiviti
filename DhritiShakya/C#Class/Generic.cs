using System.Collections.Generic;

public class TestList<T,U>// T can be of any datatype
{
    public void Add(T num) // method overloading-- same method name but may have different number of argument or different datatype in argument
    {
      
    }

    // public void Add(double num)
    // {

    // }

    public void Addanother(U num)
    {

    }
}

public class Collection
{
    public List<string> GetAnimals()
    {
      List<string> animals=new List<string>();//new List<string> {"Dog","Cat"};another way of initializing
      //var animals=new List<string> {"Dog","Cat"}; if var type is used then the object animals already knows it as List of string in the compile time itself
      animals.Add("Tiger");
      animals.Add("Lion");
        return animals;
    }

    // public Dictionary<string,string> FetchSongs()
    // {
    //   Dictionary<string,string> songs=new Dictionary<string, string>();
    //   songs.Add("abc","Smelly Cat");
    //   songs.Add("def","I don't know");


    //   return songs;
    // }

    // public Dictionary<string,List<string>> FetchSongs1()
    // {
    //   var songs=new Dictionary<string, List<string>>
      
    //   ["abc"]=new List<string>{"Smelly Cat","sdasd"},
    //   ["def"]=new List<string>{"I don't know","sdas"},
    // };
    //   return songs;

      public List<(string,string,string)> FetchSongs2()
      {
        var songs=new List<(string,string,string)>
        {
          ("abc","Smelly Cat","sdasd"),
          ("def","I don't know","sdas"),
        };
return songs;
      }
}