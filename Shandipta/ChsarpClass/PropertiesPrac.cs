namespace PropertiesPrac
{
    public class prac{
         private string lastName;
         private string firstName;


         public string FN {
             get{return firstName;}
             set{firstName=value;}
         }

         public string LN{
             get{return lastName;}
             set{lastName=value;}
         }

         public string FullName =>$"{firstName} {lastName}";

    }    

}