using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trend_Analyser
{
    public partial class Stock_Trend_Analyser : Form
    {
        public Stock_Trend_Analyser()
        {
            InitializeComponent();
        }

        private void viewAndRequestDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data_Request form = new Data_Request();
            form.MdiParent = this;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }

        private void scanDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Support_Resistance_Result report = new Support_Resistance_Result();
            report.MdiParent = this;
            report.StartPosition = FormStartPosition.CenterScreen;
            report.Show();

            List<string> filesList = Trend_Analyser_Connector.List_Storage_Files();

            List<string> symbols = new List<string>();
            foreach (var item in filesList)
            {
                symbols.Add(item.ToString());
            }

            report.review(symbols);
        }

        private void Stock_Trend_Analyser_Load(object sender, EventArgs e)
        {
            Splash_Screen splash = new Splash_Screen();
            splash.MdiParent = this;
            splash.StartPosition = FormStartPosition.CenterScreen;
            splash.Show();
        }

        private void showLastReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Support_Resistance_Result report = new Support_Resistance_Result();
            report.MdiParent = this;
            report.StartPosition = FormStartPosition.CenterScreen;
            report.Show();

            report.loadFromFile();
        }
    }
}
