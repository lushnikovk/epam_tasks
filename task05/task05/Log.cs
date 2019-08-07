using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;
namespace task05
{
    class Logger
    {
        public Logger()
        {
            logger();
        }

        private void logger()
        {
            DirectoryInfo directory = new DirectoryInfo($@"{Environment.CurrentDirectory}\Backup");
            if (!directory.Exists)
                directory.Create();
            else
            {
                directory.Delete(true);
                directory.Create();
            }
        }

        public void SaveChangedOrCreatedFileLog(string dir, string fileName, DateTime date)
        {
            if (Path.GetExtension(fileName) == "")
            {
                DirectoryInfo directory = new DirectoryInfo($@"{Environment.CurrentDirectory}\Backup" + $@"\{fileName}\");
                if (!directory.Exists)
                {
                    directory.Create();
                }
            }
            else
            {
                string Date = date.ToString("yyyy.MM.dd-HH.mm.ss");
                string FileName = Path.GetFileNameWithoutExtension(fileName);
                DirectoryInfo directory = new DirectoryInfo($@"{Environment.CurrentDirectory}\Backup" + $@"\{ FileName }\");
                if (!directory.Exists)
                {
                    directory.Create();
                }
                string NewDir = directory.FullName + $@"{Date}-{Path.GetFileName(fileName)}";
                try
                {
                    if (!File.Exists(NewDir))
                        File.Copy(dir, NewDir);
                }
                catch
                {
                    return;
                }
            }
        }
        public void SaveRenamedFileLog(string newdir, string oldFileName, string newFileName, DateTime date)
        {
            if (Path.GetExtension(newFileName) == string.Empty)
            {
                DirectoryInfo directory = new DirectoryInfo($@"{Environment.CurrentDirectory}\Backup" + $@"\{oldFileName}\");
                string Directory = $@"{Environment.CurrentDirectory}\Backup" + $@"\{newFileName}\";
                if (directory.Exists)
                {
                    directory.MoveTo(Directory);
                }
            }
            else
            {
                string Date = date.ToString("yyyy.MM.dd-HH.mm.ss");
                string OldFileName = Path.GetFileNameWithoutExtension(oldFileName);
                string NewFileName = Path.GetFileNameWithoutExtension(newFileName);
                DirectoryInfo directory = new DirectoryInfo($@"{Environment.CurrentDirectory}\Backup" + $@"\{OldFileName}\");
                string Directory = $@"{Environment.CurrentDirectory}\Backup" + $@"\{NewFileName}\";
                if (directory.Exists)
                {
                    directory.MoveTo(Directory);
                }
                string newFileDir = Directory + $@"{Date}-{Path.GetFileName(newFileName)}";
                DirectoryInfo newDir = new DirectoryInfo(newFileDir);
                if (!newDir.Parent.Exists)
                    newDir.Parent.Create();
                if (!File.Exists(newFileDir))
                    File.Copy(newdir, newFileDir);
            }
        }
        public void SaveDeletedFileLog(string dir, string fileName, DateTime date)
        {
            string Date = date.ToString("yyyy.MM.dd-HH.mm.ss");
            if (Path.GetExtension(fileName) == string.Empty)
            {
                DirectoryInfo directory = new DirectoryInfo($@"{Environment.CurrentDirectory}\Backup" + $@"\{fileName}\");
                string destDirectory = $@"{Environment.CurrentDirectory}\Backup" + $@"\Deleted-{Date}-{fileName}\";
                if (directory.Exists)
                {
                    directory.MoveTo(destDirectory);
                }
            }
            else
            {
                string FileName = fileName.Replace(Path.GetExtension(fileName), "");
                DirectoryInfo directory = new DirectoryInfo($@"{Environment.CurrentDirectory}\Backup" + $@"\{FileName}\");
                string newDir = FileName.Replace(Path.GetFileNameWithoutExtension(fileName), "");
                string newfolderDir = Path.GetFileNameWithoutExtension(fileName); ;
                string Directory = $@"{Environment.CurrentDirectory}\Backup" + $@"{newDir}\Deleted-{date}-{newfolderDir}\";
                if (directory.Exists)
                {
                    directory.MoveTo(Directory);
                }
            }
        }
    }
}
