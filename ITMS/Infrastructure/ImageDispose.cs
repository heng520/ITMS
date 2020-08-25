using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMS.Infrastructure
{
    public class ImageDispose
    {

        /// <summary>
        /// 裁剪图片并保存
        /// </summary>
        /// <param name="Image">图片信息</param>
        /// <param name="maxWidth">缩略图宽度</param>
        /// <param name="maxHeight">缩略图高度</param>
        /// <param name="cropWidth">裁剪宽度</param>
        /// <param name="cropHeight">裁剪高度</param>
        /// <param name="X">X轴</param>
        /// <param name="Y">Y轴</param>
        public static Bitmap MakeThumbnailImage(Image originalImage, int maxWidth, int maxHeight, int cropWidth, int cropHeight, int X, int Y)
        {
            Bitmap b = new Bitmap(cropWidth, cropHeight);
            try
            {
                using (Graphics g = Graphics.FromImage(b))
                {
                    //清空画布并以透明背景色填充
                    g.Clear(Color.Transparent);
                    //在指定位置并且按指定大小绘制原图片的指定部分
                    g.DrawImage(originalImage, new Rectangle(0, 0, cropWidth, cropHeight), X, Y, cropWidth, cropHeight, GraphicsUnit.Pixel);
                    Image displayImage = new Bitmap(b, maxWidth, maxHeight);
                    displayImage.Save("E:\\cutimg.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                    Bitmap bit = new Bitmap(b, maxWidth, maxHeight);
                    return bit;
                }
            }
            catch (System.Exception e)
            {
                throw e;
            }
            finally
            {
                originalImage.Dispose();
                b.Dispose();
            }
        }
    }
}
