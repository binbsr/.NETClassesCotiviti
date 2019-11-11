
using System;
namespace UsingMethods
{
    public class Assignment2
    {
        public float CalcAverage(float n1, float n2, float n3)
        {
            //calculate average of 3 decimal number arguments
            float average = (n1 + n2 + n3) / 3;
            return average;
        }
        //Calculate average of all decimal number arguments
        public decimal CalcAllAverage(params decimal[] numbers)
        {
            decimal sum = 0;

            foreach (long num in numbers)
            {
                sum = sum + num;
            }
            return (sum / numbers.Length);
        }

        //counting total males, females and others, given the array of genders

        public (int, int, int) CountGender(char?[]genders)
        {
            //char?[] genderCollection = new char?[] { 'F', 'M', 'F', 'M', null, 'M', null, 'F', 'F', 'M', null, null, 'F', 'M', 'M' };
            
            int male = 0, female = 0, others = 0;
            foreach (char? gender in genders)
            {
                if (gender == 'M')
                {
                    male += 1;
                }
                else if (gender == 'F')
                {
                    female += 1;
                }
                else
                {
                    others += 1;
                }
                return (male, female, others);
            }
        }
    }

}