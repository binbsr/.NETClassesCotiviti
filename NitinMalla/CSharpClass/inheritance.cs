public class Animal
{
    public bool HasLegs {get; set;} // auto implemented properties
    public void Eat()
    {
        System.Console.WriteLine("Eating ... Don't Distrub");
    }
}

public class Dog : Animal 
{
    public Dog()
    {
        HasLegs = true;
        System.Console.WriteLine("call from Dog() constructor");
    }
    public void Bark()
    {
        System.Console.WriteLine("Vow .. Vow");
    }
}

public class Snake: ISaleable
{
    public Snake()
    {
     //   HasLegs = false;
    }

    public void Buy()
    {
        throw new System.NotImplementedException();
    }

    public void Crawl()
    {

    }

    public void Sell()
    {
        throw new System.NotImplementedException();
    }
}

public class Puppy : Dog, ISaleable
{
    public Puppy()
    {
        System.Console.WriteLine("call from puppy constructor");
   }
    public void Buy()
    {
        throw new System.NotImplementedException();
    }

    public void Sell()
    {
        throw new System.NotImplementedException();
    }

    public void Weep()
    {
        System.Console.WriteLine("Weeping ..");
    }    
}

// Is a 
// Has a 
public interface ISaleable
{
    public void Buy();
    
    public void Sell();
    
}
