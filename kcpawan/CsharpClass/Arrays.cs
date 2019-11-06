namespace DatTypeBasics
{
    internal class Arrays {

        //Declaring one dimensional array

        int[] array1 = new int[5];
       

        int[] array2 = new int[] { 23, 24, 25, 26, 78 };

        int[] array3 = { 23, 24, 25, 26, 27 };

        //Declaring multi-dimensional array

        decimal[, ] multiarray1 = new decimal[2, 3];

        decimal[, ] multiarray2 = { { 1, 2, 3 }, { 1, 2, 3 } };

        //Jagged Arrays

        void DefineArrays () 
        {
            byte[][] jaggedArray1 = new byte[3][];
            jaggedArray1[0] = new byte[3] { 1, 2, 3 };
            jaggedArray1[1] = new byte[2] { 45, 56 };
            jaggedArray1[2] = new byte[5] { 4, 5, 6, 7, 8 };
        }

    }
}