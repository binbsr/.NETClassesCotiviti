using System;
using System.Collections;
using System.Collections.Generic;
using LearningMethods;
using LoopsAndConditions;
using PropertiesAndEnum;

//comment ctrl+K+C and uncomment ctrl+K+U
namespace MainProgram {
    public class EntryPoint {
        public static void Main () //Main method has to be static
        {

            // Iterations iterations = new Iterations();
            // iterations.DefineLoops();
            // Exercise1 exercise =new Exercise1();
            //exercise.ByteArrays();

            //Conditionals c = new Conditionals();
            //c.PrintHello();//Check if user says "Hi" or "Hello"? 
            //c.CheckIfUserSaysHi();
            //c.GetLargest(); //Largest number among 3 numbers?
            //c.CheckVowels(); //Check if entered alphabet is vowel or not?
            //c.EvenNumberCheckTernary();
            // c.SumofSquares();
            // c.LearnNestedLoops();
            //--------------------------------------------------------------------
            //Methods m = new Methods();

            //long s=m.AddTwoNumbers(222,3333);
            //Console.WriteLine("Sum is "+s);

            //string fn=m.GetFullName("Sristi","Musyaju");
            //string fn=m.GetFullName(lastName:"Musyaju", firstName:"Sristi");//Named arguments, no need to worry about argument ordering
            //Console.WriteLine("The fullname is "+fn);

            //Calculate Min/Max from the given set of numbers
            //  (int Min,int Max)  result=m.GetMinMax(new int[] {1,2,3,4,5});
            //  int minimum= result.Min;
            //  int maximum=result.Max;
            //  Console.WriteLine($"Minimum={result.Min} and Largest ={result.Max}");

            //Calculate average of the numbers provided
            // decimal avg = m.GetAverage(new decimal[] { 9.5M, 6.5M, 5.5M });
            // Console.WriteLine("The average of the provided input numbers=" + avg);

            // //Determine gender of the provided set
            // (int NoOfMales, int NoOfFemales, int NoOfOthers) result =
            // m.DetemineGender(new char?[] { 'F', 'M', 'F', 'M', null, 'M', null, 'F', 'F', 'M', null, null, 'F', 'M', 'M' });
            // Console.WriteLine($"No of Males={result.NoOfMales} and No of Females={result.NoOfFemales} and No of Others={result.NoOfOthers}");
            //-----------------------------------------------------------------------------------            

            //calling generic method
            // TestList<string> list=new TestList<string>();
            // list.Add("abcd");

            // TestList<byte> list1=new TestList<byte>();
            // list1.Add(34);

            //Non generic list, can hold any data type but is not suggested to use
            // ArrayList arrayList=new ArrayList();
            // //ctrl+. to find the namespace
            // arrayList.Add("asdf");
            // arrayList.Add(1234);

            // SortedList sortedList=new SortedList();

            // List<short> list = new List<short>();//List holds only one data type
            // {
            //     list.Add(123);
            //     list.Add(123);
            //     list.Add(123);

            //     List<Student> students = new List<Student>();
            //     Student student1 = new Student { name = "sristi" };

            //     Student student2 = new Student()
            //     {
            //         name = "shreya"
            //     };

            //     students.Add(student1);
            //     students.Add(student2);

            // Dictionary<int, string> countries = new Dictionary<int, string>()
            // {
            //     [1] = "USA",
            //     [977] = "Nepal",
            //     [91] = "India"
            // };
            // // //Dictionary hold multiple data type
            // // //Key has to be unique,first paramter is always key like int in this case
            // // countries.Add(1,"USA");
            // // countries.Add(977,"Nepal");
            // // countries.Add(91,"Nepal");

            // //Console.WriteLine(countries[0]);
            // foreach (var item in countries)
            // {
            //     Console.WriteLine(item.Key + "=" + item.Value);
            // }
            //------------------------------------------------------------------------------
            // Collection c = new Collection();
            // //Print the list of animals
            // List<string> resultListOfAnimals = c.GetAnimals();
            // foreach (string anim in resultListOfAnimals)
            // {
            //     Console.WriteLine(anim);

            // }
            // Console.WriteLine();

            // //Print the list of Songs and Genres
            // Dictionary<string, string> resultSongNameGenre = c.FetchSongsGenre();
            // foreach (var item in resultSongNameGenre)
            // {
            //     Console.WriteLine("Song name is " + item.Key + ", and song genre is " + item.Value);
            // }
            // Console.WriteLine();

            // //Print the list of Song details
            // List<SongDetails> resultSongDetails = c.FetchSongDetails();
            // foreach (var item in resultSongDetails)
            // {
            //     Console.WriteLine($"Song name is {item.name} , and song genre is {item.genre} and the artist is {item.artist}");
            // }
            // Console.WriteLine();

            // List<(string SongName, string Genre, string artist)> listofSongs = c.FetchSongDetails2();//Tuple deconstruction
            // foreach (var song in listofSongs)
            // {
            //     Console.WriteLine($"Song Name= {song.SongName} Genre={song.Genre} Artist= {song.artist}");
            // }

            //----------------------------------------------------------------------------------------
            // Person p = new Person();
            // Person p1 = new Person("Person1");
            //-----------------------------------------------------------
            //     PropertiesAndEnum.Person p = new PropertiesAndEnum.Person("Shreya", "Shrestha");
            //     var x = p.FirstName;
            //     var y = p.LastName;
            //     x = p.FullName;
            //     // p.FirstName = "abc";
            //     // x = p.FirstName;
            //     //Console.WriteLine($"{x}, {y}");
            //     Console.WriteLine(x);

            //     Customer customer = new Customer("");
            //     var a = Customer.cardNumber;
            //    // var z = Customer.citizenshipNumber;
            //    var z = customer.citizenshipNumber;
            //---------------------------------------------------
            // Student s1 = new Student (); //first object call always looks for static constructor, and is called only once
            // Student s2 = new Student ();
            // Student s3 = new Student ();
            //Student.address

            //Student.PrintStudentDetails();//call the static method through class i.e. class.
            //-----------------------------------------------------------
            //inheritance
            //Puppy p=new Puppy();
            // Isaleable p=new Puppy();//this allows dependency injection and hence loosely coupled code
            ISaleable s = new Snake ();
            Animal p = new Puppy ();//First calls the baseclass constructor i.e. Animal and later calls its own constructor
            // Animal p=new Puppy();

        }
    }
}