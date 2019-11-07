using System;
namespace LoopsAndConditions
{

    public class Conditionals{


        public void CheckForCorrectString(){
           String str = Console.ReadLine();
           if(str=="Gracious"){
               Console.WriteLine("Wow you said "+str+". "+"Thank you!");
           }
           else
           {
               Console.WriteLine("I simply asked you to say Gracious but you said "+str+" how rude.");
           }

        }

        public void GetLargestNumber(long x, long y, long z){
        
           if(x>y && x>z){
               Console.WriteLine(x+" is greater than "+ y+ " and "+ z);
           }
           else if(y>x && y>z){
                Console.WriteLine(y+" is greater than "+ x+ " and "+ z);

           }
           else   Console.WriteLine(z+" is greater than "+ x+ " and "+ y);


        }

    }
    
}