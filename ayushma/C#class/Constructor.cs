using System;
public class Person
{
    private string name;
    private byte age;
    private static string scientificName = "Homo Sapiens";
    public Person()
    {

    }
    public Person(string name)
    {
        this.name = name;
    }

    public void print()
    {
        Console.WriteLine(this.name);
    }
    //public Person (string nam)=> name= nam;
}