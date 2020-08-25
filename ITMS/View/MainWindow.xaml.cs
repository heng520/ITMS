using IMagineWorldClient.SDK.Equipment;
using ITMS.APi.Model;
using ITMS.Equipment;
using ITMS.Infrastructure;
using ITMS.Model;
using ITMS.SDK.Equipment;
using ITMS.Style;
using ITMS.View.Page;
using MaterialDesignThemes.Wpf;
using Modbus.Device;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Media;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;
using Point = System.Drawing.Point;

namespace ITMS.View
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            //Common.DrawingMark(@"image\2020-04-13\1102233014.jpg", @"image\2020-04-13\1102233013.jpg", "dsa", new Point(10, 10), 200, 200);
            //Uri a = new Uri(@"image\2020-04-13\1102233014.jpg",UriKind.Relative);
            InitializeComponent();
            //设备初始化

            ///温度传感器循环
            Task.Run(() => { m_bInitSDK = CHCNetSDK.NET_DVR_Init(); envirTemp(); });
            senseView.ItemsSource = SenseDatas;
            //SenseDatas.Add(new senseData()
            //{
            //    mask = "有",
            //    temp = "234",
            //     imgDir=new BitmapImage(new Uri("F:\heng\红外测温\ITMS\ITMS\bin\Debug\image\2020-04-13"))
            //});
            ShowTimer = new System.Windows.Threading.DispatcherTimer();

            ShowTimer.Tick += new EventHandler(ShowCurTimer);//起个Timer一直获取当前时间

            ShowTimer.Interval = new TimeSpan(0, 0, 0, 1, 0);

            ShowTimer.Start();


            DeleteTimer = new System.Windows.Threading.DispatcherTimer();
            DeleteTimer.Tick += new EventHandler((sender, e) =>
            {
                //删除视频

                DirectoryInfo root = new DirectoryInfo("vedio");
                DirectoryInfo[] directories = root.GetDirectories();
                for (int i = 0; i < directories.Length; i++)
                {

                    if (DateTime.Parse(directories[i].Name) < DateTime.Now.AddDays((-1) * Common.deleteImage))
                    {
                        FileInfo[] files = directories[i].GetFiles();
                        files.ToList().ForEach(x => File.Delete(x.FullName));
                        directories[i].Delete();
                    }
                }
                //图片
                root = new DirectoryInfo("image");
                directories = root.GetDirectories();
                for (int i = 0; i < directories.Length; i++)
                {

                    if (DateTime.Parse(directories[i].Name) < DateTime.Now.AddDays((-1) * Common.deleteImage))
                    {
                        FileInfo[] files = directories[i].GetFiles();
                        files.ToList().ForEach(x => File.Delete(x.FullName));
                        directories[i].Delete();
                    }
                }
                root = new DirectoryInfo("Logs/Error");
                directories = root.GetDirectories();
                for (int i = 0; i < directories.Length; i++)
                {

                    if (DateTime.Parse(directories[i].Name) < DateTime.Now.AddDays((-1) * Common.deleteImage))
                    {
                        FileInfo[] files = directories[i].GetFiles();
                        files.ToList().ForEach(x => File.Delete(x.FullName));
                        directories[i].Delete();
                    }
                }
            });
            //起个Timer一直获取当前时间

            DeleteTimer.Interval = new TimeSpan(1, 0, 0);

            DeleteTimer.Start();
        }
        public void ShowCurTimer(object sender, EventArgs e)
        {

            ShowTime();

        }
        private DispatcherTimer ShowTimer;

        private DispatcherTimer DeleteTimer;
        private void ShowTime()
        {

            nowTime.Content = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        }
        public ObservableCollection<senseData> SenseDatas { get; set; } = new ObservableCollection<senseData>();

        public statisticData statisticData { get; set; } = new statisticData();

        public Int32 m_lUserID = -1;
        public Int32 m_lRealHandle = -1;
        private bool m_bInitSDK = false;
        public CHCNetSDK.NET_DVR_DEVICEINFO_V30 DeviceInfo;
        private ConfigModel equipInfo { get; set; }
        private IRNetSDK.pfJpegdataCallback pfJpegCallBack = null;
        private bool m_bRecord { get; set; }

        private AreaTemp areaTemp { get; set; } = new AreaTemp();
        /// <summary>
        /// 定时录像
        /// </summary>
        private DispatcherTimer VideoTimer;
        private bool videoStart { get; set; } = false;
        //定时录像事件
        public void OnVideoTimer(object sender, EventArgs e)
        {
            string dir = $"vedio\\{DateTime.Now.ToString("yyyy-MM-dd")}";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            string sVideoFileName = $"{dir}\\{DateTime.Now.ToString("yyyy-MM-dd HHmmss")}.mp4";
            if (!videoStart)
            {
                //强制I帧 Make one key frame
                int lChannel = DeviceInfo.byStartChan; //通道号 Channel number
                CHCNetSDK.NET_DVR_MakeKeyFrame(m_lUserID, lChannel);
                //开始录像 Start recording
                if (!CHCNetSDK.NET_DVR_SaveRealData(m_lRealHandle, sVideoFileName))
                {
                    //iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    //str = "NET_DVR_SaveRealData failed, error code= " + iLastErr;
                    //DebugInfo(str);
                    //return;
                }
                else
                {
                    //    DebugInfo("NET_DVR_SaveRealData succ!");
                    //    btnRecord.Text = "Stop";
                    videoStart = true;
                }
            }
            else
            {
                //停止录像 Stop recording
                if (!CHCNetSDK.NET_DVR_StopSaveRealData(m_lRealHandle))
                {
                    //iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    //str = "NET_DVR_StopSaveRealData failed, error code= " + iLastErr;
                    //DebugInfo(str);
                    //return;
                }
                else
                {
                    //str = "NET_DVR_StopSaveRealData succ and the saved file is " + sVideoFileName;
                    //DebugInfo(str);
                    //btnRecord.Text = "Record";
                    m_bRecord = false;
                }
            }
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            pseronPassEvent += CapImage;
            try
            {
                if (!string.IsNullOrEmpty(Common.defaultDeviceId) && Common.configList.Count != 0)
                {

                    //1打开视频
                    equipInfo = Common.configList.SingleOrDefault(x => x.DeviceId == Common.defaultDeviceId);
                    //string currentDirectory = @"D:\VLC";
                    var vlcLibDirectory = new DirectoryInfo(Common.vlcDir);
                    var options = new string[]
                    {
                        ////添加日志
                        //"--file-logging", "-vvv", "--logfile=Logs.log"
                        // VLC options can be given here. Please refer to the VLC command line documentation.
                    };
                    //初始化播放器

                    this.myControl.SourceProvider.CreatePlayer(vlcLibDirectory, options);
                    // Load libvlc libraries and initializes stuff. It is important that the options (if you want to pass any) and lib directory are given before calling this method.



                    myControl.SourceProvider.MediaPlayer.Play(new Uri(equipInfo.rtspAdtress));


                    m_lUserID = CHCNetSDK.NET_DVR_Login_V30(equipInfo.CameraIp, 8000, equipInfo.CameraUser, equipInfo.CameraPassword, ref DeviceInfo);

                    CHCNetSDK.NET_DVR_PREVIEWINFO lpPreviewInfo = new CHCNetSDK.NET_DVR_PREVIEWINFO();
                    lpPreviewInfo.hPlayWnd = pictureBox1.Handle;//预览窗口 live view window
                    lpPreviewInfo.lChannel = (int)DeviceInfo.byStartChan; //预览的设备通道 the device channel number
                    lpPreviewInfo.dwStreamType = 0;//码流类型：0-主码流，1-子码流，2-码流3，3-码流4，以此类推
                    lpPreviewInfo.dwLinkMode = 0;//连接方式：0- TCP方式，1- UDP方式，2- 多播方式，3- RTP方式，4-RTP/RTSP，5-RSTP/HTTP 
                    lpPreviewInfo.bBlocked = true; //0- 非阻塞取流，1- 阻塞取流
                    lpPreviewInfo.dwDisplayBufNum = 15; //播放库显示缓冲区最大帧数

                    IntPtr pUser = IntPtr.Zero;//用户数据 user data 

                    m_lRealHandle = CHCNetSDK.NET_DVR_RealPlay_V40(m_lUserID, ref lpPreviewInfo, null/*RealData*/, pUser);

                    //红外线开始区域测温
                    areaTemp.rayInfo = equipInfo;
                    IntPtr handle = new WindowInteropHelper(this).Handle;
                    if (Common.areaList.Count != 0 && Common.areaList.Any(x => x.DeviceId == Common.defaultDeviceId))
                    {
                        // areaTemp.areaList = Common.areaList.SingleOrDefault(x => x.DeviceId == Common.defaultDeviceId);
                        areaList = Common.areaList.SingleOrDefault(x => x.DeviceId == Common.defaultDeviceId);
                    }
                    Start(equipInfo, handle);
                    pfJpegCallBack = M_CallBacK;
                    rayHandle = IRNetSDK.IRNET_ClientJpegCapStart("sa", equipInfo.RayIp, equipInfo.RayUser, equipInfo.RayPassword, 3000, pfJpegCallBack, IntPtr.Zero);
                    VideoTimer = new DispatcherTimer();
                    VideoTimer.Tick += OnVideoTimer;
                    VideoTimer.Interval = new TimeSpan(0, 30, 0);
                    VideoTimer.Start();
                    OnVideoTimer(this, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public IntPtr irnetIntptr { get; set; }
        public IRNetSDK.TEMPCALLBACK tt { get; set; }
        public IRNetSDK.M_MessageCallBacK mm = null;

        public void Start(ConfigModel rayInfo, IntPtr handle)
        {
            //IRNetSDK.IRNET_ClientStartup(0x0400 + 100, handle, IntPtr.Zero, mm);
            LogHelper.Error("红外线测温开起");
            try
            {
                IRNetSDK.CHANNEL_CLIENTINFO cHANNEL = new IRNetSDK.CHANNEL_CLIENTINFO()
                {
                    m_password = rayInfo.RayPassword,
                    m_username = rayInfo.RayUser,
                    m_sername = rayInfo.RayIp,
                    m_tranType = 3,
                    m_hChMsgWnd = IntPtr.Zero,
                    m_nChmsgid = 0,
                    m_playstart = 1,
                    m_useoverlay = 0,
                    m_buffnum = 20,
                    m_hVideohWnd = handle,
                    // m_messagecallback = null,
                    m_ch = 0,
                    nColorKey = 255,
                    context = IntPtr.Zero

                };
                irnetIntptr = IRNetSDK.IRNET_ClientStart(rayInfo.RayIp, ref cHANNEL);
                IRNetSDK.DEV_TEMP_SPAN dEV_TEMP_SPAN = new IRNetSDK.DEV_TEMP_SPAN()
                {
                    bAuto = true
                };
                tt = new IRNetSDK.TEMPCALLBACK(TTCALLBACK);
                bool a = IRNetSDK.IRNET_ClientRegTempCallBack(irnetIntptr, tt, ref dEV_TEMP_SPAN, IntPtr.Zero);
            }
            catch (Exception ex)
            {
                LogHelper.Error(ex.Message);
            }
        }
        public TemperatureAreaList areaList { get; set; } = new TemperatureAreaList();
        public delegate void pseronPass(ConfigModel model, float[] Temp);
        public event pseronPass pseronPassEvent;
        /// <summary>
        /// 区域测温回调
        /// </summary>
        /// <param name="hHandle"></param>
        /// <param name="fTemperature"></param>
        /// <param name="uWidth"></param>
        /// <param name="uHeight"></param>
        /// <param name="tempSpan"></param>
        /// <param name="context"></param>
        public void TTCALLBACK(IntPtr hHandle, IntPtr fTemperature, uint uWidth, uint uHeight, ref IRNetSDK.DEV_TEMP_SPAN tempSpan, IntPtr context)
        {
            if (!Common.tempAlarm)
            {
                LogHelper.Error($"温度检测关闭");
                return;
            }
            LogHelper.Error($"start----全局温度");
            if (areaList.areas == null || areaList.areas.Count == 0)
            {
                return;
            }
            int count = (int)uWidth * (int)uHeight;
            if (count == 0)
            {
                return;
            }
            try
            {
                float[] temp = new float[count];
                Marshal.Copy(fTemperature, temp, 0, (int)uWidth * (int)uHeight);
                float aaa = temp.Max();

                LogHelper.Error($"温度点数量{count}--宽度{uWidth}--高度 {uHeight}最高温度{aaa}");

                for (int i = 0; i < areaList.areas.Count; i++)
                {
                    if (calculateAreaTemp_Ray(areaList.areas[i].x, areaList.areas[i].y, areaList.areas[i].maxx, areaList.areas[i].maxy, temp, (int)uWidth))
                    {
                        LogHelper.Error($"第{immm++}个人通过");
                        //人通过
                        pseronPassEvent?.Invoke(equipInfo, temp);
                        Thread.Sleep(1000);
                        return;
                    }

                }
            }
            catch (Exception ex)
            {
                LogHelper.Error($"全局温度Exception{ex.Message}");
            }


        }


        /// <summary>
        /// 红外区域计算
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="maxX"></param>
        /// <param name="maxY"></param>
        /// <param name="temp"></param>
        /// <param name="uWidth"></param>
        /// <returns></returns>
        public bool calculateAreaTemp_Ray(int x, int y, int maxX, int maxY, float[] temp, int uWidth)
        {
            float[] ff = new float[(maxX - x) * (maxY - y)];
            int m = 0;
            for (int i = 0; i < ff.Length; i++)
            {
                ff[i] = temp[(y + i / (maxX - x)) * uWidth + x + i % (maxX - x)];
                if (ff[i] > Common.envirTemp) m++;
            }
            //10个 点大于环境温度
            return m > 10 ? true : false;
        }
        public IntPtr rayHandle { get; set; }
        public int immm { get; set; } = 1;

        /// <summary>
        /// 抓拍
        /// </summary>
        public void CapImage(ConfigModel model, float[] Temp)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            //红外图片地址
            string Rdir = "";
            //isdelegate = x =>
            //{
            //    Rdir = x;
            //    LogHelper.Error($"红外抓图-1-地址{Rdir}");
            //};
            ////抓图
            //try
            //{
            //    bool dd = IRNetSDK.IRNET_ClientJpegCapSingle(rayHandle, 0, 100);
            //    LogHelper.Error($"红外抓图-1-完成");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            byte[] buff = null;
            string sJpegPicFileName = $"image\\{DateTime.Now.ToString("yyyy-MM-dd")}\\{DateTime.Now.ToString("HHmmssffff")}.jpg";
            try
            {
                int lChannel = DeviceInfo.byStartChan;

                //预览的设备通道 the device channel number
                //通道号 Channel number

                CHCNetSDK.NET_DVR_JPEGPARA lpJpegPara = new CHCNetSDK.NET_DVR_JPEGPARA();
                lpJpegPara.wPicQuality = 0; //图像质量 Image quality
                lpJpegPara.wPicSize = 0; //抓图分辨率 Picture size: 0xff-Auto(使用当前码流分辨率) 
                                         //抓图分辨率需要设备支持，更多取值请参考SDK文档

                //JPEG抓图保存成文件 Capture a JPEG picture
                string dir = $"image\\{DateTime.Now.ToString("yyyy-MM-dd")}";
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                //图片保存路径和文件名 the path and file name to save
                LogHelper.Error("摄像机开始抓图--2");
                if (!CHCNetSDK.NET_DVR_CaptureJPEGPicture(m_lUserID, lChannel, ref lpJpegPara, sJpegPicFileName))
                {
                    uint iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    //str = "NET_DVR_CaptureJPEGPicture failed, error code= " + iLastErr;
                    LogHelper.Error("ET_DVR_CaptureJPEGPicture failed, error code = " + iLastErr);
                    return;
                }
                else
                {
                    // recordMsg("抓图成功：filetest.jpg");

                    FileStream fs = new FileStream(sJpegPicFileName, FileMode.Open);
                    buff = new byte[fs.Length];
                    fs.Read(buff, 0, buff.Length);
                    fs.Dispose();
                    LogHelper.Error($"摄像机抓图成功");
                }

            }
            catch (Exception ex)
            {
                LogHelper.Error($"摄像机抓图--{ex.ToString()}");
            }

            //人脸计算

            //while (string.IsNullOrEmpty(Rdir))
            //{
            //    Thread.Sleep(100);
            //}
            CalculatePseronFace(buff, Rdir, Temp, sJpegPicFileName);
            sw.Stop();
            LogHelper.Error($"第{immm++}个人计算完成---{sw.Elapsed.Milliseconds}");
        }
        /// <summary>
        /// 播放声音
        /// </summary>
        /// <param name="message"></param>
        public void PlayVoice(string message)
        {
            try
            {
                SpeechSynthesizer speech = new SpeechSynthesizer();
                speech.Rate = -1;
                speech.SelectVoice("Microsoft Huihui Desktop");
                //设置播音员（中文）                                                                                
                //speech.SelectVoice("Microsoft Anna"); //英文
                speech.Volume = 100;
                speech.SpeakAsync(message);
            }
            catch (Exception ex)
            {

            }
        }

        public box box { get; set; }
        /// <summary>
        /// 计算脸部
        /// </summary>
        /// <param name="buff"></param>
        /// <param name="rayImg"></param>
        /// <param name="maxTemp"></param>
        public void CalculatePseronFace(byte[] buff, string rayImg, float[] Temp, string camerImg)
        {
            if (buff.Length == 0)
            {
                LogHelper.Error("图片length为0");
                return;
            }
            try
            {
                string requestStr = "{\"img_base64\":\"" + Convert.ToBase64String(buff) + "\"}";
                HttpClient http = new HttpClient();
                HttpContent content = new StringContent(requestStr);
                content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

                HttpResponseMessage response = http.PostAsync(Common.faceIP, content).Result;
                string str = response.Content.ReadAsStringAsync().Result;
                LogHelper.Error($"HTTP请求{str}");
                box = JsonConvert.DeserializeObject<box>(str);
                if (!box.success)
                {
                    //recordMsg("算力盒子接口出错");
                    return;
                }
                if (box.predictions.Length == 0)
                {
                    LogHelper.Error("当前图片人脸数量位0");
                    return;
                }
                http.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("算力盒子错误：" + ex.Message);
                return;
            }
            LogHelper.Error($"算力盒子");
            float[] ffff = Temp;
            //计算图片全局温度
            //try
            //{
            //    IntPtr handle = new IntPtr();
            //    IrAnalysisSDK.IR_SDK_Read(rayImg, ref handle);
            //    IrAnalysisSDK.SDK_DATA sDK_ = new IrAnalysisSDK.SDK_DATA();
            //    sDK_.enType = IrAnalysisSDK.SDK_DATA_TYPE.SDK_DATAID_IR_IMG;
            //    IrAnalysisSDK.IR_SDK_DataOption(handle, ref sDK_, 0);
            //    IrAnalysisSDK.SDK_IR_IMG img = (IrAnalysisSDK.SDK_IR_IMG)Marshal.PtrToStructure(sDK_.pvData, typeof(IrAnalysisSDK.SDK_IR_IMG));

            //    ffff = new float[img.usWidth * img.usHeight];
            //    uint ssss = (uint)(img.usWidth * img.usHeight);
            //    IrAnalysisSDK.IR_SDK_GetTemp(handle, ssss, ffff);
            //    if (ffff.Length == 0)
            //    {
            //        return;
            //    }
            //}
            //catch (Exception ex)
            //{
            //   LogHelper.Error("图片温度解析" + ex.Message);
            //}


            LogHelper.Error($"温度计算");

            //计算区域温度 加选中框 温度是否戴口罩
            int i = 1; double a = (double)myControl.ActualWidth / (double)1920, db = (double)myControl.ActualHeight / (double)1080,
            a2 = (double)336 / (double)1920, db2 = (double)256 / (double)1080;
            this.Dispatcher.Invoke(() =>
            {
                if (canvansVedio.Children.Count > 0)
                {
                    canvansVedio.Children.Clear();
                }
            });
            bool voicebool = true;
            if (box.predictions.Length > 1)
            {//

                voicebool = false;
            }

            UpImg_Request request = new UpImg_Request();
            request.list = new imgInfo[1];
            request.list[0] = new imgInfo();
            request.list[0].list = new personInfo[box.predictions.Length];
            //request.list[0].pic=
            List<personInfo> imgs = new List<personInfo>();
            int num = 1;
            bool alarmPlay = false;
            try
            {

                //画框
                box.predictions.ToList().ForEach(x =>
                {
                    this.Dispatcher.Invoke(() =>
                    {
                        statisticData.personNum++;
                        personInfo info = new personInfo();
                        FaceFrame frame = new FaceFrame();
                        frame.Width = (x.xmax - x.xmin) * a;
                        frame.Height = (x.ymax - x.ymin) * db;
                        string classid = x.class_id == "0" ? "有" : "无";
                        frame.L1.Content = $"口罩:{classid}";

                        float ab = calculateAreaTemp((int)(x.xmin * a2), (int)(x.ymin * db2), (int)(x.xmax * a2), (int)(x.ymax * db2), ffff, 336);
                        if (ab < 30) return;
                        //Console.WriteLine(ab);
                        float temp = ab; //new TempFixBlh().tempFix(36.5f, Common.envirTemp, ab);
                        frame.L2.Content = $"体温:{temp.ToString("0.0")}";
                        Canvas.SetLeft(frame, x.xmin * a);
                        Canvas.SetTop(frame, x.ymin * db);
                        canvansVedio.Children.Add(frame);
                        //声音
                        string voice = ""; bool alarm = false;
                        if (temp < Common.normarlTemp)
                        {
                            voice = $"{temp.ToString("0.0")}度";
                            info.hot = false;
                        }
                        else
                        {
                            alarmPlay = true;
                            info.hot = true; statisticData.highTemp++;
                            voice = $"体温异常{ temp.ToString("0.0")}"; alarm = true;
                        }
                        if (Common.maskAlarm && classid == "无")
                        {
                            statisticData.noMask++;
                            voice += ",未戴口罩";
                            alarm = true;
                        }
                        if (voicebool)
                        {
                            PlayVoice(voice);
                        }
                        info.temp = temp.ToString();
                        info.mask = x.class_id == "0" ? true : false;
                        info.time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        info.pid = (num++).ToString();
                        imgs.Add(info);

                        string file = $"AlarmImage\\{DateTime.Now.ToString("yyyy-MM-dd")}";

                        if (!Directory.Exists(file))
                        {
                            Directory.CreateDirectory(file);
                        }
                        string savadir = $"{file}\\{DateTime.Now.ToString("HHmmssfff")}.jpg";
                        Common.DrawingMark(camerImg, savadir, $"{ temp.ToString("0.0")}度\n口罩：{classid}", new System.Drawing.Point(x.xmin, x.ymin), x.xmax - x.xmin, x.ymax - x.ymin);
                        if (alarm)
                        {
                            Task.Run(() =>
                            {
                                alarmRecord(temp.ToString(), classid, savadir);
                            });
                        }
                        var mactch = box.match_results.SingleOrDefault(m => m.det_idx == x.det_idx);
                        string matchName = mactch == null ? "--" : mactch.match_name;
                        SenseDatas.Add(new senseData()
                        {
                            mask = classid,
                            temp = temp.ToString("0.0"),
                            imgDir = new BitmapImage(new Uri($"{Environment.CurrentDirectory}\\{savadir}")),
                            MatchName = matchName
                        });
                    });
                    //温度计算

                    // float maxTemp = calculateAreaTemp()
                });
                if (voicebool == false && alarmPlay == true)
                {
                    PlayAlarm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Dispatcher.Invoke(() =>
            {
                pNum.Content = statisticData.personNum.ToString();
                maskNum.Content = statisticData.noMask.ToString();
                highNum.Content = statisticData.highTemp.ToString();
            });

            ///照片上传

            if (Common.alarmImageUp)
                Task.Run(() =>
                {
                    request.deviceId = Common.defaultDeviceId;
                    request.list[0].list = imgs.ToArray();
                    request.list[0].pic = Convert.ToBase64String(buff);
                    string rStr = JsonConvert.SerializeObject(request);
                    HttpClient http = new HttpClient();
                    HttpContent content = new StringContent(rStr);
                    content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                    HttpResponseMessage response = http.PostAsync(Common.ApiIP + "faceTemp/batchSave", content).Result;
                    string str = response.Content.ReadAsStringAsync().Result;
                    Response response1 = JsonConvert.DeserializeObject<Response>(str);
                    if (!response1.success)
                    {
                        //recordMsg("算力盒子接口出错");
                        return;
                    }
                    http.Dispose();
                });


            //LogHelper.Error($"显示");
        }

        public void PlayAlarm()
        {
            try
            {
                if (!File.Exists("AlarmVoice\\alarm.wav")) return;
                SoundPlayer player = new SoundPlayer("AlarmVoice\\alarm.wav");
                player.Play();
            }
            catch
            {

            }
        }
        /// <summary>
        /// 报警记录
        /// </summary>
        /// <param name="temp">温度</param>
        /// <param name="mask">口罩</param>
        /// <param name="dir">图片地址</param>
        public void alarmRecord(string temp, string mask, string dir)
        {
            string file = $"AlarmLog\\{DateTime.Now.ToString("yyyy-MM-dd")}";

            if (!Directory.Exists(file))
            {
                Directory.CreateDirectory(file);
            }
            string msg = $"{temp}={mask}={DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}={dir}";
            FileStream fs = new FileStream($"{file}\\{DateTime.Now.ToString("yyyy-MM-dd")}.txt", FileMode.Create);
            byte[] buffer = Encoding.GetEncoding("gbk").GetBytes(msg);
            fs.Write(buffer, 0, buffer.Length);
            fs.Close();
            fs.Dispose();
        }
        /// <summary>
        /// 区域温度
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="maxX"></param>
        /// <param name="maxY"></param>
        /// <param name="temp"></param>
        /// <param name="uWidth"></param>
        /// <returns></returns>
        public float calculateAreaTemp(int x, int y, int maxX, int maxY, float[] temp, int uWidth)
        {
            x += Common.rightMove;
            maxX += Common.rightMove;
            y += Common.downMove;
            maxY += Common.downMove;
            int width = Convert.ToInt32((double.Parse(maxX.ToString()) - double.Parse(x.ToString())) * Common.heightPro);
            int height = Convert.ToInt32((double.Parse(maxY.ToString()) - double.Parse(y.ToString())) * Common.widthPro);
            float[] ff = new float[width * height];
            try
            {
                for (int i = 0; i < ff.Length; i++)
                {
                    ff[i] = temp[(y + i / (maxX - x)) * uWidth + x + i % (maxX - x)];
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error($"计算脸部区域异常---{ff.Length}{ex.Message}");
                return temp.Max();
            }
            return ff.Max();
        }

        private delegate void imgSuceess(string dir);

        private imgSuceess isdelegate { get; set; }
        /// <summary>
        /// 红外抓图回调
        /// </summary>
        /// <param name="hHandle"></param>
        /// <param name="m_ch"></param>
        /// <param name="pBuffer"></param>
        /// <param name="size"></param>
        /// <param name="extraData"></param>
        /// <param name="userdata"></param>
        public void M_CallBacK(IntPtr hHandle, int m_ch, IntPtr pBuffer, int size, IntPtr extraData, IntPtr userdata)
        {
            string dir = $"image\\{DateTime.Now.ToString("yyyy-MM-dd")}";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);

            }
            if (size < 1)
            {
                return;
            }
            // MessageBox.Show("dsa");
            byte[] buffer = new byte[size];
            Marshal.Copy(pBuffer, buffer, 0, size);
            string fileDir = $"image\\{DateTime.Now.ToString("yyyy-MM-dd")}\\{DateTime.Now.ToString("HHmmssffff")}__{new Random().Next(1, 100)}.jpg";
            FileStream fs = new FileStream(fileDir, FileMode.Create);
            fs.Write(buffer, 0, size);
            fs.Dispose();
            isdelegate?.Invoke(fileDir);
            // byte[] buffer = (byte[])Marshal.PtrToStructure(extraData, typeof(byte[]));
        }

        /// <summary>
        /// 环境温度传感器
        /// </summary>
        private void envirTemp()
        {
            while (true)
            {
                try
                {


                    SerialPort port = new SerialPort(Common.serialPort, 9600, Parity.None, 8, StopBits.Two);
                    if (port.IsOpen == false)
                    {
                        port.Open();
                    }
                    IModbusMaster master = ModbusSerialMaster.CreateRtu(port);
                    ushort[] registerBuffer = master.ReadHoldingRegisters(byte.Parse("1"), 0, 4);
                    port.Dispose();
                    lock (Common.L1)
                    {
                        Common.envirTemp = (float)registerBuffer[0] / 10;
                    }
                }
                catch (Exception ex)
                {

                }
                Thread.Sleep(10000);
            }

        }
        //设备管理
        private void equipManager_Click(object sender, RoutedEventArgs e)
        {
            EquipManager manager = new EquipManager();
            manager.Show();
        }
        //手动触发
        private void HandTrigger_Click(object sender, RoutedEventArgs e)
        {
            //Task.Run(() => CapImage(equipInfo));
        }
        //录像
        private void RecordVidio_Click(object sender, RoutedEventArgs e)
        {
            if (videoStart)
            {
                //DiaShowWindow dia = new DiaShowWindow();
                //dia.msg("当前正在录像,是否停止", "无");
                //await dia.showAlter();
                CHCNetSDK.NET_DVR_StopSaveRealData(m_lRealHandle);
                VideoTimer.Stop();
                videoStart = false;
            }
            string dir = $"vedio\\{DateTime.Now.ToString("yyyy-MM-dd")}";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            string sVideoFileName = $"{dir}\\{DateTime.Now.ToString("yyyy-MM-dd HHmmss")}.mp4";
            if (m_bRecord == false)
            {
                //强制I帧 Make one key frame
                int lChannel = DeviceInfo.byStartChan; //通道号 Channel number
                CHCNetSDK.NET_DVR_MakeKeyFrame(m_lUserID, lChannel);
                //开始录像 Start recording
                if (!CHCNetSDK.NET_DVR_SaveRealData(m_lRealHandle, sVideoFileName))
                {
                    //iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    //str = "NET_DVR_SaveRealData failed, error code= " + iLastErr;
                    //DebugInfo(str);
                    //return;
                }
                else
                {
                    new DiaShow().Show("开始录像");
                    RecordVidio.ToolTip = "停止录像";
                    //    DebugInfo("NET_DVR_SaveRealData succ!");
                    //    btnRecord.Text = "Stop";
                    m_bRecord = true;
                }
            }
            else
            {
                //停止录像 Stop recording
                if (!CHCNetSDK.NET_DVR_StopSaveRealData(m_lRealHandle))
                {
                    //iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    //str = "NET_DVR_StopSaveRealData failed, error code= " + iLastErr;
                    //DebugInfo(str);
                    //return;
                }
                else
                {
                    //str = "NET_DVR_StopSaveRealData succ and the saved file is " + sVideoFileName;
                    //DebugInfo(str);
                    //btnRecord.Text = "Record";
                    new DiaShow().Show("录像已停止");
                    RecordVidio.ToolTip = "录像";
                    m_bRecord = false;
                    VideoTimer.Start();
                    videoStart = false;
                }
            }
        }
        /// <summary>
        /// 拍照
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void photo_Click(object sender, RoutedEventArgs e)
        {
            int lChannel = DeviceInfo.byStartChan;

            //预览的设备通道 the device channel number
            //通道号 Channel number

            CHCNetSDK.NET_DVR_JPEGPARA lpJpegPara = new CHCNetSDK.NET_DVR_JPEGPARA();
            lpJpegPara.wPicQuality = 0; //图像质量 Image quality
            lpJpegPara.wPicSize = 0; //抓图分辨率 Picture size: 0xff-Auto(使用当前码流分辨率) 
                                     //抓图分辨率需要设备支持，更多取值请参考SDK文档

            //JPEG抓图保存成文件 Capture a JPEG picture
            string dir = $"HandImage\\{DateTime.Now.ToString("yyyy-MM-dd")}";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            string sJpegPicFileName = $"HandImage\\{DateTime.Now.ToString("yyyy-MM-dd")}\\{DateTime.Now.ToString("HHmmssffff")}.jpg";
            //图片保存路径和文件名 the path and file name to save
            //LogHelper.Error("开始抓图");
            if (!CHCNetSDK.NET_DVR_CaptureJPEGPicture(m_lUserID, lChannel, ref lpJpegPara, sJpegPicFileName))
            {
                uint iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                //str = "NET_DVR_CaptureJPEGPicture failed, error code= " + iLastErr;
                LogHelper.Error("ET_DVR_CaptureJPEGPicture failed, error code = " + iLastErr);
                return;
            }
            else
            {
                new DiaShow().Show("抓图成功");
            }
        }
        /// <summary>
        /// 回放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backplay_Click(object sender, RoutedEventArgs e)
        {
            PlayBack playBack = new PlayBack();
            playBack.Show();
        }
        /// <summary>
        /// 关闭登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeLogin_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modifyPassword_Click(object sender, RoutedEventArgs e)
        {
            ModifyPassword password = new ModifyPassword();
            password.Show();
        }
        /// <summary>
        /// 红外线调整
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RayModul_Click(object sender, RoutedEventArgs e)
        {
            if (m_lUserID != 0)
            {
                DialogShow show = new DialogShow();
                show.msg("初始化未完成", "无");
                return;
            }
            RayModulation ray = new RayModulation(equipInfo, m_lUserID, DeviceInfo);
            ray.Show();
        }
        //断开连接
        private void break_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                myControl.SourceProvider.MediaPlayer.ResetMedia();
                // IRNetSDK.IRNET_ClientRecordEnd(irnetIntptr);
                // IRNetSDK.IRNET_ClientStop(irnetIntptr);
                bool a = IRNetSDK.IRNET_ClientCleanup();
            }
            catch (Exception ex)
            {

            }


        }
        //开始预览
        private void startdVidio_Click(object sender, RoutedEventArgs e)
        {
            myControl.SourceProvider.MediaPlayer.Play();
            Start(equipInfo, new WindowInteropHelper(this).Handle);
        }

        private void alarmL_Click(object sender, RoutedEventArgs e)
        {
            AlarmLog log = new AlarmLog();
            log.Show();
        }
        /// <summary>
        /// 数据配置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void configMan_Click(object sender, RoutedEventArgs e)
        {
            ConfigInfo config = new ConfigInfo();
            config.Show();
        }

        private void BigImage_Click(object sender, RoutedEventArgs e)
        {
            senseData item = (senseData)senseView.SelectedItem;
            BigImageWindow big = new BigImageWindow();
            big.img.Source = item.imgDir;
            big.Show();
        }
    }


    public class statisticData
    {
        public int personNum { get; set; }
        public int noMask { get; set; }
        public int highTemp { get; set; }
    }



    public class senseData
    {
        public int id { get; set; }
        public string mask { get; set; }
        public string temp { get; set; }
        public ImageSource imgDir { get; set; }
        public string MatchName { get; set; }

    }
}
