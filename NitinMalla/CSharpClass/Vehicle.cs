
public abstract class TwoWheeler

{
    public float topSpeed {get;set;}
    public virtual bool IsElectric()
    {
        return false;
    }
    public string BrakingSystem() =>"Brakes to Stop";
}

public abstract class FourWheeler
{
      public string Color{get; set;}
      public int EngineCC{get; set;}
      public int FuelTank{get; set;}
      public abstract int NoOfSheets();
      public string FourWheelDrive() => "Four Wheel Drive ";
}



public class MotorBike : TwoWheeler, IFuelType
{
    public float EngineCC{get;set;}
    public string Fuel {get;set;}
    public void FuelDetails()
    {
        System.Console.WriteLine($"This uses {Fuel} as fuel");
    }
    public new string BrakingSystem() => "There are Front and back Brakes";
       
}

public sealed class ElecticBike : MotorBike
{
    public override bool IsElectric() => true;
    public new string BrakingSystem() => $"{base.BrakingSystem()} and disc brakes";
    
}
public class Taxi : FourWheeler,IFuelType,IRentable
{
    public string color{get; set;} = "Yellow";
    public override int NoOfSheets() => 5;
    public string Fuel {get;set;}
    public void FuelDetails()
    {
         System.Console.WriteLine($"This uses {Fuel} as fuel");
    }

    public void Rate()
    {
        System.Console.WriteLine($" The rate is 30 Rs per KM");
    }
    public new string FourWheelDrive() => $"{base.FourWheelDrive()} is not avaliable";
}

public class Car : FourWheeler, IFuelType
{
    public override int NoOfSheets() => 7;
    public string Fuel {get;set;}
    public void FuelDetails()
    {
         System.Console.WriteLine($"This uses {Fuel} as fuel");
    }
    public new string FourWheelDrive() => "{base.FourWheelDrive()} is avaliable";
}

public interface IFuelType
{
    public void FuelDetails();
}

public interface IRentable
{
    public void Rate();
}