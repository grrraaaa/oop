using lab3;
public class Program
{
    public static void Main()
    {
        Set setA = new Set();
        setA <<= "apple";
        setA <<= "banana";
        setA <<= "kiwi";
        setA <<= "grape";

        Set setB = new Set();
        setB <<= "banana";
        setB <<= "kiwi";
        setB <<= "orange";

        Console.WriteLine("Set A: " + setA);
        Console.WriteLine("Set B: " + setB);

        Console.WriteLine("Set A < Set B: " + (setA < setB));
        Console.WriteLine("Set A != Set B: " + (setA != setB));

        setA >>= "grape";
        Console.WriteLine("Set A после удаления 'grape': " + setA);

        Set intersection = setA & setB;
        Console.WriteLine("Пересечение Set A и Set B: " + intersection);

        Console.WriteLine("Самое короткое слово в Set A: " + setA.ShortestWord());
        Console.WriteLine("Упорядоченные элементы Set A: " + string.Join(", ", setA.SortedElements()));

        Console.WriteLine("Сумма элементов Set A: " + StatisticOperation.Sum(setA));
        Console.WriteLine("Разница между максимальной и минимальной длиной: " + StatisticOperation.DifferenceMaxMin(setA));
        Console.WriteLine("Количество элементов в Set A: " + setA.CountElements());

        string sampleText = "Hello world! This is a test.";
        Console.WriteLine("Количество слов: " + sampleText.WordCount());

        Console.WriteLine("Общее количество символов в Set A: " + setA.TotalCharacterCount());





        Console.WriteLine("ПРОВЕРЯЕМ SETA[1] " + setA[1]);
        setA.getProd();

    }
} 