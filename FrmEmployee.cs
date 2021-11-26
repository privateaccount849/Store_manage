using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace QLK
{
    public partial class FrmEmployee : Form
    {
        public FrmEmployee()
        {
            InitializeComponent();
        }

        private void connect()
        {
            try
            {
                SqlConnection conn = new SqlConnection("Server=LAPTOP-VJOFVIDQ\\PRIVATE;database=Store;integrated security=true");
                conn.Open();
                string sql = "Select * from tblEm1";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter com = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                com.Fill(table);
                dgvE.DataSource = table;
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
            try
            {
                string Eid = txtEid.Text;
                string En = txtEn.Text;
                string P = txtP.Text;
                string dob = DateTime.Now.ToString("yyyyMMdd");
                string ad = txtAd.Text;
                Model m = new Model();
                if (m.AddData1(Eid, En, P, dob, ad))
                {
                    MessageBox.Show("Done!");
                }
                connect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ID Exist!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string Eid = txtEid.Text;
            string En = txtEn.Text;
            string P = txtP.Text;
            string ad = txtAd.Text;
            string dob = DateTime.Now.ToString("yyyyMMdd");
            Model m = new Model();
            if (m.UpDateData1(Eid, En, P, dob, ad))
            {
                MessageBox.Show("Done!");
            }
            connect();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Eid = txtEid.Text;
            string En = txtEn.Text;
            string P = txtP.Text;
            string ad = txtAd.Text;
            string dob = DateTime.Now.ToString("yyyyMMdd");
            Model m = new Model();
            if (m.DeleteData1(Eid, En, P, dob, ad))
            {
                MessageBox.Show("Done!");
            }
            connect();
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            connect();
        }

        int run;
        private void dgvE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            run = dgvE.CurrentRow.Index;
            txtEid.Text = dgvE.Rows[run].Cells[0].Value.ToString();
            txtEn.Text = dgvE.Rows[run].Cells[1].Value.ToString();
            txtP.Text = dgvE.Rows[run].Cells[2].Value.ToString();
            txtdob.Text = dgvE.Rows[run].Cells[3].Value.ToString();
            txtAd.Text = dgvE.Rows[run].Cells[4].Value.ToString();
        }
        //TxtCalStDate.Text = Convert.ToDateTime(objItem["StartDate"]).ToString("yyyy/MM/dd")
    }
}
