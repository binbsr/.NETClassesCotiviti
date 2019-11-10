namespace Exercise
{
    public class Exercise2
    {
        public decimal CalcualteAverage(decimal a, decimal b, decimal c)
        {
            decimal avg;
            avg = (a + b + c) / 3;
            return avg;
        }

        public decimal CalcualteAvgOfAll(params decimal[] numbers)
        {
            decimal avg = 0;
            decimal sum = 0;
            foreach (decimal num in numbers)
            {
                sum += num;
            }
            avg = sum / numbers.Length;
            return avg;

        }

        public (int, int, int) CountGender()
        {
            char?[] genderCollection = new char?[] { 'F', 'M', 'F', 'M', null, 'M', null, 'F', 'F', 'M', null, null, 'F', 'M', 'M' };
            int male = 0, female = 0, other = 0;

            foreach (var gender in genderCollection)
            {
                if (gender == 'M')
                    male += 1;
                else if (gender == 'F')
                    female += 1;
                else
                    other += 1;
            }
            return (male,female,other);

        }
    }
}