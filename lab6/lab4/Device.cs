using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    abstract partial class Device : Product
    {
        public DeviceInfo Info { get; internal set; }
        public override string ToString() => $"{base.ToString()}, Brand: {Brand}";
        // Перечисление для типа техники
        public enum DeviceType
        {
            Printer,
            Scanner,
            Computer,
            Tablet
        }

        // Структура для хранения срока службы техники
        public struct DeviceInfo
        {
            public int YearsInService { get; set; }
            public DeviceType Type { get; set; }

            public DeviceInfo(int yearsInService, DeviceType type)
            {
                YearsInService = yearsInService;
                Type = type;
            }

        }
    }
}
