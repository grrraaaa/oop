using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    using System.Collections.Generic;
    using static lab4.Device;

    public class DeviceContainer
    {
        private List<Device> _devices = new List<Device>();

        // Метод для добавления устройства в контейнер
        public void AddDevice(Device device)
        {
            _devices.Add(device);
        }

        // Метод для удаления устройства из контейнера
        public bool RemoveDevice(Device device)
        {
            return _devices.Remove(device);
        }

        // Метод для получения устройства по индексу
        public Device GetDevice(int index)
        {
            if (index >= 0 && index < _devices.Count)
            {
                return _devices[index];
            }
            return null;
        }

        // Метод для вывода списка устройств
        public void PrintDevices()
        {
            foreach (var device in _devices)
            {
                Console.WriteLine(device.ToString());
            }
        }

        // Метод для подсчета количества устройств определенного типа
        public int CountDevicesByType(DeviceType type)
        {
            int count = 0;
            foreach (var device in _devices)
            {
                if (device.Info.Type == type)
                {
                    count++;
                }
            }
            return count;
        }

        // Метод для сортировки устройств по убыванию цены
        public void SortDevicesByPriceDescending()
        {
            _devices.Sort((d1, d2) => d2.Price.CompareTo(d1.Price));
        }

        // Метод для поиска устройств старше заданного срока службы
        public List<Device> FindDevicesOlderThan(int years)
        {
            List<Device> result = new List<Device>();
            foreach (var device in _devices)
            {
                if (device.Info.YearsInService > years)
                {
                    result.Add(device);
                }
            }
            return result;
        }
    }
}
