namespace LearningMethods
{
    public class Methods
    {
        public long AddTwoNumbers(long a, long b)
            {
                long sum = a+b;
                return sum;
            }
    


//variable number of arguments
    public long Sum (params long[] numbers)
    {
        long sum = 0;
        foreach (long num in numbers)
        {
            sum = sum +num;
        }        
          return sum;  
    }

    //Optional Arguments
    public string GetFullName(string firstName,
                                string lastname,
                                string middleName = "")
                                {
                                   string fullName = $"{lastname}, {firstName} {middleName}";
                                    return fullName;
                                }
    
    //Returning multiple values
    public (int,int) GetMinMax(int[] nums)
    {
        int min = nums[0];
        int max = nums[0]; 
        for (int i = 1; i<nums.Length; i++)
        {
            if (min > nums[i])
                min = nums[i];
            else
                max =nums[i];
        }
        return (min,max);
    }
}
}    