using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_BaiduWebMapDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string szTmp = "pack://siteoforigin:,,,/Html/map.html";
            //string szTmp = "../Html/map.html";

            mWebbrowser.Navigate(szTmp);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PieChartWindow pieChartWindow = new PieChartWindow();
            pieChartWindow.Show();
        }
    }
}
