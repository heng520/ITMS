using ITMS.Infrastructure;
using ITMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
using Newtonsoft.Json;
using ITMS.APi.Model;
using MaterialDesignThemes.Wpf;

namespace ITMS.View.Page
{
    /// <summary>
    /// AddEquip.xaml 的交互逻辑
    /// </summary>
    public partial class AddEquip : UserControl
    {
        public AddEquip()
        {
            InitializeComponent();

            equiment.DataContext = ConfigModel;
        }
        public ConfigModel ConfigModel { get; set; } = new ConfigModel() { orgCode = Common.orgCode };
        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            UpDevice_Request request = new UpDevice_Request()
            {
                deviceName = ConfigModel.deviceName,
                deviceType = ConfigModel.deviceType,
                location = ConfigModel.location,
                orgCode = ConfigModel.orgCode,

            };
            HttpClient http = new HttpClient();
            HttpContent content = new StringContent(JsonConvert.SerializeObject(request));
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = http.PostAsync(Common.ApiIP + "device/save", content).Result;


            UpDevice_Response str = JsonConvert.DeserializeObject<UpDevice_Response>(response.Content.ReadAsStringAsync().Result);
            if (str.success)
            {
                ConfigModel.rtspAdtress = $"rtsp://{ConfigModel.CameraUser}:{ConfigModel.CameraPassword}@{ConfigModel.CameraIp}:554";
                ConfigModel.DeviceId = str.data.deviceId;
                Common.configList.Add(ConfigModel);
                Task.Run(() => ConfigData.SerializeFile<List<ConfigModel>>(Common.configList, "config.json"));
                DialogHost.CloseDialogCommand.Execute(null, null);
            }




        }

        public async void errorMsg(string m)
        {
            msgLabel.Visibility = Visibility.Visible;
            msgLabel.Content = m;
            await Task.Delay(3000).ConfigureAwait(false);

            msgLabel.Visibility = Visibility.Collapsed;


        }
    }
}
