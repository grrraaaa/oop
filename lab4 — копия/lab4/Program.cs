using System;
using lab4;






class Program
{
    static void Main()
    {
        Device device = new Device { Brand = "Apple" };

        //ISerializer soapSerializer = new SoapSerializer();
        ISerializer jsonSerializer = new JsonSerializer();
        ISerializer xmlSerializer = new XmlSerializer();

        //var soapData = soapSerializer.Serialize(device);
        var jsonData = jsonSerializer.Serialize(device);
        var xmlData = xmlSerializer.Serialize(device);
        Console.WriteLine($"JSON: {jsonData}");
        Console.WriteLine($"XML: {xmlData}");

        //Device soapDeserialized = soapSerializer.Deserialize<Device>(soapData);
        Device jsonDeserialized = jsonSerializer.Deserialize<Device>(jsonData);
        Device xmlDeserialized = xmlSerializer.Deserialize<Device>(xmlData);

        //Console.WriteLine($"SOAP: {soapDeserialized}");
        Console.WriteLine($"JSON: {jsonDeserialized}");
        Console.WriteLine($"XML: {xmlDeserialized}");
    }
}