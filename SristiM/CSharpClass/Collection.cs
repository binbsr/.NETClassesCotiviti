using System.Collections.Generic;

public class Collection
{
    public List<string> GetAnimals()
    {

        string[] animalArray = { "Cat", "Dog", "Cow" };
        List<string> animals = new List<string>();
        animals.AddRange(animalArray);
        return animals;

    }

    public Dictionary<string, string> FetchSongsGenre()
    {
        Dictionary<string, string> nameAndGenre = new Dictionary<string, string>()
        {
            ["Kuch Kuch Hota Hai"] = "Romantic",
            ["Afreen"] = "Kawali"
        };

        return nameAndGenre;

    }

    public List<SongDetails> FetchSongDetails()
    {
        List<SongDetails> allSongDetails = new List<SongDetails>();
        SongDetails songdetail1 = new SongDetails { name = "Kuch Kuch Hota Hai", genre = "Romantic", artist = "Udit Narayan" };
        SongDetails songdetail2 = new SongDetails { name = "Afreen", genre = "Kawali Pop", artist = "Nushrat FA Khan" };
        allSongDetails.Add(songdetail1);
        allSongDetails.Add(songdetail2);
        return allSongDetails;

    }





}