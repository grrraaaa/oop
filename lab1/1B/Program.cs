class Program
{
    static void Main(string[] args)
    {
        int intValue = 100;
        double doubleValue = (double)intValue;   

        double anotherDouble = 3.14;
        int intFromDouble = (int)anotherDouble;  

        long longValue = 1000000000;
        int intFromLong = (int)longValue;        

        float floatValue = 5.75f;
        byte byteFromFloat = (byte)floatValue;   

        decimal decimalValue = 100.5m;
        int intFromDecimal = (int)decimalValue;  


        Console.WriteLine(doubleValue);
        Console.WriteLine(intFromDouble);
        Console.WriteLine(intFromLong);
        Console.WriteLine(byteFromFloat);
        Console.WriteLine(intFromDecimal);


        int smallIntValue = 42;
        long longFromInt = smallIntValue;

        float floatFromInt = smallIntValue;     

        byte byteValue = 100;
        int intFromByte = byteValue;            

        short shortValue = -32767;
        long longFromShort = shortValue;        

        char charValue = 'A';
        int intFromChar = charValue;


        Console.WriteLine('\n');
        Console.WriteLine(longFromInt);
        Console.WriteLine(floatFromInt);
        Console.WriteLine(intFromChar);
        Console.WriteLine(longFromShort);
        Console.WriteLine(intFromChar);


        string strValue = "123";

        int convertedInt = Convert.ToInt32(strValue);  
        double convertedDouble = Convert.ToDouble("12,1");
        bool convertedBool = Convert.ToBoolean("true");
        long convertedLong = Convert.ToInt64("1000");
        char convertedChar = Convert.ToChar("k");

        Console.WriteLine('\n');
        Console.WriteLine(convertedInt);
        Console.WriteLine(convertedDouble);
        Console.WriteLine(convertedBool);
        Console.WriteLine(convertedChar);

        

    }
}