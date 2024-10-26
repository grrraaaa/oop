using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

public class Set<T>
{
    private HashSet<T> elements;

    public Set()
    {
        elements = new HashSet<T>();
    }

    public void Add(T item)
    {
        elements.Add(item);
    }

    public void Remove(T item)
    {
        elements.Remove(item);
    }

    public void DisplayItems()
    {
        foreach (var item in elements)
        {
            Console.WriteLine(item);
        }
    }

    public void SaveToFile(string filePath)
    {
        var json = JsonSerializer.Serialize(elements);
        File.WriteAllText(filePath, json);
    }

    public void LoadFromFile(string filePath)
    {
        var json = File.ReadAllText(filePath);
        var list = JsonSerializer.Deserialize<HashSet<T>>(json);
        elements = list ?? new HashSet<T>();
    }
}