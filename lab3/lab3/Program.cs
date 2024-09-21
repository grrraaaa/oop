using lab2;
using System.Security.Cryptography.X509Certificates;
public class Program
{
    public static void Main()
    {
        var abiturients = new List<Abiturient>
        {
            new Abiturient("Ivanov", "Saveli", "NIKITIVICH", "Address 1", "1234567890", new List<double> { 3.0, 2.5, 4.0 }),
            new Abiturient("Levzikov", "Maksim", "NIKITIVICH", "Address 2", "0987654321", new List<double> { 4.5, 5.0, 4.7 }),
            new Abiturient("Dehtyaronok", "Andrey", "NIKITIVICH", "Address 4", "1122334455", new List<double> { 2.0, 1.5, 3.0 }),
            new Abiturient("Dehtyaronok", "Mikolay", "NIKITIVICH", "Address 5", "1144334455", new List<double> { 3.0, 2, 3.0 }),
            new Abiturient("Zakryzetckji", "Mikolay", "NIKITIVICH", "Address 6", "169853204455", new List<double> { 5.0, 3, 3.0 })
        };

        Console.WriteLine("Abiturients with unsatisfactory grades:");
        foreach (var abiturient in abiturients.Where(a => a.Grades.Any(g => g < 2.0)))
        {
            Console.WriteLine(abiturient);
            Console.WriteLine($"AVERAGE : {Math.Round(abiturient.Grades.Average(), 2)}");
            Console.WriteLine($"MAX : {Math.Round(abiturient.GetMaxGrade(),2)}");
            Console.WriteLine($"MIN : {abiturient.GetMinGrade()}");
        }

        double threshold = 10.0;
        Console.WriteLine($"\nAbiturients with total grades above {threshold}:");
        foreach (var abiturient in abiturients.Where(a => a.Grades.Sum() > threshold))
        {
            Console.WriteLine(abiturient);
        }

        Abiturient.ShowClassInfo();

        Console.WriteLine($"проверяем равны ли 1 и 2 абитуриенты : {abiturients[0].Equals(abiturients[1])}");
        Console.WriteLine($"проверяем равны ли 1 и 1 абитуриенты : {abiturients[0].Equals(abiturients[0])}");
        Console.WriteLine($"Hah of first : {abiturients[0].GetHashCode()}");
        Console.WriteLine($"Hah of sec : {abiturients[1].GetHashCode()}");

        var anonymousType = new { LastName = "Messi", FirstName = "Maksim", Grades = new List<double> { 3.5, 4.0, 4.5 } };
        Console.WriteLine($"\nAnonymous Type: LastName = {anonymousType.LastName}, FirstName = {anonymousType.FirstName}");

       
    }
}
