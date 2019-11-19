namespace Inheritances
{
    public class Animal
    {
        public void Eat()
        {
            System.Console.WriteLine("Eating ... Don't disturb..");

        }
        public bool HasLegs { get; set; }
        public Animal()
        {
            System.Console.WriteLine("I am animal constructor");
        }

    }
    public class Dog : Animal
    {
        public void Bark()
        {
            System.Console.WriteLine("Vow .. Vow..");

        }
    }
    public class VoteKukur : Dog, ISaleable
    {
        public void Availability()
        {
            System.Console.WriteLine("I am local kukur found in Nepal");
        }
        public VoteKukur()
        {
            System.Console.WriteLine("I am Votekukur constructor");
        }
        public void Buy()
        {
           System.Console.WriteLine("My Buying Price is : 50$");
         }
        public void Sell()
        { 
            System.Console.WriteLine("My Selling Price is : 55$");
        }
    }
    public class GermanShephard : Dog, ISaleable
    {
        public void Availability()
        {
            System.Console.WriteLine("I am german shephard");
        }
        public GermanShephard()
        {
            System.Console.WriteLine("I am shephard constructor");
        }
        public void Buy()
        {
           System.Console.WriteLine("My Buying Price is : 150$");
         }
        public void Sell()
        { 
            System.Console.WriteLine("My Selling Price is : 155$");
        }
    }

    public interface ISaleable
    {
        public void Buy();
        public void Sell();
    }
    public class Snake : Animal
    {
       // HasLegs = false;
        public void Crawl()
        {

        }
    }
}