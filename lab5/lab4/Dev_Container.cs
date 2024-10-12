using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lab4.Device;

namespace lab4
{
    public class DeviceController
    {
        private DeviceContainer _container;

        public DeviceController(DeviceContainer container)
        {
            _container = container;
        }

        // Метод для добавления устройств в контейнер
        public void AddDevice(Device device)
        {
            _container.AddDevice(device);
        }

        // Метод для поиска устройств старше заданного срока службы
        public void FindAndPrintDevicesOlderThan(int years)
        {
            var oldDevices = _container.FindDevicesOlderThan(years);
            Console.WriteLine($"Devices older than {years} years:");
            foreach (var device in oldDevices)
            {
                Console.WriteLine(device.ToString());
            }
        }

        // Метод для подсчета количества каждой категории устройств
        public void CountDevicesByType()
        {
            foreach (DeviceType type in Enum.GetValues(typeof(DeviceType)))
            {
                int count = _container.CountDevicesByType(type);
                Console.WriteLine($"{type}: {count}");
            }
        }

        // Метод для сортировки устройств по убыванию цены и вывода на экран
        public void SortAndPrintDevicesByPrice()
        {
            _container.SortDevicesByPriceDescending();
            Console.WriteLine("Devices sorted by price (descending):");
            _container.PrintDevices();
        }
    }
}
