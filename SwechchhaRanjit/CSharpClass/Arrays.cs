namespace DataTypeBasics
{
    internal class Arrays
    {
        // Declare one dimensional array
        int[] array1 = new int[5];
        int[] array2 = new int[] { 23, 45, 43, 56, 78 };
        int[] array3 = { 23, 45, 43, 56, 78 };

        // Declare two-dimensional array
        decimal[,] multiArray1 = new decimal[2, 3];
        decimal[,] multiArray2 = { { 1, 2, 3 }, { 1, 3, 5 } };

        void DefineArrays()
        {
            // Jagged Arrays
            byte[][] jaggArray1 = new byte[3][];
            jaggArray1[0] = new byte[3] { 1, 2, 3 };
            jaggArray1[1] = new byte[2] { 45, 56 };
            jaggArray1[2] = new byte[5] { 4, 5, 6, 7, 8 };


        }

    }

}