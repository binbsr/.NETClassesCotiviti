//calculate average of 3 decimal number arguments.

namespace Practice
{
    public class Exercise2
    {
        public decimal CalculateAvgThreeArguments(decimal a, decimal b, decimal c)
        {
            decimal average = (a + b + c) / 3;
            return average;
        }

        public decimal CalculateAvgNArguments(params decimal[] numbers)
        {
            decimal average = 0, sum = 0;

            foreach (decimal num in numbers)
            {
                sum = sum + num;
            }
            average = sum / numbers.Length;
            return average;
        }

        public (int, int, int) CountGenderType()
        {
            char?[] genderCollection = new char?[] { 'F', 'M', 'F', 'M', null, 'M', null, 'F', 'F', 'M', null, null, 'F', 'M', 'M' };
            int male = 0, female = 0, others = 0;

            foreach (var gender in genderCollection)
            {
                if (gender == 'M')
                    male = male + 1;
                else if (gender == 'F')
                    female = female + 1;
                else
                    others = others + 1 ;
            }
            return (male, female, others);

        }

    }

}