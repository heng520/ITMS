using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ITMS.View.Page
{
    /// <summary>
    /// DiaShow.xaml 的交互逻辑
    /// </summary>
    public partial class DiaShow : Window
    {
        System.Windows.Threading.DispatcherTimer dtimer;

        public DiaShow()
        {
            InitializeComponent();
            this.DataContext = new DataModel() { YOffSet = -300d };
            this.Loaded += (y, k) =>
            {
                this.Top = 41;
                this.Left = (SystemParameters.WorkArea.Width) / 2 - this.ActualWidth / 2;
                if (iserror)
                {
                    this.grid1.Visibility = Visibility.Collapsed;
                }
                else { this.grid2.Visibility = Visibility.Collapsed; }
            };
        }
        private bool iserror = false;
        private string Message = "";
        public void Show(string messageBoxText, bool iserror = false)
        {
            this.iserror = iserror;
            this.Message = messageBoxText;
            tb.Text = messageBoxText;
            if (dtimer == null)
            {
                dtimer = new System.Windows.Threading.DispatcherTimer();
                dtimer.Interval = TimeSpan.FromSeconds(0.1);
                dtimer.Tick += dtimer_Tick;
            }
            if (!dtimer.IsEnabled) dtimer.Start();
            this.Show();
        }
        private int countDown = 30;
        void dtimer_Tick(object sender, EventArgs e)
        {
            countDown--;
            if (countDown > 0) return;
            dtimer.Stop();
            this.Close();
        }


        private void Storyboard_Completed(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class DataModel : ViewModelBase
    {
       
        public double YOffSet { get; set; }
      

    }
}
