using lab4;
using static lab4.Device;

class Program
{
    static void Main()
    {
        // Создаем контейнер
        DeviceContainer container = new DeviceContainer();
        DeviceController controller = new DeviceController(container);

        // Добавляем устройства
        controller.AddDevice(new SealedPrinter
        {
            Name = "HP Printer",
            Price = 200,
            Brand = "HP",
            PrintSpeed = 30,
            Info = new DeviceInfo(3, DeviceType.Printer)
        });
        controller.AddDevice(new Scanner
        {
            Name = "Canon Scanner",
            Price = 150,
            Brand = "Canon",
            Resolution = 1200,
            Info = new DeviceInfo(5, DeviceType.Scanner)
        });
        controller.AddDevice(new Computer
        {
            Name = "Dell PC",
            Price = 800,
            Brand = "Dell",
            Processor = "Intel i7",
            Info = new DeviceInfo(2, DeviceType.Computer)
        });
        controller.AddDevice(new Tablet
        {
            Name = "iPad",
            Price = 600,
            Brand = "Apple",
            Processor = "A14",
            ScreenSize = 10.2,
            Info = new DeviceInfo(1, DeviceType.Tablet)
        });

        // Найдем устройства старше 2 лет службы
        controller.FindAndPrintDevicesOlderThan(2);

        // Подсчитаем количество каждого типа устройств
        controller.CountDevicesByType();

        // Отсортируем устройства по убыванию цены и выведем их
        controller.SortAndPrintDevicesByPrice();
    }
}