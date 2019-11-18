using Sport;

public class MMA : FightingSport, IWeightDivision, IChampion
{

    float weightInKg;
    public MMA()
    {
        base.FightingRules();

    }

    public void WeightDivision(float weight)
    {
        weightInKg = weight;

        if (weight > 93 && weight <= 120.2)
        {

            System.Console.WriteLine($"{weight}kg -----> Heavyweight");
        }
        else if (weight > 83.9 && weight <= 93)
        {

            System.Console.WriteLine($"{weight}kg -----> Light Heavyweight");
        }
        else if (weight > 77.1 && weight <= 83.9)
        {

            System.Console.WriteLine($"{weight}kg ----->  MiddleWeight");
        }
        else
            System.Console.WriteLine("The given weight is not eligible to participate in any weight class division.");

    }

    public void WinnerName()
    {
        if (weightInKg > 93 && weightInKg <= 120.2)
        {

            System.Console.WriteLine($"Current Heavyweight Champion is Stipe Miocic.");
        }
        if (weightInKg > 83.9 && weightInKg <= 93)
        {

            System.Console.WriteLine($"Current Light Heavyweight Champion is John Jones.");
        }
        if (weightInKg > 77.1 && weightInKg <= 83.9)
        {

            System.Console.WriteLine($"Current Middleweight Champion is Israel Adesanya.");
        }


    }
}