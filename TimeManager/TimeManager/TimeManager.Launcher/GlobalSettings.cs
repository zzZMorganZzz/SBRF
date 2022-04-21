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

        public static System.IO.DirectoryInfo RootProjectPathToClient
        {
            get 
            {
                return new System.IO.DirectoryInfo(string.Format(@"{0}\{1}",Environment.GetFolderPath(Environment.SpecialFolder.Personal),@"SCIB\ProjectRepository"));
            }
        }


        

       
    }
}
