internal class Arrays{
    int[] array1 = new int[5]; //single dimension array
   // array1[0] = 1;

    int[] array2 = new int[] {2,3,4}; // intializing at the declaration time

    int[] array3 = new int[] {43,45,67};

    decimal[,] multidimension = new decimal[2,3]; //2 dimension

    decimal[,,] multidimension2 = new decimal[2,3,4]; //3 dimension

    decimal[,] multiArray2 = {{1,2,3},{4,5,6}} ; // initialize while declaring : multidimension array

    //jagged Arrays
    void DefineArrays()
    {
    byte[][] jaggedArray = new byte[3][];
    jaggedArray[0] = new byte[3] {1,2,3};
    jaggedArray[1] = new byte[2] {3,4};
    }

}