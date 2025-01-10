using lab10;
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] months = { "June", "July", "May", "December", "January", "February", "March", "April", "August", "September", "October", "November" };

        int n = 4;
        var monthsWithLengthN = months.Where(m => m.Length == n).ToList();
        Console.WriteLine("Месяцы с длиной строки равной {0}:", n);
        monthsWithLengthN.ForEach(Console.WriteLine);

        var summerAndWinterMonths = months.Where(m =>
            m == "June" || m == "July" || m == "August" ||
            m == "December" || m == "January" || m == "February").ToList();
        Console.WriteLine("\nЛетние и зимние месяцы:");
        summerAndWinterMonths.ForEach(Console.WriteLine);

        var sortedMonths = months.OrderBy(m => m).ToList();
        Console.WriteLine("\nМесяцы в алфавитном порядке:");
        sortedMonths.ForEach(Console.WriteLine);

        var monthsWithU = months.Where(m => m.Contains('u') && m.Length >= 4).ToList();
        Console.WriteLine("\nМесяцы, содержащие 'u' и длиной не менее 4-х:");
        monthsWithU.ForEach(Console.WriteLine);



        //Задание 2
        List<Abiturient> abiturients = new List<Abiturient>
            {
                new Abiturient("Ivanov", "Ivan", "Ivanovich", "Moscow", "1234567890", new List<double> { 5.5, 4.0, 9.5 }),
                new Abiturient("Petrov", "Petr", "Petrovich", "Saint Petersburg", "0987654321", new List<double> { 6.5, 4.0, 5.5 }),
                new Abiturient("Sidorov", "Sidor", "Sidorovich", "Novosibirsk", "4567890123", new List<double> { 9.0, 2.5, 3.0 }),
                new Abiturient("Vasiliev", "Vasily", "Vasilievich", "Kazan", "3216549870", new List<double> { 5.0, 8.5, 4.0 }),
                new Abiturient("Petrova", "Anna", "Petrovna", "Nizhny Novgorod", "6543217890", new List<double> { 3.0, 3.5, 4.0 }),
                new Abiturient("Smirnov", "Alexey", "Alexeyevich", "Yekaterinburg", "7896541230", new List<double> { 9.0, 2.0, 3.0 }),
                new Abiturient("Kuznetsov", "Dmitry", "Dmitrievich", "Chelyabinsk", "1472583690", new List<double> { 7.5, 9.5, 4.5 }),
                new Abiturient("Mikhailov", "Mikhail", "Mikhailovich", "Ufa", "2589631470", new List<double> { 4.5, 7.5, 10.0 }),
                new Abiturient("Fedorov", "Fedor", "Fedorovich", "Rostov", "3692581470", new List<double> { 1.0, 9.0, 2.5 }),
                new Abiturient("Romanov", "Roman", "Romanovich", "Voronezh", "1237894560", new List<double> { 4.0, 4.5, 6 })
            };

        // Пример LINQ запроса: Студенты с средней оценкой выше 3.0
        var highAchievers = abiturients
            .Where(a => a.CalculateAverageGrade() > 3.0)
            .ToList();

        Console.WriteLine("\nСтуденты с средней оценкой выше 3.0:");
        highAchievers.ForEach(a => Console.WriteLine(a));


        //ЗАДАНИЕ 4
        List<Student> students = new List<Student>
        {
            new Student { Name = "Alice", Age = 20, GPA = 3.5 },
            new Student { Name = "Bob", Age = 22, GPA = 3.9 },
            new Student { Name = "Charlie", Age = 21, GPA = 2.8 },
            new Student { Name = "David", Age = 23, GPA = 3.1 }
        };
        var complexQuery = students
        .Where(s => s.GPA >= 3.0) // Условия
        .GroupBy(s => s.Age) // Группировка
        .Select(g => new
        {
            Age = g.Key,
            AverageGPA = g.Average(s => s.GPA), // Агрегирование
            Count = g.Count() // Агрегирование
        })
        .OrderByDescending(g => g.AverageGPA) // Упорядочивание
        .ToList();

        Console.WriteLine("\nСредний GPA по возрасту:");
        foreach (var group in complexQuery)
        {
            Console.WriteLine($"Возраст: {group.Age}, Средний GPA: {group.AverageGPA}, Количество: {group.Count}");
        }




        //ЗАДАНИЕ 5
        List<Faculty> faculties = new List<Faculty>
        {
            new Faculty { Name = "Computer Science", AbiturientId = 1 },
            new Faculty { Name = "Mathematics", AbiturientId = 2 },
            new Faculty { Name = "Physics", AbiturientId = 3 },
            new Faculty { Name = "Biology", AbiturientId = 4 },
            new Faculty { Name = "Chemistry", AbiturientId = 5 }
        };

        // Join запрос
        var joinedQuery = from abiturient in abiturients
                          join faculty in faculties on abiturient.Id equals faculty.AbiturientId
                          select new
                          {
                              AbiturientName = abiturient.ToString(),
                              FacultyName = faculty.Name
                          };

        Console.WriteLine("\nАбитуриенты и их факультеты:");
        foreach (var item in joinedQuery)
        {
            Console.WriteLine($"{item.AbiturientName} -> Факультет: {item.FacultyName}");
        }



        //ЗАДАНИЕ ПО ВАРИАНТАМ 
        // 1. Список абитуриентов, имеющих неудовлетворительные оценки
        var studentsWithUnsatisfactoryGrades = abiturients
            .Where(a => a.HasUnsatisfactoryGrades())
            .ToList();

        Console.WriteLine("Абитуриенты с неудовлетворительными оценками:");
        studentsWithUnsatisfactoryGrades.ForEach(a => Console.WriteLine(a));

        // 2. Список абитуриентов, у которых сумма баллов выше заданной
        double threshold = 10.0; 
        var studentsWithHighGrades = abiturients
            .Where(a => a.CalculateSumGrades() > threshold)
            .ToList();

        Console.WriteLine($"\nАбитуриенты с суммой оценок выше {threshold}:");
        studentsWithHighGrades.ForEach(a => Console.WriteLine(a));

        int countOfTens = abiturients.Count(a => a.Grades.Count > 0 && a.Grades.Last() == 10.0); //10 - максимальная оценка
        Console.WriteLine($"\nКоличество абитуриентов с оценкой 10 по последнему предмету(химии): {countOfTens}");

        // 4. Массив абитуриентов, упорядоченных по алфавиту
        var sortedAbiturients = abiturients
            .OrderBy(a => a.LastName)
            .ThenBy(a => a.FirstName)
            .ToList();

        Console.WriteLine("\nАбитуриенты, упорядоченные по алфавиту:");
        sortedAbiturients.ForEach(a => Console.WriteLine(a));

        // 5. 4 последних абитуриента с самой низкой успеваемостью
        var lowestPerformingAbiturients = abiturients
            .OrderBy(a => a.CalculateAverageGrade()) // Сортируем по средней оценке
            .Take(4) // Берем первых 4
            .ToList();

        Console.WriteLine("\n4 абитуриента с самой низкой успеваемостью:");
        lowestPerformingAbiturients.ForEach(a => Console.WriteLine(a));


    }
}