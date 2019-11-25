namespace Inheritances
{
    public abstract class Vehicle
    {
        public virtual void Transport(){}

    }
    public class Car : Vehicle, IBrakingSystem
    {
        public void getBrakingSystem()
        {
            System.Console.WriteLine("Car has Disk or hydraulic Drum braking system. They also have emergency hand brake");
        }
        public override void Transport()
        {
            System.Console.WriteLine("This is the vehicle which can transport few number of people and generally bought for personal and family use.");
        }
    }
    public sealed class SportsCar : Car
    {

    }
    public abstract class Bike
    {
        public abstract void Carries();
        public byte MaxCC {get; set;}
        public string Suspension()
        {
            return "Bike have two suspensions front and rear";
        }
        public virtual string Comfortable()
        {
            return "Bikes are generally Comfortable for short trip";
        }
    }
    public class SportsBike : Bike, IBrakingSystem, ILegGuard
    {
        public bool hasLG = false;    
        public void getBrakingSystem()
        {
            System.Console.WriteLine("They generally have disk brakes. Most of the Sports Bike generally have Anti Locking Braking System");
        }
        public bool hasLegGuard {
            get {return hasLG;}
            set {hasLG = value;}
        }
        public override void Carries()
        {
            System.Console.WriteLine("Sports Bike generally don't have passenger seat");
        }
        public new string Suspension() => $"{base.Suspension()} front : fork, rear : mono";
        public override string Comfortable()
        {
            return $"Though {base.Comfortable()}, cruise bikes are designed for longer trip and classic look.";
        }
        
    }
    public class CruiseBike : Bike, IBrakingSystem, ILegGuard
    {
        public bool hasLG = true;    
        public void getBrakingSystem()
        {
            System.Console.WriteLine("They generally have disk brakes. Some of them may have drum brakes as well");
        }
        public bool hasLegGuard {
            get {return hasLG;}
            set {hasLG = value;}
        }
        public override void Carries()
        {
            System.Console.WriteLine("Cruise Bike generally have passenger seat");
        }
        public new byte MaxCC {
            get {
                return 250;
                }
            set {
                MaxCC = value;
                }
        }
        
    }
    public interface IBrakingSystem
    {
        public void getBrakingSystem();
    }
    public interface ILegGuard
    {
        public bool hasLegGuard { get; set; }
    }
}