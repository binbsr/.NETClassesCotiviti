public class Animal
{    
    public bool HasLegs { get; set; }
    public void Eat()
    { 
        System.Console.WriteLine("Eating... Don't disturb!");
    }
}

public class Dog : Animal
{
    public Dog()
    {
        HasLegs = true;   
        System.Console.WriteLine("From Dog() constructor.");       

    }
    public void Bark() 
    {
        System.Console.WriteLine("Vow.. Vow..");
    }
}

public class Snake : ISaleable
{
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
        System.Console.WriteLine("From Puppy() constructor.");        
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
        System.Console.WriteLine("Weeping...");
    }
}
//"Is a"
//"Has a"
public interface ISaleable
{
    public void Buy();
    public void Sell();
}  