using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trend_Analyser
{
    public partial class Support_Resistance_Result : Form
    {
        DataTable dt;

        public Support_Resistance_Result()
        {
            InitializeComponent();
        }

        private DataTable initHeader()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Symbol", typeof(string));
            table.Columns.Add("Scanned Days", typeof(string));
            table.Columns.Add("Closing Price", typeof(double));
            table.Columns.Add("Predicted Price", typeof(double));
            table.Columns.Add("Predicted Date", typeof(string));
            table.Columns.Add("Expected Remaining Days", typeof(string));
            table.Columns.Add("Profit", typeof(double));
            table.Columns.Add("Percentage Profit", typeof(double));
            table.Columns.Add("Trend", typeof(double));

            return table;
        }

        public DataTable calc(List<string> symbols)
        {
            var map = new Dictionary<string, string>();

            DataTable table = initHeader();

            foreach (string sym in symbols)
            {
                string result = Trend_Analyser_Connector.Trend_Analyser_Module_3_Support_Resistance_Predictor_1(sym);
                char[] sep = { '\n' };
                string[] pairs = result.Split(sep);
                int comma_index = -1;
                string key, val;

                foreach (string keyval in pairs)
                {
                    if (keyval.Trim() != "")
                    {
                        comma_index = keyval.IndexOf(',');
                        //MessageBox.Show("Comma" + comma_index.ToString());
                        key = keyval.Substring(1, comma_index - 1);
                        val = keyval.Substring(comma_index + 1, keyval.Length - comma_index - 1);
                        map[key] = val;
                    }
                }

                //MessageBox.Show("Working till Here " + double.Parse(map["Predicted_Price"]).ToString());

                string not_possible_value = null;
                map.TryGetValue("Not_possible", out not_possible_value);

                if (not_possible_value == null)
                {
                    table.Rows.Add(map["Symbol"], map["Scanned"], double.Parse(map["Closing_Price"]), double.Parse(map["Predicted_Price"]), map["Predicted_Date"], map["Expected_Days"], double.Parse(map["Profit"]), double.Parse(map["Profit_Percentage"]), double.Parse(map["Trend"]));
                }
                //table.Rows.Add("TESTING", "30 days", 333.33, 444.44, "2018-01-01", 11.11, 6.66, 1.088888);
            }

            return table;
        }

        public void review(List<string> symbols)
        {
            dt = calc(symbols);
            dgResult.DataSource = dt;

            using (StreamWriter sw = new StreamWriter(Path.Result_Table))
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        if (j != 0)
                            sw.Write(",");
                        sw.Write(dt.Rows[i][j].ToString().Replace("\n\r", "").Trim());
                    }
                    sw.WriteLine();
                }
            }

            dgResult.DataSource = dt;

        }

        public void loadFromFile()
        {
            using (StreamReader sr = new StreamReader(Path.Result_Table))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] words = line.Split(new char[] { ',' });

                    dt.Rows.Add(words[0], words[1], words[2], words[3], words[4], words[5], words[6], words[7], words[8]);
                }
            }
        }

        private void Support_Resistance_Result_Load(object sender, EventArgs e)
        {
            dt = initHeader();

            dgResult.DataSource = dt;
        }

        private void Support_Resistance_Result_Resize(object sender, EventArgs e)
        {
            this.Text = "Form " + this.Width.ToString();
        }
    }
}
