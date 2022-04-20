using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeManager.Launcher.Upload
{
    public class Project
    {
        public string ProjectName { get; set; }

        public string Owner { get; set; }

        public List<ItemProject> CollectionItem { get; set; } 
    }
}
