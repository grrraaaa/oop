using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

[Serializable]
public class Table
{
    public string ItemType { get; set; } // Тип предмета, например "Стол", "Стул"
    public string Material { get; set; }  // Материал, из которого сделан предмет, например "Дерево", "Металл"

    public override string ToString() => $"ItemType: {ItemType}, Material: {Material}";
}

class Program
{
    static void Main(string[] args)
    {
        string filePath = "tables.xml";

        // Создание и сериализация коллекции
        List<Table> tables = new List<Table>
        {
            new Table { ItemType = "Dining Table", Material = "Wood" },
            new Table { ItemType = "Office Chair", Material = "Plastic" },
            new Table { ItemType = "Coffee Table", Material = "Glass" }
        };

        SerializeToXml(tables, filePath);
        List<Table> deserializedTables = DeserializeFromXml(filePath);
        foreach (var table in deserializedTables)
        {
            Console.WriteLine(table);
        }

        // Выполнение XPath запросов
        ExecuteXPathQueries(filePath);

        // Создание нового XML с использованием LINQ
        CreateXmlWithLinq();
    }

    static void SerializeToXml(List<Table> tables, string filePath)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Table>));
        using (FileStream stream = new FileStream(filePath, FileMode.Create))
        {
            serializer.Serialize(stream, tables);
        }
    }

    static List<Table> DeserializeFromXml(string filePath)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Table>));
        using (FileStream stream = new FileStream(filePath, FileMode.Open))
        {
            return (List<Table>)serializer.Deserialize(stream);
        }
    }

    static void ExecuteXPathQueries(string xmlFilePath)
    {
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.Load(xmlFilePath);

        // XPath запросы
        XmlNodeList allTables = xmlDoc.SelectNodes("/ArrayOfTable/Table");
        XmlNode woodTables = xmlDoc.SelectSingleNode("/ArrayOfTable/Table[Material='Wood']");

        Console.WriteLine("Все предметы:");
        foreach (XmlNode table in allTables)
        {
            Console.WriteLine(table.OuterXml);
        }

        Console.WriteLine("\nПредметы из дерева:");
        Console.WriteLine(woodTables?.OuterXml);
    }

    static void CreateXmlWithLinq()
    {
        var tables = new List<Table>
        {
            new Table { ItemType = "Dining Table", Material = "Wood" },
            new Table { ItemType = "Office Chair", Material = "Plastic" },
            new Table { ItemType = "Coffee Table", Material = "Glass" }
        };

        XDocument xmlDoc = new XDocument(
            new XElement("Tables",
                tables.Select(t =>
                    new XElement("Table",
                        new XElement("ItemType", t.ItemType),
                        new XElement("Material", t.Material)
                    )
                )
            )
        );

        // Сохранение нового XML
        xmlDoc.Save("newTables.xml");

        // Запросы LINQ
        var woodTables = xmlDoc.Descendants("Table")
                                  .Where(t => t.Element("Material")?.Value == "Wood");

        Console.WriteLine("\nПредметы из дерева (LINQ):");
        foreach (var table in woodTables)
        {
            Console.WriteLine(table);
        }
    }
}