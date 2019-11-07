namespace DataTypeBasics
{
    internal class Arrays
    {
        // declaring one dimensional array
        int[] array = new int[5];
        // numbers[0] = 435;
        int[] array1 = new int[] { 23, 123, 12, 21, 123, 32, 232 };

        int[] array2 = { 12, 34, 343, 34, 34 };

        // declare multi dimensional array
        decimal[,] multiArray1 = new decimal[2, 3];

        decimal[,] multiArray2 = { { 1, 2, 0 }, { 1, 3, 5 } };

        void DefineArrays()
        {
            // jagged Arrays
            byte[][] jaggArray1 = new byte[3][]; //{{1,2,3},{1,9},{8,90,99,78}};

            jaggArray1[0] = new byte[3] { 1, 2, 3 };
            jaggArray1[1] = new byte[2] { 1, 3 };
            jaggArray1[2] = new byte[5] { 1, 2, 3, 45, 34 };

        }
    }
}