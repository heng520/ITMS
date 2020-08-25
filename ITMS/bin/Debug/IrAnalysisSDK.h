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

	//���庯�����ù���
#ifndef SYS_LINUX
#define DLL_CALL  __stdcall 
#else
#define DLL_CALL  
#endif
 
	/**
	/**
	* @name	��������ֵ����
	* @{
	*/
#define SDK_STAT_OK				(0)		    /**< �����ɹ�             */
#define SDK_STAT_FAIL			(-1)		/**< ����ʧ��             */
#define SDK_STAT_ERR_PARAM		(-2)		/**< �����������         */
#define SDK_STAT_ERR_MALLOC		(-3)		/**< �����ڴ�ʧ��         */
#define SDK_STAT_OPEN_FILE_FAIL	(-4)		/**< ���ļ�ʧ��         */
#define SDK_STAT_TELL_FILE_FAIL	(-5)		/**< ��ȡ�ļ���дλ��ʧ�� */
	/** @} */

	/** LFF�ļ���� */
	typedef void* SDK_HANDLE;

	typedef enum SDK_VIS_TYPE
	{
		SDK_VISID_DATA = 0,			/**<ԭʼ��������*/
		SDK_VISID_JPG = 1,			/**<jpg�ļ����� */
		SDK_VISID_PNG = 2			/**<png�ļ����� */
	}SDK_VIS_TYPE;

	/** ����ͼ�� */
	typedef struct
	{
		unsigned short  usWidth;		/**< ͼ���ȣ���λ����    */
		unsigned short	usHeight;		/**< ͼ��߶ȣ���λ����    */
		unsigned short	usStride;		/**< ��ȣ��򲽳�����λ�ֽ�*/
		unsigned short	*pusData;		/**< ͼ���׵�ַ�� 16λ/����*/
	}SDK_IR_IMG;

	/** �ɼ���ͼ�� */
	typedef struct SDK_VIS_IMG
	{
		SDK_VIS_TYPE	enType;		    /**< �ɼ������ݵ�����*/
		unsigned int	uiLen;			/**< ���ݳ���        */
		unsigned char	*pucData;		/**< �����׵�ַ      */
	}SDK_VIS_IMG;

	/** �ⲿ��ʾͼ�� */
	typedef struct SDK_EXT_IMG
	{
		unsigned short	usWidth;		/**< ͼ���ȣ���λ����                     */
		unsigned short	usHeight;		/**< ͼ��߶ȣ���λ����                     */
		unsigned short	usStride;		/**< ��ȣ��򲽳�����λ�ֽ�                 */
		unsigned char	*pucData;		/**< ͼ���׵�ַ��3*8λ/���أ���ʽΪBGRBGR...*/
	}SDK_EXT_IMG;

	/** �����ⲿ����״̬��Ϣ */
	typedef struct SDK_ENV_INFO
	{
		float	fEmissivity;	/**< ����������(0-1)*/
		float	fWinTrans;		/**< ���ڴ�����(0-1)*/
		float	fWinTemp;		/**< �����¶�[K]    */
		float	fWinRefl;		/**< ���ڷ�����(0-1)*/
		float	fReflTemp;		/**< ���ڷ����¶�[k]*/
		float	fAtmTrans;		/**< ����������(0-1)*/ 
		float	fAtmTemp;		/**< �����¶�[K]    */
		float	fBkgTemp;		/**< �����¶�[K]    */
		float	fDistance;		/**< ����[meters]   */
		float	fHumidity;		/**< ���ʪ��       */
	}SDK_ENV_INFO;

	/** ��״���� */
	typedef enum SDK_SHAPE_TYPE
	{
        SDK_SHAPEID_SPOT = 1,		/**<  SDK_SPOT   */
        SDK_SHAPEID_BOX = 2,		/**<  SDK_BOX    */
        SDK_SHAPEID_ELLIPSE = 3,    /**<  SDK_ELLIPSE*/
        SDK_SHAPEID_LINE = 4,       /**<  SDK_LINE   */

        SDK_SHAPEID_OTHERS = 0,		/**<  SDK_OTHERS */
        SDK_SHAPEID_POLYGON = 6,    /**<  SDK_POLYGON*/
	}SDK_SHAPE_TYPE;

	/** �� */
	typedef struct SDK_SPOT
	{
		unsigned short	usX;		/**< ����x*/
		unsigned short	usY;		/**< ����y*/
	}SDK_SPOT;

	/** ���� */
	typedef struct SDK_BOX
	{
		unsigned short	usX;		/**< ���Ͻ�����x*/
		unsigned short	usY;		/**< ���Ͻ�����y*/
		unsigned short	usWidth;	/**< ��         */
		unsigned short	usHeight;	/**< ��         */
	}SDK_BOX;

    typedef struct tagSDKELLIPSEINFO
    {
        unsigned short	xcentre;	/**< USHORT	��Բ����x��������	   */
        unsigned short	ycentre;	/**< USHORT	��Բ����y��������	   */
        unsigned short	x1;			/**< USHORT	��Բ���뾶��x��������*/	
        unsigned short	y1;			/**< USHORT	��Բ���뾶��y��������*/
        unsigned short	x2;			/**< USHORT	��Բ��С�뾶��x��������*/
        unsigned short	y2;			/**< USHORT	��Բ��С�뾶��y��������*/
    }SDK_ELLIPSE;

    /**����δ洢�Ķ���*/
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
        unsigned short	xstart;	/**< USHORT	�����λ��x��������	2	0    */   
        unsigned short	ystart;	/**< USHORT	�����λ��y��������	2	2    */
        unsigned short	xend;	/**< USHORT	���յ��λ��x��������	2	4*/
        unsigned short	yend;	/**< USHORT	���յ�λ��y��������	2	6    */
    }SDK_LINE;


    typedef struct tagSDKGPSINFO
    {
        unsigned int	DataValid;		/**< ULONG	1 = �����ݿ���Ч	4	0*/
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
        unsigned char	Reserved2[20];	/**< BYTE[20]	����	20	72       */
    }SDK_GPS;

	/** �û��Զ��� */
	typedef struct SDK_OTHERS
	{
        unsigned char abData[32];/**<����*/
	}SDK_OTHERS;

	/** ��ע */
	typedef struct SDK_LABEL
	{
		unsigned short	usX;		/**< ����x*/
		unsigned short	usY;		/**< ����y*/
		char	        acName[16];	/**< ���� */
	}SDK_LABEL;

	/** ����������Ϣ */
	typedef struct SDK_PSTOBJECT
	{
        SDK_SHAPE_TYPE	enType; /**<��״����*/

		union
		{
			SDK_SPOT	stSpot;     /**<SDK_SPOT    */
			SDK_BOX		stBox;      /**<SDK_BOX     */
            SDK_ELLIPSE stEllipse;  /**<SDK_ELLIPSE */
            SDK_LINE    stLine;     /**<SDK_LINE    */
            SDK_POLYGON stPolygon;  /**<SDK_POLYGON */
			SDK_OTHERS	stOthers;   /**<SDK_OTHERS  */
		};

        SDK_LABEL		stLabel;    /**<��ǩ        */
	}SDK_PSTOBJECT;

	/** LFF�ļ��������� */
	typedef struct SDK_MEASURE
	{
		unsigned int    uiNum;			/**< ����                         */
		SDK_PSTOBJECT * pstObject;		/**< ��������̬���飬����ΪuiNum*/
	}SDK_MEASURE;

	/** LFF�ļ���ɫ������ */
	typedef struct SDK_PALETTE
	{
		unsigned char	bMode;			/*��< ��ɫ��ģʽ��
								0���Ҷ�ͼ
								1���Ƚ�������
								2����α��ɫ����
								3���Ƚ�������
								4���ʺ�ɫ����
								5�� rainbowHC
								6�� lava
								7�� arctic
								*/
	}SDK_PALETTE;

	/** LFF�ļ��ں����� */
	//typedef struct SDK_FUSION
	//{
	//	unsigned char	bLevel;			///< �ں�ǿ��(0-100)
	//	int		iIROffsetX;	///< ����ͼ��ƫ��
	//}SDK_FUSION;
    typedef struct SDK_FUSION
    {
        FLOAT	zoomFactor;		/**< float	�ɼ���ͼ�������IRͼ��ķŴ����	4	0 */
        SHORT	xpanVal;		/**< SSHORT	�ɼ������ĵ�X����ƫ��	2	4             */
        SHORT	ypanVal;		/**< SSHORT	�ɼ������ĵ�Y����ƫ��	2	6             */
        SHORT	firstFusionX;	/**< SSHORT	��IRͼ���ϵ��ں�����X��������λ��	2	8 */
        SHORT	lastFusionX;	/**< SSHORT	��IRͼ���ϵ��ں�����X������յ�λ��	2	10*/
        SHORT	firstFusionY;	/**< SSHORT	��IRͼ���ϵ��ں�����Y��������λ��	2	12*/
        SHORT	lastFusionY;	/**< SSHORT	��IRͼ���ϵ��ں�����Y������յ�λ��	2	14*/
        UCHAR	colorMode;		/*!< UCHAR	0 - �ɼ����ɫģʽ
                                1 - �ɼ���ڰ�ģʽ
                                1	16
                                */
        UCHAR	useBlending;	/*!< UCHAR	0 - ��ʹ�û��
                                1 - ʹ�û��	1	17
                                */
        UCHAR	fusionMode;		/*!< UCHAR	0 - ���ں�
                                1 - �ں�
                                2 - PIP
                                3 - ����	1	18
                                */
        BYTE	Reserved1;		/**< BYTE	����	1	19                                                      */
        FLOAT	rotateDeg;		/**< FLOAT	�ɼ��������IR˳ʱ����ת�Ƕȣ���λ��	4	20                      */
        FLOAT	blend;			/**< FLOAT	���ǿ�ȣ���Χ0.0~1.0������0.0��ʾֻ�пɼ��⣬1.0��ʾֻ��IR	2	24  */ 
        SHORT	bLevel;	///< SSHORT	�ں�ǿ�ȣ���Χ0~100	2	28
        SHORT   reserve3;
        int     iIROffsetX;
        BYTE	Reserved2[4];	///< BYTE[10]	����	10	30*/
    }SDK_FUSION;

	/*AGC����*/
	typedef struct SDK_AGC
	{
		float mintenp;  /**<�����      */
		float maxtemp;  /**<�����      */
		int   isAuto;   /**<1�Զ���0�ֶ�*/
	}SDK_AGC;

	/** LFF�ı�ע��*/
	typedef struct SDK_TXTCMT
	{
		unsigned int uiLen;			/**< ע�ͳ��ȣ���λ�ֽ� */
		char	*    pcTxtCmt;		/**< ע�ͣ����ȵ���uiLen*/
	}SDK_TXTCMT;

    typedef struct SDK_DISPLAY_INFO
    {
        float	yxPixRatio;		/**< float	�Ƿ�������X / Y�������	4	0       */
        float	zoomFactor;		/**< float	�䱶���ӣ�1.0 = ������С	4	4   */
        short	xpanVal;		/**< SSHORT	�䱶����X����	2	8               */
        short	ypanVal;		/**< SSHORT	�䱶����Y����	2	10              */
        short	flipVal;		/*!< SSHORT	ͼ��ת��
                                0 - �޷�ת
                                1 - ˮƽ��ת
                                2 - ��ֱ��ת
                                3 - ˮƽ + ��ֱ��ת
                                2	12
                                */
        unsigned char	Reserved[6];	///< byte[6]	����	6	14
    }SDK_DISPLAY_INFO;

    /**��ͷ*/
    typedef struct SDK_LENS_DATA
    {
        CHAR	Name[16];		///< char[16]	����	16	0
        CHAR	PN[16];			///< char[16]	�����	16	16
        CHAR	SN[16];			///< char[16]	���к�	16	32
        FLOAT	HFoV;			///< FLOAT	ˮƽ�ӳ���	4	48
        FLOAT	VFoV;			///< FLOAT	��ֱ�ӳ���	4	52
        FLOAT	Transm;			///< FLOAT	������	4	56
        USHORT	FocalLength;	///< USHORT	��ͷ���࣬��λmm	2	60
        USHORT	Length;			///< USHORT	��ͷ���ȣ���λmm	2	62
        FLOAT	Aperture;		///< FLOAT	��Ȧֵ	4	64
        BYTE	Reserved[12];	///< BYTE[12]	����	12	68
    }SDK_LENS_DATA;

    /**�����Ϣ*/
    typedef struct SDK_CAMERA_INFO
    {
        CHAR		CameraModel[16];	///< char[16]	����ͺ�	16	0
        CHAR		CameraPN[16];		///< char[16]	��������	16	16
        CHAR		CameraSN[16];		///< char[16]	������к�	16	32
        CHAR		CameraSoftware[16];	///< char[16]	����̼��汾��	16	48
        SDK_LENS_DATA	Lens[2];			///< LENS_DATA_T[2]	��ͷ����	160	52
        BYTE		Reserved[20];		///< BYTE[20]	����	20
    }SDK_CAMERA_INFO;

    /** ������ */
    typedef struct SDK_SENSOR_PARAM
    {
        UCHAR	ucID;			///< ID
        FLOAT	fValue;			///< ֵ
    }SDK_SENSOR_PARAM;

    /** ���������������Ϣ */
    typedef struct SDK_SENSOR_INFO
    {
        SDK_SENSOR_PARAM	astSensor[20];	///< ����������
    }SDK_SENSOR_INFO;

    /** ����У׼���� */
    typedef struct SDK_CALIB_INFO
    {
        FLOAT	fR;				///< У׼����R
        FLOAT	fB;				///< У׼����B
        FLOAT	fF;				///< У׼����F
        FLOAT	fO;				///< �¶Ȳ���ƫ��
    }SDK_CALIB_INFO;

	/** LFF�ļ��������� */
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
        SDK_DATAID_TXTCMT = 8,      /**< �ı�            */
        SDK_DATAID_GPS = 9,         /**< SDK_GPS         */
        SDK_DATAID_DISP_INFO = 10,  /**< SDK_DISPLAY_INFO*/
        SDK_DATAID_CAMERA_INFO = 11,/**<SDK_CAMERA_INFO  */
        SDK_DATAID_SENSOR_INFO = 12,/**<SDK_SENSOR_INFO  */
        SDK_DATAID_CALIB_INFO = 13,/**<SDK_CALIB_INFO  */
	}SDK_DATA_TYPE;

	/** LFF�ļ����� */
	typedef struct SDK_DATA
	{
		SDK_DATA_TYPE	enType; /**<��������*/
		void			*pvData;/**<����    */
	}SDK_DATA;
    /**yuv420sp�ṹ*/
	typedef struct SDK_IMG_YUV420SP
	{
		unsigned short	usWidth;		/**< ͼ����           */
		unsigned short	usHeight;		/**< ͼ��߶�           */
		unsigned short	usStride[3];	/**< YUVÿ�������Ŀ��  */
		unsigned char	*pucData[3];	/**< YUVÿ���������׵�ַ*/
	}SDK_IMG_YUV420SP;

    /** ����Ȥ���� */
    typedef struct IMG_ATTENTION
    {
        short	sX;			        /**< ���Ͻ�����x*/
        short	sY;			        /**< ���Ͻ�����y*/
        unsigned short	usWidth;	/**< ��         */
        unsigned short	usHeight;	/**< ��         */
    }IMG_ATTENTION;
	/**
	@brief					��ȡLFF�ļ�
	@param[in] acFile		·��+�ļ���
	@param[out] phLFF	    LFF�ļ����ָ��
	@return					��������ֵ����
	*/
	IR_SDK_API int DLL_CALL IR_SDK_Read(char const acFile[],SDK_HANDLE *phLFF);

	/**
	@brief					д��LFF�ļ�
	@param[in] phLFF		FFF�ļ����ָ��
	@param[in] acFile		·�� + �ļ���
	@return					��������ֵ����
	*/
	IR_SDK_API int DLL_CALL IR_SDK_Write(SDK_HANDLE const phLFF, char const acFile[]);

	/**
	@brief					����LFF�ļ����
	@param[in] phLFF		LFF�ļ����ָ��
	@return					��������ֵ����
	*/
	IR_SDK_API int DLL_CALL IR_SDK_Detory(SDK_HANDLE *phLFF);

	/**
	@brief					��ȡ������LFF�ļ�������Ϣ
	@param[in] phLFF		LFF�ļ����ָ��
	@param[in] pstData		����
	@param[in] isGetOrSet	���ݲ���������0 = ��ȡ��1 = ����
	@return					��������ֵ����
	*/
	IR_SDK_API int DLL_CALL IR_SDK_DataOption(SDK_HANDLE const phLFF, SDK_DATA *pstData, int isGetOrSet);

	/**
	@brief					����LFF�ļ��ж�Ӧ����λ�õ��¶�
	@param[in] phLFF		LFF�ļ����ָ��
	@param[in] uiNum		��������
	@param[out] afTemp		�¶�����[C]
	@return					��������ֵ����
	*/
	IR_SDK_API 	int DLL_CALL IR_SDK_GetTemp(SDK_HANDLE const phLFF, unsigned int const uiNum, float afTemp[]);

	/**
	@brief					ˢ��ͼ��
	@param[in] phLFF		LFF�ļ����ָ��
	@param[out] pstFusion	�ں�ͼ���ⲿ�����ڴ�
	@return					��������ֵ����
	*/
	IR_SDK_API 	int DLL_CALL IR_SDK_NewImage(SDK_HANDLE const phLFF, SDK_EXT_IMG *pstFusion);

    /**
    @brief					    ��ȡ����ͼ��(��ָ����С���ͼ��)
    @param[in] phLFF		    LFF�ļ����ָ��
    @param[in,out] pstFusion	ͼ���ⲿ�����ڴ�(�Կ��Ϊ��׼�Ŵ�ͼ��)
    @return					    ��������ֵ����
    */
    IR_SDK_API 	int DLL_CALL IR_SDK_GetIRImage(SDK_HANDLE const phLFF, SDK_EXT_IMG *pstFusion);


    /**
    @brief					    ��ȡ�ɼ���ͼ����
    @param[in] phLFF		    LFF�ļ����ָ��
    @param[in] width            ͼ���
    @param[in] height           ͼ���
    @return					    ��������ֵ����
    */
    IR_SDK_API 	int DLL_CALL IR_SDK_GetVISImageSize(SDK_HANDLE const phLFF, unsigned int * width, unsigned int* height);

    /**
    @brief					    ��ȡ�ɼ���ͼ��
    @param[in] phLFF		    LFF�ļ����ָ��
    @param[in,out] pstFusion    ͼ���ⲿ�����ڴ�
    @return					    ��������ֵ����
    */
    IR_SDK_API 	int DLL_CALL IR_SDK_GetVISImage(SDK_HANDLE const phLFF,SDK_EXT_IMG *pstFusion);

    /**
    @brief					    �ж��ļ��Ƿ���Խ���
    @param[in] filepathanme	    �ļ�ȫ·����  
    @return					    ������:\n 
    -1-�쳣���ڴ治��\n
    0-���ܱ�����\n
    1-��������\n
    2-�ܹ�����
    */
    IR_SDK_API 	int DLL_CALL IR_SDK_FileFormatValid(char* filepathanme);

    /**
    @brief					    �ɼ���ͼ��ü�
    @param[in]  pImgIn		    ����ͼ��
    @param[in]  pArea		    ����Ȥ������
    @param[out] pImgOut         ���ͼ��(�����߷����㹻���ڴ棬���Ժ�pImgIn��һ������Ϊ�ü����ͼ�񲻴���ԭʼͼ��)
    @return					    ��������ֵ����
    */
    IR_SDK_API 	int DLL_CALL IR_SDK_VisImageClip(SDK_VIS_IMG *pImgIn, IMG_ATTENTION*pArea, SDK_VIS_IMG *pImgOut);

    /**
    @brief					    ����ͼ��Ŵ�
    @param[in]  pImgIn		    ����ͼ��
    @param[out] pImgOut         ���ͼ��(�����߷����ڴ�)
    @return					    ��������ֵ����
    */
    IR_SDK_API 	int DLL_CALL IR_SDK_IrImageMagnification(SDK_IR_IMG *pImgIn, SDK_IR_IMG *pImgOut);

    /**
    @brief					    ͼ���ں�
    @param[in]  phLFF		    �ļ����
    @param[out] pImgOut         ���ͼ��
    @return					    ��������ֵ����
    @attention  ��Ҫ��֤����ͼ��Ϳɼ���ͼ��ķֱ���һ��
    */
    IR_SDK_API 	int DLL_CALL IR_SDK_ImageFusion(SDK_HANDLE const phLFF, SDK_EXT_IMG*pImgOut);


#ifdef __cplusplus
};
#endif

#endif  // _IR_SDK_H_