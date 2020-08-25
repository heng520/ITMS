#ifndef _IR_SDK_H_
#define _IR_SDK_H_

#ifdef __cplusplus
extern "C"
{
#endif

#ifdef IR_SDK_EXPORTS
#ifdef SYS_LINUX
#define IR_SDK_API __attribute__((visibility("default")))
#else
#define IR_SDK_API _declspec(dllexport)
#endif

#else
#ifdef SYS_LINUX
#define IR_SDK_API 
#else
#define IR_SDK_API _declspec(dllimport)
#endif

#endif

	//定义函数调用规则
#ifndef SYS_LINUX
#define DLL_CALL  __stdcall 
#else
#define DLL_CALL  
#endif
 
	/**
	/**
	* @name	常见返回值类型
	* @{
	*/
#define SDK_STAT_OK				(0)		    /**< 操作成功             */
#define SDK_STAT_FAIL			(-1)		/**< 操作失败             */
#define SDK_STAT_ERR_PARAM		(-2)		/**< 输入参数错误         */
#define SDK_STAT_ERR_MALLOC		(-3)		/**< 分配内存失败         */
#define SDK_STAT_OPEN_FILE_FAIL	(-4)		/**< 打开文件失败         */
#define SDK_STAT_TELL_FILE_FAIL	(-5)		/**< 获取文件读写位置失败 */
	/** @} */

	/** LFF文件句柄 */
	typedef void* SDK_HANDLE;

	typedef enum SDK_VIS_TYPE
	{
		SDK_VISID_DATA = 0,			/**<原始网络数据*/
		SDK_VISID_JPG = 1,			/**<jpg文件数据 */
		SDK_VISID_PNG = 2			/**<png文件数据 */
	}SDK_VIS_TYPE;

	/** 红外图像 */
	typedef struct
	{
		unsigned short  usWidth;		/**< 图像宽度，单位像素    */
		unsigned short	usHeight;		/**< 图像高度，单位像素    */
		unsigned short	usStride;		/**< 跨度，或步长，单位字节*/
		unsigned short	*pusData;		/**< 图像首地址， 16位/像素*/
	}SDK_IR_IMG;

	/** 可见光图像 */
	typedef struct SDK_VIS_IMG
	{
		SDK_VIS_TYPE	enType;		    /**< 可见光数据的类型*/
		unsigned int	uiLen;			/**< 数据长度        */
		unsigned char	*pucData;		/**< 数据首地址      */
	}SDK_VIS_IMG;

	/** 外部显示图像 */
	typedef struct SDK_EXT_IMG
	{
		unsigned short	usWidth;		/**< 图像宽度，单位像素                     */
		unsigned short	usHeight;		/**< 图像高度，单位像素                     */
		unsigned short	usStride;		/**< 跨度，或步长，单位字节                 */
		unsigned char	*pucData;		/**< 图像首地址，3*8位/像素，格式为BGRBGR...*/
	}SDK_EXT_IMG;

	/** 测温外部环境状态信息 */
	typedef struct SDK_ENV_INFO
	{
		float	fEmissivity;	/**< 场景发射率(0-1)*/
		float	fWinTrans;		/**< 窗口传输率(0-1)*/
		float	fWinTemp;		/**< 窗口温度[K]    */
		float	fWinRefl;		/**< 窗口反射率(0-1)*/
		float	fReflTemp;		/**< 窗口反射温度[k]*/
		float	fAtmTrans;		/**< 大气传输率(0-1)*/ 
		float	fAtmTemp;		/**< 大气温度[K]    */
		float	fBkgTemp;		/**< 背景温度[K]    */
		float	fDistance;		/**< 距离[meters]   */
		float	fHumidity;		/**< 相对湿度       */
	}SDK_ENV_INFO;

	/** 形状类型 */
	typedef enum SDK_SHAPE_TYPE
	{
        SDK_SHAPEID_SPOT = 1,		/**<  SDK_SPOT   */
        SDK_SHAPEID_BOX = 2,		/**<  SDK_BOX    */
        SDK_SHAPEID_ELLIPSE = 3,    /**<  SDK_ELLIPSE*/
        SDK_SHAPEID_LINE = 4,       /**<  SDK_LINE   */

        SDK_SHAPEID_OTHERS = 0,		/**<  SDK_OTHERS */
        SDK_SHAPEID_POLYGON = 6,    /**<  SDK_POLYGON*/
	}SDK_SHAPE_TYPE;

	/** 点 */
	typedef struct SDK_SPOT
	{
		unsigned short	usX;		/**< 坐标x*/
		unsigned short	usY;		/**< 坐标y*/
	}SDK_SPOT;

	/** 矩形 */
	typedef struct SDK_BOX
	{
		unsigned short	usX;		/**< 左上角坐标x*/
		unsigned short	usY;		/**< 左上角坐标y*/
		unsigned short	usWidth;	/**< 宽         */
		unsigned short	usHeight;	/**< 高         */
	}SDK_BOX;

    typedef struct tagSDKELLIPSEINFO
    {
        unsigned short	xcentre;	/**< USHORT	椭圆中心x方向坐标	   */
        unsigned short	ycentre;	/**< USHORT	椭圆中心y方向坐标	   */
        unsigned short	x1;			/**< USHORT	椭圆最大半径处x方向坐标*/	
        unsigned short	y1;			/**< USHORT	椭圆最大半径处y方向坐标*/
        unsigned short	x2;			/**< USHORT	椭圆最小半径处x方向坐标*/
        unsigned short	y2;			/**< USHORT	椭圆最小半径处y方向坐标*/
    }SDK_ELLIPSE;

    /**多边形存储的顶点*/
    typedef struct tagSDKVertexINFO
    {
        unsigned short x;/**<pointx*/
        unsigned short y;/**<pointy*/
    }SDK_VERTEX;
    /** polygon*/
    typedef struct tagSDKPOLYGONINFO
    {
        unsigned int cnt;           /**< vertex count*/
        SDK_VERTEX* pData;          /**< data        */
    }SDK_POLYGON;

    typedef struct tagLINEINFO
    {
        unsigned short	xstart;	/**< USHORT	线起点位置x方向坐标	2	0    */   
        unsigned short	ystart;	/**< USHORT	线起点位置y方向坐标	2	2    */
        unsigned short	xend;	/**< USHORT	线终点点位置x方向坐标	2	4*/
        unsigned short	yend;	/**< USHORT	线终点位置y方向坐标	2	6    */
    }SDK_LINE;


    typedef struct tagSDKGPSINFO
    {
        unsigned int	DataValid;		/**< ULONG	1 = 该数据块有效	4	0*/
        unsigned char	VersionID[4];	/**< UCHAR[4]	EXIF Tag	4	4    */
        char	        LatitudeRef[2];	/**< SCHAR[2]	EXIF Tag 1	2	8    */
        short	        LongitudeRef;	/**< SSHORT	EXIF Tag 3	2	0        */
        short	        AltitudeRef;	/**< SSHORT	EXIF Tag 5	2	12       */
        unsigned char	Reserved1[2];	/**< BYTE[2]		2	14           */
        double	        Latitude;		/**< double	EXIF Tag 2	8	16       */
        double	        Longitude;		/**< double	EXIF Tag 4	8	24       */
        float	        Altitude;		/**< float	EXIF Tag 6	4	32       */
        unsigned int	TimeStamp;		/**< ULONG	EXIF Tag 7	4	36       */
        char	        SpeedRef[2];	/**< SCHAR[2]	EXIF Tag 12	2	40   */
        char	        TrackRef[2];	/**< SCHAR[2]	EXIF Tag 14	2	42   */
        float	        Speed;			/**< float	EXIF Tag 13	4	44       */
        float	        Track;			/**< float	EXIF Tag 15	4	48       */
        char	        MapDatum[20];	/**< SCHAR[20]	EXIF Tag 18	20	52   */
        unsigned char	Reserved2[20];	/**< BYTE[20]	保留	20	72       */
    }SDK_GPS;

	/** 用户自定义 */
	typedef struct SDK_OTHERS
	{
        unsigned char abData[32];/**<数据*/
	}SDK_OTHERS;

	/** 标注 */
	typedef struct SDK_LABEL
	{
		unsigned short	usX;		/**< 坐标x*/
		unsigned short	usY;		/**< 坐标y*/
		char	        acName[16];	/**< 名称 */
	}SDK_LABEL;

	/** 测温区域信息 */
	typedef struct SDK_PSTOBJECT
	{
        SDK_SHAPE_TYPE	enType; /**<形状类型*/

		union
		{
			SDK_SPOT	stSpot;     /**<SDK_SPOT    */
			SDK_BOX		stBox;      /**<SDK_BOX     */
            SDK_ELLIPSE stEllipse;  /**<SDK_ELLIPSE */
            SDK_LINE    stLine;     /**<SDK_LINE    */
            SDK_POLYGON stPolygon;  /**<SDK_POLYGON */
			SDK_OTHERS	stOthers;   /**<SDK_OTHERS  */
		};

        SDK_LABEL		stLabel;    /**<标签        */
	}SDK_PSTOBJECT;

	/** LFF文件测量数据 */
	typedef struct SDK_MEASURE
	{
		unsigned int    uiNum;			/**< 个数                         */
		SDK_PSTOBJECT * pstObject;		/**< 测温区域动态数组，长度为uiNum*/
	}SDK_MEASURE;

	/** LFF文件调色板数据 */
	typedef struct SDK_PALETTE
	{
		unsigned char	bMode;			/*！< 调色板模式：
								0，灰度图
								1，热金属编码
								2，新伪彩色编码
								3，热金属编码
								4，彩虹色编码
								5， rainbowHC
								6， lava
								7， arctic
								*/
	}SDK_PALETTE;

	/** LFF文件融合数据 */
	//typedef struct SDK_FUSION
	//{
	//	unsigned char	bLevel;			///< 融合强度(0-100)
	//	int		iIROffsetX;	///< 红外图像偏移
	//}SDK_FUSION;
    typedef struct SDK_FUSION
    {
        FLOAT	zoomFactor;		/**< float	可见光图像相对于IR图像的放大比例	4	0 */
        SHORT	xpanVal;		/**< SSHORT	可见光中心点X方向偏移	2	4             */
        SHORT	ypanVal;		/**< SSHORT	可见光中心点Y方向偏移	2	6             */
        SHORT	firstFusionX;	/**< SSHORT	在IR图像上的融合区域X方向的起点位置	2	8 */
        SHORT	lastFusionX;	/**< SSHORT	在IR图像上的融合区域X方向的终点位置	2	10*/
        SHORT	firstFusionY;	/**< SSHORT	在IR图像上的融合区域Y方向的起点位置	2	12*/
        SHORT	lastFusionY;	/**< SSHORT	在IR图像上的融合区域Y方向的终点位置	2	14*/
        UCHAR	colorMode;		/*!< UCHAR	0 - 可见光彩色模式
                                1 - 可见光黑白模式
                                1	16
                                */
        UCHAR	useBlending;	/*!< UCHAR	0 - 不使用混合
                                1 - 使用混合	1	17
                                */
        UCHAR	fusionMode;		/*!< UCHAR	0 - 无融合
                                1 - 融合
                                2 - PIP
                                3 - 其他	1	18
                                */
        BYTE	Reserved1;		/**< BYTE	保留	1	19                                                      */
        FLOAT	rotateDeg;		/**< FLOAT	可见光相对于IR顺时针旋转角度，单位°	4	20                      */
        FLOAT	blend;			/**< FLOAT	混合强度，范围0.0~1.0，其中0.0表示只有可见光，1.0表示只有IR	2	24  */ 
        SHORT	bLevel;	///< SSHORT	融合强度，范围0~100	2	28
        SHORT   reserve3;
        int     iIROffsetX;
        BYTE	Reserved2[4];	///< BYTE[10]	保留	10	30*/
    }SDK_FUSION;

	/*AGC参数*/
	typedef struct SDK_AGC
	{
		float mintenp;  /**<最低温      */
		float maxtemp;  /**<最高温      */
		int   isAuto;   /**<1自动，0手动*/
	}SDK_AGC;

	/** LFF文本注释*/
	typedef struct SDK_TXTCMT
	{
		unsigned int uiLen;			/**< 注释长度，单位字节 */
		char	*    pcTxtCmt;		/**< 注释，长度等于uiLen*/
	}SDK_TXTCMT;

    typedef struct SDK_DISPLAY_INFO
    {
        float	yxPixRatio;		/**< float	非方条件，X / Y拉伸比例	4	0       */
        float	zoomFactor;		/**< float	变倍因子，1.0 = 正常大小	4	4   */
        short	xpanVal;		/**< SSHORT	变倍基点X坐标	2	8               */
        short	ypanVal;		/**< SSHORT	变倍基点Y坐标	2	10              */
        short	flipVal;		/*!< SSHORT	图像翻转，
                                0 - 无翻转
                                1 - 水平翻转
                                2 - 垂直翻转
                                3 - 水平 + 垂直翻转
                                2	12
                                */
        unsigned char	Reserved[6];	///< byte[6]	保留	6	14
    }SDK_DISPLAY_INFO;

    /**镜头*/
    typedef struct SDK_LENS_DATA
    {
        CHAR	Name[16];		///< char[16]	名称	16	0
        CHAR	PN[16];			///< char[16]	零件号	16	16
        CHAR	SN[16];			///< char[16]	序列号	16	32
        FLOAT	HFoV;			///< FLOAT	水平视场角	4	48
        FLOAT	VFoV;			///< FLOAT	垂直视场角	4	52
        FLOAT	Transm;			///< FLOAT	传输率	4	56
        USHORT	FocalLength;	///< USHORT	镜头焦距，单位mm	2	60
        USHORT	Length;			///< USHORT	镜头长度，单位mm	2	62
        FLOAT	Aperture;		///< FLOAT	光圈值	4	64
        BYTE	Reserved[12];	///< BYTE[12]	保留	12	68
    }SDK_LENS_DATA;

    /**相机信息*/
    typedef struct SDK_CAMERA_INFO
    {
        CHAR		CameraModel[16];	///< char[16]	相机型号	16	0
        CHAR		CameraPN[16];		///< char[16]	相机零件号	16	16
        CHAR		CameraSN[16];		///< char[16]	相机序列号	16	32
        CHAR		CameraSoftware[16];	///< char[16]	相机固件版本号	16	48
        SDK_LENS_DATA	Lens[2];			///< LENS_DATA_T[2]	镜头参数	160	52
        BYTE		Reserved[20];		///< BYTE[20]	保留	20
    }SDK_CAMERA_INFO;

    /** 传感器 */
    typedef struct SDK_SENSOR_PARAM
    {
        UCHAR	ucID;			///< ID
        FLOAT	fValue;			///< 值
    }SDK_SENSOR_PARAM;

    /** 红外相机传感器信息 */
    typedef struct SDK_SENSOR_INFO
    {
        SDK_SENSOR_PARAM	astSensor[20];	///< 传感器数组
    }SDK_SENSOR_INFO;

    /** 测温校准参数 */
    typedef struct SDK_CALIB_INFO
    {
        FLOAT	fR;				///< 校准常量R
        FLOAT	fB;				///< 校准常量B
        FLOAT	fF;				///< 校准常量F
        FLOAT	fO;				///< 温度补偿偏移
    }SDK_CALIB_INFO;

	/** LFF文件数据类型 */
	typedef enum SDK_DATA_TYPE
	{
        SDK_DATAID_IR_IMG = 0,		/**< SDK_IR_IMG      */
        SDK_DATAID_VIS_IMG = 1,		/**< SDK_VIS_IMG     */
        SDK_DATAID_EXT_IMG = 2,		/**< SDK_EXT_IMG     */
        SDK_DATAID_ENV_INFO = 3,	/**< SDK_ENV_INFO    */
        SDK_DATAID_MEASURE = 4,		/**< SDK_MEASURE     */
        SDK_DATAID_PALETTE = 5,		/**< SDK_PALETTE     */
        SDK_DATAID_FUSION = 6,		/**< SDK_FUSION      */
        SDK_DATAID_AGC = 7,         /**< SDK_AGC         */
        SDK_DATAID_TXTCMT = 8,      /**< 文本            */
        SDK_DATAID_GPS = 9,         /**< SDK_GPS         */
        SDK_DATAID_DISP_INFO = 10,  /**< SDK_DISPLAY_INFO*/
        SDK_DATAID_CAMERA_INFO = 11,/**<SDK_CAMERA_INFO  */
        SDK_DATAID_SENSOR_INFO = 12,/**<SDK_SENSOR_INFO  */
        SDK_DATAID_CALIB_INFO = 13,/**<SDK_CALIB_INFO  */
	}SDK_DATA_TYPE;

	/** LFF文件数据 */
	typedef struct SDK_DATA
	{
		SDK_DATA_TYPE	enType; /**<数据类型*/
		void			*pvData;/**<数据    */
	}SDK_DATA;
    /**yuv420sp结构*/
	typedef struct SDK_IMG_YUV420SP
	{
		unsigned short	usWidth;		/**< 图像宽度           */
		unsigned short	usHeight;		/**< 图像高度           */
		unsigned short	usStride[3];	/**< YUV每个分量的跨度  */
		unsigned char	*pucData[3];	/**< YUV每个分量的首地址*/
	}SDK_IMG_YUV420SP;

    /** 感兴趣区域 */
    typedef struct IMG_ATTENTION
    {
        short	sX;			        /**< 左上角坐标x*/
        short	sY;			        /**< 左上角坐标y*/
        unsigned short	usWidth;	/**< 宽         */
        unsigned short	usHeight;	/**< 高         */
    }IMG_ATTENTION;
	/**
	@brief					读取LFF文件
	@param[in] acFile		路径+文件名
	@param[out] phLFF	    LFF文件句柄指针
	@return					常见返回值类型
	*/
	IR_SDK_API int DLL_CALL IR_SDK_Read(char const acFile[],SDK_HANDLE *phLFF);

	/**
	@brief					写入LFF文件
	@param[in] phLFF		FFF文件句柄指针
	@param[in] acFile		路径 + 文件名
	@return					常见返回值类型
	*/
	IR_SDK_API int DLL_CALL IR_SDK_Write(SDK_HANDLE const phLFF, char const acFile[]);

	/**
	@brief					销毁LFF文件句柄
	@param[in] phLFF		LFF文件句柄指针
	@return					常见返回值类型
	*/
	IR_SDK_API int DLL_CALL IR_SDK_Detory(SDK_HANDLE *phLFF);

	/**
	@brief					获取或设置LFF文件参数信息
	@param[in] phLFF		LFF文件句柄指针
	@param[in] pstData		数据
	@param[in] isGetOrSet	数据操作方法，0 = 获取，1 = 设置
	@return					常见返回值类型
	*/
	IR_SDK_API int DLL_CALL IR_SDK_DataOption(SDK_HANDLE const phLFF, SDK_DATA *pstData, int isGetOrSet);

	/**
	@brief					计算LFF文件中对应坐标位置的温度
	@param[in] phLFF		LFF文件句柄指针
	@param[in] uiNum		坐标数量
	@param[out] afTemp		温度数组[C]
	@return					常见返回值类型
	*/
	IR_SDK_API 	int DLL_CALL IR_SDK_GetTemp(SDK_HANDLE const phLFF, unsigned int const uiNum, float afTemp[]);

	/**
	@brief					刷新图像
	@param[in] phLFF		LFF文件句柄指针
	@param[out] pstFusion	融合图像，外部分配内存
	@return					常见返回值类型
	*/
	IR_SDK_API 	int DLL_CALL IR_SDK_NewImage(SDK_HANDLE const phLFF, SDK_EXT_IMG *pstFusion);

    /**
    @brief					    获取红外图像(按指定大小输出图像)
    @param[in] phLFF		    LFF文件句柄指针
    @param[in,out] pstFusion	图像，外部分配内存(以宽度为基准放大图像)
    @return					    常见返回值类型
    */
    IR_SDK_API 	int DLL_CALL IR_SDK_GetIRImage(SDK_HANDLE const phLFF, SDK_EXT_IMG *pstFusion);


    /**
    @brief					    获取可见光图像宽高
    @param[in] phLFF		    LFF文件句柄指针
    @param[in] width            图像宽
    @param[in] height           图像高
    @return					    常见返回值类型
    */
    IR_SDK_API 	int DLL_CALL IR_SDK_GetVISImageSize(SDK_HANDLE const phLFF, unsigned int * width, unsigned int* height);

    /**
    @brief					    获取可见光图像
    @param[in] phLFF		    LFF文件句柄指针
    @param[in,out] pstFusion    图像，外部分配内存
    @return					    常见返回值类型
    */
    IR_SDK_API 	int DLL_CALL IR_SDK_GetVISImage(SDK_HANDLE const phLFF,SDK_EXT_IMG *pstFusion);

    /**
    @brief					    判断文件是否可以解析
    @param[in] filepathanme	    文件全路径名  
    @return					    错误码:\n 
    -1-异常，内存不足\n
    0-不能被解析\n
    1-正常解析\n
    2-能够解析
    */
    IR_SDK_API 	int DLL_CALL IR_SDK_FileFormatValid(char* filepathanme);

    /**
    @brief					    可见光图像裁剪
    @param[in]  pImgIn		    输入图像
    @param[in]  pArea		    感兴趣的区域
    @param[out] pImgOut         输出图像(调用者分配足够的内存，可以和pImgIn的一样大，因为裁剪后的图像不大于原始图像)
    @return					    常见返回值类型
    */
    IR_SDK_API 	int DLL_CALL IR_SDK_VisImageClip(SDK_VIS_IMG *pImgIn, IMG_ATTENTION*pArea, SDK_VIS_IMG *pImgOut);

    /**
    @brief					    红外图像放大
    @param[in]  pImgIn		    输入图像
    @param[out] pImgOut         输出图像(调用者分配内存)
    @return					    常见返回值类型
    */
    IR_SDK_API 	int DLL_CALL IR_SDK_IrImageMagnification(SDK_IR_IMG *pImgIn, SDK_IR_IMG *pImgOut);

    /**
    @brief					    图像融合
    @param[in]  phLFF		    文件句柄
    @param[out] pImgOut         输出图像
    @return					    常见返回值类型
    @attention  需要保证红外图像和可见光图像的分辨率一致
    */
    IR_SDK_API 	int DLL_CALL IR_SDK_ImageFusion(SDK_HANDLE const phLFF, SDK_EXT_IMG*pImgOut);


#ifdef __cplusplus
};
#endif

#endif  // _IR_SDK_H_