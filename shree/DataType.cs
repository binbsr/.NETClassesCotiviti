namespace DataTypeBasic
{
    class DataType
    {
        // integer data typeof
        byte a = 1; // 8 bits;

        short b = 2; // 16 bits

        int c = 255; //32 bits

        long d = 32423; // 64 bits


        // floating data typeof
        float e; // 32 bits , 6 to 9 digits after decimal points

        double f;  // 64 bits, 15 to 17 digits precision

        decimal g; // 128 bits 28 to 29 digits

        // character types 
        char h = 'r';

        // boolean type 
        bool m; //true or false
                //bool? m(here? (question) mark hold TRUE, FALSE and NULL value for m);

        // Refrence type
        string n = "ram";
        string n = @"f\sfsd";  // @ is verbating character to represent '\' special character as a string ( we can use double \\ as well)

        // object type
        object o = "ram 1";  // take anything integer , character, string etc

    }
}