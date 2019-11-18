namespace DataTypeBasic
{
public class DataType
{
   //value types
    //numbers
    //Integers
    byte a; //8 bits 255
    short b; //16 bits
    int c;  //32 bits
    long d; //64 bits

    //Floting points
    float e =23423.123234F; //32 bits 6-9 digits after decimal .CPU intensive. gaming
    double f; //64 bits 15-17 digits after decimal
    decimal g =342423.323m; //128 bits 28-29 digits after decimal. Scientific purpose

    //Character Types
    char h = 't';
    
    //boolean type
    bool i;
    bool? j = null; //nullable. boolean that holds null, true, false

    //reference type
    string k= "";

    //object
    object l;

    

}   

}