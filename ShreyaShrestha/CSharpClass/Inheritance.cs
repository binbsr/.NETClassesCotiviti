using System;

public class Animal
{
    public bool HasLegs { get; set; }
    public void Eat()
    {
        Console.WriteLine("Eating....");
    }

}

public class Dog : Animal
{
    public Dog()
    {
        HasLegs = true;

        Console.WriteLine("From dog constructor");
    }

    public void Barks()
    {
        Console.WriteLine("Bow-vow");
    }
}

// public class Snake : Animal, ISaleable
// {
//     public void Crawl()
//     {}
//     public Snake()
//     {
//         HasLegs = false;
//     }

//     public void Buy()
//     {
//         throw new NotImplementedException();
//     }

//     public void Sell()
//     {
//         throw new NotImplementedException();
//     }
// }

public class Snake : ISaleable
{
    public void Crawl()
    { }

    public void Buy()
    {
        throw new NotImplementedException();
    }

    public void Sell()
    {
        throw new NotImplementedException();
    }
}


//Multilevel inheritance
public class Puppy : Dog, ISaleable
{
    public Puppy()
    {
        Console.WriteLine("From Puppy() constructor");
    }
    public void Buy()
    {
        throw new NotImplementedException();
    }

    public void Sell()
    {
        throw new NotImplementedException();
    }

    public void Weep()
    { }

}

interface ISaleable
{
    public void Buy();


    public void Sell();

}

