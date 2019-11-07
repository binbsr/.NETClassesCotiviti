namespace DataTypeBasics
{
    public class DataType
    {
        //Value Types
        //Numbers
        //Intergers
        byte a = 24; //8 bits
        short b = 345;  //16 bits
        int c = 32423242; //32 bits
        long d = 34234242342423424; //64 bits

        //Floating point numbers
        float e = 234234.5f; //32 bits, 6-9 digits
        double f = 32332.2; //64 bits, 15-17 digits precision
        decimal g = 324242.5m;   //128 bits, 28-29 digits

        //Character types
        char h = 'r';

        //Boolean types
        bool? m = null;

        //Reference Types
        string n = @"f\sd\f\sf";
        object o = 342342;
    }
}