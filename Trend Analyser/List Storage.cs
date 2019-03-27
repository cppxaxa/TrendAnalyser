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
    public partial class List_Storage : Form
    {
        public List_Storage()
        {
            InitializeComponent();
        }

        private void List_Storage_Load(object sender, EventArgs e)
        {
            fileLister.DataSource = Trend_Analyser_Connector.List_Storage_Files();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            fileLister.DataSource = Trend_Analyser_Connector.List_Storage_Files();
        }

        private void fileLister_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
