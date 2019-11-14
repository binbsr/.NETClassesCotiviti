public class Person
{
    private string name;
    private byte age;
    private static string scientificName ="Homo Sapiens";
    //private const string scientificName ="Homo Sapiens";//value does not change
    //private readonly string scientificName ="Homo Sapiens";//value is constant in compile time but can be changed in run time

    public Person() { }//Default parameterless constructor is availabe even if you do not define
   //if not explicitly defined like this, below construtor with parameter will override the Person method

    public Person(string name1)
    {
        this.name=name1;
    }

   // public Person(string name2)=>name=name2;

}