public class Person
{
    private string name;
    private byte age;
    private static string scientificName="Homo Sapiens";//takes same value for all instance of a class--can be changed
    // private const string scientificName="Homo Sapiens";//const can never be changed
    // private readonly string scientificName="Homo Sapiens";//readonly can only be changed in runtime
    public Person()
    {

    }

    public Person(string nam)//public Person(string nam)=> name=nam;
    {
      name=nam;  
    }
}