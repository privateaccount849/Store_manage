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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = txtMa.Text;
            string name = txtName.Text;
            int phone = Convert.ToInt32(txtPhone.Text);
            string a_id = txtAdd.Text;
            string ca_id = txtCate.Text;
            string em_id = txtEm.Text;
            Model m = new Model();
            if (m.AddData(id, name, phone, a_id, ca_id, em_id))
            {
                MessageBox.Show("Done!");
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var selectedProduct = dataGridView1.SelectedRows[0].DataBoundItem as Product;
                txtMa.Text = selectedProduct.Id.ToString();
                txtName.Text = selectedProduct.Name;
                txtPhone.Text = selectedProduct.Phone;
                txtEm.Text = selectedProduct.EId;
                txtCate.Text = selectedProduct.CId;
                txtAdd.Text = selectedProduct.AId;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error!!!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
