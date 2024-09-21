using System;

public class Class1
{
	public Class1()
	{
        int intValue = 100;
        double doubleValue = (double)intValue;   // Явное приведение int к double

        double anotherDouble = 3.14;
        int intFromDouble = (int)anotherDouble;  // Явное приведение double к int

        long longValue = 1000000000;
        int intFromLong = (int)longValue;        // Явное приведение long к int

        float floatValue = 5.75f;
        byte byteFromFloat = (byte)floatValue;   // Явное приведение float к byte

        decimal decimalValue = 100.5m;
        int intFromDecimal = (int)decimalValue;  // Явное приведение decimal к int

    }
}
