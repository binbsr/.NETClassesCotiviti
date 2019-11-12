public class Person
{
    private string name;
    private byte age;
    private static string scientificName = "Homo Sapiens";

    public Person()
    {

    }
    // public Person(string name)
    // {
    //     this.name = name;
    // }
    //alternative way
        public Person(string name) =>this.name = name;

}