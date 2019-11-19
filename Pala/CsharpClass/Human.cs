public class Human
{
    public void CanSpeak()
    {
        System.Console.WriteLine("Can speak");
    }
    
}
public class IsMale : Human, CanPlay
{
    public void Basketball()
    {
        System.Console.WriteLine(" It has Mustache hence its a boy !!");
    }

    public void canPlayBasketball()
    {
        System.Console.WriteLine(" It has Mustache hence its a boy !!");
    }

      public void Swimming()
    {
        System.Console.WriteLine(" It has Mustache hence its a boy !!");
    }

    public void hasMutache()
    {
        System.Console.WriteLine(" It has Mustache hence its a boy !!");
    }
 
}

public class Boy : IsMale
{
    public void hasShortHair()
    {
        System.Console.WriteLine(" It has Short hair hence its a Boy !!");
    }
}

public class IsFemale
{
    public void hasNoMustache()
    {
        System.Console.WriteLine("Its a female hence no Mustache!!");
    }
}
public class IsGirl: IsFemale,CanPlay
{
    public void canPlayBasketball()
    {
        throw new System.NotImplementedException();
    }

    public void hasLongHair()
    {
        System.Console.WriteLine("Its a girl hence has long hair");
    }

    public void Swimming()
    {
        throw new System.NotImplementedException();
    }
}

public class GirlPlayer: IsFemale , CanSing
{
    public void CanSingClassical()
    {
        throw new System.NotImplementedException();
    }

    public void CanSingPop()
    {
        throw new System.NotImplementedException();
    }

    public void isSinger()
 {
     System.Console.WriteLine("Can sing songs");
 }

}
public interface CanPlay
{
    public void canPlayBasketball();
    public void Swimming();
}

public interface CanSing
{
    public void CanSingPop();
    public void CanSingClassical();
}