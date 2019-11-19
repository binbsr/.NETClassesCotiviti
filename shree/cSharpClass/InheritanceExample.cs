using System;
using System.Collections.Generic;
using System.Text;

namespace MultipleInheritance
{
    public class CooldBloodedAnimal
    {
        public string BodyTemperature { get; set; }
    }
    public class Amphibian : CooldBloodedAnimal, IBehaviouralAction
    {
        public void LiveInLand()
        {
            throw new NotImplementedException();
        }

        public void LiveInWater()
        {
            throw new NotImplementedException();
        }
    }
    public class Frog:Amphibian
    {

    }
    public class WarmBloodedAnimal
    {

    }
    public class Mammals : WarmBloodedAnimal, IBehaviouralAction, ICanFlyable
    {
        public void CanFly()
        {
            throw new NotImplementedException();
        }

        public void LiveInLand()
        {
            throw new NotImplementedException();
        }

        public void LiveInWater()
        {
            throw new NotImplementedException();
        }
    }
    public class Birds : WarmBloodedAnimal, ICanFlyable
    {
        public void CanFly()
        {
            throw new NotImplementedException();
        }
    }
    interface IBehaviouralAction
    {
        void LiveInWater();
        void LiveInLand();
    }
    interface ICanFlyable
    {
        void CanFly();
    }
}
