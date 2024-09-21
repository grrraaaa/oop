class Program
{
    static void Main(string[] args)
    {
        (int, string, char, string, ulong) myTuple = (42, "Hello", 'A', "World", 1000000UL);

        Console.WriteLine("Кортеж целиком: " + myTuple);
        Console.WriteLine($"1-й элемент: {myTuple.Item1}, 3-й элемент: {myTuple.Item3}, 4-й элемент: {myTuple.Item4}");

        (int number, string str1, char symbol, string str2, ulong largeNumber) = myTuple;
        Console.WriteLine($"Распакованные значения: {number}, {str1}, {symbol}, {str2}, {largeNumber}");

        (_, _, char onlySymbol, _, _) = myTuple;
        Console.WriteLine($"Только символ: {onlySymbol}");

        int myInt;
        string myStr1, myStr2;
        char myChar;
        ulong myUlong;
        (myInt, myStr1, myChar, myStr2, myUlong) = myTuple;
        Console.WriteLine($"Распакованные значения с явными типами: {myInt}, {myStr1}, {myChar}, {myStr2}, {myUlong}");

        var anotherTuple = (42, "Hello", 'A', "World", 1000000UL);
        bool areTuplesEqual = myTuple == anotherTuple;
        Console.WriteLine($"Кортежи равны: {areTuplesEqual}");
    }
}
