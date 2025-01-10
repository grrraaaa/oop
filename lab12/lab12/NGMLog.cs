using System;
using System.IO;
using System.Linq;

namespace lab12
{
    public class NGMLog
    {
        private string logFile = "ngmlogfile.txt";

        // Метод для записи в лог
        public void WriteLog(string action, string details)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(logFile, true))
                {
                    writer.WriteLine($"{DateTime.Now:G} | {action} | {details}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка записи в лог: {ex.Message}");
            }
        }

        // Метод для чтения всего содержимого лога
        public void ReadLog()
        {
            try
            {
                using (StreamReader reader = new StreamReader(logFile))
                {
                    Console.WriteLine(reader.ReadToEnd());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка чтения лога: {ex.Message}");
            }
        }

        // Метод для поиска по ключевому слову
        public void SearchLog(string keyword)
        {
            try
            {
                using (StreamReader reader = new StreamReader(logFile))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.Contains(keyword))
                        {
                            Console.WriteLine(line);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка поиска в логе: {ex.Message}");
            }
        }

        // Метод для фильтрации записей по определенной дате
        public void FilterLogByDate(DateTime date)
        {
            try
            {
                using (StreamReader reader = new StreamReader(logFile))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Проверяем, начинается ли строка с указанной даты
                        if (line.StartsWith(date.ToString("d"))) // Формат: "MM/dd/yyyy"
                        {
                            Console.WriteLine(line);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка фильтрации лога: {ex.Message}");
            }
        }

        // Метод для фильтрации записей по диапазону времени
        public void FilterLogByTimeRange(DateTime start, DateTime end)
        {
            try
            {
                using (StreamReader reader = new StreamReader(logFile))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split('|');
                        if (parts.Length > 0)
                        {
                            if (DateTime.TryParse(parts[0].Trim(), out DateTime logTime))
                            {
                                if (logTime >= start && logTime <= end)
                                {
                                    Console.WriteLine(line);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка фильтрации по диапазону времени: {ex.Message}");
            }
        }

        // Метод для подсчета количества записей
        public void CountLogEntries()
        {
            try
            {
                int count = 0;
                using (StreamReader reader = new StreamReader(logFile))
                {
                    while (reader.ReadLine() != null)
                    {
                        count++;
                    }
                }
                Console.WriteLine($"Количество записей в логе: {count}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка подсчета записей: {ex.Message}");
            }
        }

        // Метод для удаления записей, оставляя только записи за текущий час
        public void KeepOnlyCurrentHourLogs()
        {
            try
            {
                var currentHour = DateTime.Now.Hour;
                var currentDate = DateTime.Now.Date;

                // Читаем все строки из файла
                string[] lines = File.ReadAllLines(logFile);

                // Фильтруем записи, оставляя только текущий час
                var filteredLines = lines.Where(line =>
                {
                    string[] parts = line.Split('|');
                    if (parts.Length > 0)
                    {
                        if (DateTime.TryParse(parts[0].Trim(), out DateTime logTime))
                        {
                            return logTime.Date == currentDate && logTime.Hour == currentHour;
                        }
                    }
                    return false;
                }).ToArray();

                // Перезаписываем файл с отфильтрованными строками
                File.WriteAllLines(logFile, filteredLines);

                Console.WriteLine("Лог обновлен: оставлены только записи за текущий час.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при удалении записей: {ex.Message}");
            }
        }
    }
}