using System;
namespace Flight
{

    public class Aeroplane
    {
        private const int  noOfWheels=3;

        private readonly string flightNumer;

        private  string blackBoxInfo;

        private string airline;

        private string pilot;

        public string destination{ get;set;}
        public string origin{ get;set;}
         public int Capacity { get;} // read-only
           public string BlackBoxInfo{
            
            set
            {
                for (int i=0;i<20;i++)
               {
                blackBoxInfo=origin+destination+i;
               }
            }
            } // write-only 

         public Aeroplane() 
                 {
                     flightNumer="RA124";
                 }

         public Aeroplane(string pilot, string Airline,int capacity) //constructor  executes only in run time
                 {
                     flightNumer="RA124";
                     this.airline=Airline;
                     this.pilot=pilot;
                     this.Capacity=capacity;
                     
                 }
        
         

      

        
        public string DisplayRoute()
        {
               return $"{origin}-{destination}";
        }

      
    }

    enum PassangerType{

             Economy=0,
             FirstClass =1,
             
         
         }

}