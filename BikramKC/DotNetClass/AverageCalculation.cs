namespace DotNetClass
{
    public class CalculateAverage
    {
        public decimal CalcAvg(decimal x, decimal y , decimal z)
        {
            return (x + y + z ) /3;
        }
        public decimal CalcAvg1(decimal[] x)
        {
            decimal sum = 0;
            foreach(decimal y in x)
            {
                sum+=y;
            }
            return sum/x.Length;
        }
        public (int,int,int) GenderCount()
        {
            char?[] genderArrays = new char?[] { 'F', 'M', 'F', 'M', null, 'M', null, 'F', 'F', 'M', null, null, 'F', 'M', 'M' };
            int male=0,female=0,unknown=0;
            foreach(char? ch in genderArrays){
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
