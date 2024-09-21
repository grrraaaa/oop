class Program
{
    static void Main(string[] args)
    {
        var myVar = 5;   // Неявно типизированная переменная (тип выводится как int)
        Console.WriteLine($"Тип переменной myVar: {myVar.GetType()}");
    }
}