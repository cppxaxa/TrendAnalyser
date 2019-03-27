using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace Trend_Analyser
{
    public partial class Data_Request : Form
    {
        public Data_Request()
        {
            InitializeComponent();
        }

        private bool validate()
        {
            bool val = true;
            string error = "";

            if (txtSymbol.Text.Trim() == "")
            {
                val = false;
                error += "Symbol cannot be blank";
            }

            if (!val)
                MessageBox.Show(error);

            return val;
        }

        private bool validate(string text)
        {
            bool val = true;
            string error = "";

            if (text == "")
            {
                val = false;
                error += "Symbol cannot be blank";
            }

            if (!val)
                MessageBox.Show(error);

            return val;
        }

        private void btn1mon_Click(object sender, EventArgs e)
        {
            fromDate.Value = DateTime.Today.Subtract(TimeSpan.FromDays(30));
        }

        private void btn3mon_Click(object sender, EventArgs e)
        {
            fromDate.Value = DateTime.Today.Subtract(TimeSpan.FromDays(90));
        }

        private void btn6mon_Click(object sender, EventArgs e)
        {
            fromDate.Value = DateTime.Today.Subtract(TimeSpan.FromDays(180));
        }

        private void btn1yr_Click(object sender, EventArgs e)
        {
            fromDate.Value = DateTime.Today.Subtract(TimeSpan.FromDays(365));
        }

        private void btn3yr_Click(object sender, EventArgs e)
        {
            fromDate.Value = DateTime.Today.Subtract(TimeSpan.FromDays(365 * 3));
        }

        private void btn5yr_Click(object sender, EventArgs e)
        {
            fromDate.Value = DateTime.Today.Subtract(TimeSpan.FromDays(365 * 5));
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            bool result = validate();
            if (!result)
            {
                UI.TimeoutMessage("Validation Failed");
                return;
            }

            UI.TimeoutMessage();

            DateTime f = fromDate.Value;
            DateTime t = toDate.Value;
            MessageBox.Show(Trend_Analyser_Connector.Trend_Analyser_Module_2_Download_Data(txtSymbol.Text, f.Year.ToString(), f.Month.ToString(), f.Day.ToString(), t.Year.ToString(), t.Month.ToString(), t.Day.ToString()));

            fileLister.DataSource = Trend_Analyser_Connector.List_Storage_Files();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            fileLister.DataSource = Trend_Analyser_Connector.List_Storage_Files();
        }

        private void Data_Request_Load(object sender, EventArgs e)
        {
            fileLister.DataSource = Trend_Analyser_Connector.List_Storage_Files();

            List<string> request_multiple_symbols = Data_Request_Persistence.Get_Last_Request_Multiple();
            foreach (var symbol in request_multiple_symbols)
            {
                symbolsList.Items.Add(symbol);
            }
        }

        private void btnShowChart_Click(object sender, EventArgs e)
        {
            string item = getSelectedStockName();
            if (item == null)
            {
                UI.TimeoutMessage("Failed");
                return;
            }

            UI.TimeoutMessage();

            Trend_Analyser_Connector.Trend_Analyser_Module_3_Analyser(item);
            //Trend_Analyser_Connector.Trend_Analyser_Module_3_Analyser_with_Highlighter(item, 2015, 1, 1, 2016, 1, 1);
        }

        private void btnShowLineChart_Click(object sender, EventArgs e)
        {
            string item = getSelectedStockName();
            if (item == null)
            {
                UI.TimeoutMessage("Failed");
                return;
            }

            UI.TimeoutMessage();

            Trend_Analyser_Connector.Trend_Analyser_Module_3_Analyser_Line(item);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string item = getSelectedStockName();
            if (item == null)
            {
                UI.TimeoutMessage("Failed");
                return;
            }

            DialogResult result = MessageBox.Show("Confirm Delete?","Delete Downloaded Data", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                File.Delete(Path.Storage_Dir + "\\" + item + ".csv");
                fileLister.DataSource = Trend_Analyser_Connector.List_Storage_Files();
            }
        }

        private string getSelectedStockName()
        {
            if (fileLister.SelectedIndex < 0)
                return null;

            int index = fileLister.SelectedIndex;
            string item = fileLister.Items[index].ToString();

            return item;
        }

        private void btn_support_resistant_predictor_1_Click(object sender, EventArgs e)
        {
            string item = getSelectedStockName();
            if (item == null)
            {
                UI.TimeoutMessage("Failed");
                return;
            }

            UI.TimeoutMessage();

            string report = Trend_Analyser_Connector.Trend_Analyser_Module_3_Support_Resistance_Predictor_1(item);

            MessageBox.Show(report);
        }

        private void btn_support_resistant_predictor_1_enable_charts_Click(object sender, EventArgs e)
        {
            string item = getSelectedStockName();
            if (item == null)
            {
                UI.TimeoutMessage("Failed");
                return;
            }

            UI.TimeoutMessage();

            string report = Trend_Analyser_Connector.Trend_Analyser_Module_3_Support_Resistance_Predictor_1_with_segmentation_chart(item);

            MessageBox.Show(report);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string item = getSelectedStockName();
            if (item == null)
            {
                UI.TimeoutMessage("Failed");
                return;
            }

            UI.TimeoutMessage();

            string report = Trend_Analyser_Connector.Trend_Analyser_Module_3_Support_Resistance_Predictor_1_with_regression_chart(item);

            MessageBox.Show(report);
        }

        private void btnAddSymbol_Click(object sender, EventArgs e)
        {
            string symbol = txtSymbolAdder.Text;

            if (symbol == "")
                return;

            foreach(var item in symbolsList.Items)
            {
                if (item.ToString() == symbol)
                {
                    MessageBox.Show("Item already exists in the list");
                    return;
                }
            }

            symbolsList.Items.Add(symbol);
            txtSymbolAdder.Clear();
        }

        private void btnDeleteSymbol_Click(object sender, EventArgs e)
        {
            if (symbolsList.SelectedIndex >= 0)
            {
                //MessageBox.Show(symbolsList.SelectedIndex.ToString());
                symbolsList.Items.RemoveAt(symbolsList.SelectedIndex);
            }
        }

        private void btnClearAllSymbol_Click(object sender, EventArgs e)
        {
            symbolsList.Items.Clear();
        }

        private void btnSingleMode_Click(object sender, EventArgs e)
        {
            tlSingleRequest.Visible = true;
            btnRequest.Visible = true;
            
            btnSingleMode.Visible = false;
            btnRequestMultiple.Visible = true;

            fileLister.Height = 434;
            btnRefresh.Location = new Point(594, 465);
            btnDelete.Location = new Point(594, 493);

            tlRequestMultiple.Visible = false;
            btnRequestAll.Visible = false;
            symbolsList.Visible = false;
            btnDeleteSymbol.Visible = false;
            btnClearAllSymbol.Visible = false;

        }

        private void btnRequestMultiple_Click(object sender, EventArgs e)
        {
            tlSingleRequest.Visible = false;
            btnRequest.Visible = false;
            
            btnSingleMode.Visible = true;
            btnRequestMultiple.Visible = false;

            fileLister.Height = 130;
            btnRefresh.Location = new Point(594, 164);
            btnDelete.Location = new Point(594, 192);

            tlRequestMultiple.Visible = true;
            btnRequestAll.Visible = true;
            symbolsList.Visible = true;
            btnDeleteSymbol.Visible = true;
            btnClearAllSymbol.Visible = true;

        }

        private void txtSymbolAdder_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                string symbol = txtSymbolAdder.Text;

                if (symbol == "")
                    return;

                foreach (var item in symbolsList.Items)
                {
                    if (item.ToString() == symbol)
                    {
                        MessageBox.Show("Item already exists in the list");
                        return;
                    }
                }

                symbolsList.Items.Add(symbol);
                txtSymbolAdder.Clear();
            }
        }

        private void btnRequestAll_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ignoring all invalid or inavailable symbols");

            //UI.TimeoutMessage();

            int count = symbolsList.Items.Count;
            int i = 1;

            foreach (var item in symbolsList.Items)
            {
                bool result = validate(item.ToString());

                if (!result)
                    continue;

                DateTime f = fromDate.Value;
                DateTime t = toDate.Value;
                Trend_Analyser_Connector.Trend_Analyser_Module_2_Download_Data(item.ToString(), f.Year.ToString(), f.Month.ToString(), f.Day.ToString(), t.Year.ToString(), t.Month.ToString(), t.Day.ToString());

                fileLister.DataSource = Trend_Analyser_Connector.List_Storage_Files();

                i++;
            }

            MessageBox.Show("Completed");
        }

        private void Data_Request_FormClosed(object sender, FormClosedEventArgs e)
        {
            List<string> request_multiple_symbols = new List<string>();

            foreach (var item in symbolsList.Items)
            {
                request_multiple_symbols.Add(item.ToString());
            }

            Data_Request_Persistence.Save_Last_Request_Multiple(request_multiple_symbols);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ignoring all invalid or inavailable symbols");

            List<Download_Data_Info> info_list = new List<Download_Data_Info>();

            foreach (var item in symbolsList.Items)
            {
                DateTime f = fromDate.Value;
                DateTime t = toDate.Value;

                Download_Data_Info info = new Download_Data_Info();
                info.symbol = item.ToString();
                info.item = item.ToString();
                info.fYear = f.Year.ToString();
                info.fMonth = f.Month.ToString();
                info.fDay = f.Day.ToString();
                info.tYear = t.Year.ToString();
                info.tMonth = t.Month.ToString();
                info.tDay = t.Day.ToString();

                info_list.Add(info);
            }

            Request_Multiple_Download_With_Progress downloader = new Request_Multiple_Download_With_Progress(info_list);
            downloader.UpdateEvent += update_view_after_download;
        }

        public void update_view_after_download()
        {
            fileLister.DataSource = Trend_Analyser_Connector.List_Storage_Files();
        }

        private void btn_support_resistant_predictor_1_review_all_Click(object sender, EventArgs e)
        {
            Support_Resistance_Result report = new Support_Resistance_Result();
            if (this.IsMdiChild)
                report.MdiParent = this.MdiParent;

            report.Show();

            List<string> symbols = new List<string>();
            foreach (var item in fileLister.Items)
            {
                symbols.Add(item.ToString());
            }

            report.review(symbols);
        }

        public static int LivenshteinCompute(string s, string t)
        {
            int n = s.Length;
            int m = t.Length;
            int[,] d = new int[n + 1, m + 1];

            // Step 1
            if (n == 0)
            {
                return m;
            }

            if (m == 0)
            {
                return n;
            }

            // Step 2
            for (int i = 0; i <= n; d[i, 0] = i++)
            {
            }

            for (int j = 0; j <= m; d[0, j] = j++)
            {
            }

            // Step 3
            for (int i = 1; i <= n; i++)
            {
                //Step 4
                for (int j = 1; j <= m; j++)
                {
                    // Step 5
                    int cost = (t[j - 1] == s[i - 1]) ? 0 : 1;

                    // Step 6
                    d[i, j] = Math.Min(
                        Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1),
                        d[i - 1, j - 1] + cost);
                }
            }
            // Step 7
            return d[n, m];
        }

        public void search_result_update(){
            List<string> src = Trend_Analyser_Connector.List_Storage_Files();
                List<Tuple<string, int>> list = new List<Tuple<string, int>>();

                for (int i = 0; i < src.Count; i++)
                {
                    int dist1 = LivenshteinCompute(src[i].Split(new char[] { '_' })[0], txtKeyword.Text);
                    int dist2 = 0;
                    if (src[i].StartsWith(txtKeyword.Text))
                        dist2 = 1;
                    int dist3 = 0;
                    if (txtKeyword.Text == src[i].Split(new char[] { '_' })[0])
                        dist3 = 1;

                    int val = dist1;
                    if (dist2 == 1)
                        val = -1;
                    if (dist3 == 1)
                        val = -2;

                    list.Add(new Tuple<string, int>(src[i], val));
                }

                var list2 = from element in list
                            orderby element.Item2
                            select element;

                List<string> result = new List<string>();
                foreach(var i in list2){
                    result.Add(i.Item1);
                }

                fileLister.DataSource = result;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtKeyword.Text != "")
            {
                search_result_update();
            }
        }

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {
            search_result_update();
        }
    }
}
