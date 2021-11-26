using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLK
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmployee f = new FrmEmployee();
            f.Show();
            
        }

        private void storeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Store s = new Store();
            s.Show();
        }
        private void billCatergoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBill b = new FrmBill();
            b.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
