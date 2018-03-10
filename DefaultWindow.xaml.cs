using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfAppOneStyle
{
    /// <summary>
    /// DefaultWindow.xaml 的交互逻辑
    /// </summary>
    public partial class DefaultWindow :  EasyCustomControlLibrary.DefAultWindow
    {
        public DefaultWindow()
        {
            InitializeComponent();
        }


        private void SkinButton_Click(object sender, RoutedEventArgs e)
        {
            var w = new MainWindow();
            w.Show();
        }
    }
}
