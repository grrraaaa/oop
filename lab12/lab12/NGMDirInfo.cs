using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;

namespace lab12
{
   
    public class NGMDirInfo
    {
        public void DisplayDirInfo(string dirPath)
        {
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(dirPath);
                if (dirInfo.Exists)
                {
                    Console.WriteLine($"Количество файлов: {dirInfo.GetFiles().Length}");
                    Console.WriteLine($"Дата создания: {dirInfo.CreationTime}");
                    Console.WriteLine($"Количество поддиректорий: {dirInfo.GetDirectories().Length}");
                    Console.WriteLine("Родительские директории:");
                    DirectoryInfo parent = dirInfo.Parent;
                    while (parent != null)
                    {
                        Console.WriteLine(parent.FullName);
                        parent = parent.Parent;
                    }
                }
                else
                {
                    Console.WriteLine("Директория не найдена.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка получения информации о директории: {ex.Message}");
            }
        }
    }

}
