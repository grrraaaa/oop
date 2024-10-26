using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

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

class Program
{
    static void Main()
    {
        ObservableCollection<Student> students = new ObservableCollection<Student>();
        students.CollectionChanged += Students_CollectionChanged;

        var student1 = new Student("Alice", 20);
        var student2 = new Student("Bob", 22);

        Console.WriteLine("Adding students...");
        students.Add(student1);
        students.Add(student2);

        Console.WriteLine("\nRemoving a student...");
        students.Remove(student1);
    }

    private static void Students_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
    {
        if (e.Action == NotifyCollectionChangedAction.Add)
        {
            Console.WriteLine("Student added:");
            foreach (Student student in e.NewItems)
            {
                Console.WriteLine(student);
            }
        }
        else if (e.Action == NotifyCollectionChangedAction.Remove)
        {
            Console.WriteLine("Student removed:");
            foreach (Student student in e.OldItems)
            {
                Console.WriteLine(student);
            }
        }
    }
}