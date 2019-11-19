namespace InheritanceExample2
{

    public class Cars
    {
        public Cars()
        {
            System.Console.WriteLine("This is base class for Cars");
        }

    }
    public class Planes
    {
        public Planes()
        {
            System.Console.WriteLine("This is base class for Planes");
        }

    }

    public class LuxuryCars : Cars, IModeOfTransport, IFuel
    {
        public LuxuryCars()
        {
            System.Console.WriteLine("Everyone loves Luxury");

        }

        public void FuleUsed()
        {
            System.Console.WriteLine("Luxury Cars use Diesel");
        }
          public void ModeOfTransport()
        {
            System.Console.WriteLine("Luxury Cars run on the Streets");
        }

      
    }


    public class SportsCars : Cars, IFuel
    {
        public SportsCars()
        {
            System.Console.WriteLine("Not everyone owns Sports cars");
        }
        public void FuleUsed()
        {
            System.Console.WriteLine("Sports car run on Diesel ");
        }
    }


    public class FighterPlanes : Planes, IModeOfTransport
    {
        public FighterPlanes()
        {
            System.Console.WriteLine("Fighter Planes are designed for air-to-air combat");
        }

        public void ModeOfTransport()
        {
            System.Console.WriteLine("Planes Fly high in the sky");
        }

    }

    public class Raptor : FighterPlanes
    {
        public Raptor()
        {
            System.Console.WriteLine("For Raptor the stealth air superiority is second to none");
        }
    }

    public interface IModeOfTransport
    {
        public void ModeOfTransport();

    }

    public interface IFuel
    {
        public void FuleUsed();
    }
}