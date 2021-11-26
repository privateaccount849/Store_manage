using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLK
{
    public partial class FrmBill : Form
    {
        public FrmBill()
        {
            InitializeComponent();
        }

        private void FrmBill_Load(object sender, EventArgs e)
        {
            connect();
        }

        private void connect()
        {
            try
            {
                SqlConnection conn = new SqlConnection("Server=LAPTOP-VJOFVIDQ\\PRIVATE;database=Store;integrated security=true");
                conn.Open();
                string sql = "Select * from tblBill";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter com = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                com.Fill(table);
                dgvB.DataSource = table;
            }
            catch
            {
                MessageBox.Show("Error!");
            }
            finally
            {
                SqlConnection conn = new SqlConnection("Server=LAPTOP-VJOFVIDQ\\PRIVATE;database=Store;integrated security=true");
                conn.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string BillID = txtBillID.Text;
            string Type = txtType.Text;
            string EmployeeID = txtEmployeeID.Text;
            string Date = DateTime.Now.ToString("yyyyMMdd");
            string StoreID = txtStoreID.Text;
            Model m = new Model();
            if (m.AddData3(BillID, Type, EmployeeID, Date, StoreID))
            {
                MessageBox.Show("Done!");
            }
            connect();
        }

    }
}
