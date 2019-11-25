public class Animal
{
    public bool HasLegs{ get ; set;}

    public void Eat()
    {
        System.Console.WriteLine("Eating... Don't Disturb!!!");
    }
}

public class Dog : Animal
{
    public Dog()
    {
        HasLegs = true;
        System.Console.WriteLine("From Dog() Constructor.");
    }
    public void Bark()
    {
        System.Console.WriteLine("Vow... Vow...");
    }
}

public class Snake : Animal, ISaleable
{
    public Snake()
    {
        HasLegs = false;
    }

    public void Crawl()
    {
        
    }

    public void Buy()
    {
        throw new System.NotImplementedException();
    }

     public void Sell()
    {
        throw new System.NotImplementedException();
    }
    


}

public class Puppy : Dog, ISaleable
{
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
        System.Console.WriteLine("Weeping.......");
    }

    public Puppy()
    {
       System.Console.WriteLine("From Puppy() constructor."); 
    }

}

public interface ISaleable
{
    public void Buy();
    public void Sell();
}