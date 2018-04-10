using System;
using System.Collections.Generic;
using System.Globalization;
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
using System.Windows.Shapes;

namespace Wpf_BaiduWebMapDemo
{
    /// <summary>
    /// PieChartWindow.xaml 的交互逻辑
    /// </summary>
    public partial class PieChartWindow : Window
    {
        public PieChartWindow()
        {
            InitializeComponent();
        }



        #region 点击事件
        //点击事件
        void dataPoint_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //DataPoint dp = sender as DataPoint;
            //MessageBox.Show(dp.YValue.ToString());
        }
        #endregion

        //private List<string> strListx = new List<string>() { "在岗时间", "请假时间" };
        //private List<string> strListy = new List<string>() { "1936", "80" };

        private void workTimeDataPage_Loaded(object sender, RoutedEventArgs e)
        {
            //Simon.Children.Clear();
            //CreateChartPie("2018工时统计", strListx, strListy);
        }
        Double x = 1;
        Double y = 1;
        Double x2 = 1;
        Double y2 = 1;

        private void FatPie_MouseEnter(object sender, MouseEventArgs e)
        {
            ScaleTransform scale = new ScaleTransform();
            scale.CenterX = 80;
            scale.CenterY = 80;
            x = x * 1.1;
            y = y * 1.1;
            scale.ScaleX = x;
            scale.ScaleY = y;
            FatPie.RenderTransform = scale;
            FatPie1.Visibility = Visibility.Visible;
            FatPie2.Visibility = Visibility.Visible;
            textFatpie.Visibility = Visibility.Visible;
        }

        private void ProteinPie_MouseEnter(object sender, MouseEventArgs e)
        {
            ScaleTransform scale = new ScaleTransform();
            scale.CenterX = 80;
            scale.CenterY = 80;
            x2 = x2 * 1.1;
            y2 = y2 * 1.1;
            scale.ScaleX = x2;
            scale.ScaleY = y2;
            ProteinPie.RenderTransform = scale;
            lineproteinPie1.Visibility = Visibility.Visible;
            lineproteinPie2.Visibility = Visibility.Visible;
            textProteinPie.Visibility = Visibility.Visible;
        }

        private void ProteinPie_MouseLeave(object sender, MouseEventArgs e)
        {
            ScaleTransform scale = new ScaleTransform();
            scale.CenterX = 80;
            scale.CenterY = 80;
            x2 = x2 / 1.1;
            y2 = y2 / 1.1;
            scale.ScaleX = x2;
            scale.ScaleY = y2;
            ProteinPie.RenderTransform = scale;
            lineproteinPie1.Visibility = Visibility.Hidden;
            lineproteinPie2.Visibility = Visibility.Hidden;
            textProteinPie.Visibility = Visibility.Hidden;
        }

        private void FatPie_MouseLeave(object sender, MouseEventArgs e)
        {
            ScaleTransform scale = new ScaleTransform();
            scale.CenterX = 80;
            scale.CenterY = 80;
            x = x / 1.1;
            y = y / 1.1;
            scale.ScaleX = x;
            scale.ScaleY = y;
            FatPie.RenderTransform = scale;
            FatPie1.Visibility = Visibility.Hidden;
            FatPie2.Visibility = Visibility.Hidden;
            textFatpie.Visibility = Visibility.Hidden;
        }
    }

    class AngleX1 : IMultiValueConverter

    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            Double start = ((Double)values[0]);
            Double end = ((Double)values[1]);
            Double slice = (Double)values[4];
            Double angle = 0;
            if (end < start)
            {
                if (slice < 0.5)
                {
                    angle = (((Double)values[1]) + ((Double)values[0])) / 2 + 180;
                }
                else
                {
                    angle = (((Double)values[0]) + ((Double)values[1])) / 2 + 180;
                }
            }
            else if (end > start)
            {
                angle = (((Double)values[0]) + ((Double)values[1])) / 2;

            }
            else if (end == start)
            {
                angle = start;
            }

            Double center = (Double)values[2] / 2;
            Double r = (Double)values[3] / 2;
            //Double r = 80;
            Double x1 = center + (r + 15) * Math.Cos(angle * 3.14 / 180);
            Double y1 = center + (r + 15) * Math.Sin(angle * 3.14 / 180);
            //Point p = new Point((int)x1,(int)y1);
            //return p;
            return x1;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    class AngleX2 : IMultiValueConverter

    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            Double start = ((Double)values[0]);
            Double end = ((Double)values[1]);
            Double slice = (Double)values[4];
            Double angle = 0;
            if (end < start)
            {
                if (slice < 0.5)
                {
                    angle = (((Double)values[1]) + ((Double)values[0])) / 2 + 180;
                }
                else
                {
                    angle = (((Double)values[0]) + ((Double)values[1])) / 2 + 180;
                }
            }
            else if (end > start)
            {
                angle = (((Double)values[0]) + ((Double)values[1])) / 2;

            }
            else if (end == start)
            {
                angle = start;
            }
            Double center = (Double)values[2] / 2;
            Double r = (Double)values[3] / 2;
            //Double r = 80;
            Double x1 = center + (r + 20) * Math.Cos(angle * 3.14 / 180);
            Double y1 = center + (r + 20) * Math.Sin(angle * 3.14 / 180);
            //Point p = new Point((int)x1,(int)y1);
            //return p;
            return x1;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    class AngleY1 : IMultiValueConverter

    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            Double start = ((Double)values[0]);
            Double end = ((Double)values[1]);
            Double slice = (Double)values[4];
            Double angle = 0;
            if (end < start)
            {
                if (slice < 0.5)
                {
                    angle = (((Double)values[1]) + ((Double)values[0])) / 2 + 180;
                }
                else
                {
                    angle = (((Double)values[0]) + ((Double)values[1])) / 2 + 180;
                }
            }
            else if (end > start)
            {
                angle = (((Double)values[0]) + ((Double)values[1])) / 2;

            }
            else if (end == start)
            {
                angle = start;
            }
            Double center = (Double)values[2] / 2;
            Double r = (Double)values[3] / 2;
            //Double r = 80;
            Double x1 = center + (r + 15) * Math.Cos(angle * 3.14 / 180);
            Double y1 = center + (r + 15) * Math.Sin(angle * 3.14 / 180);
            //Point p = new Point((int)x1,(int)y1);
            //return p;
            return y1;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    class AngleY2 : IMultiValueConverter

    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            Double start = ((Double)values[0]);
            Double end = ((Double)values[1]);
            Double slice = (Double)values[4];
            Double angle = 0;
            if (end < start)
            {
                if (slice < 0.5)
                {
                    angle = (((Double)values[1]) + ((Double)values[0])) / 2 + 180;
                }
                else
                {
                    angle = (((Double)values[0]) + ((Double)values[1])) / 2 + 180;
                }
            }
            else if (end > start)
            {
                angle = (((Double)values[0]) + ((Double)values[1])) / 2;

            }
            else if (end == start)
            {
                angle = start;
            }
            Double center = (Double)values[2] / 2;
            Double r = (Double)values[3] / 2;
            //Double r = 80;
            Double x1 = center + (r + 20) * Math.Cos(angle * 3.14 / 180);
            Double y1 = center + (r + 20) * Math.Sin(angle * 3.14 / 180);
            //Point p = new Point((int)x1,(int)y1);
            //return p;
            return y1;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    class Center2 : IMultiValueConverter
    {
        //public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        //{
        //    Double w =(Double)value / 2;
        //    return w;
        //}

        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            Double w1 = (Double)values[0] / 2;
            Double w2 = (Double)values[1] / 2;
            return w1 - w2;
        }

        //public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        //{
        //    throw new NotImplementedException();
        //}

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    class PositionPieText : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            Double x2 = (Double)values[0];
            Double y2 = (Double)values[1];
            Double width = (Double)values[2];
            Double result = 0;
            if (x2 >= 130)
            {
                result = x2 + 5;
            }
            else
            {
                result = x2 - width - 5;
            }
            return result;


        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    class PositionTextY : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            Double x2 = (Double)values[0];
            Double y2 = (Double)values[1];
            Double height = (Double)values[2];
            Double result = 0;

            result = y2 - height / 2;

            return result;

        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    class PositionX2 : IValueConverter
    {
        public object Convert(object values, Type targetType, object parameter, CultureInfo culture)
        {
            Double x2 = (Double)values;
            Double result;
            if (x2 >= 130)
            {
                result = x2 + 31;
            }
            else
            {
                result = x2 - 31;
            }
            return result;
        }


        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    class SliceLabelConverter : IValueConverter
    {
        public object Convert(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return ((double)value).ToString("#.#% " + parameter);
        }

        public object ConvertBack(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new System.NotImplementedException();
        }
    }
}
