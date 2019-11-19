using LoopsAndConditions;
using LearningMethos;
using System.Collections.Generic;
using System.Collections;
using Practice;
using Collection;
using System;
using Properties;
using HealthAndFitness;
using Inheritance;
using PropertiesPrac;
using Sport;
namespace MainProgram
{
    public class entryPoint
    {
        public static void Main()
        {

            /*   Iterration iter = new Iterration ();
               iter.DefineLoops ();
               MultipleOfFive m = new MultipleOfFive();
               m. Multiple();
               m.Multiple1(100);
               */

            /*   Conditionals c = new Conditionals();
              c.CheckForCorrectString();
              c. GetLargestNumber();
              c.CheckVowel();*/
            /*        CheckForEvenNumber evenNum =  new CheckForEvenNumber();
                    evenNum.CheckEvenNumbers();
                    SumOfNaturalNumbers nnum = new SumOfNaturalNumbers();
                    nnum.NaturalNumbersSum();
                    Loops loop = new Loops();
                    loop.LearnNestedLoop();
                    Methods m = new Methods();
                    long sum=m.AddTwoNumbers(211,311111);
                    Console.WriteLine(sum);
                    long sum1=m.Sum(1,2,3,4,5);
                    Console.WriteLine(sum1);
                    string fullName = m.GetFullName(lastName:"Rai",firstName:"Shandipta");//named arguments
                    Console.WriteLine(fullName);
                    int[] value = new int[]{1,1,12,5,5,9};
                   (int min,int max) result= m.GetMinMax(value);
                    Console.WriteLine($"The Min. number is {result.min} and the Max. number is {result.max}");*/
            /*      DecimalAverage dec = new DecimalAverage();
                  decimal average = dec.CalculateAverage(123.54673m,5.678901m,545367.789m);
                  Console.WriteLine($"The average is {average}");
                  decimal average2=dec.Average(12.5m,15.2456m,1.445m,2,3,7,9,8);
                 Console.WriteLine($"The average is {average2}");
                (int F, int M, int U)result = dec.CountEachGenderType();
               Console.WriteLine($"Total Female: {result.F} Total Male: {result.M} Total Unknown: {result.U} ");*/


            /*         Collections c = new Collections();
                     List<String> animalList = c.GetAnimals();
                     Console.WriteLine("List of Animals:");
                     foreach (string a in animalList)
                     {
                         Console.WriteLine(a);

                     }
                     Console.WriteLine("-----------------------");

                     Dictionary<string, string> songList = c.FetchSongs();
                     Console.WriteLine("Song => Genre");
                     foreach (KeyValuePair<string, string> songs in songList)
                     {
                         Console.WriteLine("{0} => {1}", songs.Key, songs.Value);
                     }

                     Console.WriteLine("-----------------------");


                     Dictionary<string, List<string>> songDetail = c.FetchSongsDetail();
                     Console.WriteLine("Song | Genre | Singer/Band");
                     foreach (var songs in songDetail)
                     {
                         string key = songs.Key;
                         List<string> values = songs.Value;
                         Console.WriteLine(key + "| " + string.Join("| ", values));
                     }

                     Colletion02 cc = new Colletion02();
                    List<(string songName,string genreName,string artistName)> songs02 = cc.FetchSongDetail();
                    foreach(var song in songs02){
                        Console.WriteLine($"Song:{song.songName} Genre:{song.genreName} Artist:{song.artistName}");

                    } */
            /*        Properties.Person p = new Properties.Person("Anna", "Rai"); //to remove ambugity
                                                                                //  var x = p.FirstName;
                                                                                //  var y = p.LastName;
                                                                                //    var z = p.Phone;
                    var a = p.FullName;
                    //  var b = p.FirstName02;
                    Console.WriteLine(a);
                    //   Console.WriteLine(b);
                    // var x=Customer.CardNo; //doesnt need to create class object to call a constant of a class.
        */
            /*       Console.WriteLine("Enter your height in meter:");
                   var heightInMeter = float.Parse(Console.ReadLine());
                   Console.WriteLine("Enter your weight in kg:");
                   var weightInKg = float.Parse(Console.ReadLine());
                   Console.WriteLine("Enter your age:");
                   var age = Convert.ToInt32(Console.ReadLine());
                   Console.WriteLine("Gender M/F:");
                   var sex = Console.ReadLine();
                   BodyFatCaclulator FatCalc = new BodyFatCaclulator(heightInMeter, weightInKg);
                   FatCalc.Age = age;
                   FatCalc.Gender = sex;
                   FatCalc.GenderFlag = sex == "F" ? 0 : 1;
                   var bmicalc = FatCalc.PersonHealthDetail(FatCalc.BMICalculator);
                   Console.WriteLine(bmicalc);
                   var bodyFatAnalysis = sex == "F" ? FatCalc.BodyFatResultEvaluationFemale : FatCalc.BodyFatResultEvaluationMale;
                   Console.WriteLine(bodyFatAnalysis);*/

            //    Student s1 = new Student();
            //    Student s2 = new Student();
            //   Student s3 = new Student();
            //   Student.PrintStudentDetails();
            //Math.Sin(123);

            //Student.address

            // Dog d= new Dog();
            //  GermanShepard g = new GermanShepard(); 
            //  Animal a = new Snake(); // base cass
            //  var s = new Snake(); //loose coupling
            //  var g = new GermanShepard();
            //  ISaleable ss = new Snake();

            /*     prac p = new prac();
               var a = p.FName="Shandipta";
                p.LName="Rai";
                var v = p.FullName;
                Console.WriteLine(a);
                */
            Console.WriteLine("-----------------------------------");
            MotoGP mgp = new MotoGP();
            mgp.WinnerName();
            Console.WriteLine("-----------------------------------");
            Moto2 m3 = new Moto2();
            Console.WriteLine("-----------------------------------");
            MMA mma = new MMA();
            mma.WeightDivision(90);
            mma.WinnerName();
            Console.WriteLine("-----------------------------------");
            Boxing boxing = new Boxing();
            boxing.WeightDivision(90);


        }
    }
}
