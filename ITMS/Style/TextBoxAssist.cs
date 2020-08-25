using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace ITMS.Style.Themes
{
    public class TextBoxAssist
    {

        /// <summary>
        /// 背景图片
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public static ImageSource GetBackImg(DependencyObject element)
    => (ImageSource)element.GetValue(BackImgProperty);

        public static void SetBackImg(DependencyObject element, ImageSource value)
            => element.SetValue(BackImgProperty, value);

        public static readonly DependencyProperty BackImgProperty =
            DependencyProperty.Register("BackImg", typeof(ImageSource), typeof(TextBoxAssist));



        /// <summary>
        /// 左边图片
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public static ImageSource GetLeftImg(DependencyObject element)
           => (ImageSource)element.GetValue(LeftImgProperty);

        public static void SetLeftImg(DependencyObject element, ImageSource value)
            => element.SetValue(LeftImgProperty, value);

        public static readonly DependencyProperty LeftImgProperty =
            DependencyProperty.Register("BackImg", typeof(ImageSource), typeof(TextBoxAssist));



    }
}
