using System;

public class Animal {
    public bool HasLegs { get; set; }
    public void Eat () {
        System.Console.WriteLine ("Eats veg-nonveg!");

    }
}

public class Dog : Animal 
{
    public void Dark ()
    {
        System.Console.WriteLine ("Bhow-Bhow");
    }

    public Dog () 
    {
        HasLegs = true;

        System.Console.WriteLine ("From Dog() Constructor");

    }

}

public class Snake : Animal, ISaleable {
    public Snake () {
        HasLegs = false;
    }

    public void Crawl () {

    }

    public void Buy () {
        throw new System.NotImplementedException ();
    }

    public void Sale () {
        throw new System.NotImplementedException ();
    }

}

public class Puppy : Dog, ISaleable
//public class Pupply: Dog, Animal----multiple inheritance is not allowed in c# 
// puppy is a Dog, is a gives identity/implement
//Puppy has a ISaleable, has a gives interfaces/extend
{

    public Puppy () {
        System.Console.WriteLine ("From Puppy() Constructor");
    }
    public void Weep () {
        System.Console.WriteLine ("Weeping...");
    }

    public void Buy () {
        throw new System.NotImplementedException ();
    }

    public void Sale () {
        throw new System.NotImplementedException ();
    }

}

//-------------------------interface-------------------------
public interface ISaleable {
    public void Buy ();
    public void Sale ();
}