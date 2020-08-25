using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ITMS.Style
{
    public class UniversalWindow
    {
        public static readonly DependencyProperty TitleBarProperty = DependencyProperty.RegisterAttached(
               "TitleBar", typeof(UniversalTitleBar), typeof(UniversalWindow),
               new PropertyMetadata(new UniversalTitleBar(), OnTitleBarChanged));

        public static UniversalTitleBar GetTitleBar(DependencyObject element)
            => (UniversalTitleBar)element.GetValue(TitleBarProperty);

        public static void SetTitleBar(DependencyObject element, UniversalTitleBar value)
            => element.SetValue(TitleBarProperty, value);

        public static readonly DependencyProperty TitleBarButtonStateProperty = DependencyProperty.RegisterAttached(
            "TitleBarButtonState", typeof(WindowState?), typeof(UniversalWindow),
            new PropertyMetadata(null, OnButtonStateChanged));

        public static WindowState? GetTitleBarButtonState(DependencyObject element)
            => (WindowState?)element.GetValue(TitleBarButtonStateProperty);

        public static void SetTitleBarButtonState(DependencyObject element, WindowState? value)
            => element.SetValue(TitleBarButtonStateProperty, value);

        public static readonly DependencyProperty IsTitleBarCloseButtonProperty = DependencyProperty.RegisterAttached(
            "IsTitleBarCloseButton", typeof(bool), typeof(UniversalWindow),
            new PropertyMetadata(false, OnIsCloseButtonChanged));

        public static bool GetIsTitleBarCloseButton(DependencyObject element)
            => (bool)element.GetValue(IsTitleBarCloseButtonProperty);

        public static void SetIsTitleBarCloseButton(DependencyObject element, bool value)
            => element.SetValue(IsTitleBarCloseButtonProperty, value);

        private static void OnTitleBarChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue == null) throw new NotSupportedException("TitleBar property should not be null.");
        }

        private static void OnButtonStateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var button = (Button)d;

            if (e.OldValue is WindowState)
            {
                button.Click -= StateButton_Click;
            }

            if (e.NewValue is WindowState)
            {
                button.Click -= StateButton_Click;
                button.Click += StateButton_Click;
            }
        }

        private static void OnIsCloseButtonChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var button = (Button)d;

            if (Convert.ToBoolean(e.OldValue) == true)
            {
                button.Click -= CloseButton_Click;
            }

            if (Convert.ToBoolean(e.NewValue) == true)
            {
                button.Click -= CloseButton_Click;
                button.Click += CloseButton_Click;
            }
        }

        private static void StateButton_Click(object sender, RoutedEventArgs e)
        {
            var button = (DependencyObject)sender;
            var window = Window.GetWindow(button);
            var state = GetTitleBarButtonState(button);
            if (window != null && state != null)
            {
                window.WindowState = state.Value;
            }
        }

        private static void CloseButton_Click(object sender, RoutedEventArgs e)
            => Window.GetWindow((DependencyObject)sender)?.Close();
    }

    public class UniversalTitleBar
    {
        public Color BackgroundColor { get; set; } = Colors.BlueViolet;
        public Color ForegroundColor { get; set; } = Colors.Black;
        public Color InactiveForegroundColor { get; set; } = Color.FromRgb(0x99, 0x99, 0x99);
        public Color ButtonHoverForeground { get; set; } = Colors.Black;
        public Color ButtonHoverBackground { get; set; } = Color.FromRgb(0xE6, 0xE6, 0xE6);
        public Color ButtonPressedForeground { get; set; } = Colors.Black;
        public Color ButtonPressedBackground { get; set; } = Color.FromRgb(0xCC, 0xCC, 0xCC);
    }
}
