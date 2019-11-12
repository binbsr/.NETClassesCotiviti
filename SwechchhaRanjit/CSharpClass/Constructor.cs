public class Person
{
    private string name;
    private byte age;
    //static is used when class value is needed 
    //const is fixed and can not be changed, readonly is kind of fixed but can be changed in runtime
    private static string scientificName = "Homo Sapiens" ;

    //once class is made, this type of default constructor is made and hence we can use that constructor in main program
    public Person()
    {

    }

   /* public Person (string name)
    {
        this.name = name;
    }*/

    public Person(string nam) => name = nam;
   
}