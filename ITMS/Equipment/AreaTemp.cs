using ITMS.Infrastructure;
using ITMS.Model;
using ITMS.SDK.Equipment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ITMS.Equipment
{
    /// <summary>
    /// 区域温度
    /// </summary>
    public class AreaTemp
    {
        public delegate void pseronPass(ConfigModel model);
        public event pseronPass pseronPassEvent;
        /// <summary>
        /// 红外参数
        /// </summary>
        public ConfigModel rayInfo { get; set; }

        public IRNetSDK.TEMPCALLBACK tt { get; set; }

        public TemperatureAreaList areaList { get; set; } = new TemperatureAreaList();

        public IntPtr handle { get; set; }
        public void Start()
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
            IntPtr b = IRNetSDK.IRNET_ClientStart(rayInfo.RayIp, ref cHANNEL);
            IRNetSDK.DEV_TEMP_SPAN dEV_TEMP_SPAN = new IRNetSDK.DEV_TEMP_SPAN()
            {
                bAuto = true
            };
            tt = new IRNetSDK.TEMPCALLBACK(TTCALLBACK);
            bool a = IRNetSDK.IRNET_ClientRegTempCallBack(b, tt, ref dEV_TEMP_SPAN, IntPtr.Zero);
        }
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
            Console.WriteLine($"全局温度");
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
                //Console.WriteLine($"{aaa++}-----------{temp[0]}---{temp.Length}");

                for (int i = 0; i < areaList.areas.Count; i++)
                {
                    if (calculateAreaTemp(areaList.areas[i].x, areaList.areas[i].y, areaList.areas[i].maxx, areaList.areas[i].maxy, temp, (int)uWidth))
                    {
                        Console.WriteLine($"第{immm++}个人通过");
                        //人通过
                        pseronPassEvent?.Invoke(rayInfo);
                        Thread.Sleep(1000);
                        return;
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"全局温度{ex.Message}");
            }


        }
        public int immm { get; set; } = 1;
        public bool calculateAreaTemp(int x, int y, int maxX, int maxY, float[] temp, int uWidth)
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
    }
}
