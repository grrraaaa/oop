class Program
{
    static void Main(string[] args)
    {
        int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        Console.WriteLine("Двумерный массив (матрица):");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

        string[] stringArray = { "Apple", "Banana", "Cherry", "Date", "Elderberry" };

        Console.WriteLine("\nОдномерный массив строк:");
        foreach (var str in stringArray)
        {
            Console.WriteLine(str);
        }

        Console.WriteLine($"Длина массива: {stringArray.Length}");

        Console.Write("Введите позицию элемента для изменения (0-4): ");
        int position = int.Parse(Console.ReadLine());

        Console.Write("Введите новое значение для элемента: ");
        string newValue = Console.ReadLine();

        if (position >= 0 && position < stringArray.Length)
        {
            stringArray[position] = newValue;
        }

        Console.WriteLine("\nИзмененный массив строк:");
        foreach (var str in stringArray)
        {
            Console.WriteLine(str);
        }

        double[][] jaggedArray = new double[3][];
        jaggedArray[0] = new double[2];
        jaggedArray[1] = new double[3];
        jaggedArray[2] = new double[4];

        Console.WriteLine("\nВведите значения для ступенчатого массива:");

        for (int i = 0; i < jaggedArray.Length; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write($"Введите элемент [{i}][{j}]: ");
                jaggedArray[i][j] = double.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("\nСтупенчатый массив:");
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write(jaggedArray[i][j] + "\t");
            }
            Console.WriteLine();
        }

        var implicitlyTypedArray = new[] { 1, 2, 3, 4, 5 };
        var implicitlyTypedString = "Это неявно типизированная строка";

        Console.WriteLine("\nНеявно типизированный массив:");
        foreach (var item in implicitlyTypedArray)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine("\n\nНеявно типизированная строка:");
        Console.WriteLine(implicitlyTypedString);
    }
}
