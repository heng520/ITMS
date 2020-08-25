using ITMS.APi.Model;
using ITMS.Infrastructure;
using ITMS.Model;
using ITMS.SDK.Equipment;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ITMS.View
{
    /// <summary>
    /// RayModulation.xaml 的交互逻辑
    /// </summary>
    public partial class RayModulation : Window
    {
        public RayModulation(ConfigModel _config,Int32 _m_lUserID, CHCNetSDK.NET_DVR_DEVICEINFO_V30 _device)
        {
            InitializeComponent();

            config = _config;
            m_lUserID = _m_lUserID;
            DeviceInfo = _device;
        }

        private ConfigModel config { get; set; }
        public Int32 m_lUserID = -1;
        public Int32 m_lRealHandle = -1;
        private bool m_bInitSDK = false;
        public CHCNetSDK.NET_DVR_DEVICEINFO_V30 DeviceInfo;

        public IRNetSDK.M_MessageCallBacK mm = null;

        public IRNetSDK.pfJpegdataCallback pp = null;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                rightMove.Text = Common.rightMove.ToString();
                downMove.Text = Common.downMove.ToString();
                heightPro.Text = Common.heightPro.ToString();
                widthPro.Text = Common.widthPro.ToString();
                // m_bInitSDK = CHCNetSDK.NET_DVR_Init();

              //  m_lUserID = CHCNetSDK.NET_DVR_Login_V30(config.CameraIp, 8000, config.CameraUser, config.CameraPassword, ref DeviceInfo);

                //CHCNetSDK.NET_DVR_PREVIEWINFO lpPreviewInfo = new CHCNetSDK.NET_DVR_PREVIEWINFO();
                //lpPreviewInfo.hPlayWnd = pictureBox1.Handle;//预览窗口 live view window
                //lpPreviewInfo.lChannel = (int)DeviceInfo.byStartChan; //预览的设备通道 the device channel number
                //lpPreviewInfo.dwStreamType = 0;//码流类型：0-主码流，1-子码流，2-码流3，3-码流4，以此类推
                //lpPreviewInfo.dwLinkMode = 0;//连接方式：0- TCP方式，1- UDP方式，2- 多播方式，3- RTP方式，4-RTP/RTSP，5-RSTP/HTTP 
                //lpPreviewInfo.bBlocked = true; //0- 非阻塞取流，1- 阻塞取流
                //lpPreviewInfo.dwDisplayBufNum = 15; //播放库显示缓冲区最大帧数

                //IntPtr pUser = IntPtr.Zero;//用户数据 user data 

                //m_lRealHandle = CHCNetSDK.NET_DVR_RealPlay_V40(m_lUserID, ref lpPreviewInfo, null/*RealData*/, pUser);


                var vlcLibDirectory = new DirectoryInfo(Common.vlcDir);

                var options = new string[]
                {
                //添加日志
                "--file-logging", "-vvv", "--logfile=Logs.log"
                    // VLC options can be given here. Please refer to the VLC command line documentation.
                };
                //初始化播放器
                this.myControl.SourceProvider.CreatePlayer(vlcLibDirectory, options);

                // Load libvlc libraries and initializes stuff. It is important that the options (if you want to pass any) and lib directory are given before calling this method.

                myControl.SourceProvider.MediaPlayer.Play(new Uri(config.rtspAdtress));
                recordMsg("摄像机预览成功");

            }
            catch (Exception ex)
            {
                recordMsg(ex.Message);
            }

            try
            {
                // IntPtr hwnd = new WindowInteropHelper(this).Handle;
             //   mm = new IRNetSDK.M_MessageCallBacK(cll);
                pp = new IRNetSDK.pfJpegdataCallback(M_CallBacK);
                //bool ad = IRNetSDK.IRNET_ClientStartup(0x0400 + 100, hwnd, IntPtr.Zero, mm);

                //IRNetSDK.CHANNEL_CLIENTINFO cHANNEL = new IRNetSDK.CHANNEL_CLIENTINFO()
                //{
                //    // url = "192.168.1.29",
                //    m_password = "888888",
                //    m_username = "888888",
                //    m_sername = "192.168.1.29",
                //    m_tranType = 3,
                //    m_hChMsgWnd = IntPtr.Zero,
                //    m_nChmsgid = 0,
                //    m_playstart = 1,
                //    m_useoverlay = 0,
                //    m_buffnum = 20,
                //    m_hVideohWnd = pictureBox2.Handle,
                //    m_messagecallback = mm,
                //    m_ch = 0,
                //    nColorKey = 255,
                //    context = IntPtr.Zero

                //};
                //IntPtr b = IRNetSDK.IRNET_ClientStart("192.168.1.29", ref cHANNEL);
                //  int safdsf = IRNetSDK.IRNET_ClientCapture(b, IRNetSDK.FileType.EN_FT_SDK_CHANNEL_BMP, "D:\\sdsadas.bmp");sl
                //bool c = IRNetSDK.IRNET_ClientSetWnd(b, p1.Handle);
                //bool d = IRNetSDK.IRNET_ClientStartView(b);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void cll(IntPtr hHandle, uint wParam, int lParam, IntPtr context)
        {
            //MessageBox.Show("dsa");
        }

        public void M_CallBacK(IntPtr hHandle, int m_ch, IntPtr pBuffer, int size, IntPtr extraData, IntPtr userdata)
        {
            if (size < 1)
            {
                return;
            }
            
            string dir = $"image\\{DateTime.Now.ToString("yyyy-MM-dd")}";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            // MessageBox.Show("dsa");

            try
            {
                byte[] buffer = new byte[size];
                Marshal.Copy(pBuffer, buffer, 0, size);
                FileStream fs = new FileStream($"{dir}\\ray-{DateTime.Now.ToString("HHmmssffff")}.jpg", FileMode.Create);
                fs.Write(buffer, 0, size); fs.Dispose();


                this.Dispatcher.Invoke(() =>
                {
                    BitmapImage image = ByteArrayToBitmapImage(buffer);
                    img2.Source = image;
                });
            }
            catch (Exception ex)
            {

            }


            // byte[] buffer = (byte[])Marshal.PtrToStructure(extraData, typeof(byte[]));
        }
        public BitmapImage ByteArrayToBitmapImage(byte[] byteArray)
        {
            BitmapImage bmp = null;

            try
            {
                bmp = new BitmapImage();
                bmp.BeginInit();
                bmp.StreamSource = new MemoryStream(byteArray);
                bmp.EndInit();
            }
            catch
            {
                bmp = null;
            }

            return bmp;
        }
        public void recordMsg(string m)
        {
            msg.Text = $"{m}\r\n{ msg.Text}";
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

            TextBox text = sender as TextBox;
            if (string.IsNullOrEmpty(text.Text))
            {
                return;
            }
            if (text.Text == "0")
            {
                return;
            }
            if (text.Text == "-")
            {
                return;
            }
            switch (text.Name)
            {
                case "rightMove":

                    Canvas.SetLeft(r2, Rleft + Convert.ToDouble(rightMove.Text));
                    break;
                case "downMove":

                    Canvas.SetTop(r2, Rtop + Convert.ToDouble(downMove.Text));
                    break;
                case "widthPro":

                    r2.Width = rwidth * Convert.ToDouble(widthPro.Text);
                    break;
                case "heightPro":

                    r2.Height = rheight * Convert.ToDouble(heightPro.Text);
                    break;
            }
        }

        public byte[] buff;
        //抓图
        private void Capture_Click(object sender, RoutedEventArgs e)
        {
            IntPtr cc = IRNetSDK.IRNET_ClientJpegCapStart("sa", config.RayIp, "888888", "888888", 3000, pp, IntPtr.Zero);
            bool dd = IRNetSDK.IRNET_ClientJpegCapSingle(cc, 0, 100);


            int lChannel = (int)DeviceInfo.byStartChan;

            //预览的设备通道 the device channel number
            //通道号 Channel number

            CHCNetSDK.NET_DVR_JPEGPARA lpJpegPara = new CHCNetSDK.NET_DVR_JPEGPARA();
            lpJpegPara.wPicQuality = 0; //图像质量 Image quality
            lpJpegPara.wPicSize = 4; //抓图分辨率 Picture size: 0xff-Auto(使用当前码流分辨率) 
            //抓图分辨率需要设备支持，更多取值请参考SDK文档

            //JPEG抓图保存成文件 Capture a JPEG picture
            string dir = $"image\\{DateTime.Now.ToString("yyyy-MM-dd")}";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            string sJpegPicFileName = $"image\\{DateTime.Now.ToString("yyyy-MM-dd")}\\{DateTime.Now.ToString("HHmmssffff")}.jpg";
            //图片保存路径和文件名 the path and file name to save

            if (!CHCNetSDK.NET_DVR_CaptureJPEGPicture(m_lUserID, lChannel, ref lpJpegPara, sJpegPicFileName))
            {
                uint iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                //str = "NET_DVR_CaptureJPEGPicture failed, error code= " + iLastErr;
                //DebugInfo(str);
                //return;

                recordMsg($"抓图失败，错误Code{iLastErr}");
            }
            else
            {
                recordMsg("抓图成功：filetest.jpg");
                // string filename = $"{Environment.CurrentDirectory}\\{sJpegPicFileName}";
                FileStream fs = new FileStream(sJpegPicFileName, FileMode.Open);
                buff = new byte[fs.Length];
                fs.Read(buff, 0, buff.Length);
                BitmapImage image = ByteArrayToBitmapImage(buff);
                img.Source = image;
                recordMsg($"图片宽度：{image.Width}图片高度：{image.Height}");
                recordMsg($"Imag控件宽度：{img.Width}Imag控件高度：{img.Height}");
                recordMsg($"Imag显示宽度：{img.ActualWidth}Imag显示高度：{img.ActualHeight}");
                //fs
                // img.Source = new BitmapImage(new Uri("F:\\heng\\红外测温\\WpfApp1\\WpfApp1\\bin\\x64\\Debug\\filetest.jpg"));
                //Stream stream = fs;  
                //   img.Source=BitmapFrame.Create(stream, BitmapCreateOptions.None, BitmapCacheOption.Default);
                fs.Dispose();
                //str = "NET_DVR_CaptureJPEGPicture succ and the saved file is " + sJpegPicFileName;
                //DebugInfo(str);
            }

        }
        public double Rleft, Rtop, rwidth, rheight;

        private void save_Click(object sender, RoutedEventArgs e)
        {
            Common.rightMove = int.Parse(rightMove.Text);
            Common.UpdateSettingString("rightMove", rightMove.Text);

            Common.downMove = int.Parse(downMove.Text);
            Common.UpdateSettingString("downMove", downMove.Text);

            Common.widthPro = double.Parse(widthPro.Text);
            Common.UpdateSettingString("widthPro", widthPro.Text);

            Common.heightPro = double.Parse(heightPro.Text);
            Common.UpdateSettingString("heightPro", heightPro.Text);
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            // FileStream fs = new FileStream("D:\\下载\\CH-HCNetSDKV6.1.4.6_build20191220_Win64\\Demo示例\\3- C# 开发示例\\2-实时预览示例代码二\\NVRCsharpDemo\\bin\\buffertest.jpg", FileMode.Open);
            //Image im = Image.FromStream(fs);
            //MakeThumbnailImage(im, 1058 - 784, 499 - 175, 1058 - 784, 499 - 175, 784, 175);

            //byte[] buff = new byte[fs.Length];
            //fs.Read(buff, 0, buff.Length);
            try
            {
                string requestStr = "{\"img_base64\":\"" + Convert.ToBase64String(buff) + "\"}";
                // string ipAdress = ip; //"http://www.smaradio.tech/facemask/image_predict";
                HttpClient http = new HttpClient();
                HttpContent content = new StringContent(requestStr);
                content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

                HttpResponseMessage response = http.PostAsync(Common.faceIP, content).Result;
                string str = response.Content.ReadAsStringAsync().Result;

                box b = JsonConvert.DeserializeObject<box>(str);
                if (!b.success)
                {
                    recordMsg("算力盒子接口出错");
                    return;
                }
                if (b.predictions.Length == 0)
                {
                    recordMsg("当前图片人脸数量位0");
                    return;
                }
                int i = 1; double a = (double)400 / (double)1920, db = (double)320 / (double)1080, a2 = (double)336 / (double)1920, db2 = (double)256 / (double)1080;
                b.predictions.ToList().ForEach(x =>
                {
                    recordMsg($"第{i++}个人脸：口罩->{x.class_id}(0- 有口罩 1-无口罩) 可信度->{x.confident_score} xmax->{x.xmax} xmin->{x.xmin} ymax->{x.ymax} ymin->{x.ymin}");


                    r1.Width = (x.xmax - x.xmin) * a;

                    r1.Height = (x.ymax - x.ymin) * db;
                    Canvas.SetLeft(r1, x.xmin * a);
                    Canvas.SetTop(r1, x.ymin * db);


                    r2.Width = (x.xmax - x.xmin) * a2 * double.Parse(widthPro.Text);


                    r2.Height = (x.ymax - x.ymin) * db2 * double.Parse(heightPro.Text);

                    Canvas.SetLeft(r2, x.xmin * a2 + int.Parse(rightMove.Text));
                    Canvas.SetTop(r2, x.ymin * db2 + int.Parse(downMove.Text));
                    rwidth = r2.Width;
                    rheight = r2.Height;
                    Rleft = x.xmin * a2;

                    Rtop = x.ymin * db2;



                    r3.Width = (x.xmax - x.xmin) * a;

                    r3.Height = (x.ymax - x.ymin) * db;
                    Canvas.SetLeft(r3, x.xmin * a);
                    Canvas.SetTop(r3, x.ymin * db);
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void CalculateTemperature_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
