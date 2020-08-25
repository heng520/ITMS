using ITMS.Infrastructure;
using ITMS.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ITMS.View
{
    /// <summary>
    /// InfraredRay.xaml 的交互逻辑
    /// </summary>
    public partial class InfraredRay : Window
    {
        public InfraredRay(ConfigModel _config)
        {
            InitializeComponent();
            config = _config;
        }
        public ConfigModel config { get; set; }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string currentDirectory = @"D:\VLC";
            var vlcLibDirectory = new DirectoryInfo(currentDirectory);

            var options = new string[]
            {
                //添加日志
                "--file-logging", "-vvv", "--logfile=Logs.log"
                // VLC options can be given here. Please refer to the VLC command line documentation.
            };
            //初始化播放器
            this.myControl.SourceProvider.CreatePlayer(vlcLibDirectory, options);

            // Load libvlc libraries and initializes stuff. It is important that the options (if you want to pass any) and lib directory are given before calling this method.

            myControl.SourceProvider.MediaPlayer.Play(new Uri($"rtsp://{config.RayIp}:554/stream0"));

            if (Common.areaList.Any(x => x.DeviceId == config.DeviceId))
            {
                TemperatureAreaList tempList   = Common.areaList.SingleOrDefault(x => x.DeviceId == config.DeviceId);
                
                for (int i=0;i< tempList.areas.Count; i++)
                {
                    inPiont = new Point(tempList.areas[i].x*2, tempList.areas[i].y*2);
                    endP=new Point(tempList.areas[i].maxx*2, tempList.areas[i].maxy*2);
                    List<System.Windows.Point> pointList = new List<System.Windows.Point>
                            {
                            new System.Windows.Point(inPiont.X, inPiont.Y),//第一个点
                            new System.Windows.Point(inPiont.X, endP.Y),//第二个点
                            new System.Windows.Point(endP.X, endP.Y),//第三个点
                            new System.Windows.Point(endP.X, inPiont.Y),//第四个点
                            new System.Windows.Point(inPiont.X, inPiont.Y)//第一个点
                            };

                    StylusPointCollection point = new StylusPointCollection(pointList);
                    Stroke stroke = new Stroke(point);

                    stroke.DrawingAttributes = DefaultdrawingAttributes.Clone();
                    if (RectangleStroke.Count > 0)
                    {
                        inkCanvas.Strokes.Remove(RectangleStroke);
                        RectangleStroke.Clear();
                    }
                    temperatures.Add(new TemperatureArea()
                    {
                        x = (int)inPiont.X / 2,
                        y = (int)inPiont.Y / 2,
                        maxx = (int)endP.X / 2,
                        maxy = (int)endP.Y / 2,
                        class_id = stroke
                    });

                    inkCanvas.Strokes.Add(stroke);//添加到面板中

                    RectangleStroke.Add(stroke);//添加到暂存集合中
                }
                
            }
        }
        public DrawingType Type { get; set; } = DrawingType.Rectangle;
        public enum DrawingType
        {

            Rectangle = 1,

            Select = 2
        }
        /// 起点坐标
        /// </summary>
        public Point inPiont { get; set; }
        public Point endP { get; set; }
        /// <summary>
        /// 暂存轨迹路劲图形
        /// </summary>
        public StrokeCollection RectangleStroke { get; set; } = new StrokeCollection();
        List<Rectangle> Rectangles = new List<Rectangle>();


        /// <summary>
        /// 笔迹属性
        /// </summary>
        public DrawingAttributes DefaultdrawingAttributes { get; set; } = new DrawingAttributes
        {
            Color = Colors.Black,
            Width = 1,
            Height = 1,
            StylusTip = StylusTip.Ellipse,

            FitToCurve = false,
            IsHighlighter = false,
            IgnorePressure = false,
        };
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void inkCanvas_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Rectangles.Clear();
            RectangleStroke.Clear();
            inkCanvas.DefaultDrawingAttributes = DefaultdrawingAttributes;//恢复画笔
        }


        private void inkCanvas_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            inPiont = e.GetPosition(inkCanvas); UIElement[] ui = new UIElement[inkCanvas.GetSelectedElements().Count()];
            inkCanvas.GetSelectedElements().CopyTo(ui, 0);

            if (ui.Count() > 0)
            {
                //遍历选中的对象
                for (int i = 0; i < ui.Count(); i++)
                {
                    //选择的图标
                    if (ui[i] is Image)
                    {
                        Image tt = ui[i] as Image;
                        Console.WriteLine(string.Format("width:{0}-----height:{1}", tt.ActualWidth, tt.ActualHeight));
                        //slelectIconEvent?.Invoke(Convert.ToInt32(tt.Tag));
                        break;
                    }
                }
                return;
            }
            //选中模式
            if (inkCanvas.EditingMode == InkCanvasEditingMode.Select)
            {
                return;
            }

            DrawingAttributes drawingAttributes = DefaultdrawingAttributes.Clone();
            drawingAttributes.Color = Colors.Transparent;
            drawingAttributes.FitToCurve = false;
            drawingAttributes.IsHighlighter = false;
            drawingAttributes.IgnorePressure = true;
            inkCanvas.DefaultDrawingAttributes = drawingAttributes;
        }

        public TemperatureArea temperatureArea { get; set; } 
        public List<TemperatureArea> temperatures { get; set; } = new List<TemperatureArea>();
        private void inkCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)//左键已经按下
            {
                endP = e.GetPosition(inkCanvas);
                if (Type == DrawingType.Rectangle)
                {
                    //获取矩形路径点
                    List<System.Windows.Point> pointList = new List<System.Windows.Point>
                            {
                            new System.Windows.Point(inPiont.X, inPiont.Y),//第一个点
                            new System.Windows.Point(inPiont.X, endP.Y),//第二个点
                            new System.Windows.Point(endP.X, endP.Y),//第三个点
                            new System.Windows.Point(endP.X, inPiont.Y),//第四个点
                            new System.Windows.Point(inPiont.X, inPiont.Y)//第一个点
                            };

                    StylusPointCollection point = new StylusPointCollection(pointList);
                    Stroke stroke = new Stroke(point);

                    stroke.DrawingAttributes = DefaultdrawingAttributes.Clone();
                    
                    if (RectangleStroke.Count > 0)
                    {
                        inkCanvas.Strokes.Remove(RectangleStroke);
                        RectangleStroke.Clear();
                        temperatures.Remove(temperatureArea);
                    }
                    temperatureArea = new TemperatureArea()
                    {
                        x = (int)inPiont.X / 2,
                        y = (int)inPiont.Y / 2,
                        maxx = (int)endP.X / 2,
                        maxy = (int)endP.Y / 2,
                        class_id = stroke
                    };
                    temperatures.Add(temperatureArea);
                    inkCanvas.Strokes.Add(stroke);//添加到面板中

                    RectangleStroke.Add(stroke);//添加到暂存集合中

                    //Rectangle rectangle = new Rectangle();
                    //double width = endP.X - inPiont.X;
                    //double Height = endP.Y - inPiont.Y;

                    //rectangle.Width = width <= 0 ? 1 : width;
                    //rectangle.Height = Height <= 0 ? 1 : Height;
                    //rectangle.Stroke = new SolidColorBrush(DefaultdrawingAttributes.Color);
                    //rectangle.StrokeThickness = DefaultdrawingAttributes.Width;
                    ////rectangle
                    //if (Rectangles.Count > 0)
                    //{
                    //    inkCanvas.Children.Remove(Rectangles[0]);
                    //    Rectangles.Clear();
                    //}
                    //InkCanvas.SetLeft(rectangle, inPiont.X);
                    //InkCanvas.SetTop(rectangle, inPiont.Y);
                    //InkCanvas.SetRight(rectangle, inkCanvas.ActualWidth - inPiont.X);
                    //InkCanvas.SetBottom(rectangle, inkCanvas.ActualHeight - inPiont.Y);
                    //inkCanvas.Children.Add(rectangle);
                    //Rectangles.Add(rectangle);
                }


                if (Type == DrawingType.Select)
                {
                    InkCanvas im = sender as InkCanvas;
                }
            }
        }

        private void selectArea_Click(object sender, RoutedEventArgs e)
        {
            inkCanvas.EditingMode = InkCanvasEditingMode.Select;
            Type = DrawingType.Select;
        }

        private void AddArea_Click(object sender, RoutedEventArgs e)
        {
            Type = DrawingType.Rectangle;
            inkCanvas.EditingMode = InkCanvasEditingMode.Ink;//恢复画笔
        }

        private void deleteArea_Click(object sender, RoutedEventArgs e)
        {
            if (inkCanvas.GetSelectedStrokes().Count != 0)
            {
                for (int i = 0; i < inkCanvas.GetSelectedStrokes().Count; i++)
                {
                    Stroke stroke = inkCanvas.GetSelectedStrokes()[i];

                    if (temperatures.Any(x => x.class_id == stroke))
                    {
                        temperatures.Remove(temperatures.ToList().SingleOrDefault(x => x.class_id == stroke));
                    }
                }

                inkCanvas.Strokes.Remove(inkCanvas.GetSelectedStrokes());
            }

            //UIElement[] ui = new UIElement[inkCanvas.GetSelectedElements().Count()];
            //inkCanvas.GetSelectedElements().CopyTo(ui, 0);
            //foreach (var item in ui)
            //{
            //    inkCanvas.Children.Remove(item);
            //}
        }

        private void savaArea_Click(object sender, RoutedEventArgs e)
        {

            if (Common.areaList.Any(x => x.DeviceId == config.DeviceId))
            {
                Common.areaList.Remove(Common.areaList.ToList().SingleOrDefault(x => x.DeviceId == config.DeviceId));
            }
            Common.areaList.Add(new TemperatureAreaList()
            {
                DeviceId = config.DeviceId,
                areas = temperatures
            });

            ConfigData.SerializeFile<List<TemperatureAreaList>>(Common.areaList, "tempArea.json");

        }
    }
}
