public class Person{

    private string name;
    public byte age;
    private static string scientificName="HomoSapiens";

    // use const if values does not have to change. you can use readonly as well.

     // readonly values can be changed during run time while const can not be changed ever

    public Person()
    {

    }
     public Person(string name) => this.name=name;
    
}