using System;
namespace LearningMethos

{

    public class Methods
    {

        public long AddTwoNumbers(long a, long b)
        {
            long sum = a + b;
            return sum;
        }
        //Variable number of arguments
        public long Sum(params long[] numbers)
        {
            long sum = 0;
            foreach (long num in numbers)
            {
                sum = sum + num;

            }
            return sum;
        }


        //Optional Arguments
        public string GetFullName(string firstName,  
                                    string lastName,
                                     string middleName="") //Optional argument should appear at 
                                                            // the last i.e after all formal arguments.
        {
               // string fullName =lastName+","+firstName+" "+middleName;
                string fullName =$"{lastName}, {firstName} {middleName}"; //string interpolation
                return fullName;
        }

        //return more than one arguments is called topple in c#
        public (int, int) GetMinMax(int[] nums){
            int min=nums[0];
            int max=nums[0];
           for(int i=1; i<nums.Length;i++){

               if(min>nums[i])
                   min=nums[i];
                   else max=nums[i];
               
           }
           return (min,max);
        } 




    }
}