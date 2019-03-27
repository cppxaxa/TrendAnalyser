using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trend_Analyser
{
    class Data_Request_Persistence
    {
        public static List<string> Get_Last_Request_Multiple()
        {
            List<string> symbols = new List<string>();

            if (File.Exists(Path.Last_Request_Multiple))
            {
                using (StreamReader r = new StreamReader(Path.Last_Request_Multiple))
                {
                    string line;
                    while ((line = r.ReadLine()) != null)
                    {
                        symbols.Add(line);
                    }
                }
            }

            return symbols;
        }

        public static void Save_Last_Request_Multiple(List<string> symbols)
        {
            using (StreamWriter w = new StreamWriter(Path.Last_Request_Multiple))
            {
                foreach (string symbol in symbols)
                {
                    w.WriteLine(symbol);
                    //MessageBox.Show(symbol);
                }
            }
        }
    }
}
