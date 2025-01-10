using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;
using System.IO.Compression;


namespace lab12
{
    public class NGMFileManager
    {
        public void InspectDirectory(string dirPath)
        {
            try
            {
                string inspectPath = Path.Combine(dirPath, "NGMInspect");
                Directory.CreateDirectory(inspectPath);

                string logFile = Path.Combine(inspectPath, "ngmdirinfo.txt");
                using (StreamWriter writer = new StreamWriter(logFile))
                {
                    foreach (var entry in Directory.GetFileSystemEntries(dirPath))
                    {
                        writer.WriteLine(entry);
                    }
                }

                File.Copy(logFile, Path.Combine(inspectPath, "copy_ngmdirinfo.txt"));
                
                File.Delete(logFile);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка обработки директории: {ex.Message}");
            }
        }

        public void ManageFiles(string sourceDir, string extension)
        {
            try
            {
                string filesDir = Path.Combine(sourceDir, "NGMFiles");
                Directory.CreateDirectory(filesDir);

                foreach (var file in Directory.GetFiles(sourceDir, $"*{extension}"))
                {
                    string destPath = Path.Combine(filesDir, Path.GetFileName(file));
                    File.Copy(file, destPath);
                }

                string inspectPath = Path.Combine(sourceDir, "NGMInspect");
                Directory.Move(filesDir, Path.Combine(inspectPath, "NGMFiles"));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка управления файлами: {ex.Message}");
            }
        }

        public void ArchiveFiles(string sourceDir, string archivePath)
        {
            try
            {
                ZipFile.CreateFromDirectory(sourceDir, archivePath);
                Console.WriteLine($"Архив создан: {archivePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка создания архива: {ex.Message}");
            }
        }

        public void ExtractArchive(string archivePath, string extractPath)
        {
            try
            {
                ZipFile.ExtractToDirectory(archivePath, extractPath);
                Console.WriteLine($"Архив разархивирован в: {extractPath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка разархивирования: {ex.Message}");
            }
        }
    }

}
