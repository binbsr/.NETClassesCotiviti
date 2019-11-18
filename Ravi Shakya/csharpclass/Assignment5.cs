public class WarmBloodedAnimals
{
public bool GivesBirth {get; set;}
}
public class ColdBloodedAnimals
{
public bool GivesBirth {get; set;}
}

public class Mammals: WarmBloodedAnimals, ILivesOnLand
{
    public Mammals()
    {
        GivesBirth = true;
        System.Console.WriteLine ("Mammals gives birth to babies.");
    }

    public void LandAnimal()
    {
        throw new System.NotImplementedException();
    }
}

public class Reptiles: ColdBloodedAnimals, ILivesOnLand, ILivesOnWater
{
    public Reptiles()
    {
        GivesBirth = false;
        System.Console.WriteLine ("Reptiles lays eggs.");
    }

    public void LandAnimal()
    {
        throw new System.NotImplementedException();
    }

    public void WaterAnimal()
    {
        throw new System.NotImplementedException();
    }
}

public class Amphibians: ColdBloodedAnimals, ILivesOnWater
{
    public Amphibians()
    {
        GivesBirth = false;
        System.Console.WriteLine ("Amphibians also lays eggs.");
    }

    public void WaterAnimal()
    {
        throw new System.NotImplementedException();
    }
}

public class Humans: Mammals
{
    public Humans()
    {
        System.Console.WriteLine("Humans are the intellectual species among animals.");
    }
}

public interface ILivesOnLand
{
    public void LandAnimal();
}
public interface ILivesOnWater
{
    public void WaterAnimal();
}