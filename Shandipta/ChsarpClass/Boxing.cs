using Sport;

public class Boxing : FightingSport, IWeightDivision
{


    public Boxing()
    {
        base.FightingRules();

    }


    public void WeightDivision(float weight)
    {
        if (weight > 91)
        {

            System.Console.WriteLine($"{weight}kg -----> Heavy Weight");
        }
        else if (weight > 79 && weight <= 91)
        {

            System.Console.WriteLine($"{weight}kg -----> Cruiser Weight");
        }
        else if (weight > 76 && weight <= 79)
        {

            System.Console.WriteLine($"{weight}kg -----> Light HeavyWeight");
        }
        else
            System.Console.WriteLine("The given weight is not eligible to participate in any weight class division.");

    }
}