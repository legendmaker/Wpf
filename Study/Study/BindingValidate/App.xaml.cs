using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;

namespace BindingValidate
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        SplashScreen ss = new SplashScreen("resources/merge.bmp");
        protected override void OnStartup(StartupEventArgs e)
        {
            ss.Show(false);
            ss.Close(TimeSpan.FromSeconds(0.1));
            base.OnStartup(e);
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {

        }
    }
}
