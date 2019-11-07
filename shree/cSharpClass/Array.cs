using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayBasics
{     internal class Array
    {
        // declaring single dimensional array

        int[] numbers = new int[5];
        int[] numbers1 = new int[] { 1, 2, 3, 4, 5 };       // array initialization
        int[] numbers2 = { 10, 20, 30, 40, 50 };                 // another way to initialize

        // declaring two dimensional array

        decimal[,] multiArray1 = new decimal[2, 3];         // two dimension with 2 rows 3 cols
        decimal[,] multiArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

        // Jagged arrays

        void DefineArray()
        {
            byte[][] jaggdArray1 = new byte[3][];
            jaggdArray1[0] = new byte[3] { 1, 2, 3 };
            jaggdArray1[1] = new byte[2] { 4, 5 };
            jaggdArray1[2] = new byte[4] { 6, 7, 8, 9 };

        }

    }
}
