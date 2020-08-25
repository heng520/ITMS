using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace IMagineWorldClient.SDK.Equipment
{
    public class IrAnalysisSDK
    {
        public enum SDK_DATA_TYPE
        {
            SDK_DATAID_IR_IMG = 0,      /**< SDK_IR_IMG      */
            SDK_DATAID_VIS_IMG = 1,     /**< SDK_VIS_IMG     */
            SDK_DATAID_EXT_IMG = 2,     /**< SDK_EXT_IMG     */
            SDK_DATAID_ENV_INFO = 3,    /**< SDK_ENV_INFO    */
            SDK_DATAID_MEASURE = 4,     /**< SDK_MEASURE     */
            SDK_DATAID_PALETTE = 5,     /**< SDK_PALETTE     */
            SDK_DATAID_FUSION = 6,      /**< SDK_FUSION      */
            SDK_DATAID_AGC = 7,         /**< SDK_AGC         */
            SDK_DATAID_TXTCMT = 8,      /**< 文本            */
            SDK_DATAID_GPS = 9,         /**< SDK_GPS         */
            SDK_DATAID_DISP_INFO = 10,  /**< SDK_DISPLAY_INFO*/
            SDK_DATAID_CAMERA_INFO = 11,/**<SDK_CAMERA_INFO  */
            SDK_DATAID_SENSOR_INFO = 12,/**<SDK_SENSOR_INFO  */
            SDK_DATAID_CALIB_INFO = 13,
        }

        public struct SDK_DATA
        {
            public SDK_DATA_TYPE enType; /**<数据类型*/
            public IntPtr pvData;/**<数据    */
        }
        public struct SDK_IR_IMG
        {
            public ushort usWidth;
            public ushort usHeight;
            public ushort usStride;
            public ushort pusData;

        }


        public delegate void SDK_HANDLE();
        /**
        *  @brief 读取LFF文件 
        *  @param  string acFile 文件地址
        *  @param  SDK_HANDLE  lef句柄指针
        *  @return 0表示成功，-1表示失败 -2输入参数错误 -3分配内存失败 -4打开文件失败 -5 获取文件读写位置失败
        *  @ingroup group_database
        */
        [DllImport("IrAnalysisSDK.dll")]
        public static extern int IR_SDK_Read(string acFile, ref IntPtr phLFF);


        [DllImport("IrAnalysisSDK.dll")]
        public static extern int IR_SDK_DataOption(IntPtr phLFF, ref SDK_DATA pstData, int isGetOrSet);


        [DllImport("IrAnalysisSDK.dll")]
        public static extern int IR_SDK_GetTemp(IntPtr phLFF, uint uiNum, float[] afTemp);
    }
}
