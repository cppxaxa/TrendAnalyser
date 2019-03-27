using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trend_Analyser
{
    class UI
    {
        public static void TimeoutMessage(string msg = "Invoking Modules", int time = 2)
        {
            new Thread(() =>
            {
                var w = new Form() { Size = new Size(0, 0) };
                Task.Delay(TimeSpan.FromSeconds(time)).ContinueWith((t) => w.Close(), TaskScheduler.FromCurrentSynchronizationContext());

                MessageBox.Show(w, msg);
            }).Start();
        }
    }
}
