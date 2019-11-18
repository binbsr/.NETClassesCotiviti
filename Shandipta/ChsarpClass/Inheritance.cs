namespace Inheritance
{


    public class Animal
    {
        //derive other class(derived class) from base class

        public void Eat()
        {
            System.Console.WriteLine("DO not disturb while eating.");
        }
        public bool HasLegs { get; set; }


    }


    public class Dog : Animal
    {
        public Dog()
        {

            HasLegs = true;
            System.Console.WriteLine("Has 4 legs.");

        }
        public void Bark()
        {
            System.Console.WriteLine("vow vow");
        }
    }

    public class GermanShepard : Dog
    {
        public GermanShepard()
        {
            System.Console.WriteLine("Clever and intelligent");
        }
    }

    public class Snake : Animal , ISaleable
    {

        public Snake()
        {
            HasLegs = false;
        }

        public void Crawl()
        {

        }

        public void Purchase()
        {
            throw new System.NotImplementedException();
        }

        public void Sale()
        {
            throw new System.NotImplementedException();
        }
    }

    //multilevel inheretance are not allowed in c# which is only possible through interface.
    //interface add various abilities which can be shared accross multiple classes in the form of methods.
    //interface doesnot contain a body.
    //we cannot instantiate interface.
    public interface ISaleable
    {

        public void Sale();
        public void Purchase();

    }
}

//is a, has a 
//is a gives characteristic
//if to add something new its inheritance
//dependency injection loosly coupling
