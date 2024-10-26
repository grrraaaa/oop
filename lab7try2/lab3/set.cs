using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace lab3
{
    public partial class Set<T> 
    {
        private HashSet<T> elements;

        public Set()
        {
            elements = new HashSet<T>();
            ProductionInfo = new Production(0, "Default");
        }

        public void Add(T item)
        {
            elements.Add(item);
        }

        public void Remove(T item)
        {
            elements.Remove(item);
        }

        public bool Contains(T item)
        {
            return elements.Contains(item);
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
}

