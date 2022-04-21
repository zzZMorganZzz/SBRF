using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeManager.Launcher
{
    public class ManagerProject
    {
        TimeManager.Launcher.Core.RepositoryAppEntities _core { get; set; }
        public ManagerProject()
        {
            _core = new Core.RepositoryAppEntities();
        }

        
        public List<TimeManager.Launcher.Core.Project> GetProjects()
        {
            List<TimeManager.Launcher.Core.Project> Result = _core.Projects.ToList();
            return Result;
        }

        public static string GetMD5(string _path, bool isLowercase = false)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                var byteHash = md5.ComputeHash(Encoding.UTF8.GetBytes(_path));
                var hash = BitConverter.ToString(byteHash).Replace("-", "");
                return (isLowercase) ? hash.ToLower() : hash;
            }
        }

         


        


    }
}
