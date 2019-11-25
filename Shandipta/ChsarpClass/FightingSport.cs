using System;
namespace Sport
{

    public class FightingSport{

       private string name;

         public  FightingSport()
        {
         name = this.GetType().Name;
        }
            public void FightingRules(){
                String fightingRules = name=="MMA"?"In MMA a fighter can use boxing, Muay Thai, BJJ, Wrestling etc."
                :"In boxing a fighter can only use arms and hands in order to knock out an opponent.";
                Console.WriteLine(fightingRules);

            }
    }
}