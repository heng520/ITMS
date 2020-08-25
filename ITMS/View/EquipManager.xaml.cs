using ITMS.Infrastructure;
using ITMS.Model;
using ITMS.View.Page;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// EquipManager.xaml 的交互逻辑
    /// </summary>
    public partial class EquipManager : Window
    {
        public EquipManager()
        {
            InitializeComponent();


            Configs = new ObservableCollection<ConfigModel>(Common.configList);

            //Configs = new ObservableCollection<ConfigModel>();
            //Configs.Add(new ConfigModel() { CameraIp = "dasdsa" }); 
            equipList.ItemsSource = Configs;

            for (int i = 0; i < Configs.Count; i++)
            {
                addRadioBtn(Configs[i].DeviceId, Configs[i].CameraIp);
            }
        }

        public void addRadioBtn(string id, string ip)
        {
            CheckBox radioButton = new CheckBox();
            radioButton.Tag = id;
            radioButton.Content = ip;
            stack.Children.Add(radioButton);
            if (id == Common.defaultDeviceId)
            {
                radioButton.IsChecked = true;
            }

        }
        public ObservableCollection<ConfigModel> Configs { get; set; }
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private async void addEquipment_Click(object sender, RoutedEventArgs e)
        {
            AddEquip equip = new AddEquip();
            await DialogHost.Show(equip, "equipDialog");
            Configs.Add(equip.ConfigModel);

            addRadioBtn(equip.ConfigModel.DeviceId, equip.ConfigModel.CameraIp);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            InfraredRay infrared = new InfraredRay(Configs[equipList.SelectedIndex]);
            infrared.Show();
        }

        private async void deleteEquipment_Click(object sender, RoutedEventArgs e)
        {


            if (equipList.SelectedItems.Count != 1)
            {
                msg("请选中一行");
                return;
            }
            ConfigModel config = (ConfigModel)equipList.SelectedItem;
            DialogShow diaShow = new DialogShow();
            diaShow.msg("是否删除", "");

            await DialogHost.Show(diaShow, "equipDialog");
            if (!diaShow.Result) return;
            Common.configList.Remove(config);
            Configs.Remove(config);

            ConfigData.SerializeFile<List<ConfigModel>>(Common.configList, "config.json");
            stack.Children.Clear();
            for (int i = 0; i < Configs.Count; i++)
            {
                addRadioBtn(Configs[i].DeviceId, Configs[i].CameraIp);
            }
        }


        public async void msg(string error)
        {

            errorMsg.Content = error;
            errorMsg.Visibility = Visibility.Visible;
            await Task.Delay(2000).ConfigureAwait(false);
            this.Dispatcher.Invoke(() =>
            {
                errorMsg.Visibility = Visibility.Collapsed;
            });

        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int i = 0;
            CheckBox box = null;
            foreach (CheckBox check in stack.Children)
            {
                if ((bool)check.IsChecked)
                {
                    i++;
                    box = check;
                }
            }
            if (i > 1)
            {
                msg("只能选择一个视频");
                return;
            }
            if (i == 0)
            {
                msg("请选择一个视频");
                return;
            }
            Common.defaultDeviceId = box.Tag.ToString();
            Common.UpdateSettingString("defaultDeviceId", box.Tag.ToString());
            DialogShow diaShow = new DialogShow();
            diaShow.msg("保存成功", "无");
            await DialogHost.Show(diaShow, "equipDialog");
        }

        private async void updateEquipment_Click(object sender, RoutedEventArgs e)
        {
            DialogShow diaShow = new DialogShow();
            if (equipList.SelectedIndex == -1)
            {

                diaShow.msg("请选中一行", "无");
                await DialogHost.Show(diaShow, "equipDialog");
                return;
            }
            UpdateEquip update = new UpdateEquip((ConfigModel)equipList.SelectedItem);

            await DialogHost.Show(update, "equipDialog");
            if (!update.result) return;
            else
            {
                diaShow.msg("修改成功", "无");
                await DialogHost.Show(diaShow, "equipDialog");

            }



        }
    }
}
