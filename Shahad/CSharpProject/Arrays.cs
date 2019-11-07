namespace DataTypeBasic
{
internal class Arrays
{
    //Declare one-dimensional array
    int[] arrays1 = new int[5]; //declare array
    int[] arrays2 = new int[] {12, 34, 23, 44, 67}; //declare and initialize
    int[] arrays3 = {12, 34, 23, 44, 67}; //another way to declare
 
    //Declare two-dimensional array
    decimal[,] multlArray1 =new decimal [2, 3]; 
    decimal [,] multiArray2 = {{1,2,3},{4,5,6}};
 
    void DefineArrays()
    {
    //Jagged Arrays
    byte[][] jaggArray1 = new byte[3][];
    jaggArray1[0] = new byte[3] {1, 2, 3};
    jaggArray1[1] = new byte[2] {5, 32};
    jaggArray1[2] = new byte[5] {45, 23, 2, 54, 3}; 
    }
}
}