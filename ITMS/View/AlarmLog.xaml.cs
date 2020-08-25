using ITMS.View.Page;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
    /// AlarmLog.xaml 的交互逻辑
    /// </summary>
    public partial class AlarmLog : Window
    {
        public AlarmLog()
        {
            InitializeComponent();
        }
        public ObservableCollection<ItemTreeData> treeDatas { get; set; }
        public ObservableCollection<alarmLogInfo> loginfo { get; set; } = new ObservableCollection<alarmLogInfo>();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DirectoryInfo root = new DirectoryInfo("AlarmLog");
            if (!root.Exists)
            {
                Directory.CreateDirectory("AlarmLog");
            }
            DirectoryInfo[] directories = root.GetDirectories();
            treeDatas = new ObservableCollection<ItemTreeData>()
                {
                   new ItemTreeData()
                   {
                        itemId=0,
                         itemName="日志文件",
                          imageBtn=new BitmapImage(new Uri("/ITMS;component/Resource/log1.png",UriKind.Relative))
                   }
                };
            for (int i = 0; i < directories.Length; i++)
            {
                treeDatas[0].Children.Add(new ItemTreeData() { itemName = directories[i].Name, imageBtn = new BitmapImage(new Uri("/ITMS;component/Resource/log2.png", UriKind.Relative)) });
                if (directories[i].GetFiles().Length == 0)
                {
                    continue;
                }
                foreach (FileInfo info in directories[i].GetFiles())
                {
                    treeDatas[0].Children[i].Children.Add(new ItemTreeData()
                    {
                        itemName = info.Name,
                        fileDir = info.FullName,
                        imageBtn = new BitmapImage(new Uri("/ITMS;component/Resource/log3.png", UriKind.Relative)),
                        IsLastNode = true
                    }); ;
                }
            }
            vedioData.ItemsSource = treeDatas;
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
        public string currentDir { get; set; }
        private void viewLog_Click(object sender, RoutedEventArgs e)
        {
            if (vedioData.SelectedItem != null)
            {
                ItemTreeData item = (ItemTreeData)vedioData.SelectedItem;
                if (!item.IsLastNode)
                {
                    MessageBox.Show("请选中文件");
                    return;
                }
                if (currentDir == item.fileDir)
                {
                    MessageBox.Show("该文件正在查看");
                    return;
                }
                loginfo.Clear();
                FileStream info = new FileStream(item.fileDir, FileMode.Open);

                currentDir = item.fileDir;
                byte[] buffer = new byte[info.Length];
                info.Read(buffer, 0, buffer.Length);
                string en = Encoding.GetEncoding("gbk").GetString(buffer);

                List<string> log = en.Split(new string[] { "\r\n" }, StringSplitOptions.None).ToList();

                for (int i = 0; i < log.Count; i++)
                {
                    string[] linfo = log[i].Split('=');
                    alarmLogInfo info1 = new alarmLogInfo()
                    {
                        temp = linfo[0],
                        mask = linfo[1],
                        time = linfo[2],
                        imgdir = new BitmapImage(new Uri(Environment.CurrentDirectory + "\\" + linfo[3]))
                    };
                    loginfo.Add(info1);
                }
                //playVedio.LoadedBehavior = MediaState.Manual; 
                //playVedio.Stop();
                //playVedio.Play();

                senseView.ItemsSource = loginfo;

            }
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {

            alarmLogInfo item = (alarmLogInfo)senseView.SelectedItem;
            bigImag big = new bigImag();
            big.img.Source = item.imgdir;
            await DialogHost.Show(big, "logDialog");


        }
    }

    public class LogTreeData // 自定义Item的树形结构
    {
        public int itemId { get; set; }      // ID
        public string itemName { get; set; } // 名称
        public int itemStep { get; set; }    // 所属的层级
        public int itemParent { get; set; }  // 父级的ID
        public ObservableCollection<ItemTreeData> Children
        {  // 树形结构的下一级列表
            get;
        } = new ObservableCollection<ItemTreeData>();
        public bool IsExpanded { get; set; } // 节点是否展开
        public bool IsSelected { get; set; } // 节点是否选中
        public bool IsLastNode { get; set; } = false;// 节点是否选中=
        public string fileDir { get; set; }

        public ImageSource imageBtn { get; set; }
    }


    public class alarmLogInfo
    {
        public string temp { get; set; }
        public string mask { get; set; }
        public string time { get; set; }
        public ImageSource imgdir { get; set; }
    }
}
