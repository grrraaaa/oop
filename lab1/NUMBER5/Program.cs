using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 10, 20, 30, 40, 50 };
        string inputString = "Hello";

        (int max, int min, int sum, char firstLetter) ProcessData(int[] arr, string str)
        {
            int maxValue = arr[0];
            int minValue = arr[0];
            int sumValue = 0;

            foreach (int num in arr)
            {
                if (num > maxValue) maxValue = num;
                if (num < minValue) minValue = num;
                sumValue += num;
            }

            char firstChar = str.Length > 0 ? str[0] : '\0';

            return (maxValue, minValue, sumValue, firstChar);
        }

        var result = ProcessData(numbers, inputString);

        Console.WriteLine($"Максимум: {result.max}, Минимум: {result.min}, Сумма: {result.sum}, Первая буква строки: {result.firstLetter}");
    }
}
