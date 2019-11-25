public  abstract class Airtransport
{
    
    public Airtransport()
    {
        System.Console.Write("Call Airtransport Constructor ()");
    }
    public abstract int hasLane();
    public int NumOfPlanes => 100;
    public int NumOfLane => 900;
    public int JetCode{get;set;}
    public string GetJetCodeAndPlanes()=>$"{JetCode} {NumOfPlanes}";
    }
 
public class Airplane : Airtransport, HaveWings
{
    //public new int GetNumOfPlanes() => 100;

    public override int hasLane()
    {
        return NumOfLane;
    }

    public void hasPassengerSeats()
    {
      System.Console.WriteLine("has Passenger seat");  
    }

    public void Wings()
    {
        throw new System.NotImplementedException();
    }
}
public sealed class Jet: Airplane
{
    public new int JetCode{get;set;}
    public new string GetJetCodeAndPlanes()=>$"{base.GetJetCodeAndPlanes()}- No of Jet and Planes";

    public void hasWindow()
    {
        System.Console.WriteLine("Jetplane has windows");
    }


}
public  abstract class Bird
{
    public abstract int haveMultipleWings();
   
}

public class HummingBird : Bird, HaveWings, Canfly
{
    public override int haveMultipleWings()=>3;
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

    public override int haveMultipleWings()
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
