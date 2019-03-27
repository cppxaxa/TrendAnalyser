using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Trend_Analyser
{
    class Download_Data_Info
    {
        public string symbol, item, fYear, fMonth, fDay, tYear, tMonth, tDay;
    }

    class Request_Multiple_Download_With_Progress
    {
        ProgressBar prog = new ProgressBar();
        List<Download_Data_Info> info = null;
        int i, count;

        public delegate void UpdateEventHandler();
        public event UpdateEventHandler UpdateEvent = null;

        public delegate void CompletedEventHandler();
        public event CompletedEventHandler CompletedEvent = null;

        public Request_Multiple_Download_With_Progress(List<Download_Data_Info> info)
        {
            this.info = info;
            this.count = info.Count;
            this.i = 1;

            start();
        }

        public void start()
        {
            int val = i * 100 / count;
            prog.setPercentage(val);
            prog.Show();

            foreach (var item in info)
                ThreadPool.QueueUserWorkItem(new WaitCallback(run), item);
        }

        public void run(object item)
        {
            Download_Data_Info inf = item as Download_Data_Info;
            //Trend_Analyser_Connector.Trend_Analyser_Module_2_Download_Data(inf.symbol, inf.fYear, inf.fMonth, inf.fDay, inf.tYear, inf.tMonth, inf.tDay);

            if(UpdateEvent != null)
                UpdateEvent.Invoke();
            
            Interlocked.Increment(ref i);

            if (i == count)
            {
                prog.Close();

                if(CompletedEvent != null)
                    CompletedEvent.Invoke();
            }
            else
                prog.setPercentage(i * 100 / count);
        }
    }
}
