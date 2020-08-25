using ITMS.Infrastructure;
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
    /// PlayBack.xaml 的交互逻辑
    /// </summary>
    public partial class PlayBack : Window
    {
        public PlayBack()
        {
            InitializeComponent();

        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
        public ObservableCollection<ItemTreeData> treeDatas { get; set; }

        public ItemTreeData selectData { get; set; }
        private  void Window_Loaded(object sender, RoutedEventArgs e)
        {

            DirectoryInfo root = new DirectoryInfo("vedio");

            DirectoryInfo[] directories = root.GetDirectories();
            treeDatas = new ObservableCollection<ItemTreeData>()
                {
                   new ItemTreeData()
                   {
                        itemId=0,
                         itemName="视频文件",
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
            FileInfo file = new FileInfo("vedio");
            vedioData.ItemsSource = treeDatas;

        }
         public string currentDir { get; set; }
        private void startView_Click(object sender, RoutedEventArgs e)
        {
            if (vedioData.SelectedItem != null)
            {
                ItemTreeData item = (ItemTreeData)vedioData.SelectedItem;
                if (!item.IsLastNode)
                {
                    MessageBox.Show("请选中文件");
                    return;
                }
                var vlcLibDirectory = new DirectoryInfo(Common.vlcDir);
                var options = new string[]
                {
                ////添加日志
                //"--file-logging", "-vvv", "--logfile=Logs.log"
                    // VLC options can be given here. Please refer to the VLC command line documentation.
                };
                //初始化播放器
                if(item.fileDir== currentDir) { errorShow("正在播放该视频"); return; }
                this.myControl.SourceProvider.CreatePlayer(vlcLibDirectory, options);
                FileInfo info = new FileInfo(item.fileDir);
                currentDir = item.fileDir;
                myControl.SourceProvider.MediaPlayer.Play(info);
                //playVedio.LoadedBehavior = MediaState.Manual; 
                //playVedio.Stop();
                //playVedio.Play();

                

            }
          
        }


        public async void errorShow(string msg)
        {
            errorMsg.Visibility = Visibility.Visible;
            errorMsg.Content = msg;
            await Task.Delay(2000);
            errorMsg.Visibility = Visibility.Collapsed;
        }
    }

    public class ItemTreeData // 自定义Item的树形结构
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
}
