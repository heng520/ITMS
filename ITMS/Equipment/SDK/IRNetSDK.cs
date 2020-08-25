using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace ITMS.SDK.Equipment
{

    public class IRNetSDK
    {

        public struct CHANNEL_CLIENTINFO
        {
            public string m_sername;
            public string m_username;                   ///<user name
            public string m_password;                   ///<password
            public ushort m_tranType;                    ///<transmit type   
            public ushort m_playstart;                   ///<is start view
            public byte m_ch;                          ///<channel
            public IntPtr m_hVideohWnd;                  ///<video wnd handle
            public IntPtr m_hChMsgWnd;                   ///<message wnd handle
            public uint m_nChmsgid;                    ///<message id  
            public int m_buffnum;                     ///<buff num
            public int m_useoverlay;                  ///<is use overlay
            public uint nColorKey;                 ///<color key(reserved)
            public string url;                       ///<url
            public M_MessageCallBacK m_messagecallback;       ///<message callback function
            public IntPtr context;

        }
        public enum FileType
        {
            EN_FT_SDK_LCR,          ///<热图
            EN_FT_SDK_CHANNEL_JPG,  ///<通道jpg
            EN_FT_SDK_CHANNEL_BMP,  ///<通道bmp
        };
        public struct DEV_TEMP_SPAN
        {
            public float fTempMin { get; set; }//最小温度

            public float fTempMax { get; set; }//最大温度
            public bool bAuto { get; set; }//自动测温
        }

        public delegate void TEMPCALLBACK(IntPtr hHandle, IntPtr fTemperature, uint uWidth, uint uHeight, ref DEV_TEMP_SPAN tempSpan, IntPtr context);
        public delegate void pfJpegdataCallback(IntPtr hHandle, int m_ch, IntPtr pBuffer, int size, IntPtr extraData, IntPtr userdata);

        public delegate void M_MessageCallBacK(IntPtr hHandle, uint wParam, int lParam, IntPtr context);
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="m_nMessage"></param>
        /// <param name="m_hWnd"></param>
        /// <param name="context"></param>
        /// <param name="m_messagecallback"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        [DllImport("IRNetSDK.dll")]
        public static extern bool IRNET_ClientStartup(uint m_nMessage, IntPtr m_hWnd, IntPtr context, M_MessageCallBacK m_messagecallback, string key = null);


        [DllImport("IRNetSDK.dll")]
        public static extern IntPtr IRNET_ClientStart(string m_url, ref CHANNEL_CLIENTINFO m_pChaninfo, ushort wserport = 3000, int streamtype = 2);

        [DllImport("IRNetSDK.dll")]
        public static extern int IRNET_ClientStop(IntPtr hHandle);

        [DllImport("IRNetSDK.dll")]
        public static extern bool IRNET_ClientSetWnd(IntPtr hHandle, IntPtr hWnd);
        [DllImport("IRNetSDK.dll")]
        public static extern bool IRNET_ClientStartView(IntPtr hHandle, bool decodesign = true);


        [DllImport("IRNetSDK.dll")]
        public static extern IntPtr IRNET_ClientJpegCapStart(string m_sername, string m_url, string m_username, string m_password, ushort wserport, pfJpegdataCallback jpegdatacallback, IntPtr userdata);
        [DllImport("IRNetSDK.dll")]
        public static extern bool IRNET_ClientJpegCapSingle(IntPtr hHandle, int m_ch, int m_quality);
        [DllImport("IRNetSDK.dll")]
        public static extern int IRNET_ClientCapture(IntPtr hHandle, FileType type, string fileName, int quality = 100, string dataAddr = null, uint dataSize = 0);


        [DllImport("IRNetSDK.dll")]
        public static extern bool IRNET_ClientRegTempCallBack(IntPtr hHandle, TEMPCALLBACK pCallBack, ref DEV_TEMP_SPAN tempSpan, IntPtr context);


        [DllImport("IRNetSDK.dll")]
        public static extern bool IRNET_ClientCleanup();

        [DllImport("IRNetSDK.dll")]
        public static extern bool  IRNET_ClientRecordEnd(/*LONG*/IntPtr hHandle);


    }
}
