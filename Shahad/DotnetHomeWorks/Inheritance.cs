namespace InheritanceExample
{

    public class LaLiga
    {
        public LaLiga()
        {
            System.Console.WriteLine("You are in Spanish Premier League");
        }

    }
    public class EPL
    {
        public EPL()
        {
            System.Console.WriteLine("You are in English Premier League");
        }

    }

    public class Barcelona : LaLiga, IChampionsLeague
    {
        public Barcelona()
        {
            System.Console.WriteLine("This is Barcelona Football Club");

        }
               public void ChampionsLeagueEntry()
        {
            System.Console.WriteLine(" Barcelona is Eligible for Champions League "); 
        }


    }


    public class ManchesterUnited : EPL, IChampionsLeague
    {
        public ManchesterUnited()
        {
            System.Console.WriteLine("This is Manchester United Football Club");
        }
             public void ChampionsLeagueEntry()
        {
            System.Console.WriteLine(" Manchester United is Eligible for Champions League "); 
        }
    }


    public class Liverpool : EPL, IClubWorldCup, IChampionsLeague
    {
        public Liverpool()
        {
            System.Console.WriteLine("This is Liverpool Football Club");
        }

          public void ClubWCEntry()
        {
            System.Console.WriteLine(" Liverpool is Eligible for Club World Cup ");
        }

           public void ChampionsLeagueEntry()
        {
            System.Console.WriteLine(" Liverpool is Eligible for Champions League "); 
        }


    }

    public class Forward : Barcelona
    {
        public Forward()
        {
            System.Console.WriteLine("Barcelona FC Forwards are worldClass");
        }
    }

    public interface IClubWorldCup
    {
        public void ClubWCEntry();
    
    }

    public interface IChampionsLeague
    {
        public void ChampionsLeagueEntry();
    }
}