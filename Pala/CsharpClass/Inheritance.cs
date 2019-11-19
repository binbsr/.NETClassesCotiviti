//Inheritance
//Base class- parnet class
//Derived class - child class
//Multiple Base class cannot be derived from derived class
//Accessin Ability (Multiple method )is called Interface from classes, it has no body.
public class Animal
{
    public bool HasLegs{get;set;}//Auto Implemented property
    public void Eat()
    {
        System.Console.WriteLine("Eating .. dont disturb!!");

    }

}
public class Dog : Animal
{
    public Dog()
    {
        HasLegs = true;
        System.Console.WriteLine("from Puppy() constructor");
    }
    public void Bark()
    {
        System.Console.WriteLine("vow..vow!!");
    }
}
public class snake: Animal
{
    public snake()
    {
        HasLegs = false;
    }

}

public class Puppy : ISaleable
{
    public Puppy()
    {
        System.Console.WriteLine("from Puppy() constructor");
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
        System.Console.WriteLine("Weeping");
    }
}

//is a 
//has a 

public interface ISaleable// no body in interface
{
    public void Buy();
    public void Sell();
}
