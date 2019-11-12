using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    public class AverageOfThreeNumber
    {
        // Write C# method that calculate average of 3 decimal number arguments.
        public decimal GetAvgOfThreeNum(decimal x, decimal y, decimal z)
        {
            decimal result = (x + y + z) / 3;
            return result;
        }

        //Modify same method above that allows user to supply any number of argumnets and calculate average of all.
        public decimal GetAverageOfThreeNum1(params decimal[] numbers)
        {
            decimal sum = 0;
            foreach (decimal num in numbers)
            {
                sum += num;
            }
            return (sum / numbers.Length);
        }
    }
        
        public class Gender
        {
            //Wrtie C# method that count total males, females and others, given the array of genders as:
            //char?[] genderCollection = new char?[] { 'F', 'M', 'F', 'M', null, 'M', null, 'F', 'F', 'M', null, null, 'F', 'M', 'M' };

            public (int, int, int) GenderCollectionCount(char?[] genderCollection)
            {
                int maleCount = 0; int femaleCount = 0; int otherCount = 0;
                foreach (char? genderCount in genderCollection)             // here char ? is used to take null value as well
                {
                    if (genderCount == 'M')
                    {
                        maleCount++;
                    }
                    else if (genderCount == 'F')
                    {
                        femaleCount++;
                    }    
                    else
                    {
                        otherCount++;
                    }
                }
                return (maleCount, femaleCount, otherCount);
            }

        
    }
}
