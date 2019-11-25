using System;
using System.Collections.Generic;
using System.Text;

namespace LearningInheritance
{
    public class Animal
    {
        public bool HasLegs { get; set; }
        public void Eat() 
        {
            Console.WriteLine("Eating.....");
        }
    }

    public class Dog : Animal       // inheritance from base class Animal
    {
        public Dog()
        {
            HasLegs = true;
            Console.WriteLine("From Dog() constructor");
        }

        public void Bark()
        {
            Console.WriteLine("Vow..Vow..Vow");
        }
    }

    public class Snake:Animal, Isaleable
    {
        public Snake()
        {
            HasLegs = false;
        }
        public void Crawl()
        {

        }

        void Isaleable.Buy()
        {
            throw new NotImplementedException();
        }

        void Isaleable.Sale()
        {
            throw new NotImplementedException();
        }
    }

    /*   
     *   public class Puppy : Dog, Animal       (MULTIPLE INHERITANCE)
     *   this type of inheritance is called multiple inheritance which is not allowed in C# but do exists in JAVA
     *   
     *   BUT this can be allowed in C# through INTERFACE 
     *   
     */
    public class Puppy:Dog, Isaleable
    {
        public Puppy()
        {
            Console.WriteLine("From Puppy() constructor");
        }

        public void Weep()
        {
            Console.WriteLine("Weep...");
        }

        /*
         *  "Is a"  relation 
         * "Has a" relation
         * 
         * 
         * 
         */

        // this is interface method implementation (must be defined while accessing Interface)
        void Isaleable.Buy()
        {
            throw new NotImplementedException();
        }

        void Isaleable.Sale()
        {
            throw new NotImplementedException();
        }
    }

    public interface Isaleable
    {
        /*
         * Interface method only define where 
         * but no body part of methods
         * can not be instatiated (i.e object can not be created of interface)
         */

        public void Buy();          
        public void Sale();     
    }
}
