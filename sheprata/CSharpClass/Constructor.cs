public class Person{
    private string name;
    private byte age;
    private static string scientificName = "Homo Sapiens"; //class level value
    private const string defaultvalue = "sss"; //never changes
    private readonly string anothervalue = "fff" ;     //readable is changed in runtime not in compile time

    public Person()
    {
    }

    /*public Person(string name){
        this.name = name;
    }*/

    public Person(byte ag) => age = ag;


}