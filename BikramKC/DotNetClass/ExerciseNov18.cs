namespace Inheritances
{
    public class Vehicle
    {
        private byte noOfWheels = 4;

    }
    public class Car : Vehicle, IBrakingSystem
    {
        public void getBrakingSystem()
        {
            System.Console.WriteLine("Car has Disk or hydraulic Drum braking system. They also have emergency hand brake");
        }
    }
    public class SportsCar : Car
    {

    }
    public class Bike
    {

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