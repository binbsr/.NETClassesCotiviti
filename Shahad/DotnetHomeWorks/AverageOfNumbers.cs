namespace GetMethods
{
    public class AverageOfNumbers
    {
        public double GetAverageOf3(double n1, double n2, double n3)
        {
            double avg = (n1 + n2 + n3) / 3;
            return avg;
        }

        public double GetAverageOfN(double[] numbers)
        {
            double sum = 0;
            double avg = 0;
            foreach (double num in numbers)
            {
                sum = sum + num;
            }
            return avg = sum / (numbers.Length); ;
        }

    }
}
