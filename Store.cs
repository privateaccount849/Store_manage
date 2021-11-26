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
using System.Configuration;

namespace QLK
{
    public partial class Store : Form
    {
        public Store()
        {
            InitializeComponent();
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            bin_data();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            string id = txtMa.Text;
            string name = txtName.Text;
            string phone = txtPhone.Text;
            string a_id = txtAdd.Text;
            string ca_id = txtCate.Text;
            string em_id = txtEm.Text;
            Model m = new Model();
            if (m.UpdateData(id, name, phone, a_id, ca_id, em_id))
            {
                MessageBox.Show("Done!");
            }
            bin_data();
        }
        int index;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = dataGridView1.CurrentRow.Index;
            txtMa.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            txtPhone.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            txtAdd.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            txtCate.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
            txtEm.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string id = txtMa.Text;
                string name = txtName.Text;
                string phone = txtPhone.Text;
                string a_id = txtAdd.Text;
                string ca_id = txtCate.Text;
                string em_id = txtEm.Text;
                Model m = new Model();
                if (m.AddData(id, name, phone, a_id, ca_id, em_id))
                {
                    MessageBox.Show("Done!");
                }
                bin_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ID Exist!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //TxtCalStDate.Text = Convert.ToDateTime(objItem["StartDate"]).ToString("yyyy/MM/dd")
        private void button4_Click_1(object sender, EventArgs e)
        {
            string id = txtMa.Text;
            string name = txtName.Text;
            string phone = txtPhone.Text;
            string a_id = txtAdd.Text;
            string ca_id = txtCate.Text;
            string em_id = txtEm.Text;
            Model m = new Model();
            if (m.DeleteData(id, name, phone, a_id, ca_id, em_id))
            {
                MessageBox.Show("Done!");
            }
            bin_data();
        }
        private void bin_data()
        {
            SqlConnection conn = new SqlConnection("Server=LAPTOP-VJOFVIDQ\\PRIVATE;database=Store;integrated security=true");
            conn.Open();
            string sql = "Select * from tblStore";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter com = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            com.Fill(table);
            dataGridView1.DataSource = table;
            conn.Close();
        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Server=LAPTOP-VJOFVIDQ\\PRIVATE;database=Store;integrated security=true");
            string sql = "Select * from tblStore where Name like '" + textBox1.Text + "%'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter com = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            com.Fill(table);
            dataGridView1.DataSource = table;
            conn.Close();
        }
    }
}

