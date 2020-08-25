using ITMS.Infrastructure;
using ITMS.View.Page;
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

namespace ITMS.View
{
    /// <summary>
    /// ModifyPassword.xaml 的交互逻辑
    /// </summary>
    public partial class ModifyPassword : Window
    {
        public ModifyPassword()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            if (oldPwd.Password != Common.password)
            {
                errorMsg("旧密码错误");
                return;
            }
            if (newNewPwd.Password != newPwd.Password)
            {
                errorMsg("输入的密码不一致");
                return;
            }
            Common.password = newNewPwd.Password;

            Common.UpdateSettingString("password", newNewPwd.Password);
            this.Close();
            new DiaShow().Show("密码修改成功");
        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public async void errorMsg(string errormsg)
        {
            msg.Content = errormsg;
            msg.Visibility = Visibility.Visible;
            await Task.Delay(2000).ConfigureAwait(false);
            msg.Visibility = Visibility.Hidden;


        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
