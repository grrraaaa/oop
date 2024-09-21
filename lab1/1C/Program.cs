class Program
{
    static void Main(string[] args)
    {
        int value = 10;      // Значимый тип (value type)
        object boxedValue = value;  // Упаковка (boxing)

        int unboxedValue = (int)boxedValue;  // Распаковка (unboxing)

        Console.WriteLine($"Упакованное значение: {boxedValue}");
        Console.WriteLine($"Распакованное значение: {unboxedValue}");

    }
}