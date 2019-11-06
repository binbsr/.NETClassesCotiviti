namespace DataTypeBasics
{
    internal class Arrays
{
    int[] numbers = new int[5]; //single dimensional array
    int[] knownnumbers = new int[] { 1, 2, 3, 4, 5 };
    int[] wellKnownNumbers={1,2,3,4,55};

    //2 dimensional arrays
    int[,] matrix = new int[2,3];
    int [,]matrix2={{1,2,3},{1,2,3}};
    decimal[,] multiArray=new decimal[2,3];


    //jagged arrays
    void DefineArrays()
    {
            byte[][] jaggedArray1=new byte[3][];
            jaggedArray1[0]=new byte[3]{1,2,3};
            jaggedArray1[1]=new byte[2]{1,2};
    }
    
 }

}