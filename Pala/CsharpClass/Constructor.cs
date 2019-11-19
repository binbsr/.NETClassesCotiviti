public class Person
{
    private string name;
    private byte age;
    private static string scientificName = "HomoSapiens";//readonly and const
    public Person()//default parameter less constructor
    {

    }
    public Person(string name) => this.name = name;

}