using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeManager.Launcher.SilentMode
{
    class Program
    {
        public static Guid _PojectGuid { get; set; }

        public static string _RootRepositoryApp { get {return  new System.IO.DirectoryInfo(string.Format(@"{0}\{1}",Environment.GetFolderPath(Environment.SpecialFolder.Personal),@"SCIB")).ToString(); } }

        static void Main(string[] args)
        {            
            if (args.Count() != 0)
            {
                _PojectGuid = new Guid(args[0].ToString());

                TimeManager.Launcher.SilentMode.Data.RepositoryAppEntities _core = new Data.RepositoryAppEntities();
                TimeManager.Launcher.SilentMode.Data.Project _project = _core.Project.Where(w => ((Guid)(w.Project_Id)).Equals(_PojectGuid)).FirstOrDefault();
                if (_project != null)
                {
                    string projectPath = string.Format(@"{0}\{1}",_RootRepositoryApp,_project.Project_Name);
                    TimeManager.Launcher.SilentMode.Data.Version _ver = _project.Version.Where(w => (bool)(w.Version_IsCurrentVersion)).FirstOrDefault();
                    if (System.IO.Directory.Exists(projectPath))
                    {
                        
                        foreach (TimeManager.Launcher.SilentMode.Data.ProjectItems _item in _ver.ProjectItems)
                        {
                            string pathToFile = _item.ProjectItems_MaskPathToFile.Replace("*", projectPath);
                            if(System.IO.File.Exists(pathToFile))
                            {
                                if (!GetMD5(pathToFile).Contains(_item.ProjectItems_MD5))
                                {
                                    //todo: сделать возможность принудительного скачивания настроек
                                    if (!(bool)_item.ProjectItems_IsCustomeSettings)
                                    {
                                        System.IO.File.Delete(pathToFile);
                                        LoadFile(pathToFile, _item);
                                    }
                                }
                                else
                                { 
                                    // Контрольные суммы по файлу совпали
                                }
                            }
                            else
                            {
                                LoadFile(pathToFile, _item);
                            }
                        }
                    }
                    else
                    {
                        System.IO.Directory.CreateDirectory(projectPath);
                        foreach (TimeManager.Launcher.SilentMode.Data.ProjectItems _item in _ver.ProjectItems)
                        {
                            string pathToFile = _item.ProjectItems_MaskPathToFile.Replace("*", projectPath);                           
                            LoadFile(pathToFile, _item);
                            
                        }
                    }

                    TimeManager.Launcher.SilentMode.Data.ProjectItems item = _ver.ProjectItems.Where(w => (bool)w.ProjectItems_IsStarted).FirstOrDefault();
                    System.Diagnostics.ProcessStartInfo stInfo = new System.Diagnostics.ProcessStartInfo(item.ProjectItems_MaskPathToFile.Replace("*", projectPath));
                    stInfo.UseShellExecute = false;
                    stInfo.CreateNoWindow = true;                    
                    System.Diagnostics.Process proc = new System.Diagnostics.Process();
                    proc.StartInfo = stInfo;                   
                    proc.Start();
                }
                else
                {
                    Console.WriteLine(string.Format("Проект с GUID {0} не найден.",_PojectGuid.ToString()));
                    Console.ReadLine();
                }
            }
            else
            { 
            Console.WriteLine("Не указан id проекта.");
            Console.ReadLine();
            }

        }

        private static void LoadFile(string pathToFile, Data.ProjectItems _item)
        {
            System.Net.WebClient google = new System.Net.WebClient();
            System.IO.FileInfo _file = new System.IO.FileInfo(pathToFile);
            if (!_file.Directory.Exists)
            {
                _file.Directory.Create();
            }
            google.DownloadFile(new Uri(_item.ProjectItems_PathToFile), pathToFile);
            
        }

        private static string GetMD5(string _path, bool isLowercase = false)
        {            
            using (var FileOpen = System.IO.File.OpenRead(_path))
            using (var MdHash = new System.Security.Cryptography.MD5CryptoServiceProvider())
            {
                return BitConverter.ToString(MdHash.ComputeHash(FileOpen)).Replace("-", string.Empty);
            }
            
        }
    }
}
