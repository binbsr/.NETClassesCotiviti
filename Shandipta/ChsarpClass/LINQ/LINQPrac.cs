using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ
{

    public class LINQPrac
    {
            public void LINQ(params int[] num){
                var LinqNum = num.Where(n=>n>30);
                var LinqNum02 = from nums in num where nums>30 select nums;
                string [] animals = {"Anteater","Llama","Beaver","Alpaca","Vicuna"};
                var anmls = animals.OrderBy(a=>a);

                foreach(var number in LinqNum){
                    Console.Write(number+" ");
                } 
                
                foreach(var number in LinqNum02){
                    Console.Write(number+" ");
                }

                foreach(var a in anmls){
                    Console.Write(a+" ");
                }


            }


    }

}