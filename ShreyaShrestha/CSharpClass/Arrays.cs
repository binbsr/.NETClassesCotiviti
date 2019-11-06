namespace DataTypeBasics
{
internal class Arrays
{
    //Declaration of one dimensional array
    int[] array1 = new int[5];    //one dimensional array
    int[] array2 = new int[] { 1, 2, 3, 4, 5 }; //intialization right where array has been declared

    int[] array3 = { 6, 7, 8, 9, 10 };

    //Declaration of multi - dimensional array
    decimal[,] multiArray1 = new decimal[2, 3]; /*2 rows 3 column decimal[][] multiArray1 = new decimal[2][3] is also valid */
    decimal[,] multiArray2 = { { 1, 2,3 }, { 3, 4 ,5} }; //array of 3 rows and 2 columns

    //JaggedArray
    void DefineArray()
    {    
        byte[][] jaggArray1 = new byte[3][];
        jaggArray1[0] = new byte[3] {1,2,3};
        jaggArray1[1] = new byte[2] {4,5};
        jaggArray1[2] = new byte[4] {5,6,7,8};

    }
}
}