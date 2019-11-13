using System;
namespace LearningMethos
{

    // Write C# method that calculate average of 3 decimal number arguments.

    public class DecimalAverage
    {
        public decimal CalculateAverage(decimal x, decimal y, decimal z)
        {
            return (x + y + z) / 3;
        }

        // Modify same method above that allows user to supply any number of argumnets and calculate average of all.

        public decimal Average(params decimal[] numbers)
        {
            decimal avg;
            decimal sum = 0;
            int totalArguments = numbers.Length;
            foreach (decimal num in numbers)
            {
                sum = sum + num;
            }
            return avg = (sum / totalArguments);
        }

        // Wrtie C# method that count total males, females and others, given the array of genders as:
        //char?[] genderCollection = new char?[] { 'F', 'M', 'F', 'M', null, 'M', null, 'F', 'F', 'M', null, null, 'F', 'M', 'M' };

       // public (int,int,int) CountEachGenderType(){
        public (int,int,int) CountEachGenderType(){
            char?[] genderCollection = new char?[] { 'F', 'M', 'F', 'M', null, 'M', null, 'F', 'F', 'M', null, null, 'F', 'M', 'M' };
            int male=0,female=0,unknown=0;
            foreach(char? ch in genderCollection){
              if(ch=='F'){
                female++;
              }
              else if(ch=='M')
              male++;
              else
              unknown++;
            }
            return(female,male,unknown);


        }


    }

}
