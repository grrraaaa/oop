using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{

    public class NGMFileInfo
    {
        public void DisplayFileInfo(string filePath)
        {
            try
            {
                FileInfo fileInfo = new FileInfo(filePath);
                if (fileInfo.Exists)
                {
                    Console.WriteLine($"Полный путь: {fileInfo.FullName}");
                    Console.WriteLine($"Размер: {fileInfo.Length} байт");
                    Console.WriteLine($"Расширение: {fileInfo.Extension}");
                    Console.WriteLine($"Имя: {fileInfo.Name}");
                    Console.WriteLine($"Дата создания: {fileInfo.CreationTime}");
                    Console.WriteLine($"Дата изменения: {fileInfo.LastWriteTime}");
                }
                else
                {
                    Console.WriteLine("Файл не найден.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка получения информации о файле: {ex.Message}");
            }
        }
    }

}
