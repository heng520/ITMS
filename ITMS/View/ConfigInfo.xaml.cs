using ITMS.Infrastructure;
using ITMS.View.Page;
using MaterialDesignThemes.Wpf;
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
    /// ConfigInfo.xaml 的交互逻辑
    /// </summary>
    public partial class ConfigInfo : Window
    {
        public ConfigInfo()
        {
            InitializeComponent();
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            DialogShow dialog = new DialogShow();
            try
            {
                Common.orgCode = orgCode.Text;
                Common.UpdateSettingString("orgCode", orgCode.Text);

                Common.envirTemp = float.Parse(envirTemp.Text);
                Common.UpdateSettingString("envirTemp", envirTemp.Text);

                Common.serialPort = serialPort.Text;
                Common.UpdateSettingString("serialPort", serialPort.Text);

                Common.faceIP = faceIP.Text;
                Common.UpdateSettingString("faceIP", faceIP.Text);

                Common.ApiIP = ApiIP.Text;
                Common.UpdateSettingString("ApiIP", ApiIP.Text);

                Common.alarmTemp = float.Parse(alarmTemp.Text);
                Common.UpdateSettingString("alarmTemp", alarmTemp.Text);

                Common.normarlTemp = float.Parse(normarlTemp.Text);
                Common.UpdateSettingString("normarlTemp", normarlTemp.Text);

                Common.vlcDir = vlcDir.Text;
                Common.UpdateSettingString("vlcDir", vlcDir.Text);

                Common.maskAlarm = m1.IsChecked == true ? true : false;
                Common.UpdateSettingString("maskAlarm", Common.maskAlarm.ToString());

                Common.tempAlarm = temp1.IsChecked == true ? true : false;
                Common.UpdateSettingString("tempAlarm", Common.tempAlarm.ToString());

                Common.alarmImageUp = up1.IsChecked == true ? true : false;
                Common.UpdateSettingString("alarmImageUp", Common.alarmImageUp.ToString());


                Common.deleteImage = int.Parse(fileTime.Text.Trim());
            }
            catch (Exception ex)
            {
                dialog.msg(ex.Message, "无");
                DialogHost.Show(dialog, "configDialog");
                return;
            }
            dialog.msg("修改成功", "无");
            DialogHost.Show(dialog, "configDialog");

        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            //Common.orgCode = orgCode.Text;
            //Common.envirTemp = envirTemp.Text;
            //serialPort.Text = Common.serialPort;
            //faceIP.Text = Common.faceIP;
            //ApiIP.Text = Common.ApiIP;
            //alarmTemp.Text = Common.alarmTemp.ToString();
            //normarlTemp.Text = Common.normarlTemp.ToString();
            //vlcDir.Text = Common.vlcDir;
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.Dispatcher.Invoke(() =>
              {
                  orgCode.Text = Common.orgCode;
                  envirTemp.Text = Common.envirTemp.ToString();
                  serialPort.Text = Common.serialPort;
                  faceIP.Text = Common.faceIP;
                  ApiIP.Text = Common.ApiIP;
                  alarmTemp.Text = Common.alarmTemp.ToString();
                  normarlTemp.Text = Common.normarlTemp.ToString();
                  vlcDir.Text = Common.vlcDir;
                  fileTime.Text = Common.deleteImage.ToString();


                  if (Common.maskAlarm)
                  {
                      m1.IsChecked = true;
                      m2.IsChecked = false;
                  }
                  else
                  {
                      m1.IsChecked = false;
                      m2.IsChecked = true;
                  }
                  if (Common.tempAlarm)
                  {
                      temp1.IsChecked = true;
                      temp2.IsChecked = false;
                  }
                  else
                  {
                      temp1.IsChecked = false;
                      temp2.IsChecked = true;
                  }
                  if (Common.alarmImageUp)
                  {
                      up1.IsChecked = true;
                      up2.IsChecked = false;
                  }
                  else
                  {
                      up1.IsChecked = false;
                      up2.IsChecked = true;
                  }
                  //orgCode.IsEnabled = false;
                  //envirTemp.IsEnabled = false;
                  //serialPort.IsEnabled = false;
                  //faceIP.IsEnabled = false;
                  //ApiIP.IsEnabled = false;
                  //alarmTemp.IsEnabled = false;
                  //normarlTemp.IsEnabled = false;
                  //vlcDir.IsEnabled = false;

                  //m1.IsEnabled = false;

                  //m2.IsEnabled = false;
              });


        }
    }
}
