public class Airtransport
{
    public Airtransport()
    {
        System.Console.Write("Call Airtransport Constructor ()");
    }
    public void hasLane()
    {
        System.Console.WriteLine("AirTransport has multiple Lane");
    }
 
}
public class Airplane : Airtransport, HaveWings
{
    public void hasPassengerSeats()
    {
      System.Console.WriteLine("has Passenger seat");  
    }

    public void Wings()
    {
        throw new System.NotImplementedException();
    }
}
public class Jet: Airplane
{
    public void hasWindow()
    {
        System.Console.WriteLine("Jetplane has windows");
    }


}
public class Bird
{
    public void haveMultipleWings()
    {
        System.Console.WriteLine("have wings");
    }
   
}

public class HummingBird : Bird, HaveWings, Canfly
{
    public void fly()
    {
        throw new System.NotImplementedException();
    }

    public void hasStreamLineBody()
    {
        System.Console.WriteLine("Has unique body feature");
    }

    public void Wings()
    {
        throw new System.NotImplementedException();
    }
}
public class drone : Bird, Canfly 
{
    public void CanAirTravel()
    {
        System.Console.WriteLine("Can travel from one point to other");
    }

    public void fly()
    {
        throw new System.NotImplementedException();
    }
}

public interface Canfly
{
    public void fly();

}
public interface HaveWings
{
    public void Wings();

}
