public class Person
{
    private string name;
    private byte age;
    private static string scientificName = "Homo Sapiens"; //can be changed during compile time

    private const string familyName = "Mammals"; //cannot change in compile and runtime both

    private readonly string className = "Vertebrate"; //can be changed during runtime

    //default constructor
    public Person()
    {
    }

    //Parameterized constructor
    public Person(string name) =>
        this.name = name; //assign the name to the string name defined in class Person

 // there can be static constructor

}