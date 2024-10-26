
using System.Text.Json;

namespace lab3
{
    

    public class CollectionType<T> : IManageable<T>
    {
        private List<T> items;

        public CollectionType()
        {
            items = new List<T>();
        }

        public void Add(T item)
        {
            items.Add(item);
        }

        public void Remove(T item)
        {
            items.Remove(item);
        }

        public T View(Func<T, bool> predicate)
        {
            return items.FirstOrDefault(predicate);
        }

        public void DisplayItems()
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }

        // Example method to demonstrate exception handling with finally
        public void SafeRemove(T item)
        {
            try
            {
                if (!items.Contains(item))
                {
                    throw new ArgumentException("Item not found!");
                }
                Remove(item);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Operation completed.");
            }
        }


public void SaveToFile(string filePath)
    {
        var json = JsonSerializer.Serialize(items);
        File.WriteAllText(filePath, json);
    }

    public void LoadFromFile(string filePath)
    {
        var json = File.ReadAllText(filePath);
        items = JsonSerializer.Deserialize<List<T>>(json);
    }
}
}
