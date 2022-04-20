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

            string _path = @"C:\Users\Krypton\Documents\Полис КАСКО[128].pdf";
            var a = TimeManager.Launcher.Upload.ItemProject.GetMD5(_path);
            //"B5A0DFB2AE1DB883D44786515D7C21E2"
            var b = GlobalSettings.RootProjectPath;
              





            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
            Application.Run(new Main());




        }
    }
}
