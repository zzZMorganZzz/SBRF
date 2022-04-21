using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;

namespace TimeManager.Launcher
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //string _path = @"C:\Users\Krypton\Documents\Полис КАСКО[128].pdf";
            //var a = TimeManager.Launcher.Upload.ItemProject.GetMD5(_path);
            //"B5A0DFB2AE1DB883D44786515D7C21E2"
            var b = GlobalSettings.RootProjectPathToClient;





            //TimeManager.Launcher.Core.RepositoryAppEntities _core = new Core.RepositoryAppEntities();
            //TimeManager.Launcher.Core.Project _project = new Core.Project()
            //{
            //    Project_Id = Guid.NewGuid(),
            //    Project_Name = "Time Manager",
            //    Project_Description = "Заебать соседей"
            //};
            //_core.Projects.Add(_project);
            //_core.SaveChanges();

            TimeManager.Launcher.Core.Project _project = new Core.Project()
            {
                Project_Id = Guid.NewGuid(),
                Project_Name = "TestProjectName",
                Project_Description = "test project to test system"
            };
            TimeManager.Launcher.Core.Version _version = new TimeManager.Launcher.Core.Version(){ Version_Id = Guid.NewGuid(),Version_Name = "Ver. 0.1"};
            _project.Versions.Add(_version);


           var CollectionFile = System.IO.Directory.GetFiles(@"E:\CodeRepository\Cerber [TimeManagerUtilit]\TimeManager\TimeManager.AdminConsole\bin\Debug","*.*",System.IO.SearchOption.AllDirectories);

            foreach(string _path in CollectionFile)
            {
                System.IO.FileInfo _file = new System.IO.FileInfo(_path);
                TimeManager.Launcher.Core.ProjectItem _item = new Core.ProjectItem() { ProjectItems_Id = Guid.NewGuid()};
                _version.ProjectItems.Add(_item);
                _item.ProjectItems_FileName = _file.Name;
                _item.ProjectItems_Extension = _file.Extension;
                _item.ProjectItems_PathToFile = _file.FullName;
                _item.ProjectItems_MaskPathToFile = _file.FullName.Replace(@"E:\CodeRepository\Cerber [TimeManagerUtilit]\TimeManager\TimeManager.AdminConsole\bin\Debug", "*");
                _item.ProjectItems_MD5 = ManagerProject.GetMD5(_file.FullName);
                _item.ProjectItems_IsStarted = false;
                _item.ProjectItems_IsCustomeSettings = false;
            }

            TimeManager.Launcher.Core.RepositoryAppEntities _core = new Core.RepositoryAppEntities();
            _core.Projects.Add(_project);
            _core.SaveChanges();



             Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
            Application.Run(new Main());




        }
    }
}
