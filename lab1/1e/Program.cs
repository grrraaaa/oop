class Program
{
    static void Main(string[] args)
    {
        int? nullableInt = null;   // Nullable переменная типа int
        

        if (nullableInt.HasValue)
        {
            Console.WriteLine($"Значение nullableInt: {nullableInt.Value}");
        }
        else
        {
            Console.WriteLine("nullableInt имеет значение null.");
        }

    }
}