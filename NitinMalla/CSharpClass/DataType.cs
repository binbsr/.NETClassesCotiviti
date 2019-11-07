namespace DataTypeBasics
{
    public class DataType
    {
        // Value Types
        // numbers
        //Intergers
        byte a = 24; //8 bits  0 - 255
        short b = 3452; //16 bits 
        int c = 34323423; // 32 bits
        long d = 3243232432; // 64 bits

        //Floating point numbers
        float e = 1234.42F;  // 32 bits, 6-9 digits after decimal --- gaming app

        double f = 32234.4; // 64 bits, 12-17 digitis precision  -- default

        decimal g = 234234.4M; // 128 bits, 28-29 digits; -- scientific app

        // Character types
        char h = 'r';
        
        //Boolean types
        bool? m = false; // ? holds null as well makes variable nullable

        // Refernce Types

        string n = @"sl\kfjlsj";  // Verbating characters @ 
        string n1 = "sl\\kfjlsj";  // Verbating characters double slash

        object o  = ""; // can hold any thing
        
    }
}