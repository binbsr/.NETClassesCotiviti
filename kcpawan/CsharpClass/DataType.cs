namespace DatTypeBasics
{
    public class DataType
    {
        //Value Type
        
        //Number
        //Intergers

        byte a = 24; //8 bits
        short b = 3285; // 16 bits
        int c =  283893789; // 32 bit
        long d = 2398389748327008234;  //64 bits
        
        // Floating Point number

        float e  = 1829283.12F;  // 32 bits              6 - 9 digits
        double f = 32889889809.20; //64 bits            15 - 17 digits precision
        decimal g = 3298999999919.89M; //128 bits        28 - 29 digits


    //Character Types

        char h = 'r';


    // Boolean Types

        bool? m = null;

    // IF we give the question mark after any datatype then it will be nullable datatype

    //Reference Type 

        string n = "Hello World!!";

        object o = "ABC 123";




    }
}