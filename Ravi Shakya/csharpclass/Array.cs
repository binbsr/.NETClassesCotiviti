namespace DataTypeBasics
{

internal class Arrays
{
    //Declare one-dimensional array
   
    int[] array1 = new int[5];

    int[] array2= new int[] {23, 45, 43,46,67};

    int[] array3= new int[] {23, 45, 43,46,67};

    // Declare multi-dimensional array

    decimal[,] multiArray1 = new decimal[2,3];

    decimal[,] multiArray2 = { {1,2,3} , {1,3,5} };

    void DefineArrays()
    {
        // Jagged Arrays

    byte[] [] jaggedArray1 = new byte[3] [];
    jaggedArray1[0] = new byte[3] {1,2,3};
    jaggedArray1[1]= new byte[4] {1,2,3,4};
    jaggedArray1[2] = new byte[5] {1, 2, 3, 4, 5};
    }
}
}