using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMS.Infrastructure
{
    public class TempFixBlh
    {
       
        /**
         * 当环境温度是10、20、30、40度时，温度传感器对黑体的测量数值
         * bbAvgT : black body average temperature
        */
        private float bbAvgT10 = 37.8f;
        private float bbAvgT20 = 36.8f;
        private float bbAvgT30 = 35.6f;
        private float bbAvgT40 = 35.15f;
        /**
         * 计算某阶段的黑体估计值
         * @param circumTemp 环境温度
         * @param bbAvgBeginCircums 黑体测试值（环境温度低值）时对应的环境温度
         * @param bbAvgBegin 黑体测试值（环境温度低值）
         * @param bbAvgEnd  黑体测试值（环境温度高值）

         * @return
         */
        private float compute2(float circumTemp, float bbAvgBeginCircums, float bbAvgBegin, float bbAvgEnd)
        {
            return bbAvgBegin - (circumTemp - bbAvgBeginCircums) * (bbAvgBegin - bbAvgEnd) / 10.0f;
        }
        /**
          估计温度传感器对黑体的测量数值
         * @param  circumTemp 环境温度
         * @return 估计出的对黑体的测量温度
         */
        private float blackBobyTemp(float circumTemp)
        {
            //当前环境温度对应的黑体温度
            float blackBobyTemp = 0.0f;
            if (circumTemp <= 20)
            {
                blackBobyTemp = compute2(circumTemp, 10, bbAvgT10, bbAvgT20);
            }
            else if (circumTemp > 20 && circumTemp <= 30)
            {
                blackBobyTemp = compute2(circumTemp, 20, bbAvgT20, bbAvgT30);
            }
            else if (circumTemp > 30)
            {
                blackBobyTemp = compute2(circumTemp, 30, bbAvgT30, bbAvgT40);
            }
            return blackBobyTemp;
        }
        /*
           根据原始温度得到真实体表温度
           @param originTemp 从红外传感器读到的原始数据
        *  @param circumTemp 环境温度
        *  @return  真实体表温度
         */
        public float originToReal(float originTemp, float circumTemp)
        {
            //35是黑体温度（恒温），
            return originTemp - 35 + blackBobyTemp(circumTemp);
        }


        /**
         *根据环境温度得到体表标准温度
         * @param circumTemp 环境温度
         * @param circumBegin 标准环境温度-开始
         * @param circumEnd  标准环境温度-结束
         * @param standardBegin  标准体表温度-开始
         * @param standardEnd 标准体表温度-结束
         * @return  某环境温度下体表标准温度
         */
        private float compute(float circumTemp, float circumBegin, float circumEnd, float standardBegin, float standardEnd)
        {
            return standardBegin + (circumTemp - circumBegin) * (standardEnd - standardBegin) / (circumEnd - circumBegin);
        }
        /**
         根据环境温度得到体表标准温度
         * @param  circumTemp 环境温度
         * @return 标准体表温度
         */
        private float circum2SkinStandard(float circumTemp)
        {
            //体表标准温度
            float standard = 0.0f;
            if (circumTemp <= 5)
            {
                standard = 32.1f;
            }
            else if (circumTemp > 5 && circumTemp <= 10)
            {
                standard = compute(circumTemp, 5f, 10f, 32.1f, 32.3f);
            }
            else if (circumTemp > 10 && circumTemp <= 15)
            {
                standard = compute(circumTemp, 10f, 15f, 32.3f, 32.7f);
            }
            else if (circumTemp > 15 && circumTemp <= 20)
            {
                standard = compute(circumTemp, 15f, 20f, 32.7f, 33.3f);
            }
            else if (circumTemp > 20 && circumTemp <= 23)
            {
                standard = compute(circumTemp, 20f, 23f, 33.3f, 33.7f);
            }
            else if (circumTemp > 23 && circumTemp <= 25)
            {
                standard = compute(circumTemp, 23f, 25f, 33.7f, 34f);
            }
            else if (circumTemp > 25 && circumTemp <= 26)
            {
                standard = compute(circumTemp, 25f, 26f, 34f, 34.2f);
            }
            else if (circumTemp > 26 && circumTemp <= 27)
            {
                standard = compute(circumTemp, 26f, 27f, 34.2f, 34.3f);
            }
            else if (circumTemp > 27 && circumTemp <= 28)
            {
                standard = compute(circumTemp, 27f, 28f, 34.3f, 34.5f);
            }
            else if (circumTemp > 28 && circumTemp <= 29)
            {
                standard = compute(circumTemp, 28f, 29f, 34.5f, 34.9f);
            }
            else if (circumTemp > 29 && circumTemp <= 30)
            {
                standard = compute(circumTemp, 29f, 30f, 34.9f, 34.9f);
            }
            else if (circumTemp > 30 && circumTemp <= 31)
            {
                standard = compute(circumTemp, 30f, 31f, 34.9f, 35.1f);
            }
            else if (circumTemp > 31 && circumTemp <= 32)
            {
                standard = compute(circumTemp, 31f, 32f, 35.1f, 35.3f);
            }
            else if (circumTemp > 32 && circumTemp <= 33)
            {
                standard = compute(circumTemp, 32f, 33f, 35.3f, 35.5f);
            }
            else if (circumTemp > 33 && circumTemp <= 35)
            {
                standard = compute(circumTemp, 33f, 35f, 35.5f, 35.9f);
            }
            else if (circumTemp > 35)
            {
                standard = 35.9f;
            }
            return standard;
        }

        /*
         真实体表温度 转化成 播报的温度的腋下温度
          @param skinTemp 从红外传感器读到的原始数据,经过第一次修正后的体表温度
         @param armpitStandard 腋下标准体温: 可配置，通常设置为36.5
      *  @param circumTemp 环境温度
      *  @return  可以语音播报的腋下温度
       */
        public float skin2armpit(float skinTemp, float armpitStandard, float circumTemp)
        {
            return skinTemp + (armpitStandard - circum2SkinStandard(circumTemp));
        }


        /**
         * 温度修正
         * @param armpitStandard  腋下标准体温
         * @param originTemp 温度传感器经过区域修正之后的温度
         * @param circumTemp 环境温度
         * @return
         */
        public float tempFix(float armpitStandard, float circumTemp, float originTemp)
        {
            //float skinTemp = originToReal(originTemp, circumTemp);
            
            return skin2armpit(originTemp, armpitStandard, circumTemp);
        }
    }

}
