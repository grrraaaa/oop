using System;
using lab12;
class Program
{
    static void Main(string[] args)
    {
        // Создание экземпляра для логирования
        NGMLog logger = new NGMLog();
        logger.WriteLog("Программа запущена", "Демонстрация использования классов");

        // Демонстрация работы NGMLog
        Console.WriteLine("=== Логирование действий ===");
        logger.WriteLog("Действие", "Тестовая запись в лог");
        logger.ReadLog();
        logger.SearchLog("Тестовая");

        // Демонстрация работы NGMDiskInfo
        Console.WriteLine("\n=== Информация о дисках ===");
        NGMDiskInfo diskInfo = new NGMDiskInfo();
        diskInfo.DisplayDiskInfo();

        // Демонстрация работы NGMFileInfo
        Console.WriteLine("\n=== Информация о файле ===");
        string testFilePath = "test.txt";
        System.IO.File.WriteAllText(testFilePath, "Тестовый файл");
        NGMFileInfo fileInfo = new NGMFileInfo();
        fileInfo.DisplayFileInfo(testFilePath);

        // Демонстрация работы NGMDirInfo
        Console.WriteLine("\n=== Информация о директории ===");
        string testDirPath = "TestDirectory";
        System.IO.Directory.CreateDirectory(testDirPath);
        NGMDirInfo dirInfo = new NGMDirInfo();
        dirInfo.DisplayDirInfo(testDirPath);

        // Демонстрация работы NGMFileManager
        Console.WriteLine("\n=== Управление файлами ===");
        NGMFileManager fileManager = new NGMFileManager();

        // Подготовка тестовых данных
        string testDir = "TestData";
        string testDirFiles = System.IO.Path.Combine(testDir, "Files");
        System.IO.Directory.CreateDirectory(testDir);
        System.IO.Directory.CreateDirectory(testDirFiles);
        System.IO.File.WriteAllText(System.IO.Path.Combine(testDir, "file1.txt"), "File 1");
        System.IO.File.WriteAllText(System.IO.Path.Combine(testDir, "file2.log"), "File 2");
        System.IO.File.WriteAllText(System.IO.Path.Combine(testDirFiles, "file3.txt"), "File 3");

        // 5a. Инспекция директории
        fileManager.InspectDirectory(testDir);

        // 5b. Копирование файлов по расширению
        fileManager.ManageFiles(testDir, ".txt");

        // 5c. Архивация и разархивация
        string archivePath = System.IO.Path.Combine(testDir, "NGMArchive.zip");
        string extractPath = System.IO.Path.Combine(testDir, "Extracted");
        fileManager.ArchiveFiles(System.IO.Path.Combine(testDir, "NGMInspect", "NGMFiles"), archivePath);
        fileManager.ExtractArchive(archivePath, extractPath);

        // 6. Работа с логами
        Console.WriteLine("\n=== Поиск в логах ===");
        logger.SearchLog("Действие");

        // Удаление записей, оставляя только записи текущего часа
        Console.WriteLine("\n=== Очистка лога ===");
        logger.WriteLog("Очистка", "Сохраняются только записи текущего часа");
        // (Для упрощения очистку оставляем как комментарий, добавьте метод удаления если потребуется)



        // Поиск записей за определенную дату
        Console.WriteLine("\nЗаписи за сегодня:");
        logger.FilterLogByDate(DateTime.Now);



        Console.WriteLine("\nЗаписи за последние 2 часа:");
        DateTime startTime = DateTime.Now.AddHours(-2); // 2 часа назад
        DateTime endTime = DateTime.Now;               // Сейчас
        logger.FilterLogByTimeRange(startTime, endTime);


        Console.WriteLine("\nУдаление всех записей, кроме текущего часа...");
        logger.KeepOnlyCurrentHourLogs();

        // Проверка лога после удаления
        Console.WriteLine("\nОбновленный лог:");
        logger.ReadLog();

        // Проверка лога после удаления
        Console.WriteLine("\nКоличество записей:");
        logger.CountLogEntries();

        // Завершение программы
        logger.WriteLog("Программа завершена", "Все демонстрации выполнены");
        
        Console.WriteLine("\n=== Демонстрация завершена ===");
    }
}
