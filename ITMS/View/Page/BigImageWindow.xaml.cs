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
using System.Windows.Shapes;

namespace ITMS.View.Page
{
    /// <summary>
    /// BigImageWindow.xaml 的交互逻辑
    /// </summary>
    public partial class BigImageWindow : Window
    {
        public BigImageWindow()
        {
            InitializeComponent();
            //string a = @"image\2020-04-13\1102233014.jpg";
            //img.Source = new BitmapImage(new Uri($"{Environment.CurrentDirectory}\\{a}"));
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
