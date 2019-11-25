using System;
using System.Collections.Generic;
using System.Text;

namespace MultipleInheritance
{
    public abstract class CooldBloodedAnimal
    {
        public string GetName() => "This is base class";
       
    }
    public class Amphibian : CooldBloodedAnimal, IBehaviouralAction
    {
        public string Name { get; set; }
        public String ClassName { get; set; }
        public new string GetName()=> $"{Name} {ClassName}";

        //public string GetName() => base.GetName();        // this is use to call base class method using Keyword BASE

        //public override string SecondBaseClass()=>"Override of base class 2";

        public bool DoesLiveInLand { get; set; }
        public bool DoesLiveInWater { get; set; }

        public void LiveInLand()
        {
            DoesLiveInLand = true;
        }

        public void LiveInWater()
        {
            DoesLiveInWater = false;
        }
    }
    public class Frog:Amphibian
    {
        
    }
    public class WarmBloodedAnimal
    {
        public virtual string SecondBaseClass() => "This is base class2";
    }
    public class Mammals : WarmBloodedAnimal, IBehaviouralAction, ICanFlyable
    {
        public string MammalName { get; set; }
        public string FoundPlace { get; set; }

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
