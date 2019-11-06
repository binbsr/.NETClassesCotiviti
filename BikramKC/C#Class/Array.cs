namespace C_Class
{
    internal class Array
    {
        int[] arrays1 = new int[5];
        int[] arrays2 = new int[] { 1, 2, 3, 4, 5 };
        int[] array3 = { 1, 3, 4, 5, 6 };
        char[,] multiDimArray1 = new char[2, 3];
        char[,] multiDimArray2 = { { 'a', 'b', 'c' }, { 'd', 'e', 'f' } };

        //jagged array
        void DefineArrays()
        {
            byte[][] jagArray1 = new byte[3][]; //array of array
            jagArray1[0] = new byte[3] { 1, 2, 3 };
            jagArray1[1] = new byte[3] { 11, 22, 33 };
            jagArray1[2] = new byte[3] { 14, 25, 37 };
        }
    }
}
