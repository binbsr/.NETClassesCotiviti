namespace DataTypeBasic{

}
 
 internal class Array
{

    //one dimentional array
    int[] intArray = new int[5];
   // intArray[0] = 1;
    int[] array2 = new int[] { 1, 2, 3, 4, 5 };
    // int[] array2 = {1,2,3,4,5};

    //multi dimentional array
    decimal[,] multiArray1 = new decimal[2, 3]; //comman in array represent no. of dimentions in c#
    decimal[,] multiArray2 = {{1, 2, 3}, {1, 3, 5}};

    void DefineJaggedArray()
    {
        //Jagged Array
        byte[][] jagArray1 = new byte[3][]; //array of array
        jagArray1[0] = new byte[3] { 1, 2, 3 };
        jagArray1[1] = new byte[3] { 11, 22, 33 };
        jagArray1[2] = new byte[3] { 111, 222, 123 };

    }

}
 
 