namespace Constructor
{
    public class Person{
         private string name; //to create a instant we need a constructor
         private byte age;
         private static string scientificName = "Homo Sapiens"; 
       //   private const string scientificName = "Homo Sapiens"; const cannot be changed on anycost
       // difference betn const and readonly: readonly variables can be changed on runtime

         public Person(){ // no return type in construtor


         }

       //  public Person (string name)=>this.name=name;
             public Person (string name){
             this.name = name;

         }

//


    }

   

}