using System.Drawing.Text;
using System;
using System.Timers;
using System.Windows.Forms;

namespace Stopwatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {

        }

        public class stopWatch
        {
            private static Timer aTimer;

            public int currTime { get; set; }
            public string elapsedTime { get; set; }

            public bool isStarted;

            public stopWatch()
            {
                Start();
            }

            public void Start()
            {
                Timer timer = new Timer(1000); // 1000 milliseconds = 1 second
                timer.Elapsed += OnTimedEvent;
                timer.AutoReset = true;
                timer.Enabled = true;

                Console.WriteLine("Timer started. Press any key to stop.");
                Console.ReadKey();
                timer.Stop();
            }

            private static void OnTimedEvent(Object source, ElapsedEventArgs e)
            {
                // Your function to be executed every second
                Console.WriteLine("One second has passed.");
            }

        }
    }
}
