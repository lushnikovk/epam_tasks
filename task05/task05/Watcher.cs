using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;

namespace task05
{
    class Watcher
    {
        public FileSystemWatcher watcher { get; protected set; }
        public static string PathBackup { get; private set; } = $@"{Environment.CurrentDirectory}\Backup";
        public static string PathStorage { get; private set; } = $@"{Environment.CurrentDirectory}\Storage";
        public Watcher()
            {
                string pathStorage = $@"{Environment.CurrentDirectory}\STORAGE";    
                FileSystemWatcher watcher = new FileSystemWatcher();
                watcher.Path = pathStorage;
                watcher.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.LastAccess | NotifyFilters.FileName | NotifyFilters.DirectoryName;
                watcher.EnableRaisingEvents = true;
                watcher.Filter = "*.*";
                watcher.Deleted += OnDelete;
                watcher.Renamed += OnRenamed;
                watcher.Changed += Changed;
            Console.WriteLine("Для завершения нажмите пробел");
            change();
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            
            while (keyInfo.Key !=  ConsoleKey.Spacebar);
        }
        public Watcher(string pathStorage, string pathBackup)
            {
            PathBackup = pathBackup;
          watcher = new FileSystemWatcher(pathStorage)
            {
                Filter = "*.*",
                NotifyFilter = NotifyFilters.LastAccess
                                 | NotifyFilters.LastWrite
                                 | NotifyFilters.FileName
                                 | NotifyFilters.DirectoryName,
                IncludeSubdirectories = true
            };
            watcher.Deleted += OnDelete;
            watcher.Renamed += OnRenamed;
            watcher.Changed += Changed;
        }
            private static void change()
            {
                DateTime dt = DateTime.Now;
                string pathDate = PathBackup + "\\" + dt.ToString().Replace(":", ".");
                DirectoryInfo dirDate = new DirectoryInfo(pathDate);
                dirDate.Create();
                foreach (string dirPath in Directory.GetDirectories(PathStorage, "*", SearchOption.AllDirectories))
                {
                    Directory.CreateDirectory(dirPath.Replace(PathStorage, pathDate));
                }
                foreach (string filePath in Directory.GetFiles(PathStorage, "*.*", SearchOption.AllDirectories))
                {
                    File.Copy(filePath, filePath.Replace(PathStorage, pathDate), true);
                }
            }
            private static void Changed(object temp, FileSystemEventArgs e)
            {
            change();
            Console.WriteLine("Файл изменён  {0}, {1} ", e.Name, e.ChangeType);
            }

            private static void OnRenamed(object temp, RenamedEventArgs e)
            {
            change();
            Console.WriteLine("название файла изменено  {0}, {1} ", e.OldName, e.Name);
            }
            private static void OnDelete(object temp, FileSystemEventArgs e)
            {
            change();
            Console.WriteLine("файл удалён");
            }
        }
    }

