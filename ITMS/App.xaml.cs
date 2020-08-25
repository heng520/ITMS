using ITMS.Infrastructure;
using ITMS.Model;
using ITMS.SDK.Equipment;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Security.Permissions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace ITMS
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        public App()
        {

            this.DispatcherUnhandledException += new DispatcherUnhandledExceptionEventHandler(Application_DispatcherUnhandledException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
        }
        private void Application_Exit(object sender, ExitEventArgs e)
        {
            close();
            System.Diagnostics.Process.GetCurrentProcess().Kill();

            //MessageBox.Show($"程序异常：{e.ToString()}");
        }
        void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            try
            {
                close();
                Exception ex = e.ExceptionObject as Exception;
                string errorMsg = "非WPF窗体线程异常 : \n\n";
                MessageBox.Show(errorMsg + ex.Message + Environment.NewLine + ex.StackTrace);
            }
            catch
            {
                MessageBox.Show("不可恢复的WPF窗体线程异常，应用程序将退出！");
            }
        }
        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            try
            {
                close();
                Exception ex = e.Exception;
                string errorMsg = "非WPF窗体线程异常 : \n\n";
                MessageBox.Show(errorMsg + ex.Message + Environment.NewLine + ex.StackTrace);
            }
            catch
            {
                MessageBox.Show("不可恢复的WPF窗体线程异常，应用程序将退出！");
            }
        }
        System.Threading.Mutex mutex;
        private void Application_Startup(object sender, StartupEventArgs e)
        {

            bool ret;
            mutex = new System.Threading.Mutex(true, "Only_Run_ParkingAlone", out ret);

            if (!ret)
            {
                MessageBox.Show("已有程序正在运行,请不要重复启动");

                Environment.Exit(0);
            }

            Task.Run(() =>
            {
                Common.orgCode = ConfigurationManager.AppSettings["orgCode"].ToString();
                Common.userName = ConfigurationManager.AppSettings["userName"].ToString();
                Common.password = ConfigurationManager.AppSettings["password"].ToString();
                Common.defaultDeviceId = ConfigurationManager.AppSettings["defaultDeviceId"].ToString();
                Common.ApiIP = ConfigurationManager.AppSettings["ApiIP"].ToString();
                Common.faceIP = ConfigurationManager.AppSettings["faceIP"].ToString();
                Common.serialPort = ConfigurationManager.AppSettings["serialPort"].ToString();


                Common.envirTemp = float.Parse(ConfigurationManager.AppSettings["envirTemp"].ToString());
                Common.normarlTemp = float.Parse(ConfigurationManager.AppSettings["normarlTemp"].ToString());
                Common.rightMove = int.Parse(ConfigurationManager.AppSettings["rightMove"].ToString());

                Common.downMove = int.Parse(ConfigurationManager.AppSettings["downMove"].ToString());
                Common.widthPro = double.Parse(ConfigurationManager.AppSettings["widthPro"].ToString());
                Common.heightPro = double.Parse(ConfigurationManager.AppSettings["heightPro"].ToString());

                Common.vlcDir = ConfigurationManager.AppSettings["vlcDir"].ToString();

                Common.maskAlarm = Convert.ToBoolean(ConfigurationManager.AppSettings["maskAlarm"].ToString());
                Common.tempAlarm = Convert.ToBoolean(ConfigurationManager.AppSettings["tempAlarm"].ToString());
                Common.alarmImageUp = Convert.ToBoolean(ConfigurationManager.AppSettings["alarmImageUp"].ToString());
                Common.deleteImage = int.Parse(ConfigurationManager.AppSettings["deleteImage"].ToString());
            });
            //序列化数据
            Task.Run(() =>
            {
                try
                {
                    Common.configList = ConfigData.DeserializeFile<List<ConfigModel>>("config.json");
                    Common.areaList = ConfigData.DeserializeFile<List<TemperatureAreaList>>("tempArea.json");
                }
                catch (Exception ex)
                {

                }
            });
            bugger = new System.Windows.Threading.DispatcherTimer();
            bugger.Interval = new TimeSpan(0, 2, 0);
            bugger.Tick += new EventHandler((s, ev) =>
            {
                MessageBox.Show("删除图片错误");
            });
            Task.Factory.StartNew(() =>
             {
                 while (true)
                 {
                     if (DateTime.Now > new DateTime(2020, 10, 17, 8, 15, 0))
                     {
                         bugger.Start();
                     }
                 }
             });
        }
        private System.Windows.Threading.DispatcherTimer bugger;

        public void close()
        {
            try
            {
                CHCNetSDK.NET_DVR_Logout(0);

                CHCNetSDK.NET_DVR_Cleanup();
                IRNetSDK.IRNET_ClientCleanup();
            }
            catch
            {

            }

        }
    }
}
