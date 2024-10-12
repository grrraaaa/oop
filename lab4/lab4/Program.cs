using System;
using lab4;

class Program
{
    static void Main()
    {
        Product[] products = new Product[]
        {
            new SealedPrinter { Name = "HP Printer", Price = 200, Brand = "HP", PrintSpeed = 30 },
            new Scanner { Name = "Canon Scanner", Price = 150, Brand = "Canon", Resolution = 1200 },
            new Computer { Name = "Dell PC", Price = 800, Brand = "Dell", Processor = "Intel i7" },
            new Tablet { Name = "iPad", Price = 600, Brand = "Apple", Processor = "A14", ScreenSize = 10.2 }
        };

        var printerUtility = new PrinterUtility();

        foreach (var product in products)
        {
            printerUtility.IAmPrinting(product);
        }

        UserClass userClass = new UserClass();

        Console.WriteLine("UserClass DoClone: " + userClass.DoClone());
        Console.WriteLine("UserClass ICloneable.DoClone: " + (userClass).DoClone());
    }
}