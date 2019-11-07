internal class Arrays
{
    //One dimensional array
    int[] array1 = new int[5];//Declare  array
    int[] array2 = new int[5] { 21, 22, 23, 24, 25 };//Declare and initialize 
    //alt+shift+F auto format
    int[] array3 = { 21, 22, 23, 24, 25 };//another option to declare

    //Multi dimensional array
    decimal[,] multiArray1 = new decimal[2, 3];
    decimal[,] multiArray2 = { { 1, 2, 3 }, { 1, 3, 5 } };//2*3

    //Jagged Arrays
    void DefineArrays()
    {
        byte[][] jaggedArray1 = new byte [3][];
        jaggedArray1[0] = new byte[3] { 1, 2, 3 };
        jaggedArray1[1] =new byte[4] { 1, 2, 3,4 };
        jaggedArray1[2] =new byte[5] { 1, 2, 3 ,4,5};
    }


}