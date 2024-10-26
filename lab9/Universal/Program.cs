using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Создание и заполнение List<int>
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Console.WriteLine("Original collection:");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }

        // Удаление n элементов
        int n = 3;
        numbers.RemoveRange(0, n);

        Console.WriteLine("\nCollection after removal:");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }

        // Добавление элементов
        numbers.Add(11);
        numbers.Insert(0, 0);

        Console.WriteLine("\nCollection after adding elements:");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }

        // Создание второй коллекции (Queue<int>)
        Queue<int> queue = new Queue<int>(numbers);

        Console.WriteLine("\nSecond collection (Queue):");
        foreach (var number in queue)
        {
            Console.WriteLine(number);
        }

        // Поиск элемента
        int searchValue = 5;
        Console.WriteLine($"\nSearching for {searchValue} in Queue:");
        if (queue.Contains(searchValue))
        {
            Console.WriteLine("Value found.");
        }
        else
        {
            Console.WriteLine("Value not found.");
        }
    }
}