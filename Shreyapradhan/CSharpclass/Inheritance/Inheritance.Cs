using System;
namespace  Inhert
{
 // class --> Is-a Relation and interface --> has a relation
    public class Animal
    {
        public bool HasLegs{get;set;}
        public void Eat()
        {
                Console.WriteLine("Eating .. Don't Disturb!");
        }
    }

    public class Dog : Animal
    {

        public Dog()
        {
            HasLegs= true;
             System.Console.WriteLine(" From Dog Constructor");
        }
        public void Bark()
        {
            System.Console.WriteLine(" wuf wuf");
        }

    }

    public class Puppy: Dog, ISellable
    {
        public Puppy()
        {
             System.Console.WriteLine(" From puppy Constructor");
        }
        public void Buy()
        {
             System.Console.WriteLine(" weeping ....");
        }

        public void Sell()
        {
             System.Console.WriteLine(" weeping ....");
        }

        public void weep()
        {
             System.Console.WriteLine(" weeping ....");
        }
    }

    public interface ISellable // one class can implement multiple interface
    {
        public void Buy();
       
        public void Sell();
        
         
    }


    public class Snake: Animal,ISellable
    {
          public Snake()
        {
            HasLegs= false;
        }

        public void Buy()
        {
            throw new NotImplementedException();
        }

        public void Crawl()
        {

        }

        public void Sell()
        {
            throw new NotImplementedException();
        }
    }
}