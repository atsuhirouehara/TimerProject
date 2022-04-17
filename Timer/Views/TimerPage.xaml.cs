using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Threading;


namespace Timer.Views
{
    /// <summary>
    /// TimerPage.xaml の相互作用ロジック
    /// </summary>
    public partial class TimerPage : Page
    {
        private readonly Stopwatch stopwatch = new();
        //private readonly EventHandler Timer_Tick;
        public TimerPage()
        {
            InitializeComponent();
            


            //定期的に実行
            DispatcherTimer timer = new();
            //0時間、0分、1秒ごとに動作
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += Timer_Tick;
            timer.Start();


            this.stopwatch.Stop();
        }

        /// <summary>
        /// 時間が表示されるところの処理を記載した関数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_Tick(object sender, EventArgs e)
        {

            int totalSecounds = ((int)this.stopwatch.Elapsed.TotalSeconds);

            TimeSpan countTime = new(0, 0, totalSecounds);
            timerTextBlock.Text = countTime.ToString(@"mm\:ss");
        }

        private void Button_StartAndStop(object sender, RoutedEventArgs e)
        {
            if (stopwatch.IsRunning)
            {
                stopwatch.Stop();
                btnStartAndStop.Content = "Start";
            }
            else
            {
                stopwatch.Start();
                btnStartAndStop.Content = "Stop";
            }

        }

        private void Button_Reset(object sender, RoutedEventArgs e)
        {
            stopwatch.Restart();
            this.stopwatch.Stop();
        }

        private void Button_Save(object sender, RoutedEventArgs e)
        {

        }
    }
}
