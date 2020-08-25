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

namespace ITMS.View.Page
{
    /// <summary>
    /// DialogShow.xaml 的交互逻辑
    /// </summary>
    public partial class DialogShow : UserControl
    {
        public DialogShow()
        {
            InitializeComponent();
        }
        public void msg(string mes, string model)
        {
            MessageText.Text = mes;
            if (model == "无")
            {
                CancelButton.Visibility = Visibility.Collapsed;
            }
        }
        public bool Result { get; set; }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            Result = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Result = false;
        }
    }
}
