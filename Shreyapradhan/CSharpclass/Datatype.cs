namespace DataTypeBasics
{
public class DataType
{
    //Value Type
        //Numbers
            //Intgers - byte, short, 
            byte a = 24; // 8 bits eg for age
            short b = 3453 ; //16 bits 
            int c = 345325; //32 bits
            long d = 1; //64 bits

            //Floating point numbers
            float e = 0.1F; //32 6-9 digits accuracy for gamings
            double f = 1.2; //64  15-17 digits precision //defacto
            decimal g = 3.4M; //128  28-29 digits precision for financial 

        // Character types
            char h = 'r';

        //Boolean types
            bool i = true;

            //nullable - int?, float? any data type can be nullable
            bool? j =  null;

    //Reference Type
        string k = @"f\sdfhkjshfd"; // or f\\sdhklldf;
        object l = "";

}

}