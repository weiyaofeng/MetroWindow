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
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace WpfAppOneStyle
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : EasyCustomControlLibrary.MetroWindow
    {
        //#3373F2 #EA4333 #FB8633 #80BA45 #837AE5 #33BCBA #80BA45 #41B1E1 #83919F #F68ED9
        public MainWindow()
        {
            InitializeComponent();
        }
        private void cbColor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem item = cbColor.SelectedItem as ComboBoxItem;
            _thisWindow.TitleBackground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(item.Content.ToString()));
        }
    }
}
