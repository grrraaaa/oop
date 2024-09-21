using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string str1 = "Hello";
        string str2 = "Hello";
        string str3 = "World";

        bool areEqual1 = str1 == str2;
        bool areEqual2 = str1.Equals(str3);

        Console.WriteLine($"str1 == str2: {areEqual1}");
        Console.WriteLine($"str1.Equals(str3): {areEqual2}");

        string s1 = "Hello";
        string s2 = "World";
        string s3 = "Welcome to C# programming";

        string concatenated = s1 + " " + s2;
        Console.WriteLine($"Сцепление: {concatenated}");

        string copiedString = (s2);
        Console.WriteLine($"Копирование строки: {copiedString}");

        string substring = s3.Substring(0, 7);
        Console.WriteLine($"Подстрока: {substring}");

        string[] words = s3.Split(' ');
        Console.WriteLine("Разделение строки на слова:");
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }

        string insertedString = s1.Insert(5, " C#!");
        Console.WriteLine($"Вставка подстроки: {insertedString}");

        string removedSubstring = s3.Remove(7, 3);
        Console.WriteLine($"Удаление подстроки: {removedSubstring}");

        string name = "John";
        int age = 30;
        string interpolatedString = $"My name is {name} and I am {age} years old.";
        Console.WriteLine($"Интерполяция: {interpolatedString}");

        string emptyString = "";
        string nullString = null;

        bool isEmptyOrNull1 = string.IsNullOrEmpty(emptyString);
        bool isEmptyOrNull2 = string.IsNullOrEmpty(nullString);

        Console.WriteLine($"emptyString IsNullOrEmpty: {isEmptyOrNull1}");
        Console.WriteLine($"nullString IsNullOrEmpty: {isEmptyOrNull2}");

        string safeString = string.IsNullOrEmpty(nullString) ? "default value" : nullString;
        Console.WriteLine($"Безопасная строка: {safeString}");

        StringBuilder sb = new StringBuilder("Hello, World!");

        sb.Remove(5, 2);
        sb.Insert(0, "Start: ");
        sb.Append(" :End");

        Console.WriteLine($"StringBuilder после изменений: {sb}");
    }
}
