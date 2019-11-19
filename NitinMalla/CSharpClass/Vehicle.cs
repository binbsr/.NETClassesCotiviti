public class FourWheeler
{
      public int NoOfGears{get; set;}  

}

public class TwoWheeler
{
    
}

public class MotorBike : TwoWheeler, IFuelType
{
    public void Fuel()
    {
        throw new System.NotImplementedException();
    }
   
}

public class ElecticBike : MotorBike
{
    
}
public class Taxi : FourWheeler,IFuelType,IRentable
{
    public void Fuel()
    {
        throw new System.NotImplementedException();
    }

    public void Rate()
    {
        throw new System.NotImplementedException();
    }
}

public class Car : FourWheeler, IFuelType
{
    public void Fuel()
    {
        throw new System.NotImplementedException();
    }
}

public interface IFuelType
{
    public void Fuel();
}

public interface IRentable
{
    public void Rate();
}