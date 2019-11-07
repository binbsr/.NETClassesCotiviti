namespace DataTypeBasics
{

internal class Arrays
{
    //Declare one dimensional array
    int[] array1=new int[5];//can be any data type
    int[] array2=new int[]{23,24,34,45,56};
    int[] array3={23,24,34,45,56};

    //declaring two dimensional array

    decimal[,] multiarray1=new decimal[2,3];//2 rows and 3 columns
    decimal[,] multiarray2= {{1,2,3},{4,5,6}};

    // Jagged Arrays
void definearrays()
{
    byte[][] jaggedarray1=new byte[3][];
    jaggedarray1[0]=new byte{1,2,3};
    jaggedarray1[1]=new byte{45,34};
    jaggedarray1[2]=new byte{5,6,7,8,9};
}
}}