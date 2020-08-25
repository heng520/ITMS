using ITMS.Infrastructure;
using ITMS.Model;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ITMS.View
{
    /// <summary>
    /// UpdateEquip.xaml 的交互逻辑
    /// </summary>
    public partial class UpdateEquip : UserControl
    {
        public UpdateEquip(ConfigModel _config)
        {
            InitializeComponent();
            config = _config;
            equiment.DataContext = config;
        }
        public ConfigModel config { get; set; }
        public bool result { get; set; } = false;
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ConfigData.SerializeFile<List<ConfigModel>>(Common.configList, "config.json");
                DialogHost.CloseDialogCommand.Execute(null, null);
            }
            catch 
            {

            }
            result = true;
        }
    }
}
