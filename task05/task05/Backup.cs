using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;


namespace task05
{
    class Backup
    {
        private readonly string backupPath;
        private readonly string storagePath;
        public DateTime datetime { get; set; }
        private DirectoryInfo backupDir;
        private DirectoryInfo storageDir;
        private bool TryGetDateTime(string dateTimeBackup, out DateTime result)
        {
            return DateTime.TryParseExact(dateTimeBackup, "yyyy.MM.dd-HH.mm.ss", null, DateTimeStyles.None, out result);
        }
        public Backup()
        {   
            storagePath = $@"{Environment.CurrentDirectory}\Storage";
            backupPath = $@"{Environment.CurrentDirectory}\Backup";
            backupDir = new DirectoryInfo(backupPath);
            storageDir = new DirectoryInfo(storagePath);
        }
        public Backup(string backupPath, string storagePath)
        {
            this.storagePath = storagePath;
            this.backupPath = backupPath;
            backupDir = new DirectoryInfo(backupPath);
            storageDir = new DirectoryInfo(storagePath);
        }
        public void Recoil()
        {
            FileInfo[] storageInfo = storageDir.GetFiles("*.txt", SearchOption.AllDirectories);
            foreach (FileInfo file in storageInfo)
            {
                string nameDir;
                string nameFolder = Path.GetFileNameWithoutExtension(file.Name);
                if (file.DirectoryName != storageDir.FullName)
                {
                    string nameFileSubFolders = file.DirectoryName.Replace(storagePath, backupPath);
                    nameDir = Path.Combine(nameFileSubFolders, nameFolder);
                }
                else
                {
                    nameDir = Path.Combine(backupPath, nameFolder);
                }
                FileInfo[] backupInfo = backupDir.GetFiles("*.txt", SearchOption.AllDirectories) .Where(x => x.DirectoryName == nameDir).OrderByDescending(x => x.Name).ToArray();
                foreach (FileInfo backupFile in backupInfo)
                {
                    var strDateOfVersion = backupFile.Name.Substring(0, backupFile.Name.LastIndexOf('-'));
                    if (TryGetDateTime(strDateOfVersion, out DateTime date))
                        if (date.Date <= datetime.Date)
                        {
                            string text = File.ReadAllText(backupFile.FullName);
                            File.WriteAllText(file.FullName, text);
                            string name = backupFile.Name.Substring(backupFile.Name.LastIndexOf('-') + 2);
                            nameDir = $@"{ backupFile.Directory.Parent.FullName}\{name.Substring(0, name.LastIndexOf('.'))}";

                            if (backupFile.DirectoryName != nameDir)
                            {
                                Directory.Move(backupFile.DirectoryName, nameDir);
                            }
                            string fullName = $@"{file.DirectoryName}\{name}";
                            file.MoveTo(fullName);
                        }
                }
            }
        }
    }
}

