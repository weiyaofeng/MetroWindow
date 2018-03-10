using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace WpfAppOneStyle
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            ShutdownMode = ShutdownMode.OnMainWindowClose;
            MainWindow m = new MainWindow();
            DefaultWindow m2 = new DefaultWindow();
            MainWindow = m2;
            m.Show();
            m2.Show();
        }
    }
}
