using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace ITMS.Style
{
    public class ImageButton 
    {

        public static ImageSource GetBackImg(DependencyObject element)
         => (ImageSource)element.GetValue(BackImgProperty);

        public static void SetBackImg(DependencyObject element, ImageSource value)
            => element.SetValue(BackImgProperty, value);
       
        public static readonly DependencyProperty BackImgProperty =
            DependencyProperty.Register("BackImg", typeof(ImageSource), typeof(ImageButton));
       


        public static ImageSource GetBackImgClick(DependencyObject element)
        => (ImageSource)element.GetValue(BackImgProperty);

        public static void SetBackImgClick(DependencyObject element, ImageSource value)
            => element.SetValue(BackImgClickProperty, value);
        
        public static readonly DependencyProperty BackImgClickProperty =
            DependencyProperty.Register("BackImgClick", typeof(ImageSource), typeof(ImageButton));



    }
}
