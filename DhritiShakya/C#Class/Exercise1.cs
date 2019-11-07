class Multiple
{
    byte[] arrays01={5,7,15,25,34,50,67,70,75,89};
 foreach (byte array1 in arrays01)
        {
            if( array1 % 5==0)
            Console.WriteLine(array1);
        }
    }
}