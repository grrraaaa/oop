using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    public class NGMDiskInfo
    {
        public void DisplayDiskInfo()
        {
            try
            {
                foreach (var drive in DriveInfo.GetDrives())
                {
                    if (drive.IsReady)
                    {
                        Console.WriteLine($"Имя: {drive.Name}");
                        Console.WriteLine($"Файловая система: {drive.DriveFormat}");
                        Console.WriteLine($"Общий объем: {drive.TotalSize / 1024 / 1024} MB");
                        Console.WriteLine($"Доступный объем: {drive.AvailableFreeSpace / 1024 / 1024} MB");
                        Console.WriteLine($"Метка тома: {drive.VolumeLabel}");
                        Console.WriteLine("--------------------");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка получения информации о дисках: {ex.Message}");
            }
        }
    }

}
