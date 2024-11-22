using System.Drawing.Text;
using System;
using System.Timers;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics.Metrics;

namespace Stopwatch
{
    public partial class Form1 : Form
    {
        System.Timers.Timer timer = new System.Timers.Timer(1000);
        stopWatch watch = new stopWatch();


        public Form1()
        {

            InitializeComponent();
            // Create a timer with a 1-second interval


            // Set the event handler for the Elapsed event
            timer.Elapsed += OnTimerElapsed;

            // Set AutoReset to true to make the timer repeat indefinitely
            timer.AutoReset = true;

            //textBox_total_time.Text = count.ToString();
            watch.WatchStop = 0;
 

        }


        private void btn_start_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            timer.Stop();

            if(watch.WatchStop == 0)
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    textBox_delta.Text = (watch.WatchElapsedTime - watch.WatchStop).ToString();
                }));
                watch.WatchStop = watch.WatchElapsedTime;
            }
            else
            {
                watch.Delta = watch.WatchElapsedTime - watch.WatchStop;
                this.Invoke((MethodInvoker)(() =>
                {
                    textBox_delta.Text = watch.Delta.ToString();
                }));
                watch.WatchStop = watch.WatchElapsedTime;
            }

        }



        private void OnTimerElapsed(object sender, ElapsedEventArgs e)
        {
            watch.WatchElapsedTime++;
            this.Invoke((MethodInvoker)(() =>
            {
                textBox_total_time.Text = watch.WatchElapsedTime.ToString();
            }));
        }


        private void btn_reset_Click(object sender, EventArgs e)
        {
            watch.WatchElapsedTime = 0;
            watch.WatchStart = 0;
            watch.WatchStop = 0;
            watch.Delta = 0;
            this.Invoke((MethodInvoker)(() =>
            {
                textBox_total_time.Text = watch.WatchElapsedTime.ToString();
                textBox_delta.Text = watch.Delta.ToString();
            }));
        }


        public class stopWatch()
        {
            private int _watchStart;
            private int _watchStop;
            private int _watchElapsedTime;

            private int _delta;

            public int WatchStart
            {
                get { return _watchStart; }
                set { _watchStart = value; }
            }
            public int WatchStop
            {
                get { return _watchStop; }
                set { _watchStop = value; }
            }
            public int WatchElapsedTime
            {
                get { return _watchElapsedTime; }
                set { _watchElapsedTime = value; }
            }

            public int Delta
            {
                get { return _delta; }
                set { _delta = value; }
            }




            public void stopWatchReset()
            {

            }
        }
    }
}
