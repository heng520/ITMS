using ITMS.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMS.Infrastructure
{
    public static class Common
    {
        /// <summary>
        /// 设备所属机构代码
        /// </summary>
        public static string orgCode { get; set; }
        public static string userName { get; set; }
        public static string password { get; set; }
        public static int deleteImage { get; set; }
        /// <summary>
        /// 设备参数列表
        /// </summary>
        public static List<ConfigModel> configList { get; set; } = new List<ConfigModel>();
        /// <summary>
        /// 测温列表
        /// </summary>
        public static List<TemperatureAreaList> areaList { get; set; } = new List<TemperatureAreaList>();
        public static object L1 { get; set; } = new object();
        /// <summary>
        /// 环境温度
        /// </summary>
        public static float envirTemp { get; set; }
        /// <summary>
        /// 默认设备
        /// </summary>
        public static string defaultDeviceId { get; set; }
        /// <summary>
        /// 环境温度传感器串口
        /// </summary>
        public static string serialPort { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public static string faceIP { get; set; }

        public static string ApiIP { get; set; }

        /// <summary>
        /// 报警温度
        /// </summary>
        public static float alarmTemp { get; set; }

        /// <summary>
        /// 正常体温
        /// </summary>
        public static float normarlTemp { get; set; }


        public static int rightMove { get; set; }


        public static int downMove { get; set; }
        public static double widthPro { get; set; }


        public static double heightPro { get; set; }
        public static string vlcDir { get; set; }

        public static bool maskAlarm { get; set; }
        public static bool tempAlarm { get; set; }
        public static bool alarmImageUp { get; set; }
        /// <summary>
        /// 更新设置
        /// </summary>
        /// <param name="settingName"></param>
        /// <param name="valueName"></param>
        public static void UpdateSettingString(string settingName, string valueName)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            if (ConfigurationManager.AppSettings[settingName] != null)
            {
                config.AppSettings.Settings.Remove(settingName);
            }
            config.AppSettings.Settings.Add(settingName, valueName);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }
        /// <summary>
        /// 画水印
        /// </summary>
        public static void DrawingMark(string filename, string saveFile, string text, Point p, int width, int height)
        {
            Bitmap bmp = new Bitmap(filename);
            Graphics g = Graphics.FromImage(bmp);
            Font font = new Font("宋体", 20, System.Drawing.FontStyle.Bold);
            SolidBrush sbrush = new SolidBrush(Color.Red);
            g.DrawString(text, font, sbrush, p);
            g.DrawRectangle(new Pen(sbrush,2), new Rectangle(p.X, p.Y, width, height));
            bmp.Save(saveFile);
        }


    }
}
