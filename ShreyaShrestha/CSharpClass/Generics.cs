using System;
using System.Collections.Generic;

namespace LoopsAndConditions
{

    public class TestList
    {
        public void Add(int num)
        {

        }

        public void Add(double num) //function overloading
        {

        }
 
    }

    //Generics
    public class Generics<T, U> // <T> is datatype //multiple data types is also valid
    {
        public void Add(T num)
        {

        }

        public void Add(U num)
        {

        }


    }
}