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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Trend_Analyser_Connector.CPP_test_1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Trend_Analyser_Connector.Trend_Analyser_Module_1();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Trend_Analyser_Connector.Destroy();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Data_Request form = new Data_Request();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Path.test_existence();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List_Storage f = new List_Storage();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Analyser f = new Analyser();
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Support_Resistance_Result result = new Support_Resistance_Result();
            //List<string> symbols = new List<string>();
            //symbols.Add("4");
            //symbols.Add("3");
            //result.Show();
            //result.review(symbols);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ProgressBar form = new ProgressBar();
            form.Show();

            form.setPercentage(50);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Support_Resistance_Result result = new Support_Resistance_Result();
            result.Show();
        }
    }
}
