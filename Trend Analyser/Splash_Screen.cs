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
    public partial class Splash_Screen : Form
    {
        public Splash_Screen()
        {
            InitializeComponent();
        }

        private void Splash_Screen_Load(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            txtInitMsg.BackColor = System.Drawing.Color.Transparent;

            string value = Path.test_existence(false);

            txtInitMsg.Text = value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Support_Resistance_Result report = new Support_Resistance_Result();
            report.MdiParent = this.MdiParent;
            report.StartPosition = FormStartPosition.CenterScreen;
            report.Show();

            //List<string> filesList = Trend_Analyser_Connector.List_Storage_Files();

            //List<string> symbols = new List<string>();
            //foreach (var item in filesList)
            //{
            //    symbols.Add(item.ToString());
            //}

            //report.review(symbols);
            report.loadFromFile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data_Request form = new Data_Request();
            form.MdiParent = this.MdiParent;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }
    }
}
