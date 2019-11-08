namespace LearningMethods
{
    public class Methods
    {

        // public long Add2Numbers(long a, long b)
        // {
        //         return a+b;
        // }

        public long Sum(params long[] number)
        {
            long sum = 0;
            foreach (long num in number)
            {
                sum += num;
            }
            return sum;
        }

        public string GetFullName(string Fname, string Lname, string Mname = " ")
        {
            string fullName = $"{Lname},{Fname} {Mname}";
            return fullName;
        }

        public (int, int) GetMinMax(int[] nums)
        {
            int min = nums[0];
            int max = nums [0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (min > nums[i])
                {
                    min = nums[i];
                }
                else
                {
                    max = nums[i];
                }

            }
            return (min, max);
        }
    }






}