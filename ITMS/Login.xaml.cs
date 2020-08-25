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
using System.Configuration;
using ITMS.Infrastructure;
using ITMS.Model;
using ITMS.View;

namespace ITMS
{
    /// <summary>
    /// Login.xaml 的交互逻辑
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {

            //float temp = new TempFixBlh().tempFix(36.5f, 21.0f, 33.0f);
            InitializeComponent();
            // LogHelper.Error("dsadas");



        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(passwod.Password) || string.IsNullOrEmpty(帐户.Text))
            {
                errorMsg("账号密码不能为空!");
                return;
            }
            if (帐户.Text != Common.userName || passwod.Password != Common.password)
            {
                errorMsg("账号或密码不正确!");
                return;
            }
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void passwod_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (HintMsg == null)
            {
                return;
            }
            if (!string.IsNullOrEmpty(passwod.Password))
            {
                HintMsg.Visibility = Visibility.Hidden;
            }
            else
            {
                HintMsg.Visibility = Visibility.Visible;
            }
        }


        public async void errorMsg(string msg)
        {
            MesBar.IsActive = true;
            errorMessage.Content = msg;
            await Task.Delay(3000);

            MesBar.IsActive = false;
        }
    }
}
