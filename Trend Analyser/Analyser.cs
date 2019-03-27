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
    public partial class Analyser : Form
    {
        string fname = @"D:\Libraries\Documents\Visual Studio 2013\Projects\Trend Analyser\Storage\SBIN_2017_8_18_2017_7_19.csv";

        public Analyser()
        {
            InitializeComponent();
        }

        public Analyser(string path)
        {
            fname = path;
        }

        private void btnPlot_Click(object sender, EventArgs e)
        {
            DateTime f = fromDate.Value;
            DateTime t = toDate.Value;

            try
            {
                //plotbox.Image = Image.FromFile(Trend_Analyser_Connector.Trend_Analyser_Module_3_Analyser(fname, f.Year.ToString(), f.Month.ToString(), f.Day.ToString(), t.Year.ToString(), t.Month.ToString(), t.Day.ToString(), ""), true);
            }
            catch(Exception){
                MessageBox.Show("Error in analysing. Module 3");
            }
        }
    }
}
