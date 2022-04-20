using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimeManager.Launcher.Upload
{
    public class ItemProject
    {
        //public ItemProject();

        public string FileName { get; set; }

        public string MD5_Hash { get; set; }

        public object FileObject { get; set; }

        public void Save(string _path)
        { 
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
