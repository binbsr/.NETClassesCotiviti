using System;

public class Animal {
    public bool HasLegs { get; set; }
    public void Eat () {
        System.Console.WriteLine ("Eats veg-nonveg!");

    }
}

public class Dog : Animal {
    public void Dark () {
        System.Console.WriteLine ("Bhow-Bhow");
    }

    public Dog () {
        HasLegs = true;

        System.Console.WriteLine ("From Dog() Constructor");

    }

}

public class Snake : Animal, ISaleable {
    public Snake () {
        HasLegs = false;
    }

    public void Crawl () {

    }

    public void Buy () {
        throw new System.NotImplementedException ();
    }

    public void Sale () {
        throw new System.NotImplementedException ();
    }

}

public class Puppy : Dog, ISaleable
//public class Pupply: Dog, Animal----multiple inheritance is not allowed in c# 
// puppy is a Dog, is a gives identity/implement
//Puppy has a ISaleable, has a gives interfaces/extend
{

    public Puppy () {
        System.Console.WriteLine ("From Puppy() Constructor");
    }
    public void Weep () {
        System.Console.WriteLine ("Weeping...");
    }

    public void Buy () {
        throw new System.NotImplementedException ();
    }

    public void Sale () {
        throw new System.NotImplementedException ();
    }

}

//-------------------------interface-------------------------
public interface ISaleable {
    public void Buy ();
    public void Sale ();
}

//---------------------------Assignment Nov-19 -----------------------------------------

//Interface Songs
public interface IPlaySongs {
    public void PlaySongs ();
}

public interface IPlayAdvertisements {
    public void PlayAdvertisements ();
}
//----------------------------------------------

//Base Class Television
//2. Defined the baseclass as abstract to restrict instantiation
public abstract class Television {
    //1.Base class 1 should have a method that can be overriden by child classes
    public virtual int ProgramDisplayDays () { return 0; }

    public string ProgramName { get; set; }
    public string Language { get; set; }
    public string GetProgramName () => $"{ProgramName} {Language}";

}
public class MusicalShow : Television, IPlaySongs {
    public void PlaySongs () {
        throw new NotImplementedException ();
    }

    public string HostName { get; set; }

    //4.Child class 1 should have a method that hides a parent method.
    public new string GetProgramName () => $"{ProgramName} {Language} {HostName}";
    //1.Base class 1 should have a method that can be overriden by child classes
    public override int ProgramDisplayDays () { return 5; }

}

//7.Grand child should protect itself from getting inherited.
public abstract class Top10CountDownShows : MusicalShow {

}

//------------------------------------------------------

//Base class Radio
public abstract class Radio {
    //3.Base class 2 should have a method that must be overriden by child classes
    public abstract double DisplayDuration ();

    public virtual string DisplayCelerbityName (string CelebrityName) {

        return CelebrityName;
    }

    public string RadioProgramName { get; set; }

}

public class CelebritiesTalkProgram : Radio, IPlaySongs, IPlayAdvertisements {
    public void PlayAdvertisements () {
        throw new NotImplementedException ();
    }

    public void PlaySongs () {
        throw new NotImplementedException ();
    }

    public void playCommercialAdd () {
        System.Console.WriteLine ("This is commercial Add");
    }

    //6.Child class 2 should have a method that is overriden and uses base class implementation of that method as well.
    public override double DisplayDuration () => 1.5;

    //5.Child class 2 should have a propery that hides a property in a parent class.
    public new string RadioProgramName { get { return RadioProgramName; } set { RadioProgramName = value; } }

    public override string DisplayCelerbityName (string CelebrityName) {

        return $"{CelebrityName} - Is the guest invited to this program";
    }

}

public class NewsBroadCasting : Radio, IPlayAdvertisements {
    public void PlayAdvertisements () {
        throw new NotImplementedException ();
    }

    public void PlayEnglishNews () {
        System.Console.WriteLine ("This is English News.");
    }

    public override double DisplayDuration () => 1.0;
}