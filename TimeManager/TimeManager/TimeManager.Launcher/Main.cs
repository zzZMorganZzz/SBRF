using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TimeManager.Launcher
{
    public partial class Main : DevExpress.XtraEditors.XtraForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            barHeaderItem_UserProfile.Caption = GlobalSettings.CurrentUser;



            //List<TimeManager.Launcher.Upload.Project> List = new List<Upload.Project>();
            //TimeManager.Launcher.Upload.Project a = new Upload.Project() { ProjectName = "123",Owner="flwkejfwlkefwoeif"};
            //TimeManager.Launcher.Upload.Project b = new Upload.Project() { ProjectName = "3123", Owner = "flwkejfwlkefwoeif" };
            //List.Add(a);
            //List.Add(b);
            //bindingSourceProject.DataSource = List;

        }
    }
}
