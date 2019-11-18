using Sport;
using System;
public class MotoGP : RacingSport,IChampion{
private string motoRaceCategory;

    public MotoGP(){
            motoRaceCategory =base.getClassName() == "MotoGP" ? "Racing Class: MotoGP":"Racing Class: Moto2";
            Console.WriteLine(motoRaceCategory); 
    }

    public void WinnerName(){
        Console.WriteLine("The Current MotoGP Champion is Marc Marquez.");
    }

    
  
}