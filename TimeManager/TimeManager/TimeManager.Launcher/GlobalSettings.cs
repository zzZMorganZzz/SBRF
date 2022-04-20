using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeManager.Launcher
{
    public static class GlobalSettings
    {
        public static string CurrentUser 
        {
            get
            {
                return Environment.UserName;
            }
        }

        public static string RootProjectPath
        {
            get 
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            }
        }
    }
}
