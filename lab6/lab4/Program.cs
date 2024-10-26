using lab4;
using lab4.LOGGER;
using System.Diagnostics;
using System.IO;
using static lab4.Device;
using static lab4.Exceptions;

class Program
{
    static void Main()
    {
        try
        {
            // Simulate exceptions
            TestInvalidProduct();
            

        }
        catch (MemoryOverflowException ex) { 
            Console.WriteLine($"MemoryOverflowException СРАБОТАЛ ТАМ ГДЕ НЕ НАДО: {ex.Message}");

        }
        catch (InvalidProductException ex)
        {
            Console.WriteLine($"InvalidProductException: {ex.Message}");
        }
        catch { }








        try
        {
            TestMemoryIssue();
        }
        
        catch (MemoryOverflowException ex)
        {
            Console.WriteLine($"MemoryOverflowException: {ex.Message}");
        }
        





        try
        {
            TestFileRead();
        }
        
        catch (FileReadException ex)
        {
            Console.WriteLine($"FileReadException: {ex.Message}");
        } 
        
        
        
        try
        {
            TestNullReference();
        }
        
        catch (Exception ex)
        {
            Console.WriteLine($"TESTNULL: {ex.Message}");
        }




        try
        {
            TestDivisionByZero();
        }
        
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"DivideByZeroException: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Final cleanup code.");
        }



        var logger2 = new FileLogger(@"C:\log.txt");
        logger2.Log("fdfs", "fdsfs");

        ConsoleLogger logger = new ConsoleLogger();
        


        static void TestLogging(ConsoleLogger? logger)
        {
            int[] array = [1,2,3];
            Debug.Assert(array != null, "Values array cannot be null");

            logger.LogInfo("Starting application.");

            // Simulate a warning
            logger.LogWarning("This is a warning message.");

            try
            {
                // Simulate an error
                if (array == null)
                    throw new NullReferenceException("Array is null.");
            }
            catch (NullReferenceException ex)
            {
                logger.LogError(ex.Message);
                throw; // Re-throwing exception for further handling
            }
        }

        try
        {
            TestLogging(logger);
        }
        catch (Exception ex)
        {
            logger.LogError("An exception occurred: " + ex.Message);
        }


    }


    // Function to simulate invalid product initialization
    static void TestInvalidProduct()
    {
        string productName = "";
        if (string.IsNullOrWhiteSpace(productName))
        {
            try
            {
                throw new InvalidProductException("Product name cannot be empty.");

            }
            catch (Exception ex) { Console.WriteLine("СРАБОТАЛ ВНУТРЕННИЙ ВЛОЖЕННЫЙ КЭТЧ"); }
        }
    }

    // Function to simulate memory overflow
    static void TestMemoryIssue()
    {
        try
        {
            throw new MemoryOverflowException("Simulated memory overflow.");
        }
        catch (MemoryOverflowException ex)
        {
            Console.WriteLine("Caught and rethrowing: " + ex.Message);
            throw; // Rethrow the exception
        }
    }

    // Function to simulate file read error
    static void TestFileRead()
    {
        bool fileExists = false;
        if (!fileExists)
        {
            throw new FileReadException("Failed to read file. File not found.");
        }
    }

    // Function to simulate division by zero
    static void TestDivisionByZero()
    {
        int divisor = 0;
        if (divisor == 0)
        {
            throw new DivideByZeroException("Division by zero is not allowed.");
        }
    }

    // Function to simulate null reference
    static void TestNullReference()
    {
        object obj = null;
        Assert(obj != null, "Object is null.");
    }

    // Assert function with explanation
    static void Assert(bool condition, string message)
    {
        if (!condition)
        {
            throw new InvalidOperationException(message);
        }
    }












    //// Создаем контейнер
    //DeviceContainer container = new DeviceContainer();
    //DeviceController controller = new DeviceController(container);

    //// Добавляем устройства
    //controller.AddDevice(new SealedPrinter
    //{
    //    Name = "HP Printer",
    //    Price = 200,
    //    Brand = "HP",
    //    PrintSpeed = 30,
    //    Info = new DeviceInfo(3, DeviceType.Printer)
    //});
    //controller.AddDevice(new Scanner
    //{
    //    Name = "Canon Scanner",
    //    Price = 150,
    //    Brand = "Canon",
    //    Resolution = 1200,
    //    Info = new DeviceInfo(5, DeviceType.Scanner)
    //});
    //controller.AddDevice(new Computer
    //{
    //    Name = "Dell PC",
    //    Price = 800,
    //    Brand = "Dell",
    //    Processor = "Intel i7",
    //    Info = new DeviceInfo(2, DeviceType.Computer)
    //});
    //controller.AddDevice(new Tablet
    //{
    //    Name = "iPad",
    //    Price = 600,
    //    Brand = "Apple",
    //    Processor = "A14",
    //    ScreenSize = 10.2,
    //    Info = new DeviceInfo(1, DeviceType.Tablet)
    //});

    //// Найдем устройства старше 2 лет службы
    //controller.FindAndPrintDevicesOlderThan(2);

    //// Подсчитаем количество каждого типа устройств
    //controller.CountDevicesByType();

    //// Отсортируем устройства по убыванию цены и выведем их
    //controller.SortAndPrintDevicesByPrice();
}
