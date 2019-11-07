using System;
public class MultipleOfFive{
    byte[] nums = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20 };

    public void Multiple(){
            foreach (byte num in nums) {
                if (num % 5 == 0)
                    Console.WriteLine (num);
            }

    
    }

    public void Multiple1(int a){
        for(int i=1; i<=a; i++){
            if (i%5==0){
                Console.WriteLine(i);
            }
        }
    }


}