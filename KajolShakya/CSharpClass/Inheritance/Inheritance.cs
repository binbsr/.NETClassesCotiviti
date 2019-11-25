namespace Inheritance{

public class FullName {
    private string firstName;
    private string lastName;

    public string FirstName {get;set;}

    public string LastName{
        get{return lastName;}
        set{lastName = value;}
    }

    public string FN => $"{FirstName} {LastName}";
}

}

