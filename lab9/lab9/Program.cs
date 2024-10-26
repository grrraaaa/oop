
using System;
using System.Collections;
using System.Collections.Generic;

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}";
    }
}

public class StudentCollection : IEnumerable<Student>
{
    private Queue<Student> students = new Queue<Student>();

    public void AddStudent(Student student)
    {
        students.Enqueue(student);
    }

    public void RemoveStudent()
    {
        if (students.Count > 0)
        {
            students.Dequeue();
        }
    }

    public Student FindStudent(string name)
    {
        foreach (var student in students)
        {
            if (student.Name == name)
            {
                return student;
            }
        }
        return null;
    }

    public IEnumerator<Student> GetEnumerator()
    {
        return students.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

// Демонстрация
class Program
{
    static void Main()
    {
        StudentCollection collection = new StudentCollection();

        collection.AddStudent(new Student("Alice", 20));
        collection.AddStudent(new Student("Bob", 22));

        Console.WriteLine("Students in collection:");
        foreach (var student in collection)
        {
            Console.WriteLine(student);
        }

        Console.WriteLine("\nRemoving a student...");
        collection.RemoveStudent();

        Console.WriteLine("\nStudents in collection after removal:");
        foreach (var student in collection)
        {
            Console.WriteLine(student);
        }

        var foundStudent = collection.FindStudent("Bob");
        Console.WriteLine($"\nFound student: {foundStudent}");
    }
}